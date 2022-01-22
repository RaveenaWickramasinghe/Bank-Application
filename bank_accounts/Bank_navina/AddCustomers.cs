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

namespace Bank_navina
{
    public partial class AddCustomers : Form
    {

        string gender = string.Empty;
        decimal number;
        bank_applicationEntities bankAccount;
        MemoryStream memoryStream;

        public AddCustomers()
        {
            InitializeComponent();
            loadDate();
            loadAccount();
        }

        private void loadAccount()
        {
            bankAccount = new bank_applicationEntities();
            var item = 

        }

        private void loadDate()
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void AddCustomers_Load(object sender, EventArgs e)
        {

        }
    }
}
