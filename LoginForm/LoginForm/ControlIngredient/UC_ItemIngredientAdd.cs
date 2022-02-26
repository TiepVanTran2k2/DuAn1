using RJCodeAdvance.ControlIngredient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RJCodeAdvance.ControlBeverages
{
    public partial class UC_ItemIngredientAdd : UserControl
    {
        public int BeverageId;
        UC_Input_Ingredient Uc_Input;

        public UC_ItemIngredientAdd(UC_Input_Ingredient uc)
        {
            InitializeComponent();
            Uc_Input = uc;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            ShowFrmIngredient();
        }

        private void UC_ItemIngredientAdd_Click(object sender, EventArgs e)
        {
            ShowFrmIngredient();
        }
        void ShowFrmIngredient()
        {
            UC_ingredient frm = new UC_ingredient();
            frm.FormClosing += Frm_FormClosing;
            frm.ShowDialog();
            // load loại danh sách nguyên liệu
        }

        private void Frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Uc_Input.UC_Input_Ingredient_Load(this, new EventArgs());
        }
    }
}
