using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_navina
{
    public partial class Login : Form
    {
        private string Email;
        private string Password;
        public string getEmail()
        {
            return Email = textEmail.Text;
        }
        public string getPassword()
        {
            return Password = textPassword.Text;
        }

        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bank_applicationEntities bank_ApplicationEntities = new bank_applicationEntities();
            if (textEmail.Text != string.Empty || textPassword.Text != string.Empty)
            {
                var customer1 = bank_ApplicationEntities.tbl_login.FirstOrDefault(a => a.email.Equals(textEmail.Text));
                if(customer1!= null)
                {
                    if (customer1.password.Equals(textPassword.Text))
                    {
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Password in Incorrect!");
                    }
                }
                else
                {
                    MessageBox.Show("Null Value");
                }
            }
            else
            {
                MessageBox.Show("Please enter Email and Password!");
            }
        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {
            
        }


    }
}
