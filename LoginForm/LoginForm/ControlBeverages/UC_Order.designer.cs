
namespace RJCodeAdvance.ControlBeverages
{
    partial class UC_Order
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Order));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.flpTables = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nbSoLuong = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txbDoUong = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGop = new Guna.UI2.WinForms.Guna2Button();
            this.cbGopBan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btChuyenBan = new Guna.UI2.WinForms.Guna2Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txbTongThanhTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbChuyenBan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btSua = new Guna.UI2.WinForms.Guna2Button();
            this.btXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btThem = new Guna.UI2.WinForms.Guna2Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.guna2ColorTransition1 = new Guna.UI2.WinForms.Guna2ColorTransition(this.components);
            this.logout = new Guna.UI2.WinForms.Guna2ControlBox();
            this.setting = new Guna.UI.WinForms.GunaPictureBox();
            this.calender = new Guna.UI.WinForms.GunaPictureBox();
            this.changepass = new Guna.UI.WinForms.GunaPictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changepass)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.flpTables);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 651);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.lblTitle.Location = new System.Drawing.Point(184, 71);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(169, 25);
            this.lblTitle.TabIndex = 62;
            this.lblTitle.Text = "Danh Sách Bàn";
            // 
            // flpTables
            // 
            this.flpTables.AutoScroll = true;
            this.flpTables.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpTables.Location = new System.Drawing.Point(0, 99);
            this.flpTables.Name = "flpTables";
            this.flpTables.Padding = new System.Windows.Forms.Padding(5, 30, 0, 10);
            this.flpTables.Size = new System.Drawing.Size(531, 552);
            this.flpTables.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv);
            this.panel2.Location = new System.Drawing.Point(537, 299);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(556, 289);
            this.panel2.TabIndex = 1;
            // 
            // dgv
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv.ColumnHeadersHeight = 25;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.Location = new System.Drawing.Point(10, 10);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(536, 269);
            this.dgv.TabIndex = 0;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.nbSoLuong);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txbDoUong);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnGop);
            this.panel3.Controls.Add(this.cbGopBan);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btChuyenBan);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txbTongThanhTien);
            this.panel3.Controls.Add(this.cbChuyenBan);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txbEmail);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(537, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(556, 240);
            this.panel3.TabIndex = 2;
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
            this.nbSoLuong.Location = new System.Drawing.Point(272, 46);
            this.nbSoLuong.Name = "nbSoLuong";
            this.nbSoLuong.ShadowDecoration.Parent = this.nbSoLuong;
            this.nbSoLuong.Size = new System.Drawing.Size(251, 36);
            this.nbSoLuong.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label6.Location = new System.Drawing.Point(272, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 71;
            this.label6.Text = "Số lượng:";
            // 
            // txbDoUong
            // 
            this.txbDoUong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbDoUong.BorderRadius = 16;
            this.txbDoUong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbDoUong.DefaultText = "";
            this.txbDoUong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbDoUong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbDoUong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbDoUong.DisabledState.Parent = this.txbDoUong;
            this.txbDoUong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbDoUong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbDoUong.FocusedState.Parent = this.txbDoUong;
            this.txbDoUong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbDoUong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.txbDoUong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbDoUong.HoverState.Parent = this.txbDoUong;
            this.txbDoUong.Location = new System.Drawing.Point(11, 46);
            this.txbDoUong.MaxLength = 50;
            this.txbDoUong.Name = "txbDoUong";
            this.txbDoUong.PasswordChar = '\0';
            this.txbDoUong.PlaceholderText = "";
            this.txbDoUong.SelectedText = "";
            this.txbDoUong.ShadowDecoration.Parent = this.txbDoUong;
            this.txbDoUong.Size = new System.Drawing.Size(240, 36);
            this.txbDoUong.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label2.Location = new System.Drawing.Point(11, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 65;
            this.label2.Text = "Tên đồ uống:";
            // 
            // btnGop
            // 
            this.btnGop.BorderRadius = 3;
            this.btnGop.CheckedState.Parent = this.btnGop;
            this.btnGop.CustomImages.Parent = this.btnGop;
            this.btnGop.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(199)))));
            this.btnGop.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(199)))));
            this.btnGop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(199)))));
            this.btnGop.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnGop.DisabledState.Parent = this.btnGop;
            this.btnGop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnGop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGop.ForeColor = System.Drawing.Color.White;
            this.btnGop.HoverState.Parent = this.btnGop;
            this.btnGop.Location = new System.Drawing.Point(421, 186);
            this.btnGop.Name = "btnGop";
            this.btnGop.ShadowDecoration.Parent = this.btnGop;
            this.btnGop.Size = new System.Drawing.Size(102, 36);
            this.btnGop.TabIndex = 64;
            this.btnGop.Text = "Gộp";
            this.btnGop.Click += new System.EventHandler(this.btnGop_Click);
            // 
            // cbGopBan
            // 
            this.cbGopBan.BackColor = System.Drawing.Color.Transparent;
            this.cbGopBan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGopBan.BorderRadius = 16;
            this.cbGopBan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGopBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGopBan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGopBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGopBan.FocusedState.Parent = this.cbGopBan;
            this.cbGopBan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbGopBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.cbGopBan.HoverState.Parent = this.cbGopBan;
            this.cbGopBan.ItemHeight = 30;
            this.cbGopBan.ItemsAppearance.Parent = this.cbGopBan;
            this.cbGopBan.Location = new System.Drawing.Point(272, 186);
            this.cbGopBan.Name = "cbGopBan";
            this.cbGopBan.ShadowDecoration.Parent = this.cbGopBan;
            this.cbGopBan.Size = new System.Drawing.Size(143, 36);
            this.cbGopBan.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label1.Location = new System.Drawing.Point(272, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 62;
            this.label1.Text = "Gộp bàn:";
            // 
            // btChuyenBan
            // 
            this.btChuyenBan.BorderRadius = 3;
            this.btChuyenBan.CheckedState.Parent = this.btChuyenBan;
            this.btChuyenBan.CustomImages.Parent = this.btChuyenBan;
            this.btChuyenBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(199)))));
            this.btChuyenBan.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(199)))));
            this.btChuyenBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(199)))));
            this.btChuyenBan.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btChuyenBan.DisabledState.Parent = this.btChuyenBan;
            this.btChuyenBan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btChuyenBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btChuyenBan.ForeColor = System.Drawing.Color.White;
            this.btChuyenBan.HoverState.Parent = this.btChuyenBan;
            this.btChuyenBan.Location = new System.Drawing.Point(154, 186);
            this.btChuyenBan.Name = "btChuyenBan";
            this.btChuyenBan.ShadowDecoration.Parent = this.btChuyenBan;
            this.btChuyenBan.Size = new System.Drawing.Size(91, 36);
            this.btChuyenBan.TabIndex = 61;
            this.btChuyenBan.Text = "Chuyển";
            this.btChuyenBan.Click += new System.EventHandler(this.btChuyenBan_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label10.Location = new System.Drawing.Point(272, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 16);
            this.label10.TabIndex = 59;
            this.label10.Text = "Tổng thành tiền:";
            // 
            // txbTongThanhTien
            // 
            this.txbTongThanhTien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbTongThanhTien.BorderRadius = 16;
            this.txbTongThanhTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTongThanhTien.DefaultText = "0";
            this.txbTongThanhTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbTongThanhTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbTongThanhTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbTongThanhTien.DisabledState.Parent = this.txbTongThanhTien;
            this.txbTongThanhTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbTongThanhTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbTongThanhTien.FocusedState.Parent = this.txbTongThanhTien;
            this.txbTongThanhTien.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTongThanhTien.ForeColor = System.Drawing.Color.BlueViolet;
            this.txbTongThanhTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbTongThanhTien.HoverState.Parent = this.txbTongThanhTien;
            this.txbTongThanhTien.Location = new System.Drawing.Point(272, 115);
            this.txbTongThanhTien.Name = "txbTongThanhTien";
            this.txbTongThanhTien.PasswordChar = '\0';
            this.txbTongThanhTien.PlaceholderText = "";
            this.txbTongThanhTien.ReadOnly = true;
            this.txbTongThanhTien.SelectedText = "";
            this.txbTongThanhTien.SelectionStart = 1;
            this.txbTongThanhTien.ShadowDecoration.Parent = this.txbTongThanhTien;
            this.txbTongThanhTien.Size = new System.Drawing.Size(251, 36);
            this.txbTongThanhTien.TabIndex = 58;
            this.txbTongThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbChuyenBan
            // 
            this.cbChuyenBan.BackColor = System.Drawing.Color.Transparent;
            this.cbChuyenBan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbChuyenBan.BorderRadius = 16;
            this.cbChuyenBan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbChuyenBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChuyenBan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbChuyenBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbChuyenBan.FocusedState.Parent = this.cbChuyenBan;
            this.cbChuyenBan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbChuyenBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.cbChuyenBan.HoverState.Parent = this.cbChuyenBan;
            this.cbChuyenBan.ItemHeight = 30;
            this.cbChuyenBan.ItemsAppearance.Parent = this.cbChuyenBan;
            this.cbChuyenBan.Location = new System.Drawing.Point(11, 186);
            this.cbChuyenBan.Name = "cbChuyenBan";
            this.cbChuyenBan.ShadowDecoration.Parent = this.cbChuyenBan;
            this.cbChuyenBan.Size = new System.Drawing.Size(137, 36);
            this.cbChuyenBan.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label8.Location = new System.Drawing.Point(11, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 52;
            this.label8.Text = "Chuyển bàn:";
            // 
            // txbEmail
            // 
            this.txbEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
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
            this.txbEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.txbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbEmail.HoverState.Parent = this.txbEmail;
            this.txbEmail.Location = new System.Drawing.Point(11, 115);
            this.txbEmail.MaxLength = 50;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.PasswordChar = '\0';
            this.txbEmail.PlaceholderText = "Nhập email khách hàng";
            this.txbEmail.SelectedText = "";
            this.txbEmail.ShadowDecoration.Parent = this.txbEmail;
            this.txbEmail.Size = new System.Drawing.Size(240, 36);
            this.txbEmail.TabIndex = 44;
            this.txbEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbEmail_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label4.Location = new System.Drawing.Point(11, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "Email khách hàng:";
            // 
            // btThanhToan
            // 
            this.btThanhToan.BorderColor = System.Drawing.Color.White;
            this.btThanhToan.BorderRadius = 3;
            this.btThanhToan.CheckedState.Parent = this.btThanhToan;
            this.btThanhToan.CustomImages.Parent = this.btThanhToan;
            this.btThanhToan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(199)))));
            this.btThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(199)))));
            this.btThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(199)))));
            this.btThanhToan.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btThanhToan.DisabledState.Parent = this.btThanhToan;
            this.btThanhToan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btThanhToan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThanhToan.ForeColor = System.Drawing.Color.White;
            this.btThanhToan.HoverState.Parent = this.btThanhToan;
            this.btThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btThanhToan.Image")));
            this.btThanhToan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btThanhToan.Location = new System.Drawing.Point(961, 594);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.ShadowDecoration.Parent = this.btThanhToan;
            this.btThanhToan.Size = new System.Drawing.Size(122, 34);
            this.btThanhToan.TabIndex = 57;
            this.btThanhToan.Text = "Thanh toán";
            this.btThanhToan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btThanhToan.TextOffset = new System.Drawing.Point(10, 0);
            this.btThanhToan.Click += new System.EventHandler(this.btThanhToan_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 26;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.dgv;
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
            this.btSua.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.White;
            this.btSua.HoverState.Parent = this.btSua;
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btSua.Location = new System.Drawing.Point(819, 594);
            this.btSua.Name = "btSua";
            this.btSua.ShadowDecoration.Parent = this.btSua;
            this.btSua.Size = new System.Drawing.Size(122, 34);
            this.btSua.TabIndex = 65;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
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
            this.btXoa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.White;
            this.btXoa.HoverState.Parent = this.btXoa;
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btXoa.Location = new System.Drawing.Point(682, 594);
            this.btXoa.Name = "btXoa";
            this.btXoa.ShadowDecoration.Parent = this.btXoa;
            this.btXoa.Size = new System.Drawing.Size(122, 34);
            this.btXoa.TabIndex = 64;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
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
            this.btThem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.White;
            this.btThem.HoverState.Parent = this.btThem;
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btThem.Location = new System.Drawing.Point(545, 594);
            this.btThem.Name = "btThem";
            this.btThem.ShadowDecoration.Parent = this.btThem;
            this.btThem.Size = new System.Drawing.Size(122, 34);
            this.btThem.TabIndex = 63;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // guna2ColorTransition1
            // 
            this.guna2ColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Orange};
            // 
            // logout
            // 
            this.logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logout.BackColor = System.Drawing.Color.White;
            this.logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logout.BackgroundImage")));
            this.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logout.BorderColor = System.Drawing.Color.Transparent;
            this.logout.BorderRadius = 3;
            this.logout.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.logout.FillColor = System.Drawing.Color.Transparent;
            this.logout.HoverState.IconColor = System.Drawing.Color.White;
            this.logout.HoverState.Parent = this.logout;
            this.logout.IconColor = System.Drawing.Color.White;
            this.logout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.logout.Location = new System.Drawing.Point(910, 12);
            this.logout.Name = "logout";
            this.logout.ShadowDecoration.Parent = this.logout;
            this.logout.ShowIcon = false;
            this.logout.Size = new System.Drawing.Size(42, 35);
            this.logout.TabIndex = 70;
            this.logout.Click += new System.EventHandler(this.guna2ControlBox4_Click);
            // 
            // setting
            // 
            this.setting.BaseColor = System.Drawing.Color.White;
            this.setting.Image = ((System.Drawing.Image)(resources.GetObject("setting.Image")));
            this.setting.Location = new System.Drawing.Point(958, 12);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(37, 35);
            this.setting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.setting.TabIndex = 71;
            this.setting.TabStop = false;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // calender
            // 
            this.calender.BaseColor = System.Drawing.Color.White;
            this.calender.Image = ((System.Drawing.Image)(resources.GetObject("calender.Image")));
            this.calender.Location = new System.Drawing.Point(1003, 12);
            this.calender.Name = "calender";
            this.calender.Size = new System.Drawing.Size(37, 35);
            this.calender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.calender.TabIndex = 72;
            this.calender.TabStop = false;
            this.calender.Click += new System.EventHandler(this.calender_Click);
            // 
            // changepass
            // 
            this.changepass.BaseColor = System.Drawing.Color.White;
            this.changepass.Image = ((System.Drawing.Image)(resources.GetObject("changepass.Image")));
            this.changepass.Location = new System.Drawing.Point(1046, 12);
            this.changepass.Name = "changepass";
            this.changepass.Size = new System.Drawing.Size(37, 35);
            this.changepass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.changepass.TabIndex = 73;
            this.changepass.TabStop = false;
            this.changepass.Click += new System.EventHandler(this.changepass_Click);
            // 
            // UC_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.changepass);
            this.Controls.Add(this.calender);
            this.Controls.Add(this.setting);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThanhToan);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Order";
            this.Size = new System.Drawing.Size(1096, 651);
            this.Load += new System.EventHandler(this.UC_Order_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changepass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpTables;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2TextBox txbTongThanhTien;
        private Guna.UI2.WinForms.Guna2Button btThanhToan;
        private Guna.UI2.WinForms.Guna2ComboBox cbChuyenBan;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txbEmail;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Button btChuyenBan;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2DataGridView dgv;
        private Guna.UI2.WinForms.Guna2Button btnGop;
        private Guna.UI2.WinForms.Guna2ComboBox cbGopBan;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btSua;
        private Guna.UI2.WinForms.Guna2Button btXoa;
        private Guna.UI2.WinForms.Guna2Button btThem;
        private Guna.UI2.WinForms.Guna2TextBox txbDoUong;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2NumericUpDown nbSoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Guna.UI2.WinForms.Guna2ColorTransition guna2ColorTransition1;
        private Guna.UI2.WinForms.Guna2ControlBox logout;
        private Guna.UI.WinForms.GunaPictureBox changepass;
        private Guna.UI.WinForms.GunaPictureBox calender;
        private Guna.UI.WinForms.GunaPictureBox setting;
    }
}
