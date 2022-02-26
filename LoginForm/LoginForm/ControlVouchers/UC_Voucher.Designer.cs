
namespace RJCodeAdvance.ControlVouchers
{
    partial class UC_Voucher
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Voucher));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dayStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dayEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoLuong = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.btDanhSach = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.btThem = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThem = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cbSale = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaColorTransition1 = new Guna.UI.WinForms.GunaColorTransition(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.cbSearch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.rdChua = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdDung = new Guna.UI2.WinForms.Guna2RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label1.Location = new System.Drawing.Point(82, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 89;
            this.label1.Text = "Giảm giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label4.Location = new System.Drawing.Point(552, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 102;
            this.label4.Text = "Tình trạng:";
            // 
            // dayStart
            // 
            this.dayStart.Animated = true;
            this.dayStart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.dayStart.BorderRadius = 15;
            this.dayStart.BorderThickness = 1;
            this.dayStart.Checked = true;
            this.dayStart.CheckedState.Parent = this.dayStart;
            this.dayStart.CustomFormat = "yyyy/MM/dd";
            this.dayStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.dayStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dayStart.ForeColor = System.Drawing.Color.White;
            this.dayStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dayStart.HoverState.Parent = this.dayStart;
            this.dayStart.Location = new System.Drawing.Point(82, 130);
            this.dayStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dayStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dayStart.Name = "dayStart";
            this.dayStart.ShadowDecoration.Parent = this.dayStart;
            this.dayStart.Size = new System.Drawing.Size(293, 36);
            this.dayStart.TabIndex = 106;
            this.dayStart.Value = new System.DateTime(2021, 11, 7, 13, 49, 6, 43);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label7.Location = new System.Drawing.Point(82, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 105;
            this.label7.Text = "Bắt đầu:";
            // 
            // dayEnd
            // 
            this.dayEnd.Animated = true;
            this.dayEnd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.dayEnd.BorderRadius = 15;
            this.dayEnd.BorderThickness = 1;
            this.dayEnd.Checked = true;
            this.dayEnd.CheckedState.Parent = this.dayEnd;
            this.dayEnd.CustomFormat = "yyyy/MM/dd";
            this.dayEnd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.dayEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayEnd.ForeColor = System.Drawing.Color.White;
            this.dayEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dayEnd.HoverState.Parent = this.dayEnd;
            this.dayEnd.Location = new System.Drawing.Point(555, 130);
            this.dayEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dayEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dayEnd.Name = "dayEnd";
            this.dayEnd.ShadowDecoration.Parent = this.dayEnd;
            this.dayEnd.Size = new System.Drawing.Size(267, 36);
            this.dayEnd.TabIndex = 108;
            this.dayEnd.Value = new System.DateTime(2021, 11, 7, 13, 49, 6, 43);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label2.Location = new System.Drawing.Point(552, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 107;
            this.label2.Text = "Kết thúc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label3.Location = new System.Drawing.Point(855, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 111;
            this.label3.Text = "Số lượng còn lại:";
            // 
            // txtSoLuong
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.txtSoLuong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.txtSoLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.txtSoLuong.BackgroundColor = System.Drawing.SystemColors.Control;
            this.txtSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoLuong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.txtSoLuong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.txtSoLuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.txtSoLuong.ColumnHeadersHeight = 25;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.txtSoLuong.DefaultCellStyle = dataGridViewCellStyle9;
            this.txtSoLuong.EnableHeadersVisualStyles = false;
            this.txtSoLuong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.txtSoLuong.Location = new System.Drawing.Point(40, 295);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.RowHeadersVisible = false;
            this.txtSoLuong.RowHeadersWidth = 51;
            this.txtSoLuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.txtSoLuong.Size = new System.Drawing.Size(1037, 292);
            this.txtSoLuong.TabIndex = 120;
            this.txtSoLuong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.txtSoLuong.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.txtSoLuong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.txtSoLuong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.txtSoLuong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.txtSoLuong.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.txtSoLuong.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.txtSoLuong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSoLuong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.txtSoLuong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtSoLuong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.txtSoLuong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.txtSoLuong.ThemeStyle.HeaderStyle.Height = 25;
            this.txtSoLuong.ThemeStyle.ReadOnly = false;
            this.txtSoLuong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.txtSoLuong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.txtSoLuong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtSoLuong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.txtSoLuong.ThemeStyle.RowsStyle.Height = 22;
            this.txtSoLuong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.txtSoLuong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.txtSoLuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellClick);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 26;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.BorderRadius = 6;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomBorderColor = System.Drawing.Color.Gray;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.Silver;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.Silver;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.Enabled = false;
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.Location = new System.Drawing.Point(250, 50);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(125, 36);
            this.guna2Button1.TabIndex = 122;
            this.guna2Button1.Text = "Thêm";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.Animated = true;
            this.guna2Button5.BorderColor = System.Drawing.Color.White;
            this.guna2Button5.BorderRadius = 6;
            this.guna2Button5.BorderThickness = 1;
            this.guna2Button5.CheckedState.Parent = this.guna2Button5;
            this.guna2Button5.CustomImages.Parent = this.guna2Button5;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(199)))));
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(199)))));
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(199)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.DisabledState.Parent = this.guna2Button5;
            this.guna2Button5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Button5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.HoverState.Parent = this.guna2Button5;
            this.guna2Button5.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button5.Image")));
            this.guna2Button5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button5.Location = new System.Drawing.Point(536, 593);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.ShadowDecoration.Parent = this.guna2Button5;
            this.guna2Button5.Size = new System.Drawing.Size(128, 45);
            this.guna2Button5.TabIndex = 117;
            this.guna2Button5.Text = "Lưu";
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // btDanhSach
            // 
            this.btDanhSach.Animated = true;
            this.btDanhSach.BorderColor = System.Drawing.Color.White;
            this.btDanhSach.BorderRadius = 6;
            this.btDanhSach.BorderThickness = 1;
            this.btDanhSach.CheckedState.Parent = this.btDanhSach;
            this.btDanhSach.CustomImages.Parent = this.btDanhSach;
            this.btDanhSach.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(199)))));
            this.btDanhSach.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(199)))));
            this.btDanhSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(199)))));
            this.btDanhSach.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btDanhSach.DisabledState.Parent = this.btDanhSach;
            this.btDanhSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btDanhSach.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDanhSach.ForeColor = System.Drawing.Color.White;
            this.btDanhSach.HoverState.Parent = this.btDanhSach;
            this.btDanhSach.Image = ((System.Drawing.Image)(resources.GetObject("btDanhSach.Image")));
            this.btDanhSach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btDanhSach.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btDanhSach.Location = new System.Drawing.Point(677, 593);
            this.btDanhSach.Name = "btDanhSach";
            this.btDanhSach.ShadowDecoration.Parent = this.btDanhSach;
            this.btDanhSach.Size = new System.Drawing.Size(128, 45);
            this.btDanhSach.TabIndex = 116;
            this.btDanhSach.Text = "Danh Sách";
            this.btDanhSach.TextOffset = new System.Drawing.Point(-2, 0);
            this.btDanhSach.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.BorderColor = System.Drawing.Color.White;
            this.guna2Button3.BorderRadius = 6;
            this.guna2Button3.BorderThickness = 1;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(199)))));
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(199)))));
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(199)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.DisabledState.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Button3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button3.Image")));
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button3.Location = new System.Drawing.Point(396, 593);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(128, 45);
            this.guna2Button3.TabIndex = 115;
            this.guna2Button3.Text = "Xóa";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // btThem
            // 
            this.btThem.Animated = true;
            this.btThem.BorderColor = System.Drawing.Color.White;
            this.btThem.BorderRadius = 6;
            this.btThem.BorderThickness = 1;
            this.btThem.CheckedState.Parent = this.btThem;
            this.btThem.CustomBorderColor = System.Drawing.Color.Gray;
            this.btThem.CustomImages.Parent = this.btThem;
            this.btThem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(199)))));
            this.btThem.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(199)))));
            this.btThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(199)))));
            this.btThem.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btThem.DisabledState.Parent = this.btThem;
            this.btThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btThem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.White;
            this.btThem.HoverState.Parent = this.btThem;
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btThem.Location = new System.Drawing.Point(256, 593);
            this.btThem.Name = "btThem";
            this.btThem.ShadowDecoration.Parent = this.btThem;
            this.btThem.Size = new System.Drawing.Size(128, 45);
            this.btThem.TabIndex = 114;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label5.Location = new System.Drawing.Point(917, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 123;
            this.label5.Text = "Số lượng:";
            // 
            // txtThem
            // 
            this.txtThem.BackColor = System.Drawing.Color.Transparent;
            this.txtThem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.txtThem.BorderRadius = 6;
            this.txtThem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThem.DisabledState.Parent = this.txtThem;
            this.txtThem.FocusedState.Parent = this.txtThem;
            this.txtThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.txtThem.Location = new System.Drawing.Point(920, 50);
            this.txtThem.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtThem.Name = "txtThem";
            this.txtThem.ShadowDecoration.Parent = this.txtThem;
            this.txtThem.Size = new System.Drawing.Size(157, 36);
            this.txtThem.TabIndex = 124;
            // 
            // cbSale
            // 
            this.cbSale.BackColor = System.Drawing.Color.Transparent;
            this.cbSale.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.cbSale.BorderRadius = 15;
            this.cbSale.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSale.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSale.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSale.FocusedState.Parent = this.cbSale;
            this.cbSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.cbSale.HoverState.Parent = this.cbSale;
            this.cbSale.ItemHeight = 30;
            this.cbSale.ItemsAppearance.Parent = this.cbSale;
            this.cbSale.Location = new System.Drawing.Point(82, 50);
            this.cbSale.Name = "cbSale";
            this.cbSale.ShadowDecoration.Parent = this.cbSale;
            this.cbSale.Size = new System.Drawing.Size(162, 36);
            this.cbSale.TabIndex = 90;
            // 
            // gunaColorTransition1
            // 
            this.gunaColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Orange};
            this.gunaColorTransition1.EndColor = System.Drawing.Color.Blue;
            this.gunaColorTransition1.StartColor = System.Drawing.Color.Red;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.txtSoLuong;
            // 
            // cbSearch
            // 
            this.cbSearch.BackColor = System.Drawing.Color.Transparent;
            this.cbSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.cbSearch.BorderRadius = 15;
            this.cbSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearch.FocusedState.Parent = this.cbSearch;
            this.cbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.cbSearch.HoverState.Parent = this.cbSearch;
            this.cbSearch.ItemHeight = 30;
            this.cbSearch.Items.AddRange(new object[] {
            "20%",
            "50%",
            "100%"});
            this.cbSearch.ItemsAppearance.Parent = this.cbSearch;
            this.cbSearch.Location = new System.Drawing.Point(162, 253);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.ShadowDecoration.Parent = this.cbSearch;
            this.cbSearch.Size = new System.Drawing.Size(172, 36);
            this.cbSearch.TabIndex = 127;
            // 
            // btTimKiem
            // 
            this.btTimKiem.Animated = true;
            this.btTimKiem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btTimKiem.BorderRadius = 15;
            this.btTimKiem.BorderThickness = 1;
            this.btTimKiem.CheckedState.Parent = this.btTimKiem;
            this.btTimKiem.CustomBorderColor = System.Drawing.Color.Black;
            this.btTimKiem.CustomImages.Parent = this.btTimKiem;
            this.btTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btTimKiem.DisabledState.Parent = this.btTimKiem;
            this.btTimKiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btTimKiem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.ForeColor = System.Drawing.Color.White;
            this.btTimKiem.HoverState.Parent = this.btTimKiem;
            this.btTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btTimKiem.Image")));
            this.btTimKiem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btTimKiem.Location = new System.Drawing.Point(40, 254);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.ShadowDecoration.Parent = this.btTimKiem;
            this.btTimKiem.Size = new System.Drawing.Size(116, 35);
            this.btTimKiem.TabIndex = 126;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click_1);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
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
            this.guna2TextBox1.Location = new System.Drawing.Point(980, 254);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.SelectionStart = 1;
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(97, 35);
            this.guna2TextBox1.TabIndex = 128;
            this.guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rdChua
            // 
            this.rdChua.AutoSize = true;
            this.rdChua.Checked = true;
            this.rdChua.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdChua.CheckedState.BorderThickness = 0;
            this.rdChua.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdChua.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdChua.CheckedState.InnerOffset = -4;
            this.rdChua.Enabled = false;
            this.rdChua.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdChua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.rdChua.Location = new System.Drawing.Point(677, 65);
            this.rdChua.Name = "rdChua";
            this.rdChua.Size = new System.Drawing.Size(85, 21);
            this.rdChua.TabIndex = 152;
            this.rdChua.TabStop = true;
            this.rdChua.Text = "Đã dùng";
            this.rdChua.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdChua.UncheckedState.BorderThickness = 2;
            this.rdChua.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdChua.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdDung
            // 
            this.rdDung.AutoSize = true;
            this.rdDung.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdDung.CheckedState.BorderThickness = 0;
            this.rdDung.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdDung.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdDung.CheckedState.InnerOffset = -4;
            this.rdDung.Enabled = false;
            this.rdDung.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.rdDung.Location = new System.Drawing.Point(558, 65);
            this.rdDung.Name = "rdDung";
            this.rdDung.Size = new System.Drawing.Size(103, 21);
            this.rdDung.TabIndex = 151;
            this.rdDung.Text = "Chưa dùng";
            this.rdDung.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdDung.UncheckedState.BorderThickness = 2;
            this.rdDung.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdDung.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // UC_Voucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.rdChua);
            this.Controls.Add(this.rdDung);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.txtThem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.guna2Button5);
            this.Controls.Add(this.btDanhSach);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dayEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dayStart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbSale);
            this.Controls.Add(this.label1);
            this.Name = "UC_Voucher";
            this.Size = new System.Drawing.Size(1100, 651);
            this.Load += new System.EventHandler(this.UC_Voucher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dayStart;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DateTimePicker dayEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView txtSoLuong;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button btDanhSach;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button btThem;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtThem;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cbSale;
        private Guna.UI.WinForms.GunaColorTransition gunaColorTransition1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2ComboBox cbSearch;
        private Guna.UI2.WinForms.Guna2Button btTimKiem;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2RadioButton rdChua;
        private Guna.UI2.WinForms.Guna2RadioButton rdDung;
    }
}