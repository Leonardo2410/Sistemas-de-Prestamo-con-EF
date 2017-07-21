using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                //Verdad
                Properties.Settings.Default.Name = txtName.Text;
                Properties.Settings.Default.Lastname = txtLastname.Text;
                Properties.Settings.Default.Password = txtPIN.Text;
                Properties.Settings.Default.Capital = txtBalance.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("Cliente Registrado");
            }
            catch(Exception)
            {


                throw;
            }

        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            txtName.Text = Properties.Settings.Default.Name;
            txtLastname.Text = Properties.Settings.Default.Lastname;
            txtPIN.Text = Properties.Settings.Default.Password;
            txtBalance.Text = Properties.Settings.Default.Capital;
        }
    }
}
