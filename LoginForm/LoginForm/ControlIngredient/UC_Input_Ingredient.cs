using BUS_QuanLy;
using DTO_QuanLy;
using Guna.UI2.WinForms;
using RJCodeAdvance.ControlBeverages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RJCodeAdvance.ControlIngredient
{
    public partial class UC_Input_Ingredient : UserControl
    {
        public UC_Input_Ingredient()
        {
            InitializeComponent();
        }
        BUS_InputIngredients input = new BUS_InputIngredients();
        BUS_NguyenLieu bus_NguyenLieu = new BUS_NguyenLieu();
        DateTime today = DateTime.Now;
        List<DTO_NguyenLieu> ListNl;
        public void UC_Input_Ingredient_Load(object sender, EventArgs e)
        {
            ListNl = bus_NguyenLieu.getListIngredient();
            RenderBeverage(ListNl);
            nbSoLuong.Enabled = false;

            List<DTO_LoaiNguyenLieu> listBeverageType = bus_typeIngredients.listIngredientType();
            listBeverageType.Add(all);
            cbSearch.DataSource = listBeverageType;
            cbSearch.SelectedItem = all;
            cbSearch.DisplayMember = "Name";
            cbSearch.ValueMember = "Id_type";
        }
        void RenderBeverage(List<DTO_NguyenLieu> nl)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (DTO_NguyenLieu item in nl)
            {
                UC_IngeredientItem ingredients = new UC_IngeredientItem();

                ingredients.IngredientName = item.Name;
                ingredients.IngredientNPrice = item.Price.ToString("#,###") + "VNĐ";

                if (File.Exists(Application.StartupPath + "\\" + item.Images))
                {
                    ingredients.IngredientNImage = Image.FromFile(Application.StartupPath + "\\" + item.Images);
                }
                else
                {
                    ingredients.IngredientNImage = default;
                }

                ingredients.btThem.Tag = item;
                ingredients.btThem.Click += BtThem_Click;
                flowLayoutPanel1.Controls.Add(ingredients);
            }

            UC_ItemIngredientAdd b = new UC_ItemIngredientAdd(this);
            flowLayoutPanel1.Controls.Add(b);
        }
        DataTable a = new DataTable();

        private void BtThem_Click(object sender, EventArgs e)
        {
            DTO_NguyenLieu Ingredients = (DTO_NguyenLieu)(sender as Guna2Button).Tag;
            FrmAddIngredient frm = new FrmAddIngredient(Ingredients,this);
            frm.ShowDialog();
            guna2DataGridView1.Columns[3].DefaultCellStyle.Format = "#,###";
            for (int i = 0; i < guna2DataGridView1.Rows.Count - 1; i++)
            {
                string tmp = guna2DataGridView1.Rows[i].Cells[0].Value.ToString();
                for (int j = guna2DataGridView1.Rows.Count - 1; j > i; j--)
                {
                    
                    if (guna2DataGridView1.Rows[j].IsNewRow) continue;
                    if (tmp == guna2DataGridView1.Rows[j].Cells[0].Value.ToString())
                    {
                        guna2DataGridView1.Rows[i].Cells[1].Value = (int.Parse(guna2DataGridView1.Rows[i].Cells[1].Value.ToString()) + int.Parse(guna2DataGridView1.Rows[j].Cells[1].Value.ToString()));
                        guna2DataGridView1.Rows[i].Cells[3].Value = (int.Parse(guna2DataGridView1.Rows[i].Cells[3].Value.ToString()) + int.Parse(guna2DataGridView1.Rows[j].Cells[3].Value.ToString()));
                        guna2DataGridView1.Rows.RemoveAt(j);
                    }
                    //guna2DataGridView1.Rows[i].Cells[3].Value = String.Format("{0:0,0 vnđ}", guna2DataGridView1.Rows[i].Cells[3].Value);
                }
            }
            int money = 0;
            
            for(int i = 0; i < guna2DataGridView1.Rows.Count - 1; i++)
            {
                money += int.Parse(guna2DataGridView1.Rows[i].Cells[3].Value.ToString());
                txtTongTien.Text = "" + money;
            }
        }
        BUS_InputBills bill = new BUS_InputBills();
        public static string mail;
        private void UC_Input_Ingredient_Click(object sender, EventArgs e)
        {
        }
        //click datagridview
        int rows;
        int donGia;
        private void guna2DataGridView1_Click(object sender, EventArgs e)
        {
            
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.RemoveAt(rows);
            int money = 0;

            for (int i = 0; i < guna2DataGridView1.Rows.Count - 1; i++)
            {
                money += int.Parse(guna2DataGridView1.Rows[i].Cells[3].Value.ToString());
                txtTongTien.Text = "" + money;
            }
            txtName.Text = null;
            txtThanhTien.Text = ""+0;
            nbSoLuong.Text = "" + 0;
        }

        private void btThanhToan_Click_1(object sender, EventArgs e)
        {
            string time = today.ToString("yyyy-MM-dd hh:mm:ss.fff");
            if (guna2DataGridView1.Rows.Count == 1)
            {
                MessageBox.Show("Không có mặc hàng nào cần thanh toán");
            }
            else
            {
                // tạo insert vào inputBill
                DTO_InputBills dTO_InputBills = new DTO_InputBills(time, mail, float.Parse(txtTongTien.Text));
                if (bill.insertBillIngredient(dTO_InputBills))
                {
                    //vằng lặp lấy giá trị trong datagridview để insert vào inputBillsDetails
                    for (int i = 0; i < guna2DataGridView1.Rows.Count - 1; i++)
                    {
                        string nameType = guna2DataGridView1.Rows[i].Cells[0].Value.ToString();
                        string soLuong = guna2DataGridView1.Rows[i].Cells[1].Value.ToString();
                        DTO_InputIngredients dTO_InputIngredients = new DTO_InputIngredients(soLuong, nameType, time);
                        if (input.insertBillDetailIngredient(dTO_InputIngredients))
                        {
                        }
                    }
                    // để t push lên, rồi m pull về có bị lỗi ghi đè dall ko
                    guna2DataGridView1.Rows.Clear();
                    txtName.Text = null;
                    txtThanhTien.Text = "" + 0;
                    txtTongTien.Text = "" + 0;
                    nbSoLuong.Text = "" + 0;
                }
                else
                {
                    MessageBox.Show("Thao tác chậm lại :)))");
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows[rows].Cells[1].Value = int.Parse(nbSoLuong.Value.ToString());
            guna2DataGridView1.Rows[rows].Cells[3].Value = int.Parse(nbSoLuong.Value.ToString())*donGia;
            int money = 0;

            for (int i = 0; i < guna2DataGridView1.Rows.Count - 1; i++)
            {
                money += int.Parse(guna2DataGridView1.Rows[i].Cells[3].Value.ToString());
                txtTongTien.Text = "" + money;
            }
            txtName.Text = null;
            txtThanhTien.Text = ""+0;
            nbSoLuong.Text = ""+0;
        }
        BUS_LoaiNguyenLieu bus_typeIngredients = new BUS_LoaiNguyenLieu();
        DTO_LoaiNguyenLieu all = new DTO_LoaiNguyenLieu() { Name = "Tất cả", Id_Type = 9999 };
        List<DTO_NguyenLieu> SearchIngredient(string name, int idType)
        {
            List<DTO_NguyenLieu> listFind;
            if (idType == 9999)
            {
                listFind = (from ingredients in ListNl
                            where ingredients.Name.ToLower().Contains(name.ToLower())
                            select ingredients).ToList<DTO_NguyenLieu>();
            }
            else
            {
                listFind = (from ingredient in ListNl
                            where ingredient.Name.ToLower().Contains(name.ToLower()) && ingredient.Id_Type == idType
                            select ingredient).ToList<DTO_NguyenLieu>();
            }
            return listFind;
        }
        private void guna2TextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                List<DTO_NguyenLieu> listFind = SearchIngredient(guna2TextBox2.Text, (cbSearch.SelectedItem as DTO_LoaiNguyenLieu).Id_Type);
                RenderBeverage(listFind);
            }
        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<DTO_NguyenLieu> listFind = SearchIngredient(guna2TextBox2.Text, (cbSearch.SelectedItem as DTO_LoaiNguyenLieu).Id_Type);
            RenderBeverage(listFind);
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            string time = today.ToString("yyyy-MM-dd hh:mm:ss.fff");
            //vi-VN
            if (guna2DataGridView1.Rows.Count == 1)
            {
                MessageBox.Show("Không có mặc hàng nào cần thanh toán");
            }
            else
            {
                // tạo insert vào inputBill
                DTO_InputBills dTO_InputBills = new DTO_InputBills(time, mail, float.Parse(txtTongTien.Text));
                if (bill.insertBillIngredient(dTO_InputBills))
                {
                    //vằng lặp lấy giá trị trong datagridview để insert vào inputBillsDetails
                    for (int i = 0; i < guna2DataGridView1.Rows.Count - 1; i++)
                    {
                        string nameType = guna2DataGridView1.Rows[i].Cells[0].Value.ToString();
                        string soLuong = guna2DataGridView1.Rows[i].Cells[1].Value.ToString();
                        DTO_InputIngredients dTO_InputIngredients = new DTO_InputIngredients(soLuong, nameType, time);
                        if (input.insertBillDetailIngredient(dTO_InputIngredients))
                        {
                            //MessageBox.Show("Thành công");
                        }
                    }
                    // để t push lên, rồi m pull về có bị lỗi ghi đè dall ko
                    guna2DataGridView1.Rows.Clear();
                    txtName.Text = null;
                    txtThanhTien.Text = "" + 0;
                    txtTongTien.Text = "" + 0;
                    nbSoLuong.Text = "" + 0;
                }
                else
                {
                    MessageBox.Show("Thao tác chậm lại :)))");
                }
            }
        }

        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(txtThanhTien.Text, System.Globalization.NumberStyles.AllowThousands);
            txtThanhTien.Text = String.Format(culture, "{0:N0}", value);
            txtThanhTien.Select(txtThanhTien.Text.Length, 0);
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(txtTongTien.Text, System.Globalization.NumberStyles.AllowThousands);
            txtTongTien.Text = String.Format(culture, "{0:N0}", value);
            txtTongTien.Select(txtTongTien.Text.Length, 0);
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btSua.Enabled = true;
            nbSoLuong.Enabled = true;
            if (guna2DataGridView1.Rows.Count > 1)
            {
                rows = guna2DataGridView1.CurrentRow.Index;
                txtName.Text = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
                nbSoLuong.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtThanhTien.Text = guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
                rows = guna2DataGridView1.CurrentRow.Index;
                donGia = int.Parse(guna2DataGridView1.CurrentRow.Cells[3].Value.ToString()) / int.Parse(guna2DataGridView1.CurrentRow.Cells[1].Value.ToString());
            }
        }
    }
}
