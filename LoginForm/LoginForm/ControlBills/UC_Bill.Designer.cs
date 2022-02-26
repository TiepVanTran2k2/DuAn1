
namespace RJCodeAdvance.ControlBills
{
    partial class UC_Bill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Bill));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btXoa = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.rdoNguyenLieu = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdoDoUong = new Guna.UI2.WinForms.Guna2RadioButton();
            this.dgvBill = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaBillsDetail = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nbSoLuong = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDoUong = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBillsDetail = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillsDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 26;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btXoa);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.rdoNguyenLieu);
            this.panel1.Controls.Add(this.rdoDoUong);
            this.panel1.Controls.Add(this.dgvBill);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 651);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btXoa
            // 
            this.btXoa.Animated = true;
            this.btXoa.BorderColor = System.Drawing.Color.White;
            this.btXoa.BorderRadius = 6;
            this.btXoa.BorderThickness = 1;
            this.btXoa.CheckedState.Parent = this.btXoa;
            this.btXoa.CustomImages.Parent = this.btXoa;
            this.btXoa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(199)))));
            this.btXoa.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(199)))));
            this.btXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(199)))));
            this.btXoa.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btXoa.DisabledState.Parent = this.btXoa;
            this.btXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.White;
            this.btXoa.HoverState.Parent = this.btXoa;
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btXoa.Location = new System.Drawing.Point(14, 592);
            this.btXoa.Name = "btXoa";
            this.btXoa.ShadowDecoration.Parent = this.btXoa;
            this.btXoa.Size = new System.Drawing.Size(122, 34);
            this.btXoa.TabIndex = 142;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label8.Location = new System.Drawing.Point(188, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 39);
            this.label8.TabIndex = 134;
            this.label8.Text = "Hoá Đơn";
            // 
            // rdoNguyenLieu
            // 
            this.rdoNguyenLieu.AutoSize = true;
            this.rdoNguyenLieu.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoNguyenLieu.CheckedState.BorderThickness = 0;
            this.rdoNguyenLieu.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoNguyenLieu.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoNguyenLieu.CheckedState.InnerOffset = -4;
            this.rdoNguyenLieu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNguyenLieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.rdoNguyenLieu.Location = new System.Drawing.Point(195, 153);
            this.rdoNguyenLieu.Name = "rdoNguyenLieu";
            this.rdoNguyenLieu.Size = new System.Drawing.Size(107, 21);
            this.rdoNguyenLieu.TabIndex = 133;
            this.rdoNguyenLieu.Text = "Nguyên liệu";
            this.rdoNguyenLieu.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoNguyenLieu.UncheckedState.BorderThickness = 2;
            this.rdoNguyenLieu.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoNguyenLieu.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoNguyenLieu.CheckedChanged += new System.EventHandler(this.rdoNguyenLieu_CheckedChanged);
            // 
            // rdoDoUong
            // 
            this.rdoDoUong.AutoSize = true;
            this.rdoDoUong.Checked = true;
            this.rdoDoUong.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoDoUong.CheckedState.BorderThickness = 0;
            this.rdoDoUong.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoDoUong.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoDoUong.CheckedState.InnerOffset = -4;
            this.rdoDoUong.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDoUong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.rdoDoUong.Location = new System.Drawing.Point(27, 153);
            this.rdoDoUong.Name = "rdoDoUong";
            this.rdoDoUong.Size = new System.Drawing.Size(86, 21);
            this.rdoDoUong.TabIndex = 132;
            this.rdoDoUong.TabStop = true;
            this.rdoDoUong.Text = "Đồ uống";
            this.rdoDoUong.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoDoUong.UncheckedState.BorderThickness = 2;
            this.rdoDoUong.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoDoUong.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoDoUong.CheckedChanged += new System.EventHandler(this.rdoDoUong_CheckedChanged);
            this.rdoDoUong.Click += new System.EventHandler(this.rdoDoUong_Click);
            // 
            // dgvBill
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvBill.ColumnHeadersHeight = 25;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvBill.EnableHeadersVisualStyles = false;
            this.dgvBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBill.Location = new System.Drawing.Point(14, 223);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersVisible = false;
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(535, 363);
            this.dgvBill.TabIndex = 114;
            this.dgvBill.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBill.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBill.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBill.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBill.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBill.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvBill.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBill.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvBill.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBill.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvBill.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBill.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBill.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvBill.ThemeStyle.ReadOnly = false;
            this.dgvBill.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBill.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBill.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvBill.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBill.ThemeStyle.RowsStyle.Height = 22;
            this.dgvBill.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBill.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellClick);
            this.dgvBill.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvBill_ColumnAdded);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btSua);
            this.panel2.Controls.Add(this.btnXoaBillsDetail);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.nbSoLuong);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtDoUong);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dgvBillsDetail);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(567, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 651);
            this.panel2.TabIndex = 2;
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
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.White;
            this.btSua.HoverState.Parent = this.btSua;
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btSua.Location = new System.Drawing.Point(145, 592);
            this.btSua.Name = "btSua";
            this.btSua.ShadowDecoration.Parent = this.btSua;
            this.btSua.Size = new System.Drawing.Size(122, 34);
            this.btSua.TabIndex = 144;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click_1);
            // 
            // btnXoaBillsDetail
            // 
            this.btnXoaBillsDetail.Animated = true;
            this.btnXoaBillsDetail.BorderColor = System.Drawing.Color.White;
            this.btnXoaBillsDetail.BorderRadius = 6;
            this.btnXoaBillsDetail.BorderThickness = 1;
            this.btnXoaBillsDetail.CheckedState.Parent = this.btnXoaBillsDetail;
            this.btnXoaBillsDetail.CustomImages.Parent = this.btnXoaBillsDetail;
            this.btnXoaBillsDetail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(199)))));
            this.btnXoaBillsDetail.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(199)))));
            this.btnXoaBillsDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(199)))));
            this.btnXoaBillsDetail.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnXoaBillsDetail.DisabledState.Parent = this.btnXoaBillsDetail;
            this.btnXoaBillsDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnXoaBillsDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaBillsDetail.ForeColor = System.Drawing.Color.White;
            this.btnXoaBillsDetail.HoverState.Parent = this.btnXoaBillsDetail;
            this.btnXoaBillsDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaBillsDetail.Image")));
            this.btnXoaBillsDetail.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnXoaBillsDetail.Location = new System.Drawing.Point(17, 592);
            this.btnXoaBillsDetail.Name = "btnXoaBillsDetail";
            this.btnXoaBillsDetail.ShadowDecoration.Parent = this.btnXoaBillsDetail;
            this.btnXoaBillsDetail.Size = new System.Drawing.Size(122, 34);
            this.btnXoaBillsDetail.TabIndex = 143;
            this.btnXoaBillsDetail.Text = "Xóa";
            this.btnXoaBillsDetail.Click += new System.EventHandler(this.btnXoaBillsDetail_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label1.Location = new System.Drawing.Point(127, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 39);
            this.label1.TabIndex = 135;
            this.label1.Text = "Hoá Đơn Chi Tiết";
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
            this.nbSoLuong.Location = new System.Drawing.Point(395, 181);
            this.nbSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbSoLuong.Name = "nbSoLuong";
            this.nbSoLuong.ShadowDecoration.Parent = this.nbSoLuong;
            this.nbSoLuong.Size = new System.Drawing.Size(121, 36);
            this.nbSoLuong.TabIndex = 141;
            this.nbSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label6.Location = new System.Drawing.Point(392, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 140;
            this.label6.Text = "Số lượng:";
            // 
            // txtDoUong
            // 
            this.txtDoUong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDoUong.BorderRadius = 16;
            this.txtDoUong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoUong.DefaultText = "";
            this.txtDoUong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDoUong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDoUong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDoUong.DisabledState.Parent = this.txtDoUong;
            this.txtDoUong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDoUong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDoUong.FocusedState.Parent = this.txtDoUong;
            this.txtDoUong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDoUong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.txtDoUong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDoUong.HoverState.Parent = this.txtDoUong;
            this.txtDoUong.Location = new System.Drawing.Point(17, 180);
            this.txtDoUong.MaxLength = 50;
            this.txtDoUong.Name = "txtDoUong";
            this.txtDoUong.PasswordChar = '\0';
            this.txtDoUong.PlaceholderText = "";
            this.txtDoUong.ReadOnly = true;
            this.txtDoUong.SelectedText = "";
            this.txtDoUong.ShadowDecoration.Parent = this.txtDoUong;
            this.txtDoUong.Size = new System.Drawing.Size(204, 36);
            this.txtDoUong.TabIndex = 139;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label2.Location = new System.Drawing.Point(14, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 138;
            this.label2.Text = "Tên đồ uống:";
            // 
            // dgvBillsDetail
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dgvBillsDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvBillsDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBillsDetail.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBillsDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBillsDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBillsDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBillsDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvBillsDetail.ColumnHeadersHeight = 25;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBillsDetail.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvBillsDetail.EnableHeadersVisualStyles = false;
            this.dgvBillsDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBillsDetail.Location = new System.Drawing.Point(17, 223);
            this.dgvBillsDetail.Name = "dgvBillsDetail";
            this.dgvBillsDetail.RowHeadersVisible = false;
            this.dgvBillsDetail.RowHeadersWidth = 51;
            this.dgvBillsDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillsDetail.Size = new System.Drawing.Size(499, 363);
            this.dgvBillsDetail.TabIndex = 135;
            this.dgvBillsDetail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBillsDetail.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBillsDetail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBillsDetail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBillsDetail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBillsDetail.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvBillsDetail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBillsDetail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvBillsDetail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBillsDetail.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvBillsDetail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBillsDetail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBillsDetail.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvBillsDetail.ThemeStyle.ReadOnly = false;
            this.dgvBillsDetail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBillsDetail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBillsDetail.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvBillsDetail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBillsDetail.ThemeStyle.RowsStyle.Height = 22;
            this.dgvBillsDetail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBillsDetail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBillsDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillsDetail_CellClick);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.dgvBill;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.dgvBillsDetail;
            // 
            // UC_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Bill";
            this.Size = new System.Drawing.Size(1100, 651);
            this.Load += new System.EventHandler(this.UC_Bill_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillsDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2RadioButton rdoNguyenLieu;
        private Guna.UI2.WinForms.Guna2RadioButton rdoDoUong;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2NumericUpDown nbSoLuong;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtDoUong;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBillsDetail;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Button btnXoaBillsDetail;
        private Guna.UI2.WinForms.Guna2Button btXoa;
        private Guna.UI2.WinForms.Guna2Button btSua;
    }
}