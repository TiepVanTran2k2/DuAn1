using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLy;
using DTO_QuanLy;
using Guna.UI2.WinForms;
using RJCodeAdvance.ControlBeverages;

namespace RJCodeAdvance
{
    public partial class FrmOrderDetail : Form
    {
        public int Id_table;
        public int Id_Empoyee;
        BUS_Beverage bus_beverage = new BUS_Beverage();
        List<DTO_QuanLyDoUong> ListBeverage;
        BUS_TypesOfBeverage bus_typeBeverage = new BUS_TypesOfBeverage();
        DTO_TypesOfBeverage all = new DTO_TypesOfBeverage() { Name = "Tất cả", ID_Type = 9999 };

        public FrmOrderDetail(int id_table, int id_employee)
        {
            InitializeComponent();
            Id_table = id_table;
            Id_Empoyee = id_employee;
        }

        public void FrmOrderDetail_Load(object sender, EventArgs e)
        {
            ListBeverage = bus_beverage.listBeverage();
            RenderBeverage(ListBeverage);
            List<DTO_TypesOfBeverage> listBeverageType = bus_typeBeverage.listBeverageType();
            listBeverageType.Add(all);
            cbSearch.DataSource = listBeverageType;
            cbSearch.SelectedItem = all;
            cbSearch.DisplayMember = "name";
            cbSearch.ValueMember = "id_type";
        }
        void RenderBeverage(List<DTO_QuanLyDoUong> listBeverage)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (DTO_QuanLyDoUong item in listBeverage)
            {
                UC_ItemBeverage beverage = new UC_ItemBeverage();

                beverage.BeverageId = item.Id_Beverage;
                beverage.BeverageName = item.Name;
                beverage.BeveragePrice = item.Price.ToString("#,###") + " VNĐ";
                if (File.Exists(Application.StartupPath + "\\" + item.Image))
                {
                    beverage.BeverageImage = Image.FromFile(Application.StartupPath + "\\" + item.Image);
                }
                else
                {
                    beverage.BeverageImage = default;
                }
                
                beverage.btThem.Tag = item;
                beverage.btThem.Click += BtThem_Click;
                flowLayoutPanel1.Controls.Add(beverage);
            }

            UC_ItemBeverageAdd beverageAdd = new UC_ItemBeverageAdd(this);
                      
            flowLayoutPanel1.Controls.Add(beverageAdd);
        }

        private void BtThem_Click(object sender, EventArgs e)
        {
            DTO_QuanLyDoUong beverage = (DTO_QuanLyDoUong)(sender as Guna2Button).Tag;
            
            FrmAddBeverage frm = new FrmAddBeverage(Id_table, beverage, Id_Empoyee);
            frm.ShowDialog();
        }

 
        private void txbFind_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                List<DTO_QuanLyDoUong> listFind = SearchBeverabe(txbFind.Text, (cbSearch.SelectedItem as DTO_TypesOfBeverage).ID_Type);
                    RenderBeverage(listFind);
            }
        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<DTO_QuanLyDoUong> listFind = SearchBeverabe(txbFind.Text, (cbSearch.SelectedItem as DTO_TypesOfBeverage).ID_Type);
            RenderBeverage(listFind);
        }

        List<DTO_QuanLyDoUong> SearchBeverabe(string name, int idType)
        {
            List<DTO_QuanLyDoUong> listFind;
            if (idType == 9999)
            {
                listFind = (from beverage in ListBeverage
                                                   where beverage.Name.ToLower().Contains(name.ToLower())
                                                   select beverage).ToList<DTO_QuanLyDoUong>();
            } else
            {
                listFind = (from beverage in ListBeverage
                            where beverage.Name.ToLower().Contains(name.ToLower()) && beverage.Id_Type == idType
                            select beverage).ToList<DTO_QuanLyDoUong>();
            }
            return listFind;
        }
    }
}
