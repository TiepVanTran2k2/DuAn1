
namespace RJCodeAdvance.ControlCustomers
{
    partial class UC_Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Customer));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtsearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSua = new Guna.UI2.WinForms.Guna2Button();
            this.btTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.nbDiemTT = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btDanhSach = new Guna.UI2.WinForms.Guna2Button();
            this.rbNu = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbNam = new Guna.UI2.WinForms.Guna2RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbDiemTT)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 26;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label7.Location = new System.Drawing.Point(617, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 16);
            this.label7.TabIndex = 141;
            this.label7.Text = "Điểm thân thiết:";
            // 
            // dgv
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv.ColumnHeadersHeight = 20;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.Location = new System.Drawing.Point(27, 295);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1035, 284);
            this.dgv.TabIndex = 138;
            this.dgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv.ThemeStyle.HeaderStyle.Height = 20;
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
            // txtsearch
            // 
            this.txtsearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.txtsearch.BorderRadius = 16;
            this.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsearch.DefaultText = "";
            this.txtsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearch.DisabledState.Parent = this.txtsearch;
            this.txtsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearch.FocusedState.Parent = this.txtsearch;
            this.txtsearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.txtsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearch.HoverState.Parent = this.txtsearch;
            this.txtsearch.Location = new System.Drawing.Point(170, 253);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.PlaceholderText = "Nhập tên khách hàng cần tìm";
            this.txtsearch.SelectedText = "";
            this.txtsearch.ShadowDecoration.Parent = this.txtsearch;
            this.txtsearch.Size = new System.Drawing.Size(228, 36);
            this.txtsearch.TabIndex = 137;
            // 
            // txbEmail
            // 
            this.txbEmail.Animated = true;
            this.txbEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.txbEmail.BorderRadius = 16;
            this.txbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbEmail.DefaultText = "";
            this.txbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbEmail.DisabledState.Parent = this.txbEmail;
            this.txbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbEmail.FocusedState.Parent = this.txbEmail;
            this.txbEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.txbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbEmail.HoverState.Parent = this.txbEmail;
            this.txbEmail.Location = new System.Drawing.Point(617, 71);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(0);
            this.txbEmail.MaxLength = 50;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.PasswordChar = '\0';
            this.txbEmail.PlaceholderText = "Email";
            this.txbEmail.SelectedText = "";
            this.txbEmail.ShadowDecoration.Parent = this.txbEmail;
            this.txbEmail.Size = new System.Drawing.Size(330, 36);
            this.txbEmail.TabIndex = 135;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label5.Location = new System.Drawing.Point(617, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 134;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label4.Location = new System.Drawing.Point(28, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 133;
            this.label4.Text = "Giới tính:";
            // 
            // txtName
            // 
            this.txtName.Animated = true;
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.txtName.BorderRadius = 16;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.Parent = this.txtName;
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.FocusedState.Parent = this.txtName;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.HoverState.Parent = this.txtName;
            this.txtName.Location = new System.Drawing.Point(28, 71);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "Tên khách hàng";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(346, 36);
            this.txtName.TabIndex = 132;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label1.Location = new System.Drawing.Point(28, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 131;
            this.label1.Text = "Tên khách hàng:";
            // 
            // btSua
            // 
            this.btSua.Animated = true;
            this.btSua.BorderColor = System.Drawing.Color.White;
            this.btSua.BorderRadius = 6;
            this.btSua.BorderThickness = 1;
            this.btSua.CheckedState.Parent = this.btSua;
            this.btSua.CustomImages.Parent = this.btSua;
            this.btSua.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(199)))));
            this.btSua.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(199)))));
            this.btSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(199)))));
            this.btSua.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btSua.DisabledState.Parent = this.btSua;
            this.btSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btSua.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.White;
            this.btSua.HoverState.Parent = this.btSua;
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btSua.Location = new System.Drawing.Point(934, 585);
            this.btSua.Name = "btSua";
            this.btSua.ShadowDecoration.Parent = this.btSua;
            this.btSua.Size = new System.Drawing.Size(128, 45);
            this.btSua.TabIndex = 144;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btTimKiem
            // 
            this.btTimKiem.Animated = true;
            this.btTimKiem.BorderColor = System.Drawing.Color.White;
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
            this.btTimKiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btTimKiem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.ForeColor = System.Drawing.Color.White;
            this.btTimKiem.HoverState.Parent = this.btTimKiem;
            this.btTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btTimKiem.Image")));
            this.btTimKiem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btTimKiem.Location = new System.Drawing.Point(28, 253);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.ShadowDecoration.Parent = this.btTimKiem;
            this.btTimKiem.Size = new System.Drawing.Size(127, 36);
            this.btTimKiem.TabIndex = 136;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // nbDiemTT
            // 
            this.nbDiemTT.BackColor = System.Drawing.Color.Transparent;
            this.nbDiemTT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.nbDiemTT.BorderRadius = 6;
            this.nbDiemTT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nbDiemTT.DisabledState.Parent = this.nbDiemTT;
            this.nbDiemTT.FocusedState.Parent = this.nbDiemTT;
            this.nbDiemTT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nbDiemTT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.nbDiemTT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nbDiemTT.Location = new System.Drawing.Point(620, 150);
            this.nbDiemTT.Name = "nbDiemTT";
            this.nbDiemTT.ShadowDecoration.Parent = this.nbDiemTT;
            this.nbDiemTT.Size = new System.Drawing.Size(327, 35);
            this.nbDiemTT.TabIndex = 147;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.dgv;
            // 
            // btDanhSach
            // 
            this.btDanhSach.Animated = true;
            this.btDanhSach.BorderColor = System.Drawing.Color.White;
            this.btDanhSach.BorderRadius = 6;
            this.btDanhSach.BorderThickness = 1;
            this.btDanhSach.CheckedState.Parent = this.btDanhSach;
            this.btDanhSach.CustomImages.Parent = this.btDanhSach;
            this.btDanhSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btDanhSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btDanhSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btDanhSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btDanhSach.DisabledState.Parent = this.btDanhSach;
            this.btDanhSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btDanhSach.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDanhSach.ForeColor = System.Drawing.Color.White;
            this.btDanhSach.HoverState.Parent = this.btDanhSach;
            this.btDanhSach.Image = ((System.Drawing.Image)(resources.GetObject("btDanhSach.Image")));
            this.btDanhSach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btDanhSach.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btDanhSach.Location = new System.Drawing.Point(934, 253);
            this.btDanhSach.Name = "btDanhSach";
            this.btDanhSach.ShadowDecoration.Parent = this.btDanhSach;
            this.btDanhSach.Size = new System.Drawing.Size(128, 36);
            this.btDanhSach.TabIndex = 148;
            this.btDanhSach.Text = "Danh Sách";
            this.btDanhSach.TextOffset = new System.Drawing.Point(-2, 0);
            this.btDanhSach.Click += new System.EventHandler(this.btDanhSach_Click);
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Checked = true;
            this.rbNu.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbNu.CheckedState.BorderThickness = 0;
            this.rbNu.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbNu.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbNu.CheckedState.InnerOffset = -4;
            this.rbNu.Enabled = false;
            this.rbNu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.rbNu.Location = new System.Drawing.Point(117, 164);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(47, 21);
            this.rbNu.TabIndex = 150;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbNu.UncheckedState.BorderThickness = 2;
            this.rbNu.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbNu.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbNam.CheckedState.BorderThickness = 0;
            this.rbNam.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbNam.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbNam.CheckedState.InnerOffset = -4;
            this.rbNam.Enabled = false;
            this.rbNam.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.rbNam.Location = new System.Drawing.Point(32, 164);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(58, 21);
            this.rbNam.TabIndex = 149;
            this.rbNam.Text = "Nam";
            this.rbNam.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbNam.UncheckedState.BorderThickness = 2;
            this.rbNam.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbNam.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // UC_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.rbNu);
            this.Controls.Add(this.rbNam);
            this.Controls.Add(this.btDanhSach);
            this.Controls.Add(this.nbDiemTT);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "UC_Customer";
            this.Size = new System.Drawing.Size(1096, 651);
            this.Load += new System.EventHandler(this.UC_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbDiemTT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DataGridView dgv;
        private Guna.UI2.WinForms.Guna2TextBox txtsearch;
        private Guna.UI2.WinForms.Guna2Button btTimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txbEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btSua;
        private Guna.UI2.WinForms.Guna2NumericUpDown nbDiemTT;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Button btDanhSach;
        private Guna.UI2.WinForms.Guna2RadioButton rbNu;
        private Guna.UI2.WinForms.Guna2RadioButton rbNam;
    }
}