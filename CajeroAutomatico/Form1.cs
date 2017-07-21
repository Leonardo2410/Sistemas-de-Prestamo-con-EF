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
    public partial class frmban : Form
    {
        public frmban()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "6";
        }

        private void lbl0_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "0";
        }

        private void lbl9_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "9";
        }

        private void lbl8_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "8";
        }

        private void lbl7_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "7";
        }

        private void lbl5_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "5";
        }

        private void lbl4_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "4";
        }

        private void lbl3_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "3";
        }

        private void lbl2_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "2";
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "1";
        }

        private void lblCLEAR_Click(object sender, EventArgs e)
        {
            String lastChar = txtPassword.Text.Substring(0,txtPassword.Text.Length - 1);
            txtPassword.Text = lastChar;
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblOK_Click(object sender, EventArgs e)
        {
            string password = Properties.Settings.Default.Password;
            if (txtPassword.Text == password) 
            {
                tabControl1.SelectTab(1);
            }   else
            {
                MessageBox.Show("Lo sentimos, Su PIN es incorrecto", "Validacion");
                txtPassword.Text = "";
            }

        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
            lblBalance.Text = Properties.Settings.Default.Capital;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
            aux.Text = Properties.Settings.Default.Capital; 
        }

        private void btn2000_Click(object sender, EventArgs e)
        {
            Retiro(2000);
        }

        private void Retiro(Double cantidad)
        {
            double balance = double.Parse(aux.Text);
            //Validamos si el usuario tiene fondo suficientes
            if(balance >= cantidad)
            {
                double z = balance - cantidad;
                Properties.Settings.Default.Capital = Convert.ToString(z);
                Properties.Settings.Default.Save();
                MessageBox.Show("Por Favor Retire Su Dinero, Gracias Por Preferirnos", "Retirando Dinero", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("No Posee Fondos Suficientes, Intente Otra Cantidad");
            }
        }

        private void btn1000_Click(object sender, EventArgs e)
        {
            Retiro(1000);
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            Retiro(500);
        }
            
        private void btn300_Click(object sender, EventArgs e)
        {
            Retiro(300);
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            Retiro(100);
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            string request = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Otra Cantidad", "Otra Cantidad", "0");
            double money = double.Parse(request);
            MessageBox.Show("" + money);
            Retiro(money);
        }
    }
}
