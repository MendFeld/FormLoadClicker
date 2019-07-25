using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLoad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFormLoad.Text = "This text is set on startup !";
        }

        private void BtnClickMe_Click(object sender, EventArgs e)
        {
            lblButtonClick.Text = "This text is set on button click !";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            lblButtonClick.Text = string.Empty;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
