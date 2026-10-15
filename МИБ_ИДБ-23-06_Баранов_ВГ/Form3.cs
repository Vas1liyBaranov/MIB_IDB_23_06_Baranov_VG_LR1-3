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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MIB_IDB_23_06_Baranov_VG
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // при открытии окна: фокус на кнопку OK
        private void Form3_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                ActiveControl = Button1;
            }
        }

        // сохранение параметров текущей учетной записи
        private void Save_Click(object sender, EventArgs e)
        {
            UserAcc.Block = CheckBox1.Checked;
            UserAcc.Restrict = CheckBox2.Checked;
            AccFile.Seek((RecCount - 1) * RecSize, SeekOrigin.Begin);
            WriteRec();
            AccFile.Seek(RecCount * RecSize, SeekOrigin.Begin);
        }

        // переход к следующей учетной записи
        private void Next_Click(object sender, EventArgs e)
        {
            ReadRec();
            RecCount++;
            UserName.Text = UserAcc.UserName;
            CheckBox1.Checked = UserAcc.Block;
            CheckBox2.Checked = UserAcc.Restrict;
            if (AccFile.Position >= AccFile.Length)
            {
                Next.Enabled = false; // записей больше нет
            }
            Prev.Enabled = true;
        }

        // переход к предыдущей учетной записи
        private void Prev_Click(object sender, EventArgs e)
        {
            if (RecCount <= 1) return; // уже первая запись
            RecCount--;
            AccFile.Seek((RecCount - 1) * RecSize, SeekOrigin.Begin);
            ReadRec();
            UserName.Text = UserAcc.UserName;
            CheckBox1.Checked = UserAcc.Block;
            CheckBox2.Checked = UserAcc.Restrict;
            Next.Enabled = true;
            if (RecCount > 1)
                Prev.Enabled = true;
            else
                Prev.Enabled = false;
        }
    }
}