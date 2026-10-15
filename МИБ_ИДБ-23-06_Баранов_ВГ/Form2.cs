using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIB_IDB_23_06_Baranov_VG
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // при открытии окна: очистка полей, фокус на имя
        private void Form2_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                Login.Text = "";
                Password.Text = "";
                ActiveControl = Login;
            }
        }

        // закрытие по OK только при введенном имени
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK) e.Cancel = Login.Text == "";
        }
    }
}