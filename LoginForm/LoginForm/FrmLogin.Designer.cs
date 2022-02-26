
namespace RJCodeAdvance
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.toggleNhoTaiKhoan = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.btGuiMatKhau = new System.Windows.Forms.Label();
            this.btThoat = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btDangNhap = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColor = System.Drawing.Color.DarkViolet;
            this.txtEmail.BorderRadius = 8;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.Parent = this.txtEmail;
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FillColor = System.Drawing.Color.Beige;
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedState.Parent = this.txtEmail;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.HoverState.Parent = this.txtEmail;
            this.txtEmail.Location = new System.Drawing.Point(38, 100);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.SlateGray;
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.ShadowDecoration.Parent = this.txtEmail;
            this.txtEmail.Size = new System.Drawing.Size(262, 36);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.DarkViolet;
            this.txtPassword.BorderRadius = 8;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.Color.Beige;
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.Location = new System.Drawing.Point(38, 159);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.SlateGray;
            this.txtPassword.PlaceholderText = "Mật khẩu";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(262, 36);
            this.txtPassword.TabIndex = 2;
            // 
            // toggleNhoTaiKhoan
            // 
            this.toggleNhoTaiKhoan.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleNhoTaiKhoan.CheckedState.FillColor = System.Drawing.Color.DarkViolet;
            this.toggleNhoTaiKhoan.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleNhoTaiKhoan.CheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleNhoTaiKhoan.CheckedState.Parent = this.toggleNhoTaiKhoan;
            this.toggleNhoTaiKhoan.Location = new System.Drawing.Point(38, 201);
            this.toggleNhoTaiKhoan.Name = "toggleNhoTaiKhoan";
            this.toggleNhoTaiKhoan.ShadowDecoration.Parent = this.toggleNhoTaiKhoan;
            this.toggleNhoTaiKhoan.Size = new System.Drawing.Size(35, 20);
            this.toggleNhoTaiKhoan.TabIndex = 3;
            this.toggleNhoTaiKhoan.UncheckedState.BorderColor = System.Drawing.Color.DarkViolet;
            this.toggleNhoTaiKhoan.UncheckedState.BorderThickness = 2;
            this.toggleNhoTaiKhoan.UncheckedState.FillColor = System.Drawing.Color.Beige;
            this.toggleNhoTaiKhoan.UncheckedState.InnerBorderColor = System.Drawing.Color.DarkViolet;
            this.toggleNhoTaiKhoan.UncheckedState.InnerColor = System.Drawing.Color.DarkViolet;
            this.toggleNhoTaiKhoan.UncheckedState.Parent = this.toggleNhoTaiKhoan;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(89, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhớ tài khoản";
            // 
            // btGuiMatKhau
            // 
            this.btGuiMatKhau.AutoSize = true;
            this.btGuiMatKhau.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuiMatKhau.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btGuiMatKhau.Location = new System.Drawing.Point(208, 205);
            this.btGuiMatKhau.Name = "btGuiMatKhau";
            this.btGuiMatKhau.Size = new System.Drawing.Size(92, 14);
            this.btGuiMatKhau.TabIndex = 5;
            this.btGuiMatKhau.Text = "Quên mật khẩu";
            this.btGuiMatKhau.Click += new System.EventHandler(this.btGuiMatKhau_Click);
            // 
            // btThoat
            // 
            this.btThoat.BorderRadius = 10;
            this.btThoat.CheckedState.Parent = this.btThoat;
            this.btThoat.CustomImages.Parent = this.btThoat;
            this.btThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btThoat.DisabledState.Parent = this.btThoat;
            this.btThoat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btThoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btThoat.ForeColor = System.Drawing.Color.White;
            this.btThoat.HoverState.Parent = this.btThoat;
            this.btThoat.Location = new System.Drawing.Point(145, 241);
            this.btThoat.Name = "btThoat";
            this.btThoat.ShadowDecoration.Parent = this.btThoat;
            this.btThoat.Size = new System.Drawing.Size(101, 35);
            this.btThoat.TabIndex = 7;
            this.btThoat.Text = "Thoát";
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderRadius = 3;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Thistle;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(661, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(37, 26);
            this.guna2ControlBox1.TabIndex = 8;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.BorderRadius = 3;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Thistle;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(618, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(37, 26);
            this.guna2ControlBox2.TabIndex = 9;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 3;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(100, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Đăng Nhập";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(341, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 411);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // btDangNhap
            // 
            this.btDangNhap.BorderRadius = 10;
            this.btDangNhap.CheckedState.Parent = this.btDangNhap;
            this.btDangNhap.CustomImages.Parent = this.btDangNhap;
            this.btDangNhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btDangNhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btDangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btDangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btDangNhap.DisabledState.Parent = this.btDangNhap;
            this.btDangNhap.FillColor = System.Drawing.Color.SlateBlue;
            this.btDangNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btDangNhap.ForeColor = System.Drawing.Color.White;
            this.btDangNhap.HoverState.Parent = this.btDangNhap;
            this.btDangNhap.Location = new System.Drawing.Point(38, 241);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.ShadowDecoration.Parent = this.btDangNhap;
            this.btDangNhap.Size = new System.Drawing.Size(101, 35);
            this.btDangNhap.TabIndex = 6;
            this.btDangNhap.Text = "Đăng nhập";
            this.btDangNhap.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(710, 407);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btDangNhap);
            this.Controls.Add(this.btGuiMatKhau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toggleNhoTaiKhoan);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.LoginNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleNhoTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btGuiMatKhau;
        private Guna.UI2.WinForms.Guna2Button btThoat;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        public Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Button btDangNhap;
        //private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}