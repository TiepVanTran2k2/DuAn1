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
    public partial class UC_ItemBeverageAdd : UserControl
    {
        public int BeverageId;
        FrmOrderDetail frmDetail;
        public UC_ItemBeverageAdd(FrmOrderDetail frmDetail)
        {
            InitializeComponent();
            this.frmDetail = frmDetail;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            showFrmBeverage();
        }

        private void UC_ItemBeverageAdd_Click(object sender, EventArgs e)
        {
            showFrmBeverage();
        }
        void showFrmBeverage()
        {
            UC_Beverages2 frm = new UC_Beverages2();
            frm.FormClosing += Frm_FormClosing;
            frm.ShowDialog();
        }

        public void Frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmDetail.FrmOrderDetail_Load(this, new EventArgs()); 
        }
    }
}
