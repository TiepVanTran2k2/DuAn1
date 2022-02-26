
namespace RJCodeAdvance
{
    partial class FrmTypeOfBeverage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTypeOfBeverage));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TxtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvLoaiDoUong = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btThem = new Guna.UI2.WinForms.Guna2Button();
            this.btTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtLoaiDoUong = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btDanhSacch = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDoUong)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // TxtTimKiem
            // 
            this.TxtTimKiem.BorderRadius = 16;
            this.TxtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTimKiem.DefaultText = "";
            this.TxtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtTimKiem.DisabledState.Parent = this.TxtTimKiem;
            this.TxtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtTimKiem.FocusedState.Parent = this.TxtTimKiem;
            this.TxtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtTimKiem.ForeColor = System.Drawing.Color.BlueViolet;
            this.TxtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtTimKiem.HoverState.Parent = this.TxtTimKiem;
            this.TxtTimKiem.Location = new System.Drawing.Point(156, 125);
            this.TxtTimKiem.MaxLength = 50;
            this.TxtTimKiem.Name = "TxtTimKiem";
            this.TxtTimKiem.PasswordChar = '\0';
            this.TxtTimKiem.PlaceholderText = "Nhập loại đồ uống cần tìm";
            this.TxtTimKiem.SelectedText = "";
            this.TxtTimKiem.ShadowDecoration.Parent = this.TxtTimKiem;
            this.TxtTimKiem.Size = new System.Drawing.Size(228, 36);
            this.TxtTimKiem.TabIndex = 97;
            // 
            // dgvLoaiDoUong
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvLoaiDoUong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoaiDoUong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiDoUong.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoaiDoUong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLoaiDoUong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLoaiDoUong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiDoUong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLoaiDoUong.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoaiDoUong.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLoaiDoUong.EnableHeadersVisualStyles = false;
            this.dgvLoaiDoUong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLoaiDoUong.Location = new System.Drawing.Point(23, 167);
            this.dgvLoaiDoUong.Name = "dgvLoaiDoUong";
            this.dgvLoaiDoUong.RowHeadersVisible = false;
            this.dgvLoaiDoUong.RowHeadersWidth = 51;
            this.dgvLoaiDoUong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiDoUong.Size = new System.Drawing.Size(811, 214);
            this.dgvLoaiDoUong.TabIndex = 86;
            this.dgvLoaiDoUong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLoaiDoUong.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvLoaiDoUong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvLoaiDoUong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvLoaiDoUong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvLoaiDoUong.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvLoaiDoUong.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLoaiDoUong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvLoaiDoUong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLoaiDoUong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvLoaiDoUong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLoaiDoUong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvLoaiDoUong.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvLoaiDoUong.ThemeStyle.ReadOnly = false;
            this.dgvLoaiDoUong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLoaiDoUong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLoaiDoUong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvLoaiDoUong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLoaiDoUong.ThemeStyle.RowsStyle.Height = 22;
            this.dgvLoaiDoUong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLoaiDoUong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLoaiDoUong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiDoUong_CellClick);
            // 
            // btLuu
            // 
            this.btLuu.Animated = true;
            this.btLuu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btLuu.BorderRadius = 6;
            this.btLuu.BorderThickness = 1;
            this.btLuu.CheckedState.Parent = this.btLuu;
            this.btLuu.CustomImages.Parent = this.btLuu;
            this.btLuu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(190)))));
            this.btLuu.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(190)))));
            this.btLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(190)))));
            this.btLuu.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btLuu.DisabledState.Parent = this.btLuu;
            this.btLuu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.ForeColor = System.Drawing.Color.White;
            this.btLuu.HoverState.Parent = this.btLuu;
            this.btLuu.Image = ((System.Drawing.Image)(resources.GetObject("btLuu.Image")));
            this.btLuu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btLuu.Location = new System.Drawing.Point(556, 387);
            this.btLuu.Name = "btLuu";
            this.btLuu.ShadowDecoration.Parent = this.btLuu;
            this.btLuu.Size = new System.Drawing.Size(128, 45);
            this.btLuu.TabIndex = 84;
            this.btLuu.Text = "Lưu";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Animated = true;
            this.btnSua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSua.BorderRadius = 6;
            this.btnSua.BorderThickness = 1;
            this.btnSua.CheckedState.Parent = this.btnSua;
            this.btnSua.CustomImages.Parent = this.btnSua;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(190)))));
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(190)))));
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(190)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnSua.DisabledState.Parent = this.btnSua;
            this.btnSua.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.HoverState.Parent = this.btnSua;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSua.Location = new System.Drawing.Point(415, 387);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(128, 45);
            this.btnSua.TabIndex = 83;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btSua);
            // 
            // btnXoa
            // 
            this.btnXoa.Animated = true;
            this.btnXoa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnXoa.BorderRadius = 6;
            this.btnXoa.BorderThickness = 1;
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(190)))));
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(190)))));
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(190)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnXoa.DisabledState.Parent = this.btnXoa;
            this.btnXoa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnXoa.Location = new System.Drawing.Point(275, 387);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(128, 45);
            this.btnXoa.TabIndex = 82;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btXoa);
            // 
            // btThem
            // 
            this.btThem.Animated = true;
            this.btThem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btThem.BorderRadius = 6;
            this.btThem.BorderThickness = 1;
            this.btThem.CheckedState.Parent = this.btThem;
            this.btThem.CustomBorderColor = System.Drawing.Color.Gray;
            this.btThem.CustomImages.Parent = this.btThem;
            this.btThem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(190)))));
            this.btThem.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(190)))));
            this.btThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(190)))));
            this.btThem.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btThem.DisabledState.Parent = this.btThem;
            this.btThem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.White;
            this.btThem.HoverState.Parent = this.btThem;
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btThem.Location = new System.Drawing.Point(135, 387);
            this.btThem.Name = "btThem";
            this.btThem.ShadowDecoration.Parent = this.btThem;
            this.btThem.Size = new System.Drawing.Size(128, 45);
            this.btThem.TabIndex = 81;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btTimKiem
            // 
            this.btTimKiem.Animated = true;
            this.btTimKiem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btTimKiem.BorderRadius = 6;
            this.btTimKiem.BorderThickness = 1;
            this.btTimKiem.CheckedState.Parent = this.btTimKiem;
            this.btTimKiem.CustomBorderColor = System.Drawing.Color.Black;
            this.btTimKiem.CustomImages.Parent = this.btTimKiem;
            this.btTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btTimKiem.DisabledState.Parent = this.btTimKiem;
            this.btTimKiem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.ForeColor = System.Drawing.Color.White;
            this.btTimKiem.HoverState.Parent = this.btTimKiem;
            this.btTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btTimKiem.Image")));
            this.btTimKiem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btTimKiem.Location = new System.Drawing.Point(23, 125);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.ShadowDecoration.Parent = this.btTimKiem;
            this.btTimKiem.Size = new System.Drawing.Size(127, 36);
            this.btTimKiem.TabIndex = 80;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(24, 30);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(129, 20);
            this.guna2HtmlLabel1.TabIndex = 76;
            this.guna2HtmlLabel1.Text = "Tên loại đồ uống:";
            // 
            // txtLoaiDoUong
            // 
            this.txtLoaiDoUong.Animated = true;
            this.txtLoaiDoUong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtLoaiDoUong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtLoaiDoUong.BorderRadius = 16;
            this.txtLoaiDoUong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoaiDoUong.DefaultText = "";
            this.txtLoaiDoUong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLoaiDoUong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLoaiDoUong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoaiDoUong.DisabledState.Parent = this.txtLoaiDoUong;
            this.txtLoaiDoUong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoaiDoUong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoaiDoUong.FocusedState.Parent = this.txtLoaiDoUong;
            this.txtLoaiDoUong.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.txtLoaiDoUong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtLoaiDoUong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoaiDoUong.HoverState.Parent = this.txtLoaiDoUong;
            this.txtLoaiDoUong.Location = new System.Drawing.Point(23, 65);
            this.txtLoaiDoUong.MaxLength = 50;
            this.txtLoaiDoUong.Name = "txtLoaiDoUong";
            this.txtLoaiDoUong.PasswordChar = '\0';
            this.txtLoaiDoUong.PlaceholderText = "Tên đồ uống";
            this.txtLoaiDoUong.SelectedText = "";
            this.txtLoaiDoUong.ShadowDecoration.Parent = this.txtLoaiDoUong;
            this.txtLoaiDoUong.Size = new System.Drawing.Size(283, 36);
            this.txtLoaiDoUong.TabIndex = 100;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.dgvLoaiDoUong;
            // 
            // btDanhSacch
            // 
            this.btDanhSacch.Animated = true;
            this.btDanhSacch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btDanhSacch.BorderRadius = 6;
            this.btDanhSacch.BorderThickness = 1;
            this.btDanhSacch.CheckedState.Parent = this.btDanhSacch;
            this.btDanhSacch.CustomImages.Parent = this.btDanhSacch;
            this.btDanhSacch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btDanhSacch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btDanhSacch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btDanhSacch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btDanhSacch.DisabledState.Parent = this.btDanhSacch;
            this.btDanhSacch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDanhSacch.ForeColor = System.Drawing.Color.White;
            this.btDanhSacch.HoverState.Parent = this.btDanhSacch;
            this.btDanhSacch.Image = ((System.Drawing.Image)(resources.GetObject("btDanhSacch.Image")));
            this.btDanhSacch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btDanhSacch.Location = new System.Drawing.Point(700, 125);
            this.btDanhSacch.Name = "btDanhSacch";
            this.btDanhSacch.ShadowDecoration.Parent = this.btDanhSacch;
            this.btDanhSacch.Size = new System.Drawing.Size(134, 36);
            this.btDanhSacch.TabIndex = 140;
            this.btDanhSacch.Text = "Danh sách";
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.guna2ControlBox2.BorderRadius = 3;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(769, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(37, 26);
            this.guna2ControlBox2.TabIndex = 145;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.guna2ControlBox1.BorderRadius = 3;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(812, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(37, 26);
            this.guna2ControlBox1.TabIndex = 144;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(775, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 143;
            this.label1.Visible = false;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 3;
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.Gray;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // FrmTypeOfBeverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(861, 449);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDanhSacch);
            this.Controls.Add(this.txtLoaiDoUong);
            this.Controls.Add(this.TxtTimKiem);
            this.Controls.Add(this.dgvLoaiDoUong);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTypeOfBeverage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TypeOfBeverage2";
            this.Load += new System.EventHandler(this.FrmTypeOfBeverage2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDoUong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox TxtTimKiem;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLoaiDoUong;
        private Guna.UI2.WinForms.Guna2Button btLuu;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btThem;
        private Guna.UI2.WinForms.Guna2Button btTimKiem;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtLoaiDoUong;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Button btDanhSacch;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}