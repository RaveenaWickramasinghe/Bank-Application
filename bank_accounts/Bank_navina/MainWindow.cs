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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void withdrawMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newAccountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();

            bank_applicationEntities bank_ApplicationEntities = new bank_applicationEntities();
            string txtEmail = login.getEmail();
            string txtPassword = login.getPassword();
            if (txtEmail != string.Empty || txtPassword != string.Empty)
            {
                var customer1 = bank_ApplicationEntities.tbl_login.FirstOrDefault(a => a.email.Equals(txtEmail));
                if (customer1 != null)
                {
                    if (customer1.password.Equals(txtPassword))
                    {
                        AddCustomers addCustomers = new AddCustomers();
                        addCustomers.Show();
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

        private void withdrawMoneyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            bank_applicationEntities bank_ApplicationEntities = new bank_applicationEntities();
            string txtEmail = login.getEmail();
            string txtPassword = login.getPassword();
            if (txtEmail != string.Empty || txtPassword != string.Empty)
            {
                var customer1 = bank_ApplicationEntities.tbl_login.FirstOrDefault(a => a.email.Equals(txtEmail));
                if (customer1 != null)
                {
                    if (customer1.password.Equals(txtPassword))
                    {
                        WithdrawMoney withdraw = new WithdrawMoney();
                        withdraw.Show();
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

        private void depositMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();

            bank_applicationEntities bank_ApplicationEntities = new bank_applicationEntities();
            string txtEmail = login.getEmail();
            string txtPassword = login.getPassword();
            if (txtEmail != string.Empty || txtPassword != string.Empty)
            {
                var customer1 = bank_ApplicationEntities.tbl_login.FirstOrDefault(a => a.email.Equals(txtEmail));
                if (customer1 != null)
                {
                    if (customer1.password.Equals(txtPassword))
                    {
                        DepositMoney deposit = new DepositMoney();
                        deposit.Show();
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

        private void checkBalanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();

            bank_applicationEntities bank_ApplicationEntities = new bank_applicationEntities();
            string txtEmail = login.getEmail();
            string txtPassword = login.getPassword();
            if (txtEmail != string.Empty || txtPassword != string.Empty)
            {
                var customer1 = bank_ApplicationEntities.tbl_login.FirstOrDefault(a => a.email.Equals(txtEmail));
                if (customer1 != null)
                {
                    if (customer1.password.Equals(txtPassword))
                    {
                        CheckBalance check = new CheckBalance();
                        check.Show();
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

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
