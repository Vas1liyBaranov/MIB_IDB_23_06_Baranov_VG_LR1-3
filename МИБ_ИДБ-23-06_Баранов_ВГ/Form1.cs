using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MIB_IDB_23_06_Baranov_VG.Globals;

namespace MIB_IDB_23_06_Baranov_VG
{
    public partial class Form1 : Form
    {
        private int EnterCount = 0;        // счетчик неудачных попыток входа
        private Form2 form2 = new Form2(); // окно входа
        private Form3 form3 = new Form3(); // окно списка пользователей
        private Form4 form4 = new Form4(); // окно добавления пользователей
        private Form5 form5 = new Form5(); // окно смены пароля

        public Form1()
        {
            InitializeComponent();
        }

        // запуск: парольная фраза, далее ключ, далее расшифрование файла учетных записей
        private void Form1_Load(object sender, EventArgs e)
        {
            uint Param = CRYPT_MODE_CFB; // режим шифрования
            uint Len;                    // длина порции данных
            bool Final;                  // признак последней порции
            Form6 form6 = new Form6();   // окно ввода парольной фразы
            try
            {
                if (!CryptAcquireContext(out hProv, null, null, PROV_RSA_FULL, 0))
                    if ((uint)Marshal.GetLastWin32Error() == NTE_BAD_KEYSET)
                        CryptAcquireContext(out hProv, null, null, PROV_RSA_FULL, CRYPT_NEWKEYSET);
                    else throw new Exception("Ошибка при доступе к CryptoAPI!");
                if (form6.ShowDialog() != DialogResult.OK)
                    throw new Exception("Работа программы невозможна!");
                byte[] Phrase = Encoding.GetEncoding(1251).GetBytes(form6.Edit1.Text);
                if (!CryptCreateHash(hProv, CALG_MD2, IntPtr.Zero, 0, out hHash)
                    || !CryptHashData(hHash, Phrase, (uint)Phrase.Length, 0))
                    throw new Exception("Ошибка при доступе к CryptoAPI!");
                form6.Dispose();
                if (!CryptDeriveKey(hProv, CALG_RC2, hHash, CRYPT_EXPORTABLE | CRYPT_CREATE_SALT, out hKey)
                    || !CryptSetKeyParam(hKey, KP_MODE, ref Param, 0))
                    throw new Exception("Ошибка при доступе к CryptoAPI!");
                CryptDestroyHash(hHash);
            }
            catch (Exception ex)
            {
                form6.Dispose();
                if (hProv != IntPtr.Zero) CryptReleaseContext(hProv, 0);
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            if (!File.Exists(SECFILE))
            {
                AccFile = new FileStream(TMPFILE, FileMode.Create, FileAccess.Write);
                UserAcc.UserName = "ADMIN";
                UserAcc.UserPass = "";
                UserAcc.PassLen = 0;
                UserAcc.Block = false;
                UserAcc.Restrict = true;
                WriteRec();
                AccFile.Close();
            }
            else
            {
                TmpFile1 = new FileStream(SECFILE, FileMode.Open, FileAccess.Read);
                TmpFile2 = new FileStream(TMPFILE, FileMode.Create, FileAccess.Write);
                do
                {
                    Len = (uint)TmpFile1.Read(Buf, 0, 128);
                    Final = TmpFile1.Position == TmpFile1.Length;
                    if (!CryptDecrypt(hKey, IntPtr.Zero, Final, 0, Buf, ref Len) || Len > Buf.Length)
                        Len = 0; // неверный ключ: порцию не записывать
                    TmpFile2.Write(Buf, 0, (int)Len);
                }
                while (!Final);
                TmpFile1.Close();
                TmpFile2.Close();
                AccFile = new FileStream(TMPFILE, FileMode.Open, FileAccess.Read);
                ReadRec();
                AccFile.Close();
                if (UserAcc.UserName != "ADMIN")
                {
                    CryptDestroyKey(hKey);
                    CryptReleaseContext(hProv, 0);
                    MessageBox.Show("Неверный ключ расшифрования!");
                    File.Delete(TMPFILE);
                    Environment.Exit(0);
                }
            }
        }

        // вход в систему: проверка имени и пароля
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (form2.ShowDialog(this) == DialogResult.OK)
                {
                    if (AccFile != null) AccFile.Close();
                    AccFile = new FileStream(TMPFILE, FileMode.Open, FileAccess.ReadWrite);
                    RecCount = 0;
                    bool found = false; // найден ли пользователь
                    while (ReadRec())
                    {
                        RecCount++;
                        if (form2.Login.Text == UserAcc.UserName)
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                        throw new Exception("Вы не зарегистрированы!");
                    else if (UserAcc.PassLen == 0)
                    {
                        if (form5.ShowDialog(this) == DialogResult.OK)
                        {
                            AccFile.Seek((RecCount - 1) * RecSize, SeekOrigin.Begin);
                            UserAcc.UserPass = form5.Edit1.Text;
                            UserAcc.PassLen = form5.Edit1.Text.Length;
                            WriteRec();
                            Relogin();
                        }
                        return;
                    }
                    else if (UserAcc.UserPass != form2.Password.Text)
                    {
                        if (++EnterCount > 2)
                        {
                            Button1.Visible = false;
                            MessageBox.Show("Вход в программу невозможен!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Close();
                            return;
                        }
                        throw new Exception("Неверный пароль!");
                    }
                    if (UserAcc.Block)
                        throw new Exception("Вы заблокированы!");
                    if (UserAcc.Restrict && !form5.CheckPassword(UserAcc.UserPass))
                    {
                        MessageBox.Show("Пароль не соответствует ограничениям.\nНеобходимо сменить пароль.");
                        if (form5.ShowDialog(this) == DialogResult.OK)
                        {
                            AccFile.Seek((RecCount - 1) * RecSize, SeekOrigin.Begin);
                            UserAcc.UserPass = form5.Edit1.Text;
                            UserAcc.PassLen = form5.Edit1.Text.Length;
                            WriteRec();
                            Relogin();
                        }
                        return;
                    }
                    if (UserAcc.UserName == "ADMIN")
                    {
                        All.Enabled = true;
                        New.Enabled = true;
                        AccFile.Close();
                    }
                    Change.Enabled = true;
                    Button1.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // смена пароля текущего пользователя
        private void Change_Click(object sender, EventArgs e)
        {
            if (All.Enabled)
            {
                AccFile = new FileStream(TMPFILE, FileMode.Open, FileAccess.ReadWrite);
                RecCount = 0;
                ReadRec();
                RecCount++;
            }
            if (form5.ShowDialog(this) == DialogResult.OK)
            {
                AccFile.Seek((RecCount - 1) * RecSize, SeekOrigin.Begin);
                UserAcc.UserPass = form5.Edit1.Text;
                UserAcc.PassLen = form5.Edit1.Text.Length;
                WriteRec();
                Relogin();
                return;
            }
            if (All.Enabled) AccFile.Close();
        }

        private void Relogin()
        {
            if (AccFile != null) AccFile.Close();
            All.Enabled = false;
            New.Enabled = false;
            Change.Enabled = false;
            Button1.Visible = true;
            MessageBox.Show("Пароль изменен. Войдите с новым паролем.");
            Button1_Click(this, EventArgs.Empty);
        }

        // добавление нового пользователя в конец файла
        private void New_Click(object sender, EventArgs e)
        {
            AccFile = new FileStream(TMPFILE, FileMode.Open, FileAccess.ReadWrite);
            if (form4.ShowDialog(this) == DialogResult.OK)
            {
                AccFile.Seek(0, SeekOrigin.End);
                UserAcc.UserName = form4.UserName.Text;
                UserAcc.UserPass = "";
                UserAcc.PassLen = 0;
                UserAcc.Block = false;
                UserAcc.Restrict = true;
                WriteRec();
            }
            AccFile.Close();
        }

        // просмотр списка пользователей, начиная с первого
        private void All_Click(object sender, EventArgs e)
        {
            AccFile = new FileStream(TMPFILE, FileMode.Open, FileAccess.ReadWrite);
            RecCount = 0;
            ReadRec();
            RecCount++;
            form3.UserName.Text = UserAcc.UserName;
            form3.CheckBox1.Checked = UserAcc.Block;
            form3.CheckBox2.Checked = UserAcc.Restrict;
            form3.Next.Enabled = AccFile.Position < AccFile.Length;
            form3.Prev.Enabled = false;
            form3.ShowDialog(this);
            AccFile.Close();
        }

        // выход: шифрование временного файла в файл учетных записей и его удаление
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            uint Len;
            bool Final;
            if (AccFile != null) AccFile.Close();
            TmpFile2 = new FileStream(TMPFILE, FileMode.Open, FileAccess.Read);
            TmpFile1 = new FileStream(SECFILE, FileMode.Create, FileAccess.Write);
            do
            {
                Len = (uint)TmpFile2.Read(Buf, 0, 128);
                Final = TmpFile2.Position == TmpFile2.Length;
                CryptEncrypt(hKey, IntPtr.Zero, Final, 0, Buf, ref Len, (uint)Buf.Length);
                TmpFile1.Write(Buf, 0, (int)Len);
            }
            while (!Final);
            TmpFile1.Close();
            TmpFile2.Close();
            File.Delete(TMPFILE);
            CryptDestroyKey(hKey);
            CryptReleaseContext(hProv, 0);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Лабораторная работа #1 и #3\n" +
                "Автор: Баранов В.Г., группа ИДБ-23-06\n\n" +
                "Вариант 3: ограничение на пароль \n(наличие букв и цифр)\n" +
                "Тип шифрования: блочный.\n" +
                "Режим шифрования: обратная связь по шифротексту.\n" +
                "Хеш-алгоритм: MD2.",
                "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}