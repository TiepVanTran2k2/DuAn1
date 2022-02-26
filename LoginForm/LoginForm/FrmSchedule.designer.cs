
namespace RJCodeAdvance
{
    partial class FrmSchedule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSchedule));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbTenNhanVien = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.t2 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.t3 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.t5 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.t4 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.t7 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.t6 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cn = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btThemCa = new Guna.UI2.WinForms.Guna2Button();
            this.btLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btSua = new Guna.UI2.WinForms.Guna2Button();
            this.btXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btThem = new Guna.UI2.WinForms.Guna2Button();
            this.btTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btDanhSacch = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.cbCaLam = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtNhaptennv = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(791, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 63;
            this.label1.Visible = false;
            // 
            // cbTenNhanVien
            // 
            this.cbTenNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.cbTenNhanVien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.cbTenNhanVien.BorderRadius = 15;
            this.cbTenNhanVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTenNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenNhanVien.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTenNhanVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTenNhanVien.FocusedState.Parent = this.cbTenNhanVien;
            this.cbTenNhanVien.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.cbTenNhanVien.HoverState.Parent = this.cbTenNhanVien;
            this.cbTenNhanVien.ItemHeight = 30;
            this.cbTenNhanVien.Items.AddRange(new object[] {
            "Ca 1",
            "Ca 2",
            "Ca 3"});
            this.cbTenNhanVien.ItemsAppearance.Parent = this.cbTenNhanVien;
            this.cbTenNhanVien.Location = new System.Drawing.Point(50, 66);
            this.cbTenNhanVien.Name = "cbTenNhanVien";
            this.cbTenNhanVien.ShadowDecoration.Parent = this.cbTenNhanVien;
            this.cbTenNhanVien.Size = new System.Drawing.Size(259, 36);
            this.cbTenNhanVien.TabIndex = 55;
            this.cbTenNhanVien.EnabledChanged += new System.EventHandler(this.cbTenNhanVien_EnabledChanged);
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle15;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(50, 214);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(776, 196);
            this.guna2DataGridView1.TabIndex = 54;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 23;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellClick);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(50, 122);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(79, 20);
            this.guna2HtmlLabel3.TabIndex = 47;
            this.guna2HtmlLabel3.Text = "Ngày làm:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(401, 40);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(61, 20);
            this.guna2HtmlLabel2.TabIndex = 45;
            this.guna2HtmlLabel2.Text = "Ca làm:";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(50, 40);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(108, 20);
            this.guna2HtmlLabel1.TabIndex = 44;
            this.guna2HtmlLabel1.Text = "Tên nhân viên:";
            // 
            // t2
            // 
            this.t2.AutoSize = true;
            this.t2.CheckedState.BorderColor = System.Drawing.Color.White;
            this.t2.CheckedState.BorderRadius = 2;
            this.t2.CheckedState.BorderThickness = 1;
            this.t2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.t2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t2.ForeColor = System.Drawing.Color.White;
            this.t2.Location = new System.Drawing.Point(153, 125);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(61, 20);
            this.t2.TabIndex = 66;
            this.t2.Text = "Thứ 2";
            this.t2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.t2.UncheckedState.BorderRadius = 2;
            this.t2.UncheckedState.BorderThickness = 0;
            this.t2.UncheckedState.FillColor = System.Drawing.Color.Lavender;
            // 
            // t3
            // 
            this.t3.AutoSize = true;
            this.t3.CheckedState.BorderColor = System.Drawing.Color.White;
            this.t3.CheckedState.BorderRadius = 2;
            this.t3.CheckedState.BorderThickness = 1;
            this.t3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.t3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t3.ForeColor = System.Drawing.Color.White;
            this.t3.Location = new System.Drawing.Point(229, 125);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(61, 20);
            this.t3.TabIndex = 67;
            this.t3.Text = "Thứ 3";
            this.t3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.t3.UncheckedState.BorderRadius = 2;
            this.t3.UncheckedState.BorderThickness = 0;
            this.t3.UncheckedState.FillColor = System.Drawing.Color.Lavender;
            // 
            // t5
            // 
            this.t5.AutoSize = true;
            this.t5.CheckedState.BorderColor = System.Drawing.Color.White;
            this.t5.CheckedState.BorderRadius = 2;
            this.t5.CheckedState.BorderThickness = 1;
            this.t5.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.t5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t5.ForeColor = System.Drawing.Color.White;
            this.t5.Location = new System.Drawing.Point(382, 125);
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(61, 20);
            this.t5.TabIndex = 69;
            this.t5.Text = "Thứ 5";
            this.t5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.t5.UncheckedState.BorderRadius = 2;
            this.t5.UncheckedState.BorderThickness = 0;
            this.t5.UncheckedState.FillColor = System.Drawing.Color.Lavender;
            // 
            // t4
            // 
            this.t4.AutoSize = true;
            this.t4.CheckedState.BorderColor = System.Drawing.Color.White;
            this.t4.CheckedState.BorderRadius = 2;
            this.t4.CheckedState.BorderThickness = 1;
            this.t4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.t4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t4.ForeColor = System.Drawing.Color.White;
            this.t4.Location = new System.Drawing.Point(306, 125);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(61, 20);
            this.t4.TabIndex = 68;
            this.t4.Text = "Thứ 4";
            this.t4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.t4.UncheckedState.BorderRadius = 2;
            this.t4.UncheckedState.BorderThickness = 0;
            this.t4.UncheckedState.FillColor = System.Drawing.Color.Lavender;
            // 
            // t7
            // 
            this.t7.AutoSize = true;
            this.t7.CheckedState.BorderColor = System.Drawing.Color.White;
            this.t7.CheckedState.BorderRadius = 2;
            this.t7.CheckedState.BorderThickness = 1;
            this.t7.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.t7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t7.ForeColor = System.Drawing.Color.White;
            this.t7.Location = new System.Drawing.Point(523, 125);
            this.t7.Name = "t7";
            this.t7.Size = new System.Drawing.Size(61, 20);
            this.t7.TabIndex = 71;
            this.t7.Text = "Thứ 7";
            this.t7.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.t7.UncheckedState.BorderRadius = 2;
            this.t7.UncheckedState.BorderThickness = 0;
            this.t7.UncheckedState.FillColor = System.Drawing.Color.Lavender;
            // 
            // t6
            // 
            this.t6.AutoSize = true;
            this.t6.CheckedState.BorderColor = System.Drawing.Color.White;
            this.t6.CheckedState.BorderRadius = 2;
            this.t6.CheckedState.BorderThickness = 1;
            this.t6.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.t6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t6.ForeColor = System.Drawing.Color.White;
            this.t6.Location = new System.Drawing.Point(447, 125);
            this.t6.Name = "t6";
            this.t6.Size = new System.Drawing.Size(61, 20);
            this.t6.TabIndex = 70;
            this.t6.Text = "Thứ 6";
            this.t6.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.t6.UncheckedState.BorderRadius = 2;
            this.t6.UncheckedState.BorderThickness = 1;
            this.t6.UncheckedState.FillColor = System.Drawing.Color.Lavender;
            // 
            // cn
            // 
            this.cn.AutoSize = true;
            this.cn.CheckedState.BorderColor = System.Drawing.Color.White;
            this.cn.CheckedState.BorderRadius = 2;
            this.cn.CheckedState.BorderThickness = 1;
            this.cn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.cn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cn.ForeColor = System.Drawing.Color.White;
            this.cn.Location = new System.Drawing.Point(605, 125);
            this.cn.Name = "cn";
            this.cn.Size = new System.Drawing.Size(78, 20);
            this.cn.TabIndex = 72;
            this.cn.Text = "Chủ nhật";
            this.cn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.cn.UncheckedState.BorderRadius = 2;
            this.cn.UncheckedState.BorderThickness = 0;
            this.cn.UncheckedState.FillColor = System.Drawing.Color.Lavender;
            // 
            // btThemCa
            // 
            this.btThemCa.Animated = true;
            this.btThemCa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btThemCa.BorderRadius = 6;
            this.btThemCa.BorderThickness = 1;
            this.btThemCa.CheckedState.Parent = this.btThemCa;
            this.btThemCa.CustomBorderColor = System.Drawing.Color.Gray;
            this.btThemCa.CustomImages.Parent = this.btThemCa;
            this.btThemCa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(190)))));
            this.btThemCa.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(190)))));
            this.btThemCa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(190)))));
            this.btThemCa.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btThemCa.DisabledState.Parent = this.btThemCa;
            this.btThemCa.Enabled = false;
            this.btThemCa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemCa.ForeColor = System.Drawing.Color.White;
            this.btThemCa.HoverState.Parent = this.btThemCa;
            this.btThemCa.Image = ((System.Drawing.Image)(resources.GetObject("btThemCa.Image")));
            this.btThemCa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btThemCa.Location = new System.Drawing.Point(698, 66);
            this.btThemCa.Name = "btThemCa";
            this.btThemCa.ShadowDecoration.Parent = this.btThemCa;
            this.btThemCa.Size = new System.Drawing.Size(128, 36);
            this.btThemCa.TabIndex = 65;
            this.btThemCa.Text = "Thêm Ca";
            this.btThemCa.Click += new System.EventHandler(this.guna2Button1_Click);
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
            this.btLuu.Location = new System.Drawing.Point(582, 416);
            this.btLuu.Name = "btLuu";
            this.btLuu.ShadowDecoration.Parent = this.btLuu;
            this.btLuu.Size = new System.Drawing.Size(128, 45);
            this.btLuu.TabIndex = 52;
            this.btLuu.Text = "Lưu";
            this.btLuu.Click += new System.EventHandler(this.guna2Button5_Click);
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
            this.btSua.Location = new System.Drawing.Point(441, 416);
            this.btSua.Name = "btSua";
            this.btSua.ShadowDecoration.Parent = this.btSua;
            this.btSua.Size = new System.Drawing.Size(128, 45);
            this.btSua.TabIndex = 51;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.guna2Button4_Click);
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
            this.btXoa.Location = new System.Drawing.Point(301, 416);
            this.btXoa.Name = "btXoa";
            this.btXoa.ShadowDecoration.Parent = this.btXoa;
            this.btXoa.Size = new System.Drawing.Size(128, 45);
            this.btXoa.TabIndex = 50;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.guna2Button3_Click);
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
            this.btThem.Location = new System.Drawing.Point(161, 416);
            this.btThem.Name = "btThem";
            this.btThem.ShadowDecoration.Parent = this.btThem;
            this.btThem.Size = new System.Drawing.Size(128, 45);
            this.btThem.TabIndex = 49;
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
            this.btTimKiem.Location = new System.Drawing.Point(50, 172);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.ShadowDecoration.Parent = this.btTimKiem;
            this.btTimKiem.Size = new System.Drawing.Size(127, 36);
            this.btTimKiem.TabIndex = 48;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.guna2DataGridView1;
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
            this.btDanhSacch.Location = new System.Drawing.Point(692, 172);
            this.btDanhSacch.Name = "btDanhSacch";
            this.btDanhSacch.ShadowDecoration.Parent = this.btDanhSacch;
            this.btDanhSacch.Size = new System.Drawing.Size(134, 36);
            this.btDanhSacch.TabIndex = 140;
            this.btDanhSacch.Text = "Danh sách";
            this.btDanhSacch.Click += new System.EventHandler(this.btDanhSacch_Click);
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
            this.guna2ControlBox2.Location = new System.Drawing.Point(785, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(37, 26);
            this.guna2ControlBox2.TabIndex = 142;
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(828, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(37, 26);
            this.guna2ControlBox1.TabIndex = 141;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 3;
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.Gray;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // cbCaLam
            // 
            this.cbCaLam.BackColor = System.Drawing.Color.Transparent;
            this.cbCaLam.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.cbCaLam.BorderRadius = 16;
            this.cbCaLam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCaLam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaLam.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCaLam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCaLam.FocusedState.Parent = this.cbCaLam;
            this.cbCaLam.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cbCaLam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.cbCaLam.FormattingEnabled = true;
            this.cbCaLam.HoverState.Parent = this.cbCaLam;
            this.cbCaLam.ItemHeight = 30;
            this.cbCaLam.ItemsAppearance.Parent = this.cbCaLam;
            this.cbCaLam.Location = new System.Drawing.Point(401, 66);
            this.cbCaLam.Name = "cbCaLam";
            this.cbCaLam.ShadowDecoration.Parent = this.cbCaLam;
            this.cbCaLam.Size = new System.Drawing.Size(265, 36);
            this.cbCaLam.TabIndex = 143;
            // 
            // txtNhaptennv
            // 
            this.txtNhaptennv.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtNhaptennv.BorderRadius = 16;
            this.txtNhaptennv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhaptennv.DefaultText = "";
            this.txtNhaptennv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNhaptennv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNhaptennv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhaptennv.DisabledState.Parent = this.txtNhaptennv;
            this.txtNhaptennv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhaptennv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhaptennv.FocusedState.Parent = this.txtNhaptennv;
            this.txtNhaptennv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNhaptennv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtNhaptennv.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhaptennv.HoverState.Parent = this.txtNhaptennv;
            this.txtNhaptennv.Location = new System.Drawing.Point(183, 172);
            this.txtNhaptennv.Name = "txtNhaptennv";
            this.txtNhaptennv.PasswordChar = '\0';
            this.txtNhaptennv.PlaceholderText = "Nhập tên nhân viên cần tìm";
            this.txtNhaptennv.SelectedText = "";
            this.txtNhaptennv.ShadowDecoration.Parent = this.txtNhaptennv;
            this.txtNhaptennv.Size = new System.Drawing.Size(228, 36);
            this.txtNhaptennv.TabIndex = 144;
            // 
            // FrmSchedule
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(877, 476);
            this.Controls.Add(this.txtNhaptennv);
            this.Controls.Add(this.cbCaLam);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.btDanhSacch);
            this.Controls.Add(this.cn);
            this.Controls.Add(this.t7);
            this.Controls.Add(this.t6);
            this.Controls.Add(this.t5);
            this.Controls.Add(this.t4);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.btThemCa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTenNhanVien);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Name = "FrmSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSchedule2";
            this.Load += new System.EventHandler(this.FrmSchedule2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbTenNhanVien;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Button btLuu;
        private Guna.UI2.WinForms.Guna2Button btSua;
        private Guna.UI2.WinForms.Guna2Button btXoa;
        private Guna.UI2.WinForms.Guna2Button btThem;
        private Guna.UI2.WinForms.Guna2Button btTimKiem;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btThemCa;
        private Guna.UI2.WinForms.Guna2CheckBox cn;
        private Guna.UI2.WinForms.Guna2CheckBox t7;
        private Guna.UI2.WinForms.Guna2CheckBox t6;
        private Guna.UI2.WinForms.Guna2CheckBox t5;
        private Guna.UI2.WinForms.Guna2CheckBox t4;
        private Guna.UI2.WinForms.Guna2CheckBox t3;
        private Guna.UI2.WinForms.Guna2CheckBox t2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Button btDanhSacch;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2ComboBox cbCaLam;
        private Guna.UI2.WinForms.Guna2TextBox txtNhaptennv;
    }
}