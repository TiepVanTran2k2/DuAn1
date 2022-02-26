
namespace RJCodeAdvance
{
    partial class FrmSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSupplier));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtTenNCC = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btSua = new Guna.UI2.WinForms.Guna2Button();
            this.btXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btThem = new Guna.UI2.WinForms.Guna2Button();
            this.btTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.btDanhSacch = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Animated = true;
            this.txtTenNCC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtTenNCC.BorderRadius = 15;
            this.txtTenNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNCC.DefaultText = "";
            this.txtTenNCC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNCC.DisabledState.Parent = this.txtTenNCC;
            this.txtTenNCC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNCC.FocusedState.Parent = this.txtTenNCC;
            this.txtTenNCC.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.txtTenNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtTenNCC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNCC.HoverState.Parent = this.txtTenNCC;
            this.txtTenNCC.Location = new System.Drawing.Point(21, 54);
            this.txtTenNCC.MaxLength = 50;
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.PasswordChar = '\0';
            this.txtTenNCC.PlaceholderText = "Tên Nhà cung cấp";
            this.txtTenNCC.SelectedText = "";
            this.txtTenNCC.ShadowDecoration.Parent = this.txtTenNCC;
            this.txtTenNCC.Size = new System.Drawing.Size(302, 36);
            this.txtTenNCC.TabIndex = 122;
            // 
            // dgv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.Location = new System.Drawing.Point(21, 217);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(801, 214);
            this.dgv.TabIndex = 121;
            this.dgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv.ThemeStyle.HeaderStyle.Height = 25;
            this.dgv.ThemeStyle.ReadOnly = false;
            this.dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv.ThemeStyle.RowsStyle.Height = 22;
            this.dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(21, 30);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(121, 18);
            this.guna2HtmlLabel6.TabIndex = 120;
            this.guna2HtmlLabel6.Text = "Tên Nhà cung cấp:";
            // 
            // txtEmail
            // 
            this.txtEmail.Animated = true;
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtEmail.BorderRadius = 15;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.Parent = this.txtEmail;
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedState.Parent = this.txtEmail;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.HoverState.Parent = this.txtEmail;
            this.txtEmail.Location = new System.Drawing.Point(377, 54);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "Nhập Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.ShadowDecoration.Parent = this.txtEmail;
            this.txtEmail.Size = new System.Drawing.Size(302, 36);
            this.txtEmail.TabIndex = 133;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(377, 30);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(40, 18);
            this.guna2HtmlLabel1.TabIndex = 132;
            this.guna2HtmlLabel1.Text = "Email:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Animated = true;
            this.txtDiaChi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtDiaChi.BorderRadius = 15;
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.DefaultText = "";
            this.txtDiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.DisabledState.Parent = this.txtDiaChi;
            this.txtDiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.FocusedState.Parent = this.txtDiaChi;
            this.txtDiaChi.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.txtDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtDiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.HoverState.Parent = this.txtDiaChi;
            this.txtDiaChi.Location = new System.Drawing.Point(21, 120);
            this.txtDiaChi.MaxLength = 50;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.PlaceholderText = "Địa chỉ";
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.ShadowDecoration.Parent = this.txtDiaChi;
            this.txtDiaChi.Size = new System.Drawing.Size(302, 36);
            this.txtDiaChi.TabIndex = 135;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(21, 96);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(51, 18);
            this.guna2HtmlLabel2.TabIndex = 134;
            this.guna2HtmlLabel2.Text = "Địa chỉ:";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.txtSearch.BorderRadius = 16;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.BlueViolet;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.Location = new System.Drawing.Point(134, 175);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Nhập tên nhà cung cấp cần tìm";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(228, 36);
            this.txtSearch.TabIndex = 142;
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
            this.btLuu.Location = new System.Drawing.Point(551, 437);
            this.btLuu.Name = "btLuu";
            this.btLuu.ShadowDecoration.Parent = this.btLuu;
            this.btLuu.Size = new System.Drawing.Size(128, 45);
            this.btLuu.TabIndex = 140;
            this.btLuu.Text = "Lưu";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btSua
            // 
            this.btSua.Animated = true;
            this.btSua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btSua.BorderRadius = 6;
            this.btSua.BorderThickness = 1;
            this.btSua.CheckedState.Parent = this.btSua;
            this.btSua.CustomImages.Parent = this.btSua;
            this.btSua.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(190)))));
            this.btSua.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(190)))));
            this.btSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(190)))));
            this.btSua.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btSua.DisabledState.Parent = this.btSua;
            this.btSua.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.White;
            this.btSua.HoverState.Parent = this.btSua;
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btSua.Location = new System.Drawing.Point(410, 437);
            this.btSua.Name = "btSua";
            this.btSua.ShadowDecoration.Parent = this.btSua;
            this.btSua.Size = new System.Drawing.Size(128, 45);
            this.btSua.TabIndex = 139;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Animated = true;
            this.btXoa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btXoa.BorderRadius = 6;
            this.btXoa.BorderThickness = 1;
            this.btXoa.CheckedState.Parent = this.btXoa;
            this.btXoa.CustomImages.Parent = this.btXoa;
            this.btXoa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(190)))));
            this.btXoa.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(190)))));
            this.btXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(190)))));
            this.btXoa.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btXoa.DisabledState.Parent = this.btXoa;
            this.btXoa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.White;
            this.btXoa.HoverState.Parent = this.btXoa;
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btXoa.Location = new System.Drawing.Point(270, 437);
            this.btXoa.Name = "btXoa";
            this.btXoa.ShadowDecoration.Parent = this.btXoa;
            this.btXoa.Size = new System.Drawing.Size(128, 45);
            this.btXoa.TabIndex = 138;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
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
            this.btThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btThem.DisabledState.Parent = this.btThem;
            this.btThem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.White;
            this.btThem.HoverState.Parent = this.btThem;
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btThem.Location = new System.Drawing.Point(130, 437);
            this.btThem.Name = "btThem";
            this.btThem.ShadowDecoration.Parent = this.btThem;
            this.btThem.Size = new System.Drawing.Size(128, 45);
            this.btThem.TabIndex = 137;
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
            this.btTimKiem.Location = new System.Drawing.Point(21, 175);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.ShadowDecoration.Parent = this.btTimKiem;
            this.btTimKiem.Size = new System.Drawing.Size(107, 36);
            this.btTimKiem.TabIndex = 136;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
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
            this.btDanhSacch.Location = new System.Drawing.Point(688, 175);
            this.btDanhSacch.Name = "btDanhSacch";
            this.btDanhSacch.ShadowDecoration.Parent = this.btDanhSacch;
            this.btDanhSacch.Size = new System.Drawing.Size(134, 36);
            this.btDanhSacch.TabIndex = 143;
            this.btDanhSacch.Text = "Danh sách";
            this.btDanhSacch.Click += new System.EventHandler(this.btDanhSacch_Click);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.dgv;
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
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 3;
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // FrmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(861, 500);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.btDanhSacch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txtTenNCC);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSupplier";
            this.Load += new System.EventHandler(this.FrmSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNCC;
        private Guna.UI2.WinForms.Guna2DataGridView dgv;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btLuu;
        private Guna.UI2.WinForms.Guna2Button btSua;
        private Guna.UI2.WinForms.Guna2Button btXoa;
        private Guna.UI2.WinForms.Guna2Button btThem;
        private Guna.UI2.WinForms.Guna2Button btTimKiem;
        private Guna.UI2.WinForms.Guna2Button btDanhSacch;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}