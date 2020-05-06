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
    public partial class DetailsForms : Form
    {
    
        public DetailsForms(SzwalniaEntities1 db, String employeeLastName)
        {
            InitializeComponent();
            Pracownicy employee = db.Pracownicy.Where(pracownik => pracownik.Nazwisko == employeeLastName).First();

            lblTitle.Text = employee.Imie.TrimEnd() + " " + employee.Nazwisko;
            txtName.Text = employee.Imie;
            txtLastName.Text = employee.Nazwisko;
            textPesel.Text = employee.Pesel;
            txtAddress.Text = employee.Adres;

        }

        private void DetailsForms_Load(object sender, EventArgs e)
        {

        }
    }
}
