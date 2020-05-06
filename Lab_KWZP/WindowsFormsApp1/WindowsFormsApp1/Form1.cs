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
        private SzwalniaEntities1 db;
        public Form1()
        {
            InitializeComponent();
            btnClose.Enabled = false;
            db = new SzwalniaEntities1();
        }
               
        private void chkButtomEnabled_CheckedChanged(object sender, EventArgs e)
        {
            btnClose.Enabled = chkButtomEnabled.Checked;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DetailsForms detailsForms = new DetailsForms(db, txtButtonLabel.Text);
            detailsForms.Show();
                         
         }
        
    }
}
