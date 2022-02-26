
namespace RJCodeAdvance
{
    partial class FrmAddIngredient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddIngredient));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.nbSoLuong = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblBeverageName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbTongTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ptbImg = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.nbSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 3;
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.Gray;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // nbSoLuong
            // 
            this.nbSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.nbSoLuong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nbSoLuong.BorderRadius = 3;
            this.nbSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nbSoLuong.DisabledState.Parent = this.nbSoLuong;
            this.nbSoLuong.FocusedState.Parent = this.nbSoLuong;
            this.nbSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nbSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.nbSoLuong.Location = new System.Drawing.Point(194, 121);
            this.nbSoLuong.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nbSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbSoLuong.Name = "nbSoLuong";
            this.nbSoLuong.ShadowDecoration.Parent = this.nbSoLuong;
            this.nbSoLuong.Size = new System.Drawing.Size(116, 36);
            this.nbSoLuong.TabIndex = 44;
            this.nbSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbSoLuong.ValueChanged += new System.EventHandler(this.nbSoLuong_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label3.Location = new System.Drawing.Point(194, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Số lượng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(48, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 57;
            this.label9.Text = "Voucher:";
            // 
            // lblBeverageName
            // 
            this.lblBeverageName.AutoSize = true;
            this.lblBeverageName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeverageName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.lblBeverageName.Location = new System.Drawing.Point(194, 48);
            this.lblBeverageName.Name = "lblBeverageName";
            this.lblBeverageName.Size = new System.Drawing.Size(100, 23);
            this.lblBeverageName.TabIndex = 60;
            this.lblBeverageName.Text = "trân châu";
            this.lblBeverageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(194, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 148;
            this.label10.Text = "Tổng tiền:";
            // 
            // txbTongTien
            // 
            this.txbTongTien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbTongTien.BorderRadius = 16;
            this.txbTongTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTongTien.DefaultText = "0";
            this.txbTongTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbTongTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbTongTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbTongTien.DisabledState.Parent = this.txbTongTien;
            this.txbTongTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbTongTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbTongTien.FocusedState.Parent = this.txbTongTien;
            this.txbTongTien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.txbTongTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbTongTien.HoverState.Parent = this.txbTongTien;
            this.txbTongTien.Location = new System.Drawing.Point(194, 203);
            this.txbTongTien.MaxLength = 50;
            this.txbTongTien.Name = "txbTongTien";
            this.txbTongTien.PasswordChar = '\0';
            this.txbTongTien.PlaceholderText = "";
            this.txbTongTien.ReadOnly = true;
            this.txbTongTien.SelectedText = "";
            this.txbTongTien.SelectionStart = 1;
            this.txbTongTien.ShadowDecoration.Parent = this.txbTongTien;
            this.txbTongTien.Size = new System.Drawing.Size(181, 36);
            this.txbTongTien.TabIndex = 149;
            this.txbTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbTongTien.TextChanged += new System.EventHandler(this.txbTongTien_TextChanged);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.lblBeverageName;
            this.bunifuDragControl1.Vertical = true;
            // 
            // ptbImg
            // 
            this.ptbImg.BackColor = System.Drawing.Color.Transparent;
            this.ptbImg.BorderRadius = 3;
            this.ptbImg.Image = ((System.Drawing.Image)(resources.GetObject("ptbImg.Image")));
            this.ptbImg.ImageRotate = 0F;
            this.ptbImg.Location = new System.Drawing.Point(12, 48);
            this.ptbImg.Name = "ptbImg";
            this.ptbImg.ShadowDecoration.Parent = this.ptbImg;
            this.ptbImg.Size = new System.Drawing.Size(169, 191);
            this.ptbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImg.TabIndex = 150;
            this.ptbImg.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.lblPrice.Location = new System.Drawing.Point(194, 71);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(43, 16);
            this.lblPrice.TabIndex = 151;
            this.lblPrice.Text = "5000đ";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(199)))), ((int)(((byte)(210)))));
            this.guna2ControlBox2.BorderRadius = 3;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(199)))), ((int)(((byte)(210)))));
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(418, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(37, 26);
            this.guna2ControlBox2.TabIndex = 153;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(199)))), ((int)(((byte)(210)))));
            this.guna2ControlBox1.BorderRadius = 3;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(199)))), ((int)(((byte)(210)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(461, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(37, 26);
            this.guna2ControlBox1.TabIndex = 152;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.BorderRadius = 16;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "0";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(194, 203);
            this.guna2TextBox1.MaxLength = 50;
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.ReadOnly = true;
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.SelectionStart = 1;
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(181, 36);
            this.guna2TextBox1.TabIndex = 154;
            this.guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnThem
            // 
            this.btnThem.Animated = true;
            this.btnThem.BorderColor = System.Drawing.Color.White;
            this.btnThem.BorderRadius = 3;
            this.btnThem.BorderThickness = 1;
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.CustomBorderColor = System.Drawing.Color.Gray;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(199)))));
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(199)))));
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(199)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnThem.DisabledState.Parent = this.btnThem;
            this.btnThem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnThem.Location = new System.Drawing.Point(381, 203);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(122, 36);
            this.btnThem.TabIndex = 157;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // FrmAddIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(512, 259);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.ptbImg);
            this.Controls.Add(this.txbTongTien);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblBeverageName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nbSoLuong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2TextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddIngredient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddBeverage";
            this.Load += new System.EventHandler(this.FrmAddIngredient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2NumericUpDown nbSoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblBeverageName;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txbTongTien;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Guna.UI2.WinForms.Guna2PictureBox ptbImg;
        private System.Windows.Forms.Label lblPrice;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button btnThem;
    }
}