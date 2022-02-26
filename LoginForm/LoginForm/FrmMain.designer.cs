
using Bunifu.Framework.UI;

namespace RJCodeAdvance
{
    partial class FrmBeverageCP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBeverageCP));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btHoaDon = new Guna.UI2.WinForms.Guna2Button();
            this.btnKhachHang = new Guna.UI2.WinForms.Guna2Button();
            this.btnThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.btnVoucher = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhapNL = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.btnGoiDoUong = new Guna.UI2.WinForms.Guna2Button();
            this.imageSlide = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.uC_Bill1 = new RJCodeAdvance.ControlBills.UC_Bill();
            this.uC_Order2 = new RJCodeAdvance.ControlBeverages.UC_Order();
            this.uC_Voucher1 = new RJCodeAdvance.ControlVouchers.UC_Voucher();
            this.uC_Statistic1 = new RJCodeAdvance.ControlStatistic.UC_Statistic();
            this.uC_Input_Ingredient1 = new RJCodeAdvance.ControlIngredient.UC_Input_Ingredient();
            this.uC_employee1 = new RJCodeAdvance.ControlEmployees.UC_employee();
            this.uC_Customer1 = new RJCodeAdvance.ControlCustomers.UC_Customer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Meta";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btHoaDon);
            this.panel1.Controls.Add(this.btnKhachHang);
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Controls.Add(this.btnVoucher);
            this.panel1.Controls.Add(this.btnNhapNL);
            this.panel1.Controls.Add(this.btnNhanVien);
            this.panel1.Controls.Add(this.btnGoiDoUong);
            this.panel1.Controls.Add(this.imageSlide);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 661);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 604);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // btHoaDon
            // 
            this.btHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.btHoaDon.BorderRadius = 22;
            this.btHoaDon.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btHoaDon.CheckedState.FillColor = System.Drawing.Color.White;
            this.btHoaDon.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btHoaDon.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btHoaDon.CheckedState.Parent = this.btHoaDon;
            this.btHoaDon.CustomImages.Parent = this.btHoaDon;
            this.btHoaDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btHoaDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btHoaDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btHoaDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btHoaDon.DisabledState.Parent = this.btHoaDon;
            this.btHoaDon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btHoaDon.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHoaDon.ForeColor = System.Drawing.Color.White;
            this.btHoaDon.HoverState.Parent = this.btHoaDon;
            this.btHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btHoaDon.Image")));
            this.btHoaDon.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btHoaDon.ImageSize = new System.Drawing.Size(25, 25);
            this.btHoaDon.Location = new System.Drawing.Point(27, 380);
            this.btHoaDon.Name = "btHoaDon";
            this.btHoaDon.ShadowDecoration.Parent = this.btHoaDon;
            this.btHoaDon.Size = new System.Drawing.Size(186, 43);
            this.btHoaDon.TabIndex = 18;
            this.btHoaDon.Text = "Hoá đơn";
            this.btHoaDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btHoaDon.TextOffset = new System.Drawing.Point(10, 0);
            this.btHoaDon.UseTransparentBackground = true;
            this.btHoaDon.Click += new System.EventHandler(this.btnGoiDoUong_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.btnKhachHang.BorderRadius = 22;
            this.btnKhachHang.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnKhachHang.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnKhachHang.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnKhachHang.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnKhachHang.CheckedState.Parent = this.btnKhachHang;
            this.btnKhachHang.CustomImages.Parent = this.btnKhachHang;
            this.btnKhachHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKhachHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKhachHang.DisabledState.Parent = this.btnKhachHang;
            this.btnKhachHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnKhachHang.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnKhachHang.HoverState.Parent = this.btnKhachHang;
            this.btnKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.Image")));
            this.btnKhachHang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKhachHang.ImageSize = new System.Drawing.Size(25, 25);
            this.btnKhachHang.Location = new System.Drawing.Point(27, 203);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.ShadowDecoration.Parent = this.btnKhachHang;
            this.btnKhachHang.Size = new System.Drawing.Size(186, 43);
            this.btnKhachHang.TabIndex = 14;
            this.btnKhachHang.Text = "Khách Hàng";
            this.btnKhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKhachHang.TextOffset = new System.Drawing.Point(10, 0);
            this.btnKhachHang.UseTransparentBackground = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnGoiDoUong_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.Transparent;
            this.btnThongKe.BorderRadius = 22;
            this.btnThongKe.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnThongKe.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnThongKe.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnThongKe.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnThongKe.CheckedState.Parent = this.btnThongKe;
            this.btnThongKe.CustomImages.Parent = this.btnThongKe;
            this.btnThongKe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongKe.DisabledState.Parent = this.btnThongKe;
            this.btnThongKe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnThongKe.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.HoverState.Parent = this.btnThongKe;
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThongKe.ImageSize = new System.Drawing.Size(25, 25);
            this.btnThongKe.Location = new System.Drawing.Point(27, 440);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.ShadowDecoration.Parent = this.btnThongKe;
            this.btnThongKe.Size = new System.Drawing.Size(186, 43);
            this.btnThongKe.TabIndex = 13;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThongKe.TextOffset = new System.Drawing.Point(10, 0);
            this.btnThongKe.UseTransparentBackground = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnGoiDoUong_Click);
            // 
            // btnVoucher
            // 
            this.btnVoucher.BackColor = System.Drawing.Color.Transparent;
            this.btnVoucher.BorderRadius = 22;
            this.btnVoucher.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnVoucher.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnVoucher.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnVoucher.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnVoucher.CheckedState.Parent = this.btnVoucher;
            this.btnVoucher.CustomImages.Parent = this.btnVoucher;
            this.btnVoucher.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVoucher.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVoucher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVoucher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVoucher.DisabledState.Parent = this.btnVoucher;
            this.btnVoucher.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnVoucher.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoucher.ForeColor = System.Drawing.Color.White;
            this.btnVoucher.HoverState.Parent = this.btnVoucher;
            this.btnVoucher.Image = ((System.Drawing.Image)(resources.GetObject("btnVoucher.Image")));
            this.btnVoucher.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnVoucher.ImageSize = new System.Drawing.Size(25, 25);
            this.btnVoucher.Location = new System.Drawing.Point(27, 321);
            this.btnVoucher.Name = "btnVoucher";
            this.btnVoucher.ShadowDecoration.Parent = this.btnVoucher;
            this.btnVoucher.Size = new System.Drawing.Size(186, 43);
            this.btnVoucher.TabIndex = 12;
            this.btnVoucher.Text = "Voucher";
            this.btnVoucher.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnVoucher.TextOffset = new System.Drawing.Point(10, 0);
            this.btnVoucher.UseTransparentBackground = true;
            this.btnVoucher.Click += new System.EventHandler(this.btnGoiDoUong_Click);
            // 
            // btnNhapNL
            // 
            this.btnNhapNL.BackColor = System.Drawing.Color.Transparent;
            this.btnNhapNL.BorderRadius = 22;
            this.btnNhapNL.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNhapNL.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnNhapNL.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnNhapNL.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.btnNhapNL.CheckedState.Parent = this.btnNhapNL;
            this.btnNhapNL.CustomImages.Parent = this.btnNhapNL;
            this.btnNhapNL.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNhapNL.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNhapNL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhapNL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNhapNL.DisabledState.Parent = this.btnNhapNL;
            this.btnNhapNL.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnNhapNL.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapNL.ForeColor = System.Drawing.Color.White;
            this.btnNhapNL.HoverState.Parent = this.btnNhapNL;
            this.btnNhapNL.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapNL.Image")));
            this.btnNhapNL.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNhapNL.ImageSize = new System.Drawing.Size(25, 25);
            this.btnNhapNL.Location = new System.Drawing.Point(27, 263);
            this.btnNhapNL.Name = "btnNhapNL";
            this.btnNhapNL.ShadowDecoration.Parent = this.btnNhapNL;
            this.btnNhapNL.Size = new System.Drawing.Size(186, 43);
            this.btnNhapNL.TabIndex = 10;
            this.btnNhapNL.Text = "Nhập NL";
            this.btnNhapNL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNhapNL.TextOffset = new System.Drawing.Point(10, 0);
            this.btnNhapNL.UseTransparentBackground = true;
            this.btnNhapNL.Click += new System.EventHandler(this.btnGoiDoUong_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btnNhanVien.BorderRadius = 22;
            this.btnNhanVien.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNhanVien.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnNhanVien.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnNhanVien.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.btnNhanVien.CheckedState.Parent = this.btnNhanVien;
            this.btnNhanVien.CustomImages.Parent = this.btnNhanVien;
            this.btnNhanVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNhanVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNhanVien.DisabledState.Parent = this.btnNhanVien;
            this.btnNhanVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnNhanVien.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.HoverState.Parent = this.btnNhanVien;
            this.btnNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Image")));
            this.btnNhanVien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNhanVien.ImageSize = new System.Drawing.Size(25, 25);
            this.btnNhanVien.Location = new System.Drawing.Point(27, 145);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.ShadowDecoration.Parent = this.btnNhanVien;
            this.btnNhanVien.Size = new System.Drawing.Size(186, 43);
            this.btnNhanVien.TabIndex = 9;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNhanVien.TextOffset = new System.Drawing.Point(10, 0);
            this.btnNhanVien.UseTransparentBackground = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnGoiDoUong_Click);
            // 
            // btnGoiDoUong
            // 
            this.btnGoiDoUong.BackColor = System.Drawing.Color.Transparent;
            this.btnGoiDoUong.BorderRadius = 22;
            this.btnGoiDoUong.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnGoiDoUong.Checked = true;
            this.btnGoiDoUong.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnGoiDoUong.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnGoiDoUong.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            this.btnGoiDoUong.CheckedState.Parent = this.btnGoiDoUong;
            this.btnGoiDoUong.CustomImages.Parent = this.btnGoiDoUong;
            this.btnGoiDoUong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGoiDoUong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGoiDoUong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGoiDoUong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGoiDoUong.DisabledState.Parent = this.btnGoiDoUong;
            this.btnGoiDoUong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnGoiDoUong.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoiDoUong.ForeColor = System.Drawing.Color.White;
            this.btnGoiDoUong.HoverState.Parent = this.btnGoiDoUong;
            this.btnGoiDoUong.Image = ((System.Drawing.Image)(resources.GetObject("btnGoiDoUong.Image")));
            this.btnGoiDoUong.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGoiDoUong.ImageSize = new System.Drawing.Size(25, 25);
            this.btnGoiDoUong.Location = new System.Drawing.Point(27, 86);
            this.btnGoiDoUong.Name = "btnGoiDoUong";
            this.btnGoiDoUong.ShadowDecoration.Parent = this.btnGoiDoUong;
            this.btnGoiDoUong.Size = new System.Drawing.Size(186, 43);
            this.btnGoiDoUong.TabIndex = 5;
            this.btnGoiDoUong.Text = "Gọi đồ uống";
            this.btnGoiDoUong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGoiDoUong.TextOffset = new System.Drawing.Point(10, 0);
            this.btnGoiDoUong.UseTransparentBackground = true;
            this.btnGoiDoUong.Click += new System.EventHandler(this.btnGoiDoUong_Click);
            // 
            // imageSlide
            // 
            this.imageSlide.Image = ((System.Drawing.Image)(resources.GetObject("imageSlide.Image")));
            this.imageSlide.Location = new System.Drawing.Point(174, 56);
            this.imageSlide.Name = "imageSlide";
            this.imageSlide.Size = new System.Drawing.Size(39, 102);
            this.imageSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageSlide.TabIndex = 6;
            this.imageSlide.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_Bill1);
            this.panel2.Controls.Add(this.uC_Order2);
            this.panel2.Controls.Add(this.uC_Voucher1);
            this.panel2.Controls.Add(this.uC_Statistic1);
            this.panel2.Controls.Add(this.uC_Input_Ingredient1);
            this.panel2.Controls.Add(this.uC_employee1);
            this.panel2.Controls.Add(this.uC_Customer1);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(213, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.panel2.Size = new System.Drawing.Size(1100, 661);
            this.panel2.TabIndex = 6;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(350, 380);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(313, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.label1;
            // 
            // uC_Bill1
            // 
            this.uC_Bill1.BackColor = System.Drawing.Color.White;
            this.uC_Bill1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Bill1.Location = new System.Drawing.Point(0, 10);
            this.uC_Bill1.Name = "uC_Bill1";
            this.uC_Bill1.Size = new System.Drawing.Size(1090, 641);
            this.uC_Bill1.TabIndex = 11;
            // 
            // uC_Order2
            // 
            this.uC_Order2.BackColor = System.Drawing.Color.White;
            this.uC_Order2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Order2.Location = new System.Drawing.Point(0, 10);
            this.uC_Order2.Name = "uC_Order2";
            this.uC_Order2.Size = new System.Drawing.Size(1090, 641);
            this.uC_Order2.TabIndex = 10;
            // 
            // uC_Voucher1
            // 
            this.uC_Voucher1.BackColor = System.Drawing.Color.White;
            this.uC_Voucher1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Voucher1.Location = new System.Drawing.Point(0, 10);
            this.uC_Voucher1.Name = "uC_Voucher1";
            this.uC_Voucher1.Size = new System.Drawing.Size(1090, 641);
            this.uC_Voucher1.TabIndex = 7;
            // 
            // uC_Statistic1
            // 
            this.uC_Statistic1.BackColor = System.Drawing.Color.White;
            this.uC_Statistic1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Statistic1.Location = new System.Drawing.Point(0, 10);
            this.uC_Statistic1.Name = "uC_Statistic1";
            this.uC_Statistic1.Size = new System.Drawing.Size(1090, 641);
            this.uC_Statistic1.TabIndex = 6;
            // 
            // uC_Input_Ingredient1
            // 
            this.uC_Input_Ingredient1.BackColor = System.Drawing.Color.White;
            this.uC_Input_Ingredient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Input_Ingredient1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.uC_Input_Ingredient1.Location = new System.Drawing.Point(0, 10);
            this.uC_Input_Ingredient1.Name = "uC_Input_Ingredient1";
            this.uC_Input_Ingredient1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.uC_Input_Ingredient1.Size = new System.Drawing.Size(1090, 641);
            this.uC_Input_Ingredient1.TabIndex = 5;
            // 
            // uC_employee1
            // 
            this.uC_employee1.BackColor = System.Drawing.Color.White;
            this.uC_employee1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_employee1.Location = new System.Drawing.Point(0, 10);
            this.uC_employee1.Name = "uC_employee1";
            this.uC_employee1.Size = new System.Drawing.Size(1090, 641);
            this.uC_employee1.TabIndex = 3;
            // 
            // uC_Customer1
            // 
            this.uC_Customer1.BackColor = System.Drawing.Color.White;
            this.uC_Customer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Customer1.Location = new System.Drawing.Point(0, 10);
            this.uC_Customer1.Name = "uC_Customer1";
            this.uC_Customer1.Size = new System.Drawing.Size(1090, 641);
            this.uC_Customer1.TabIndex = 2;
            // 
            // FrmBeverageCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1313, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1366, 728);
            this.Name = "FrmBeverageCP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBeverageCP";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnKhachHang;
        private Guna.UI2.WinForms.Guna2Button btnThongKe;
        private Guna.UI2.WinForms.Guna2Button btnVoucher;
        private Guna.UI2.WinForms.Guna2Button btnNhapNL;
        private Guna.UI2.WinForms.Guna2Button btnNhanVien;
        private Guna.UI2.WinForms.Guna2Button btnGoiDoUong;
        private System.Windows.Forms.PictureBox imageSlide;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private ControlVouchers.UC_Voucher uC_Voucher1;
        private ControlStatistic.UC_Statistic uC_Statistic1;
        private ControlIngredient.UC_Input_Ingredient uC_Input_Ingredient1;
        private ControlEmployees.UC_employee uC_employee1;
        private ControlCustomers.UC_Customer uC_Customer1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ControlBeverages.UC_Order uC_Order2;
        private ControlBills.UC_Bill uC_Bill1;
        private Guna.UI2.WinForms.Guna2Button btHoaDon;
        private System.Windows.Forms.PictureBox pictureBox2;
        //private ControlStatistic.UC_Statistic uC_Statistic_bill_beverage1;
        //private BunifuDragControl bunifuDragControl1;
    }
}