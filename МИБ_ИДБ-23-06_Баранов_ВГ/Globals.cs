using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace MIB_IDB_23_06_Baranov_VG
{
    public struct AccountType
{
    public string UserName;
    public int PassLen;
    public string UserPass;
    public bool Block;
    public bool Restrict;
}

public static class Globals
{
    public const int MAXNAME = 20;
    public const int MAXPASS = 10;
    public const string SECFILE = "security.db";
    public const int RecSize = MAXNAME + 4 + MAXPASS + 1 + 1;

    public static AccountType UserAcc;
    public static FileStream AccFile;
    public static int RecCount;

    static readonly Encoding Enc = Encoding.GetEncoding(1251);

    private static char[] FixStr(string s, int len)
    {
        char[] buf = new char[len];
        if (s != null)
            s.CopyTo(0, buf, 0, Math.Min(s.Length, len));
        return buf;
    }

    private static string CStr(char[] buf)
    {
        int n = Array.IndexOf(buf, '\0');
        return n < 0 ? new string(buf) : new string(buf, 0, n);
    }

    public static void WriteRec()
    {
        using (BinaryWriter w = new BinaryWriter(AccFile, Enc, true))
        {
            w.Write(FixStr(UserAcc.UserName, MAXNAME));
            w.Write(UserAcc.PassLen);
            w.Write(FixStr(UserAcc.UserPass, MAXPASS));
            w.Write(UserAcc.Block);
            w.Write(UserAcc.Restrict);
        }
    }

    public static bool ReadRec()
    {
        if (AccFile.Position + RecSize > AccFile.Length) return false;
        using (BinaryReader r = new BinaryReader(AccFile, Enc, true))
        {
            UserAcc.UserName = CStr(r.ReadChars(MAXNAME));
            UserAcc.PassLen = r.ReadInt32();
            UserAcc.UserPass = CStr(r.ReadChars(MAXPASS));
            UserAcc.Block = r.ReadBoolean();
            UserAcc.Restrict = r.ReadBoolean();
        }
        return true;
    }

    public const string TMPFILE = "temp.db";
    public static FileStream TmpFile1, TmpFile2;
    public static byte[] Buf = new byte[128 + 8];
    public static IntPtr hProv = IntPtr.Zero;
    public static IntPtr hKey;
    public static IntPtr hHash;

    public const uint PROV_RSA_FULL = 1;
    public const uint CRYPT_NEWKEYSET = 0x8;
    public const uint NTE_BAD_KEYSET = 0x80090016;
    public const uint CALG_MD2 = 0x8001;
    public const uint CALG_RC2 = 0x6602;
    public const uint CRYPT_EXPORTABLE = 0x1;
    public const uint CRYPT_CREATE_SALT = 0x4;
    public const uint KP_MODE = 4;
    public const uint CRYPT_MODE_CFB = 4;

    [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Ansi)]
    public static extern bool CryptAcquireContext(out IntPtr phProv, string pszContainer,
        string pszProvider, uint dwProvType, uint dwFlags);

    [DllImport("advapi32.dll", SetLastError = true)]
    public static extern bool CryptCreateHash(IntPtr hProv, uint Algid, IntPtr hKey,
        uint dwFlags, out IntPtr phHash);

    [DllImport("advapi32.dll", SetLastError = true)]
    public static extern bool CryptHashData(IntPtr hHash, byte[] pbData, uint dwDataLen,
        uint dwFlags);

    [DllImport("advapi32.dll", SetLastError = true)]
    public static extern bool CryptDeriveKey(IntPtr hProv, uint Algid, IntPtr hBaseData,
        uint dwFlags, out IntPtr phKey);

    [DllImport("advapi32.dll", SetLastError = true)]
    public static extern bool CryptSetKeyParam(IntPtr hKey, uint dwParam, ref uint pbData,
        uint dwFlags);

    [DllImport("advapi32.dll", SetLastError = true)]
    public static extern bool CryptEncrypt(IntPtr hKey, IntPtr hHash, bool Final,
        uint dwFlags, byte[] pbData, ref uint pdwDataLen, uint dwBufLen);

    [DllImport("advapi32.dll", SetLastError = true)]
    public static extern bool CryptDecrypt(IntPtr hKey, IntPtr hHash, bool Final,
        uint dwFlags, byte[] pbData, ref uint pdwDataLen);

    [DllImport("advapi32.dll", SetLastError = true)]
    public static extern bool CryptDestroyHash(IntPtr hHash);

    [DllImport("advapi32.dll", SetLastError = true)]
    public static extern bool CryptDestroyKey(IntPtr hKey);

    [DllImport("advapi32.dll", SetLastError = true)]
    public static extern bool CryptReleaseContext(IntPtr hProv, uint dwFlags);
}
}