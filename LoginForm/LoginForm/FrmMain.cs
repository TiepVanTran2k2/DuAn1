using BUS_QuanLy;
using DTO_QuanLy;
using Guna.UI2.WinForms;
using RJCodeAdvance.ControlBeverages;
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
    public partial class FrmBeverageCP : Form
    {
        public FrmBeverageCP()
        {
            InitializeComponent();
            uC_Order2.BringToFront();
            PhanQuyen();
        }
        private void moveImage(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            imageSlide.Location = new Point(b.Location.X + 150, b.Location.Y - 31);
            imageSlide.SendToBack();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btnGoiDoUong_Click(object sender, EventArgs e)
        {
            moveImage(sender);
            if (btnGoiDoUong.Checked)
                uC_Order2.BringToFront();
            if (btnNhanVien.Checked)
                uC_employee1.BringToFront();
            if (btnKhachHang.Checked)
                uC_Customer1.BringToFront();
            if (btnNhapNL.Checked)
                uC_Input_Ingredient1.BringToFront();
            if (btnVoucher.Checked)
                uC_Voucher1.BringToFront();
            if (btnThongKe.Checked)
                uC_Statistic1.BringToFront();
            if (btHoaDon.Checked)
            {
                uC_Bill1.BringToFront();
                uC_Bill1.UC_Bill_Load(this, new EventArgs());
            }
        }

        //FrmLogin login = new FrmLogin();
        public static int vaitro = 0; 

        public static int session = 0;  // kiểm tra tình trạng login
        private void PhanQuyen()
        {
            UC_Order.a = vaitro;
            FrmSchedule.a = vaitro;
            if (session == 1)
            {
                btnKhachHang.Visible = true;
                btnNhanVien.Visible = true;
                btnNhapNL.Visible = true;
                btnThongKe.Visible = true;
                btnVoucher.Visible = true;
                btHoaDon.Visible = true;
                btnGoiDoUong.Visible = true;
                if (vaitro != 1)
                {
                    btnKhachHang.Visible = false;
                    btnNhanVien.Visible = false;
                    btnNhapNL.Visible = false;
                    btnThongKe.Visible = false;
                    btnVoucher.Visible = false;
                    btHoaDon.Visible = false;
                    btnGoiDoUong.Visible = true;
                }
            }
            
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Bạn Có chắc muốn thoát!", "thông báo", MessageBoxButtons.YesNo))
            {
                Environment.Exit(0);
            }
        }
    }
}
