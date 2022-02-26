using BUS_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RJCodeAdvance
{
    public partial class FrmAddCustomer : Form
    {
        BUS_Customer bus_customer = new BUS_Customer();
        public FrmAddCustomer(string email)
        {
            InitializeComponent();
            txbEmail.Text = email;
            txbEmail.Enabled = false;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            string gender = "Nam";
            if (rdNu.Checked)
                gender = "Nữ";
            DTO_Customer cus = new DTO_Customer(txbName.Text, txbEmail.Text, gender);
            bus_customer.CreateCustomer(cus);
            this.Close();
        }
    }
}
