using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtButtonLabel_TextChanged(object sender, EventArgs e)
        {
            if (txtButtonLabel.TextLength > 0)
            {
                btnClose.Text = txtButtonLabel.Text;
            }
        }

        private void chkButtomEnabled_CheckedChanged(object sender, EventArgs e)
        {
            btnClose.Enabled = chkButtomEnabled.Checked;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
