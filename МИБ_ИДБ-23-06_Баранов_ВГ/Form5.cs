using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MIB_IDB_23_06_Baranov_VG.Globals;

namespace MIB_IDB_23_06_Baranov_VG
{
    public partial class Form5 : Form
{
    public Form5()
    {
        InitializeComponent();
    }

    // проверка ограничений: наличие букв и цифр (вариант 3)
    public bool CheckPassword(string Pass)
    {
        bool Letter = false, Digit = false;
        foreach (char c in Pass)
        {
            Letter |= char.IsLetter(c);
            Digit |= char.IsDigit(c);
        }
        return Letter && Digit;
    }

    private void Form5_VisibleChanged(object sender, EventArgs e)
    {
        if (Visible)
        {
            OldPass.Text = "";
            Edit1.Text = "";
            Edit2.Text = "";
            bool first = UserAcc.PassLen == 0;
            OldLabel.Enabled = !first;
            OldPass.Enabled = !first;
            ActiveControl = first ? (Control)Edit1 : OldPass;
        }
    }

    private void Form5_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (DialogResult != DialogResult.OK) return;
        if (OldPass.Enabled && OldPass.Text != UserAcc.UserPass)
        {
            MessageBox.Show("Неверный старый пароль!");
            ActiveControl = OldPass;
            e.Cancel = true;
        }
        else if (Edit1.Text != Edit2.Text)
        {
            MessageBox.Show("Пароли должны совпадать!");
            ActiveControl = Edit1;
            e.Cancel = true;
        }
        else if (UserAcc.Restrict && !CheckPassword(Edit1.Text))
        {
            MessageBox.Show("Пароль не соответствует ограничениям!\n" +
                "Пароль должен содержать буквы и цифры.");
            ActiveControl = Edit1;
            e.Cancel = true;
        }
    }
}
}