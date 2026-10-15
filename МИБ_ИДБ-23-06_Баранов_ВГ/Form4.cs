using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MIB_IDB_23_06_Baranov_VG.Globals;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MIB_IDB_23_06_Baranov_VG
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        // при открытии окна: фокус на имя, очистка поля
        private void Form4_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                ActiveControl = UserName;
                UserName.Text = "";
            }
        }

        // проверка имени нового пользователя при нажатии OK
        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK) return;
            if (UserName.Text == "")
            {
                e.Cancel = true;
                ActiveControl = UserName;
            }
            else
            {
                AccFile.Seek(0, SeekOrigin.Begin);
                bool found = false; // имя уже есть в файле
                while (ReadRec())
                    if (UserName.Text == UserAcc.UserName) { found = true; break; }
                if (found)
                {
                    MessageBox.Show("Пользователь " + UserName.Text + "\nуже зарегистрирован!");
                    e.Cancel = true;
                    ActiveControl = UserName;
                }
            }
        }
    }
}