using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RJCodeAdvance.ControlBeverages
{
    public partial class UC_ItemBeverage : UserControl
    {
        public int BeverageId;
        public UC_ItemBeverage()
        {
            InitializeComponent();
        }

        public string BeverageName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }
        public string BeveragePrice
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }
        public Image BeverageImage
        {
            get { return ptbImg.Image; }
            set { ptbImg.Image = value; }
        }

        private void btThem_Click(object sender, EventArgs e)
        {

        }
    }
}
