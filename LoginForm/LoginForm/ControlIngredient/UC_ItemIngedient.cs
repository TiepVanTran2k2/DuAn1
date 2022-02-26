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
    public partial class UC_IngeredientItem : UserControl
    {
        public int IngredientNId;
        public UC_IngeredientItem()
        {
            InitializeComponent();
        }

        public string IngredientName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }
        public string IngredientNPrice
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }
        public Image IngredientNImage
        {
            get { return ptbImg.Image; }
            set { ptbImg.Image = value; }
        }
    }
}
