
namespace RJCodeAdvance.ControlBeverages
{
    partial class UC_IngeredientItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_IngeredientItem));
            this.lblName = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblPrice = new System.Windows.Forms.Label();
            this.btThem = new Guna.UI2.WinForms.Guna2Button();
            this.ptbImg = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(67, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(170, 16);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Trân châu";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 5;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(68, 25);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(93, 13);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "5000đ";
            // 
            // btThem
            // 
            this.btThem.Animated = true;
            this.btThem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(174)))), ((int)(((byte)(243)))));
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
            this.btThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(174)))), ((int)(((byte)(243)))));
            this.btThem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btThem.ForeColor = System.Drawing.Color.White;
            this.btThem.HoverState.Parent = this.btThem;
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.Location = new System.Drawing.Point(167, 34);
            this.btThem.Name = "btThem";
            this.btThem.ShadowDecoration.Parent = this.btThem;
            this.btThem.Size = new System.Drawing.Size(70, 30);
            this.btThem.TabIndex = 50;
            // 
            // ptbImg
            // 
            this.ptbImg.BorderRadius = 3;
            this.ptbImg.Image = ((System.Drawing.Image)(resources.GetObject("ptbImg.Image")));
            this.ptbImg.ImageRotate = 0F;
            this.ptbImg.Location = new System.Drawing.Point(10, 6);
            this.ptbImg.Name = "ptbImg";
            this.ptbImg.ShadowDecoration.Parent = this.ptbImg;
            this.ptbImg.Size = new System.Drawing.Size(52, 58);
            this.ptbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImg.TabIndex = 6;
            this.ptbImg.TabStop = false;
            // 
            // UC_IngeredientItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.ptbImg);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Name = "UC_IngeredientItem";
            this.Size = new System.Drawing.Size(246, 73);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lblPrice;
        private Guna.UI2.WinForms.Guna2PictureBox ptbImg;
        public Guna.UI2.WinForms.Guna2Button btThem;
    }
}
