using BUS_QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagedList;
using System.Drawing.Printing;

namespace RJCodeAdvance.ControlStatistic
{
    public partial class UC_Statistic : UserControl
    {
        BUS_Static bUS_Static = new BUS_Static();
        public UC_Statistic()
        {
            InitializeComponent();
        }
        int check = 0;
        private void UC_Statistic_Load(object sender, EventArgs e)
        {
            loadPill();
            LoadBillInput();
            LoadDanhThu();
            chart1.Visible = false;
            dataGridView1.Visible = true;
            chart2.ChartAreas["ChartArea1"].AxisX.Title = "Static";
            chart2.ChartAreas["ChartArea1"].AxisY.Title = "Total";
            DataTable dt = new DataTable();
            dt.Columns.Add("", typeof(string));
            dt.Columns.Add("", typeof(string));
            dt.Columns.Add("", typeof(string));
            dt.Rows.Add(dataGridView1.Rows[0].Cells[0].Value.ToString(), dataGridView1.Rows[0].Cells[1].Value.ToString(), dataGridView1.Rows[0].Cells[2].Value.ToString());
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chart2.Series["Tổng tiền hóa đơn"].Points.AddY(dt.Rows[i][0]);
                chart2.Series["Tổng tiền nguyên liệu"].Points.AddY(dt.Rows[i][1]);
                chart2.Series["Danh thu"].Points.AddY(dt.Rows[i][2]);
            }

            btTK.Visible = false;
        }
        void loadPill()
        {
            DataTable dt = bUS_Static.getDataBillDetail();
            guna2DataGridView1.DataSource = dt;
            guna2DataGridView1.Columns[0].HeaderText = "Nhân viên";
            guna2DataGridView1.Columns[1].HeaderText = "Mã khách hàng";
            guna2DataGridView1.Columns[2].HeaderText = "Mã bill";
            guna2DataGridView1.Columns[3].HeaderText = "Mã bàn";

            guna2DataGridView1.Columns[4].HeaderText = "Ngày tạo";
            guna2DataGridView1.Columns[5].HeaderText = "Ngày xuất";
            guna2DataGridView1.Columns[6].HeaderText = "Tổng tiền";
            guna2DataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            foreach (DataRow item in dt.Rows)
            {
                if (item[1].ToString() == "")
                {
                    item[1] = "0";
                }
            }
            DataTable dt1 = bUS_Static.getPrice();
            foreach (DataRow item in dt1.Rows)
            {
                int a = int.Parse(item[0].ToString());
                txtTongTien.Text = "" + a.ToString();
            }
        }
        //click vào thống kê hóa đơn

        string day1 = "2000-01-01 00:00:00";
        string day2 = DateTime.Now.ToString("yyyy-MM-dd 23:59:59");
        private void btThongKe_Click(object sender, EventArgs e)
        {
            btEx.Enabled = true;
            btEx1.Enabled = true;
            btEx2.Enabled = true;
            btIn1.Enabled = true;
            btIn2.Enabled = true;
            btIn3.Enabled = true;
            check = 0;
            if (rdChiTiet.Checked)
            {
                guna2DataGridView3.SendToBack();
                guna2DataGridView4.SendToBack();
                //btTuan3.SendToBack();
                //btTuan4.SendToBack();
                btThang3.SendToBack();
                btThang4.SendToBack();
                btNam3.SendToBack();
                btNam4.SendToBack();
                btEx1.SendToBack();
                btEx2.SendToBack();
                btIn2.SendToBack();
                btIn3.SendToBack();
                dayStart.Format = DateTimePickerFormat.Custom;
                dayStart.CustomFormat = "yyyy/MM/dd";
                dayEnd.Format = DateTimePickerFormat.Custom;
                dayEnd.CustomFormat = "yyyy/MM/dd 23:59:59";
                string dayStar = dayStart.Text;
                string dayend = dayEnd.Text;
                day1 = dayStar;
                day2 = dayend;
                DataTable dt = bUS_Static.getDataBillDetailDate(dayStar, dayend);
                guna2DataGridView1.DataSource = dt;
                foreach (DataRow item in dt.Rows)
                {
                    if (item[1].ToString() == "")
                    {
                        item[1] = "0";
                    }
                }
                DataTable dt1 = bUS_Static.SumPriceDateTime(dayStar, dayend);
                foreach (DataRow item in dt1.Rows)
                {
                    txtTongTien.Text = item[0].ToString();
                }
                guna2DataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                chart1.Series["Total"].Points.Clear();

                dayStart.Format = DateTimePickerFormat.Custom;
                dayStart.CustomFormat = "dd/MM/yyyy";
                dayEnd.Format = DateTimePickerFormat.Custom;
                dayEnd.CustomFormat = "dd/MM/yyyy 23:59:59";
            }
            if (rbTongThe.Checked)
            {
                dayStart.Format = DateTimePickerFormat.Custom;
                dayStart.CustomFormat = "yyyy/MM/dd";
                dayEnd.Format = DateTimePickerFormat.Custom;
                dayEnd.CustomFormat = "yyyy/MM/dd 23:59:59";
                rdChart.Visible = true;
                btTK.FillColor = Color.FromArgb(0, 118, 212);
                guna2DataGridView3.SendToBack();
                guna2DataGridView4.SendToBack();
                //btTuan3.SendToBack();
                //btTuan4.SendToBack();
                btThang3.SendToBack();
                btThang4.SendToBack();
                btNam3.SendToBack();
                btNam4.SendToBack();
                btEx1.SendToBack();
                btEx2.SendToBack();
                btIn2.SendToBack();
                btIn3.SendToBack();
                string dayStar = dayStart.Text;
                string dayend = dayEnd.Text;
                DataTable dt = bUS_Static.StaticOverAllDate(dayStar, dayend);
                day1 = dayStar;
                day2 = dayend;
                guna2DataGridView1.DataSource = dt;
                guna2DataGridView1.Columns[3].Visible = false;
                guna2DataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                DataTable dt1 = bUS_Static.SumPriceDateTime(dayStar, dayend);
                foreach (DataRow item in dt1.Rows)
                {
                    txtTongTien.Text = item[0].ToString();
                }

                chart1.Series["Total"].Points.Clear();
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Day";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Total";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    chart1.Series["Total"].Points.AddXY(dt.Rows[i][0], dt.Rows[i][3]);
                }

                dayStart.Format = DateTimePickerFormat.Custom;
                dayStart.CustomFormat = "dd/MM/yyyy";
                dayEnd.Format = DateTimePickerFormat.Custom;
                dayEnd.CustomFormat = "dd/MM/yyyy 23:59:59";
            }
        }
        DateTime dayNow = DateTime.Now;
        //Click bt tuần hóa đơn
        private void btTuan_Click(object sender, EventArgs e)
        {
            guna2DataGridView3.SendToBack();
            guna2DataGridView4.SendToBack();
            int dem;
            string time = dayNow.ToString("yyyy-MM-dd 23:59:59");
            string time1 = dayNow.ToString("yyyy-MM-dd 00:00:00");
            DateTime date = new DateTime(DateTime.Parse(time).Year, DateTime.Parse(time).Month, DateTime.Parse(time).Day);
            //MessageBox.Show("" + date.AddDays(-6).ToString("yyyy-MM-dd 00:00:00"));
            if (date.DayOfWeek == DayOfWeek.Sunday)
            {
                DataTable dt2 = bUS_Static.getDataBillDetailDayOfWeek(date.AddDays(-6).ToString("yyyy-MM-dd 00:00:01"), time);
                guna2DataGridView1.DataSource = dt2;
                foreach (DataRow item in dt2.Rows)
                {
                    if (item[1].ToString() == "")
                    {
                        item[1] = "0";
                    }
                }
                DataTable dt3 = bUS_Static.SumPriceDateTime(date.AddDays(-6).ToString("yyyy-MM-dd 00:00:00"), time);
                foreach (DataRow item in dt3.Rows)
                {
                    txtTongTien.Text = item[0].ToString();
                }
                dayStart.Text = date.AddDays(-6).ToString("yyyy-MM-dd");
                dayEnd.Text = time;
            }
            if (date.DayOfWeek != DayOfWeek.Monday && date.DayOfWeek != DayOfWeek.Sunday)
            {
                dem = date.DayOfWeek - DayOfWeek.Monday;
                DataTable dt = bUS_Static.getDataBillDetailDayOfWeek(date.AddDays(-dem).ToString("yyyy-MM-dd 00:00:01"), time);
                guna2DataGridView1.DataSource = dt;
                foreach (DataRow item in dt.Rows)
                {
                    if (item[1].ToString() == "")
                    {
                        item[1] = "0";
                    }
                }
                DataTable dt1 = bUS_Static.SumPriceDateTime(date.AddDays(-dem).ToString("yyyy-MM-dd 00:00:00"), time);
                foreach (DataRow item in dt1.Rows)
                {
                    txtTongTien.Text = item[0].ToString();
                }
                dayStart.Text = date.AddDays(-dem).ToString("yyyy-MM-dd");
                dayEnd.Text = time;
            }
            if (date.DayOfWeek == DayOfWeek.Monday)
            {
                DataTable dt = bUS_Static.getDataBillDetailDayOfWeek(time1, time);
                guna2DataGridView1.DataSource = dt;
                foreach (DataRow item in dt.Rows)
                {
                    if (item[1].ToString() == "")
                    {
                        item[1] = "0";
                    }
                }
                DataTable dt1 = bUS_Static.SumPriceDateTime(time1, time);
                foreach (DataRow item in dt1.Rows)
                {
                    txtTongTien.Text = item[0].ToString();
                }
                dayStart.Text = time1;
                dayEnd.Text = time;
            }
        }
        //Click bt tháng hóa đơn
        private void btThang_Click(object sender, EventArgs e)
        {
            btEx.Enabled = true;
            btEx1.Enabled = true;
            btEx2.Enabled = true;
            btIn1.Enabled = true;
            btIn2.Enabled = true;
            btIn3.Enabled = true;
            if (rdChiTiet.Checked)
            {
                guna2DataGridView3.SendToBack();
                guna2DataGridView4.SendToBack();
                string time = dayNow.ToString("yyyy-MM-dd 23:59:59");
                string time2 = dayNow.ToString("yyyy-MM-dd 23:59:59");
                string time1 = dayNow.ToString("yyyy-MM-dd 00:00:00");
                DateTime date = new DateTime(DateTime.Parse(time).Year, DateTime.Parse(time).Month, DateTime.Parse(time).Day);
                if (date.Day != 1)
                {
                    DataTable dt = bUS_Static.getDataBillDetailDayOfWeek(date.ToString("yyyy-MM-01 00:00:00"), dayNow.ToString("yyyy-MM-dd 23:59:59"));
                    guna2DataGridView1.DataSource = dt;
                    day1 = date.ToString("yyyy-MM-01 00:00:00");
                    day2 = dayNow.ToString("yyyy-MM-dd 23:59:59");
                    foreach (DataRow item in dt.Rows)
                    {
                        if (item[1].ToString() == "")
                        {
                            item[1] = "0";
                        }
                    }
                    DataTable dt1 = bUS_Static.SumPriceDateTime(date.ToString("yyyy-MM-01 00:00:00"), dayNow.ToString("yyyy-MM-dd 23:59:59"));
                    foreach (DataRow item in dt1.Rows)
                    {
                        txtTongTien.Text = item[0].ToString();
                    }
                    guna2DataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dayStart.Text = date.ToString("01-MM-yyyy");
                    dayEnd.Text = dayNow.ToString("yyyy-MM-dd 23:59:59");
                }
                else
                {
                    DataTable dt = bUS_Static.getDataBillDetailDayOfWeek(time1, time2);
                    day1 = time1;
                    day2 = time2;
                    guna2DataGridView1.DataSource = dt;
                    foreach (DataRow item in dt.Rows)
                    {
                        if (item[1].ToString() == "")
                        {
                            item[1] = "0";
                        }
                    }
                    DataTable dt1 = bUS_Static.SumPriceDateTime(time1, time2);
                    foreach (DataRow item in dt1.Rows)
                    {
                        txtTongTien.Text = item[0].ToString();
                    }
                    guna2DataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dayStart.Text = time1;
                    dayEnd.Text = time;
                }
            }
            if (rbTongThe.Checked)
            {
                check = 1;
                rdChart.Visible = true;
                chart1.Series["Total"].Points.Clear();
                guna2DataGridView3.SendToBack();
                guna2DataGridView4.SendToBack();
                string year = dayNow.ToString("yyyy");
                //MessageBox.Show("" + year);
                DataTable dt = new DataTable();
                dt = bUS_Static.StaticOverAllBillsMonth();
                guna2DataGridView1.DataSource = dt;
                guna2DataGridView1.Columns[3].Visible = false;
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Month";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Total";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][0].ToString() != "")
                    {
                        chart1.Series["Total"].Points.AddXY(dt.Rows[i][0], dt.Rows[i][3]);
                    }
                }
                int money = 0;
                for (int i = 0; i < guna2DataGridView1.Rows.Count; i++)
                {
                    if (guna2DataGridView1.Rows[i].Cells[3].Value.ToString() == "")
                    {
                        guna2DataGridView1.Rows[i].Cells[3].Value = "0";
                    }
                    money += int.Parse(guna2DataGridView1.Rows[i].Cells[3].Value.ToString());
                }
                txtTongTien.Text = "" + money;
                guna2DataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

        }
        // click bt năm hóa đơn
        private void btNam_Click(object sender, EventArgs e)
        {
            btEx.Enabled = true;
            btEx1.Enabled = true;
            btEx2.Enabled = true;
            btIn1.Enabled = true;
            btIn2.Enabled = true;
            btIn3.Enabled = true;
            if (rdChiTiet.Checked)
            {
                check = 1;
                guna2DataGridView3.SendToBack();
                guna2DataGridView4.SendToBack();
                string time = dayNow.ToString("yyyy-MM-dd 23:59:59");
                string time2 = dayNow.ToString("dd/MM/yyyy 23:59:59");
                DateTime date = new DateTime(DateTime.Parse(time).Year, DateTime.Parse(time).Month, DateTime.Parse(time).Day);
                DataTable dt = bUS_Static.getDataBillDetailDayOfWeek(date.ToString("yyyy-01-01 00:00:00"), dayNow.ToString("yyyy-MM-dd 23:59:59"));
                guna2DataGridView1.DataSource = dt;
                day1 = date.ToString("yyyy-01-01 00:00:00");
                day2 = dayNow.ToString("yyyy-MM-dd 23:59:59");
                foreach (DataRow item in dt.Rows)
                {
                    if (item[1].ToString() == "")
                    {
                        item[1] = "0";
                    }
                }
                DataTable dt1 = bUS_Static.SumPriceDateTime(date.ToString("yyyy-01-01 00:00:00"), dayNow.ToString("yyyy-MM-dd 23:59:59"));
                foreach (DataRow item in dt1.Rows)
                {
                    txtTongTien.Text = item[0].ToString();
                }
                guna2DataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dayStart.Text = date.ToString("01-01-yyyy");
                dayEnd.Text = dayNow.ToString("yyyy/MM/dd 23:59:59");
            }
            if (rbTongThe.Checked)
            {
                check = 2;
                rdChart.Visible = true;
                guna2DataGridView3.SendToBack();
                guna2DataGridView4.SendToBack();
                chart1.Series["Total"].Points.Clear();
                DataTable dt = bUS_Static.StaticOverAllBillsYears();
                guna2DataGridView1.DataSource = dt;
                float money = 0;
                for (int i = 0; i < guna2DataGridView1.Rows.Count; i++)
                {
                    if (guna2DataGridView1.Rows[i].Cells[3].Value.ToString() == "")
                    {
                        guna2DataGridView1.Rows[i].Cells[3].Value = "0";
                    }
                    money += int.Parse(guna2DataGridView1.Rows[i].Cells[3].Value.ToString());
                }
                txtTongTien.Text = "" + money;
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Years";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Total";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][0].ToString() != "")
                    {
                        chart1.Series["Total"].Points.AddXY(dt.Rows[i][0], dt.Rows[i][3]);
                    }
                }
                guna2DataGridView1.Columns.Remove(guna2DataGridView1.Columns[3]);
                guna2DataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }
        string ngay1 = "2000-01-01 00:00:00";
        string ngay2 = DateTime.Now.ToString("yyyy-MM-dd 23:59:59");
        int kt = 0;
        //load danh sách bill nhập nguyên liệu
        void LoadBillInput()
        {
            DataTable dt = bUS_Static.getAllBillInput();
            guna2DataGridView2.DataSource = dt;
            guna2DataGridView2.Columns[0].HeaderText = "Mã bill";
            guna2DataGridView2.Columns[1].HeaderText = "Tên nhân viên";
            guna2DataGridView2.Columns[2].HeaderText = "Ngày xuất";
            guna2DataGridView2.Columns[3].HeaderText = "Tổng tiền";
            guna2DataGridView2.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataTable dt1 = bUS_Static.getSumPriceBillInput();
            foreach (DataRow item in dt1.Rows)
            {
                txtTongTien1.Text = item[0].ToString();
            }
        }
        // thống kê bill nhập ngyên liệu trong khoảng thời gian
        private void btThongKe1_Click(object sender, EventArgs e)
        {
            dayStar1.Format = DateTimePickerFormat.Custom;
            dayStar1.CustomFormat = "yyyy/MM/dd";
            dayEnd1.Format = DateTimePickerFormat.Custom;
            dayEnd1.CustomFormat = "yyyy/MM/dd 23:59:59";

            string dayStar = dayStar1.Text;
            string dayend = dayEnd1.Text;
            DataTable dt = bUS_Static.getBillInputBetween(dayStar, dayend);
            guna2DataGridView2.DataSource = dt;
            ngay1 = dayStar;
            ngay2 = dayend;
            DataTable dt1 = bUS_Static.SumPriceBillInputBetween(dayStar, dayend);
            foreach (DataRow item in dt1.Rows)
            {
                txtTongTien1.Text = item[0].ToString();
            }

            dayStar1.Format = DateTimePickerFormat.Custom;
            dayStar1.CustomFormat = "dd/MM/yyyy";
            dayEnd1.Format = DateTimePickerFormat.Custom;
            dayEnd1.CustomFormat = "dd/MM/yyyy 23:59:59";
        }
        // click bt tuần bill nhập nguyên liệu
        private void btTuan1_Click(object sender, EventArgs e)
        {
            int dem;
            string time = dayNow.ToString("yyyy-MM-dd 23:59:59");
            string time1 = dayNow.ToString("yyyy-MM-dd 00:00:00");
            DateTime date = new DateTime(DateTime.Parse(time).Year, DateTime.Parse(time).Month, DateTime.Parse(time).Day);
            if (date.DayOfWeek != DayOfWeek.Monday)
            {
                dem = date.DayOfWeek - DayOfWeek.Monday;
                DataTable dt = bUS_Static.getBillInputBetween(date.AddDays(-dem).ToString("yyyy-MM-dd 00:00:00"), time);
                guna2DataGridView2.DataSource = dt;
                DataTable dt1 = bUS_Static.SumPriceBillInputBetween(date.AddDays(-dem).ToString("yyyy-MM-dd 00:00:00"), time);
                foreach (DataRow item in dt1.Rows)
                {
                    txtTongTien1.Text = item[0].ToString();
                }
                dayStar1.Text = date.AddDays(-dem).ToString("yyyy-MM-dd");
                dayEnd1.Text = time;
            }
            else
            {
                DataTable dt = bUS_Static.getBillInputBetween(time1, time);
                guna2DataGridView2.DataSource = dt;
                DataTable dt1 = bUS_Static.SumPriceBillInputBetween(time1, time);
                foreach (DataRow item in dt1.Rows)
                {
                    txtTongTien1.Text = item[0].ToString();
                }
                dayStar1.Text = time1;
                dayEnd1.Text = time;
            }
        }
        // click bt tháng bill nhập nguyên liệu
        private void btThang1_Click(object sender, EventArgs e)
        {
            string time = dayNow.ToString("yyyy/MM/dd 23:59:59");
            string time2 = dayNow.ToString("yyyy-MM-dd 23:59:59");
            string time1 = dayNow.ToString("yyyy-MM-01 00:00:00");
            DateTime date = new DateTime(DateTime.Parse(time).Year, DateTime.Parse(time).Month, DateTime.Parse(time).Day);
            if (date.Day != 1)
            {
                DataTable dt = bUS_Static.getBillInputBetween(date.ToString("yyyy-MM-01 00:00:00"), dayNow.ToString("yyyy-MM-dd 23:59:59"));
                guna2DataGridView2.DataSource = dt;
                ngay1 = date.ToString("yyyy-MM-01 00:00:00");
                ngay2 = dayNow.ToString("yyyy-MM-dd 23:59:59");
                DataTable dt1 = bUS_Static.SumPriceBillInputBetween(date.ToString("yyyy-MM-01 00:00:00"), dayNow.ToString("yyyy-MM-dd 23:59:59"));
                foreach (DataRow item in dt1.Rows)
                {
                    txtTongTien1.Text = item[0].ToString();
                }
            }
            else
            {
                DataTable dt = bUS_Static.getBillInputBetween(time1, time2);
                guna2DataGridView2.DataSource = dt;
                ngay1 = time1;
                ngay2 = time2;
                DataTable dt1 = bUS_Static.SumPriceBillInputBetween(time1, time2);
                foreach (DataRow item in dt1.Rows)
                {
                    txtTongTien1.Text = item[0].ToString();
                }
            }
        }
        // click bt năm bill nhập nguyên liệu
        private void btNam1_Click(object sender, EventArgs e)
        {
            string time = dayNow.ToString("yyyy/MM/dd 23:59:59");
            string time2 = dayNow.ToString("dd/MM/yyyy 23:59:59");
            DateTime date = new DateTime(DateTime.Parse(time).Year, DateTime.Parse(time).Month, DateTime.Parse(time).Day);
            DataTable dt = bUS_Static.getBillInputBetween(date.ToString("yyyy-01-01 00:00:00"), dayNow.ToString("yyyy-MM-dd 23:59:59"));
            guna2DataGridView2.DataSource = dt;
            ngay1 = date.ToString("yyyy-01-01 00:00:00");
            ngay2 = dayNow.ToString("yyyy-MM-dd 23:59:59");
            DataTable dt1 = bUS_Static.SumPriceBillInputBetween(date.ToString("yyyy-01-01 00:00:00"), dayNow.ToString("yyyy-MM-dd 23:59:59"));
            foreach (DataRow item in dt1.Rows)
            {
                txtTongTien1.Text = item[0].ToString();
            }
        }
        // load danh thu tất cả 
        void LoadDanhThu()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataTable dt = bUS_Static.getPrice();
            foreach (DataRow item in dt.Rows)
            {
                if (item[0].ToString() == "")
                {
                    txtTienHoaDon.Text = "0";
                }
                else
                {
                    txtTienHoaDon.Text = item[0].ToString();
                }
            }
            DataTable dt1 = bUS_Static.getSumPriceBillInput();
            foreach (DataRow item in dt1.Rows)
            {
                if (item[0].ToString() == "")
                {
                    txtTienIngredient.Text = "0";
                }
                else
                {
                    txtTienIngredient.Text = item[0].ToString();
                }
            }
            txtDanhThu.Text = "" + (float.Parse(txtTienHoaDon.Text) - float.Parse(txtTienIngredient.Text));
            dataGridView1.Rows.Add(txtTienHoaDon.Text, txtTienIngredient.Text, txtDanhThu.Text);
        }
        // thồng kê nhân viên, khách hàng
        bool perform1 = false;
        private void btTK_Click(object sender, EventArgs e)
        {
            btTK.FillColor = Color.Orange;

            ktMonth = false;
            ktYear = false;
            btEx.Enabled = true;
            btEx1.Enabled = true;
            btEx2.Enabled = true;
            btIn1.Enabled = true;
            btIn2.Enabled = true;
            btIn3.Enabled = true;

            chart1.Visible = false;
            rdChart.Visible = false;
            guna2DataGridView1.SendToBack();
            btEx.SendToBack();
            btIn1.SendToBack();

            check = 0;
            if (perform1 == false)
            {
                //btTuan.SendToBack();
                //btTuan4.SendToBack();
                btThang.SendToBack();
                btThang4.SendToBack();
                btNam.SendToBack();
                btNam4.SendToBack();
                guna2DataGridView4.SendToBack();
                btEx2.SendToBack();
                btIn3.SendToBack();
                guna2DataGridView3.Columns.Clear();
                DataTable dt = bUS_Static.StaticEmployee();
                guna2DataGridView3.DataSource = dt;
                guna2DataGridView3.Columns[0].HeaderText = "Tên nhân viên";
                guna2DataGridView3.Columns[1].HeaderText = "Số lượng hóa đơn";
                guna2DataGridView3.Columns[2].HeaderText = "Tổng tiền hóa đơn";
                guna2DataGridView3.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                guna2DataGridView3.Columns[3].Visible = false;
                float a = 0;
                foreach (DataRow item in dt.Rows)
                {
                    if (item[3].ToString() == "")
                    {
                        item[3] = "0";
                    }
                    a += float.Parse(item[3].ToString());
                    txtTongTien.Text = "" + a;
                }
                btTK.Text = "Nhân viên";
                perform1 = true;
            }
            else
            {
                //btTuan.SendToBack();
                //btTuan3.SendToBack();
                btThang.SendToBack();
                btThang3.SendToBack();
                btNam.SendToBack();
                btNam3.SendToBack();
                guna2DataGridView3.SendToBack();
                btEx1.SendToBack();
                btIn2.SendToBack();
                guna2DataGridView4.Columns.Clear();
                DataTable dt = bUS_Static.StaticCustomer();
                guna2DataGridView4.DataSource = dt;
                guna2DataGridView4.Columns[0].HeaderText = "Tên khách hàng";
                guna2DataGridView4.Columns[1].HeaderText = "Số lượng sản phẩm";
                guna2DataGridView4.Columns[2].HeaderText = "Tổng tiền hóa đơn";
                guna2DataGridView4.Columns[3].Visible = false;
                float a = 0;
                foreach (DataRow item in dt.Rows)
                {
                    if (item[3].ToString() == "")
                    {
                        item[3] = "0";
                    }
                    a += float.Parse(item[3].ToString());
                    txtTongTien.Text = "" + a;
                }
                btTK.Text = "Khách hàng";
                guna2DataGridView4.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                perform1 = false;
            }
            DataTable dt1 = bUS_Static.getPrice();

        }
        // thống kê nhân viên theo tháng
        private void btThang3_Click(object sender, EventArgs e)
        {
            check = 1;
            btEx.Enabled = true;
            btEx1.Enabled = true;
            btEx2.Enabled = true;
            btIn1.Enabled = true;
            btIn2.Enabled = true;
            btIn3.Enabled = true;
            ktMonth = true;
            ktYear = false;

            for (int i = 0; i < guna2DataGridView3.Columns.Count; i++)
            {
                guna2DataGridView3.Columns.RemoveAt(i);
            }
            DataTable dt = bUS_Static.StaticEmployeeWeek();
            guna2DataGridView3.DataSource = dt;
            float money = 0;
            foreach (DataRow item in dt.Rows)
            {
                if (item[5].ToString() == "")
                {
                    item[5] = "0";
                }
                money += float.Parse(item[5].ToString());
            }
            guna2DataGridView3.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            guna2DataGridView3.Columns[5].Visible = false;
            txtTongTien.Text = "" + money;
        }
        // thống kê khách hàng theo tháng
        private void btThang4_Click(object sender, EventArgs e)
        {
            check = 1;
            btEx.Enabled = true;
            btEx1.Enabled = true;
            btEx2.Enabled = true;
            btIn1.Enabled = true;
            btIn2.Enabled = true;
            btIn3.Enabled = true;
            ktMonth = true;
            ktYear = false;

            for (int i = 0; i < guna2DataGridView4.Columns.Count; i++)
            {
                guna2DataGridView4.Columns.RemoveAt(i);
            }
            DataTable dt = bUS_Static.StaticCustomerMonth();
            guna2DataGridView4.DataSource = dt;
            float money = 0;
            foreach (DataRow item in dt.Rows)
            {
                if (item[5].ToString() == "")
                {
                    item[5] = "0";
                }
                money += float.Parse(item[5].ToString());
            }
            guna2DataGridView4.Columns[5].Visible = false;
            guna2DataGridView4.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            txtTongTien.Text = "" + money;
        }
        // thống kê nhân viên theo năm
        private void btNam3_Click(object sender, EventArgs e)
        {
            check = 2;
            ktMonth = false;
            ktYear = true;
            btEx.Enabled = true;
            btEx1.Enabled = true;
            btEx2.Enabled = true;
            btIn1.Enabled = true;
            btIn2.Enabled = true;
            btIn3.Enabled = true;

            for (int i = 0; i < guna2DataGridView3.Columns.Count; i++)
            {
                guna2DataGridView3.Columns.RemoveAt(i);
            }
            DataTable dt = bUS_Static.StaticEmployeeYears();
            guna2DataGridView3.DataSource = dt;
            float money = 0;
            foreach (DataRow item in dt.Rows)
            {
                if (item[5].ToString() == "")
                {
                    item[5] = "0";
                }
                money += float.Parse(item[5].ToString());
            }
            guna2DataGridView3.Columns[5].Visible = false;
            guna2DataGridView3.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            txtTongTien.Text = "" + money;
        }
        // thống kê khách hàng theo năm
        private void btNam4_Click(object sender, EventArgs e)
        {
            check = 2;
            btEx.Enabled = true;
            btEx1.Enabled = true;
            btEx2.Enabled = true;
            btIn1.Enabled = true;
            btIn2.Enabled = true;
            btIn3.Enabled = true;
            ktYear = true;
            ktMonth = false;

            for (int i = 0; i < guna2DataGridView4.Columns.Count; i++)
            {
                guna2DataGridView4.Columns.RemoveAt(i);
            }
            DataTable dt = bUS_Static.StaticCustomerYears();
            guna2DataGridView4.DataSource = dt;
            float money = 0;
            foreach (DataRow item in dt.Rows)
            {
                if (item[5].ToString() == "")
                {
                    item[5] = "0";
                }
                money += float.Parse(item[5].ToString());
            }
            guna2DataGridView4.Columns[5].Visible = false;
            guna2DataGridView4.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            txtTongTien.Text = "" + money;
        }

        // Xuất excel hóa đơn chi tiết
        private void btEx_Click_1(object sender, EventArgs e)
        {
            if (rdChiTiet.Checked)
            {
                DataTable dt = (DataTable)guna2DataGridView1.DataSource;
                Export(dt, "Danh sach", "DANH SÁCH HÓA ĐƠN");
            }
            if (rbTongThe.Checked)
            {
                //guna2DataGridView1.Columns.Remove(guna2DataGridView1.Columns[3]);
                DataTable dt = (DataTable)guna2DataGridView1.DataSource;
                dt.Columns.RemoveAt(3);
                Export(dt, "Danh sach", "DANH SÁCH HÓA ĐƠN");
            }
        }
        bool ktMonth = false;
        bool ktYear = false;
        // xuất excel hóa đơn theo khách hàng
        private void btEx2_Click(object sender, EventArgs e)
        {
            if (ktMonth == false && ktYear == false)
            {
                DataTable dt = (DataTable)guna2DataGridView4.DataSource;
                dt.Columns.RemoveAt(3);
                Export2(dt, "Danh sach", "DANH SÁCH HÓA ĐƠN THEO KHÁCH HÀNG");
            }
            else
            {
                DataTable dt = (DataTable)guna2DataGridView4.DataSource;
                dt.Columns.RemoveAt(5);
                Export2(dt, "Danh sach", "DANH SÁCH HÓA ĐƠN THEO KHÁCH HÀNG");
            }
        }
        // xuất excel hóa đơn theo nhân viên
        private void btEx1_Click(object sender, EventArgs e)
        {
            if (ktMonth == false && ktYear == false)
            {
                DataTable dt = (DataTable)guna2DataGridView3.DataSource;
                dt.Columns.RemoveAt(3);
                Export1(dt, "Danh sach", "DANH SÁCH HÓA ĐƠN THEO NHÂN VIÊN");
            }
            else
            {
                DataTable dt = (DataTable)guna2DataGridView3.DataSource;
                dt.Columns.RemoveAt(5);
                Export1(dt, "Danh sach", "DANH SÁCH HÓA ĐƠN THEO NHÂN VIÊN");
            }
        }
        public void Export(DataTable dt, string sheetName, string title)
        {

            if (rdChiTiet.Checked)
            {
                //Tạo các đối tượng Excel

                Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

                Microsoft.Office.Interop.Excel.Workbooks oBooks;

                Microsoft.Office.Interop.Excel.Sheets oSheets;

                Microsoft.Office.Interop.Excel.Workbook oBook;

                Microsoft.Office.Interop.Excel.Worksheet oSheet;

                //Tạo mới một Excel WorkBook 

                oExcel.Visible = true;

                oExcel.DisplayAlerts = false;

                oExcel.Application.SheetsInNewWorkbook = 1;

                oBooks = oExcel.Workbooks;

                oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

                oSheets = oBook.Worksheets;

                oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

                oSheet.Name = sheetName;

                // Tạo phần đầu nếu muốn

                Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "C1");

                head.MergeCells = true;

                head.Value2 = title;

                head.Font.Bold = true;

                head.Font.Name = "Tahoma";

                head.Font.Size = "18";

                head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                //Microsoft.Office.Interop.Excel.PictureFormat a = oSheet.
                // Tạo tiêu đề cột 

                Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

                cl1.Value2 = "Nhân viên";

                cl1.ColumnWidth = 25;
                cl1.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight;

                Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

                cl2.Value2 = "Mã khách hàng";

                cl2.ColumnWidth = 13;
                cl2.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight;

                Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

                cl3.Value2 = "Mã bill";

                cl3.ColumnWidth = 13;
                cl3.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight;

                Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

                cl4.Value2 = "Mã bàn";

                cl4.ColumnWidth = 13;
                cl4.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight;

                Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

                cl5.Value2 = "Ngày tạo";

                cl5.ColumnWidth = 25;
                cl5.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight;

                Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

                cl6.Value2 = "Ngày xuất";

                cl6.ColumnWidth = 25;
                cl6.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight;

                Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

                cl7.Value2 = "Tổng tiền";

                cl7.ColumnWidth = 20;
                cl7.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft;

                Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "G3");

                rowHead.Font.Bold = true;

                // Kẻ viền

                rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Thiết lập màu nền

                rowHead.Interior.ColorIndex = 15;

                rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,

                // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.

                object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];

                //Chuyển dữ liệu từ DataTable vào mảng đối tượng

                for (int r = 0; r < dt.Rows.Count; r++)

                {

                    DataRow dr = dt.Rows[r];

                    for (int c = 0; c < dt.Columns.Count; c++)

                    {
                        arr[r, c] = dr[c];
                    }
                }

                //Thiết lập vùng điền dữ liệu

                int rowStart = 4;

                int columnStart = 1;

                int rowEnd = rowStart + dt.Rows.Count - 1;

                int columnEnd = dt.Columns.Count;

                // Ô bắt đầu điền dữ liệu

                Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

                // Ô kết thúc điền dữ liệu

                Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

                // Lấy về vùng điền dữ liệu

                Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

                //Điền dữ liệu vào vùng đã thiết lập

                range.Value2 = arr;

                // Kẻ viền

                range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Căn giữa cột STT

                Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

                Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

                oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
            }
            if (rbTongThe.Checked)
            {
                //Tạo các đối tượng Excel

                Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

                Microsoft.Office.Interop.Excel.Workbooks oBooks;

                Microsoft.Office.Interop.Excel.Sheets oSheets;

                Microsoft.Office.Interop.Excel.Workbook oBook;

                Microsoft.Office.Interop.Excel.Worksheet oSheet;

                //Tạo mới một Excel WorkBook 

                oExcel.Visible = true;

                oExcel.DisplayAlerts = false;

                oExcel.Application.SheetsInNewWorkbook = 1;

                oBooks = oExcel.Workbooks;

                oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

                oSheets = oBook.Worksheets;

                oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

                oSheet.Name = sheetName;

                // Tạo phần đầu nếu muốn

                Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "C1");

                head.MergeCells = true;

                head.Value2 = title;

                head.Font.Bold = true;

                head.Font.Name = "Tahoma";

                head.Font.Size = "18";

                head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo tiêu đề cột 

                Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

                cl1.Value2 = "Tháng(Năm)";

                cl1.ColumnWidth = 25;

                Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

                cl2.Value2 = "Tổng số bill";

                cl2.ColumnWidth = 25.0;

                Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

                cl3.Value2 = "Tổng tiền";

                cl3.ColumnWidth = 40.0;

                Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "C3");

                rowHead.Font.Bold = true;

                // Kẻ viền

                rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Thiết lập màu nền

                rowHead.Interior.ColorIndex = 15;

                rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,

                // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.

                object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];

                //Chuyển dữ liệu từ DataTable vào mảng đối tượng

                for (int r = 0; r < dt.Rows.Count; r++)

                {

                    DataRow dr = dt.Rows[r];

                    for (int c = 0; c < dt.Columns.Count; c++)

                    {
                        arr[r, c] = dr[c];
                    }
                }

                //Thiết lập vùng điền dữ liệu

                int rowStart = 4;

                int columnStart = 1;

                int rowEnd = rowStart + dt.Rows.Count - 1;

                int columnEnd = dt.Columns.Count;

                // Ô bắt đầu điền dữ liệu

                Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

                // Ô kết thúc điền dữ liệu

                Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

                // Lấy về vùng điền dữ liệu

                Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

                //Điền dữ liệu vào vùng đã thiết lập

                range.Value2 = arr;

                // Kẻ viền

                range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Căn giữa cột STT

                Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

                Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

                oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
            }
        }
        public void Export1(DataTable dt, string sheetName, string title)
        {
            if (ktMonth == false && ktYear == false)
            {
                //Tạo các đối tượng Excel

                Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

                Microsoft.Office.Interop.Excel.Workbooks oBooks;

                Microsoft.Office.Interop.Excel.Sheets oSheets;

                Microsoft.Office.Interop.Excel.Workbook oBook;

                Microsoft.Office.Interop.Excel.Worksheet oSheet;

                //Tạo mới một Excel WorkBook 

                oExcel.Visible = true;

                oExcel.DisplayAlerts = false;

                oExcel.Application.SheetsInNewWorkbook = 1;

                oBooks = oExcel.Workbooks;

                oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

                oSheets = oBook.Worksheets;

                oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

                oSheet.Name = sheetName;

                // Tạo phần đầu nếu muốn

                Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "C1");

                head.MergeCells = true;

                head.Value2 = title;

                head.Font.Bold = true;

                head.Font.Name = "Tahoma";

                head.Font.Size = "18";

                head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo tiêu đề cột 

                Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

                cl1.Value2 = "Nhân viên";

                cl1.ColumnWidth = 25;

                Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

                cl2.Value2 = "Số lượng hóa đơn";

                cl2.ColumnWidth = 25.0;

                Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

                cl3.Value2 = "Tổng tiền hóa đơn";

                cl3.ColumnWidth = 40.0;

                Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "C3");

                rowHead.Font.Bold = true;

                // Kẻ viền

                rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Thiết lập màu nền

                rowHead.Interior.ColorIndex = 15;

                rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,

                // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.

                object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];

                //Chuyển dữ liệu từ DataTable vào mảng đối tượng

                for (int r = 0; r < dt.Rows.Count; r++)

                {

                    DataRow dr = dt.Rows[r];

                    for (int c = 0; c < dt.Columns.Count; c++)

                    {
                        arr[r, c] = dr[c];
                    }
                }

                //Thiết lập vùng điền dữ liệu

                int rowStart = 4;

                int columnStart = 1;

                int rowEnd = rowStart + dt.Rows.Count - 1;

                int columnEnd = dt.Columns.Count;

                // Ô bắt đầu điền dữ liệu

                Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

                // Ô kết thúc điền dữ liệu

                Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

                // Lấy về vùng điền dữ liệu

                Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

                //Điền dữ liệu vào vùng đã thiết lập

                range.Value2 = arr;

                // Kẻ viền

                range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Căn giữa cột STT

                Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

                Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

                oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
            }
            if (ktMonth == true)
            {
                //Tạo các đối tượng Excel

                Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

                Microsoft.Office.Interop.Excel.Workbooks oBooks;

                Microsoft.Office.Interop.Excel.Sheets oSheets;

                Microsoft.Office.Interop.Excel.Workbook oBook;

                Microsoft.Office.Interop.Excel.Worksheet oSheet;

                //Tạo mới một Excel WorkBook 

                oExcel.Visible = true;

                oExcel.DisplayAlerts = false;

                oExcel.Application.SheetsInNewWorkbook = 1;

                oBooks = oExcel.Workbooks;

                oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

                oSheets = oBook.Worksheets;

                oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

                oSheet.Name = sheetName;

                // Tạo phần đầu nếu muốn

                Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "C1");

                head.MergeCells = true;

                head.Value2 = title;

                head.Font.Bold = true;

                head.Font.Name = "Tahoma";

                head.Font.Size = "18";

                head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo tiêu đề cột 

                Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

                cl1.Value2 = "Tháng";

                cl1.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

                cl2.Value2 = "Mã nhân viên";

                cl2.ColumnWidth = 15;

                Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

                cl3.Value2 = "Tên nhân viên";

                cl3.ColumnWidth = 30;

                Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

                cl4.Value2 = "Tổng số bill";

                cl4.ColumnWidth = 15;

                Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

                cl5.Value2 = "Tổng tiền";

                cl5.ColumnWidth = 30;

                Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "E3");

                rowHead.Font.Bold = true;

                // Kẻ viền

                rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Thiết lập màu nền

                rowHead.Interior.ColorIndex = 15;

                rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,

                // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.

                object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];

                //Chuyển dữ liệu từ DataTable vào mảng đối tượng

                for (int r = 0; r < dt.Rows.Count; r++)

                {

                    DataRow dr = dt.Rows[r];

                    for (int c = 0; c < dt.Columns.Count; c++)

                    {
                        arr[r, c] = dr[c];
                    }
                }

                //Thiết lập vùng điền dữ liệu

                int rowStart = 4;

                int columnStart = 1;

                int rowEnd = rowStart + dt.Rows.Count - 1;

                int columnEnd = dt.Columns.Count;

                // Ô bắt đầu điền dữ liệu

                Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

                // Ô kết thúc điền dữ liệu

                Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

                // Lấy về vùng điền dữ liệu

                Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

                //Điền dữ liệu vào vùng đã thiết lập

                range.Value2 = arr;

                // Kẻ viền

                range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Căn giữa cột STT

                Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

                Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

                oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
            }
            if (ktYear == true)
            {
                //Tạo các đối tượng Excel

                Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

                Microsoft.Office.Interop.Excel.Workbooks oBooks;

                Microsoft.Office.Interop.Excel.Sheets oSheets;

                Microsoft.Office.Interop.Excel.Workbook oBook;

                Microsoft.Office.Interop.Excel.Worksheet oSheet;

                //Tạo mới một Excel WorkBook 

                oExcel.Visible = true;

                oExcel.DisplayAlerts = false;

                oExcel.Application.SheetsInNewWorkbook = 1;

                oBooks = oExcel.Workbooks;

                oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

                oSheets = oBook.Worksheets;

                oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

                oSheet.Name = sheetName;

                // Tạo phần đầu nếu muốn

                Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "C1");

                head.MergeCells = true;

                head.Value2 = title;

                head.Font.Bold = true;

                head.Font.Name = "Tahoma";

                head.Font.Size = "18";

                head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo tiêu đề cột 

                Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

                cl1.Value2 = "Năm";

                cl1.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

                cl2.Value2 = "Mã nhân viên";

                cl2.ColumnWidth = 15;

                Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

                cl3.Value2 = "Tên nhân viên";

                cl3.ColumnWidth = 30;

                Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

                cl4.Value2 = "Tổng số bill";

                cl4.ColumnWidth = 15;

                Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

                cl5.Value2 = "Tổng tiền";

                cl5.ColumnWidth = 30;

                Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "E3");

                rowHead.Font.Bold = true;

                // Kẻ viền

                rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Thiết lập màu nền

                rowHead.Interior.ColorIndex = 15;

                rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,

                // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.

                object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];

                //Chuyển dữ liệu từ DataTable vào mảng đối tượng

                for (int r = 0; r < dt.Rows.Count; r++)

                {

                    DataRow dr = dt.Rows[r];

                    for (int c = 0; c < dt.Columns.Count; c++)

                    {
                        arr[r, c] = dr[c];
                    }
                }

                //Thiết lập vùng điền dữ liệu

                int rowStart = 4;

                int columnStart = 1;

                int rowEnd = rowStart + dt.Rows.Count - 1;

                int columnEnd = dt.Columns.Count;

                // Ô bắt đầu điền dữ liệu

                Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

                // Ô kết thúc điền dữ liệu

                Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

                // Lấy về vùng điền dữ liệu

                Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

                //Điền dữ liệu vào vùng đã thiết lập

                range.Value2 = arr;

                // Kẻ viền

                range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Căn giữa cột STT

                Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

                Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

                oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
            }

        }
        public void Export2(DataTable dt, string sheetName, string title)
        {

            if (ktMonth == false && ktYear == false)
            {
                //Tạo các đối tượng Excel

                Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

                Microsoft.Office.Interop.Excel.Workbooks oBooks;

                Microsoft.Office.Interop.Excel.Sheets oSheets;

                Microsoft.Office.Interop.Excel.Workbook oBook;

                Microsoft.Office.Interop.Excel.Worksheet oSheet;

                //Tạo mới một Excel WorkBook 

                oExcel.Visible = true;

                oExcel.DisplayAlerts = false;

                oExcel.Application.SheetsInNewWorkbook = 1;

                oBooks = oExcel.Workbooks;

                oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

                oSheets = oBook.Worksheets;

                oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

                oSheet.Name = sheetName;

                // Tạo phần đầu nếu muốn

                Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "C1");

                head.MergeCells = true;

                head.Value2 = title;

                head.Font.Bold = true;

                head.Font.Name = "Tahoma";

                head.Font.Size = "18";

                head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo tiêu đề cột 

                Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

                cl1.Value2 = "Khách hàng";

                cl1.ColumnWidth = 25;

                Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

                cl2.Value2 = "Số lượng hóa đơn";

                cl2.ColumnWidth = 25.0;

                Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

                cl3.Value2 = "Tổng tiền hóa đơn";

                cl3.ColumnWidth = 40.0;

                Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "C3");

                rowHead.Font.Bold = true;

                // Kẻ viền

                rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Thiết lập màu nền

                rowHead.Interior.ColorIndex = 15;

                rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,

                // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.

                object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];

                //Chuyển dữ liệu từ DataTable vào mảng đối tượng

                for (int r = 0; r < dt.Rows.Count; r++)

                {

                    DataRow dr = dt.Rows[r];

                    for (int c = 0; c < dt.Columns.Count; c++)

                    {
                        arr[r, c] = dr[c];
                    }
                }

                //Thiết lập vùng điền dữ liệu

                int rowStart = 4;

                int columnStart = 1;

                int rowEnd = rowStart + dt.Rows.Count - 1;

                int columnEnd = dt.Columns.Count;

                // Ô bắt đầu điền dữ liệu

                Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

                // Ô kết thúc điền dữ liệu

                Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

                // Lấy về vùng điền dữ liệu

                Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

                //Điền dữ liệu vào vùng đã thiết lập

                range.Value2 = arr;

                // Kẻ viền

                range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Căn giữa cột STT

                Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

                Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

                oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
            }
            if (ktMonth == true)
            {
                //Tạo các đối tượng Excel

                Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

                Microsoft.Office.Interop.Excel.Workbooks oBooks;

                Microsoft.Office.Interop.Excel.Sheets oSheets;

                Microsoft.Office.Interop.Excel.Workbook oBook;

                Microsoft.Office.Interop.Excel.Worksheet oSheet;

                //Tạo mới một Excel WorkBook 

                oExcel.Visible = true;

                oExcel.DisplayAlerts = false;

                oExcel.Application.SheetsInNewWorkbook = 1;

                oBooks = oExcel.Workbooks;

                oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

                oSheets = oBook.Worksheets;

                oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

                oSheet.Name = sheetName;

                // Tạo phần đầu nếu muốn

                Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "C1");

                head.MergeCells = true;

                head.Value2 = title;

                head.Font.Bold = true;

                head.Font.Name = "Tahoma";

                head.Font.Size = "18";

                head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo tiêu đề cột 

                Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

                cl1.Value2 = "Tháng";

                cl1.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

                cl2.Value2 = "Mã khách hàng";

                cl2.ColumnWidth = 15;

                Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

                cl3.Value2 = "Tên khách hàng";

                cl3.ColumnWidth = 30;

                Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

                cl4.Value2 = "Tổng hóa đơn";

                cl4.ColumnWidth = 15;

                Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

                cl5.Value2 = "Tổng tiền";

                cl5.ColumnWidth = 30;

                Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "E3");

                rowHead.Font.Bold = true;

                // Kẻ viền

                rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Thiết lập màu nền

                rowHead.Interior.ColorIndex = 15;

                rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,

                // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.

                object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];

                //Chuyển dữ liệu từ DataTable vào mảng đối tượng

                for (int r = 0; r < dt.Rows.Count; r++)

                {

                    DataRow dr = dt.Rows[r];

                    for (int c = 0; c < dt.Columns.Count; c++)

                    {
                        arr[r, c] = dr[c];
                    }
                }

                //Thiết lập vùng điền dữ liệu

                int rowStart = 4;

                int columnStart = 1;

                int rowEnd = rowStart + dt.Rows.Count - 1;

                int columnEnd = dt.Columns.Count;

                // Ô bắt đầu điền dữ liệu

                Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

                // Ô kết thúc điền dữ liệu

                Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

                // Lấy về vùng điền dữ liệu

                Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

                //Điền dữ liệu vào vùng đã thiết lập

                range.Value2 = arr;

                // Kẻ viền

                range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Căn giữa cột STT

                Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

                Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

                oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
            }
            if (ktYear == true)
            {
                //Tạo các đối tượng Excel

                Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

                Microsoft.Office.Interop.Excel.Workbooks oBooks;

                Microsoft.Office.Interop.Excel.Sheets oSheets;

                Microsoft.Office.Interop.Excel.Workbook oBook;

                Microsoft.Office.Interop.Excel.Worksheet oSheet;

                //Tạo mới một Excel WorkBook 

                oExcel.Visible = true;

                oExcel.DisplayAlerts = false;

                oExcel.Application.SheetsInNewWorkbook = 1;

                oBooks = oExcel.Workbooks;

                oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

                oSheets = oBook.Worksheets;

                oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

                oSheet.Name = sheetName;

                // Tạo phần đầu nếu muốn

                Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "C1");

                head.MergeCells = true;

                head.Value2 = title;

                head.Font.Bold = true;

                head.Font.Name = "Tahoma";

                head.Font.Size = "18";

                head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo tiêu đề cột 

                Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

                cl1.Value2 = "Năm";

                cl1.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

                cl2.Value2 = "Mã khách hàng";

                cl2.ColumnWidth = 15;

                Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

                cl3.Value2 = "Tên khách hàng";

                cl3.ColumnWidth = 30;

                Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

                cl4.Value2 = "Tổng số bill";

                cl4.ColumnWidth = 15;

                Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

                cl5.Value2 = "Tổng tiền";

                cl5.ColumnWidth = 30;

                Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "E3");

                rowHead.Font.Bold = true;

                // Kẻ viền

                rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Thiết lập màu nền

                rowHead.Interior.ColorIndex = 15;

                rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,

                // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.

                object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];

                //Chuyển dữ liệu từ DataTable vào mảng đối tượng

                for (int r = 0; r < dt.Rows.Count; r++)

                {

                    DataRow dr = dt.Rows[r];

                    for (int c = 0; c < dt.Columns.Count; c++)

                    {
                        arr[r, c] = dr[c];
                    }
                }

                //Thiết lập vùng điền dữ liệu

                int rowStart = 4;

                int columnStart = 1;

                int rowEnd = rowStart + dt.Rows.Count - 1;

                int columnEnd = dt.Columns.Count;

                // Ô bắt đầu điền dữ liệu

                Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

                // Ô kết thúc điền dữ liệu

                Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

                // Lấy về vùng điền dữ liệu

                Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

                //Điền dữ liệu vào vùng đã thiết lập

                range.Value2 = arr;

                // Kẻ viền

                range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Căn giữa cột STT

                Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

                Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

                oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
            }
        }
        //In pdf hóa đơn
        Bitmap btm;
        Image image = Image.FromFile(Application.StartupPath + "\\Images\\pictureBox1.Image.jpg");
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (rdChiTiet.Checked)
            {
                DataTable dt = new DataTable();
                dt = bUS_Static.getDataBillDetailDayOfWeek(day1, day2);
                CrystalReport1 crystalReport1 = new CrystalReport1();
                crystalReport1.SetDataSource(dt);
                Report report = new Report();
                report.crystalReportViewer1.ReportSource = crystalReport1;
                report.ShowDialog();
            }
            if (rbTongThe.Checked)
            {
                if(check == 0)
                {
                    DataTable dt = new DataTable();
                    dt = bUS_Static.StaticOverAllDate(day1, day2);
                    CrystalReport2 crystalReport1 = new CrystalReport2();
                    crystalReport1.SetDataSource(dt);
                    Report report = new Report();
                    report.crystalReportViewer1.ReportSource = crystalReport1;
                    report.ShowDialog();
                }
                if(check == 1)
                {
                    DataTable dt = new DataTable();
                    dt = bUS_Static.StaticOverAllBillsMonth();
                    CrystalReport3 crystalReport1 = new CrystalReport3();
                    crystalReport1.SetDataSource(dt);
                    Report report = new Report();
                    report.crystalReportViewer1.ReportSource = crystalReport1;
                    report.ShowDialog();
                }
                if(check == 2)
                {
                    DataTable dt = new DataTable();
                    dt = bUS_Static.StaticOverAllBillsYears();
                    CrystalReport4 crystalReport1 = new CrystalReport4();
                    crystalReport1.SetDataSource(dt);
                    Report report = new Report();
                    report.crystalReportViewer1.ReportSource = crystalReport1;
                    report.ShowDialog();
                }
            }
            //if (guna2DataGridView1.Rows.Count > 1)
            //{
            //    int height = guna2DataGridView1.Height;
            //    guna2DataGridView1.Width = 810;
            //    guna2DataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 7, FontStyle.Regular);
            //    guna2DataGridView1.Height = guna2DataGridView1.RowCount * guna2DataGridView1.RowTemplate.Height * 2;
            //    btm = new Bitmap(guna2DataGridView1.Width, guna2DataGridView1.Height);
            //    guna2DataGridView1.DrawToBitmap(btm, new Rectangle(0, 0, guna2DataGridView1.Width, guna2DataGridView1.Height));
            //    guna2DataGridView1.Height = height;

            //    printPreviewDialog1.ShowDialog();

            //    guna2DataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            //    guna2DataGridView1.Width = 1011;
            //}
            //else
            //{
            //    MessageBox.Show("Không có dữ liệu cần in");
            //}
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (rdChiTiet.Checked)
            {
                DataTable a = (DataTable)guna2DataGridView1.DataSource;
                e.Graphics.DrawImageUnscaled(image, 30, 10);
                e.Graphics.DrawString("SHOP META", new Font("Arial", 22, FontStyle.Bold), Brushes.Black, new Point(330, 60));
                e.Graphics.DrawString("THỐNG KÊ CHI TIẾT HÓA ĐƠN", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(280, 120));
                e.Graphics.DrawString("Ngày xuất: " + DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(550, 200));
                e.Graphics.DrawString("_____________________________________________________________________________________________________________________________________", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(0, 205));
                e.Graphics.DrawImageUnscaled(btm, 0, 230);

            }
            if (rbTongThe.Checked)
            {
                DataTable a = (DataTable)guna2DataGridView1.DataSource;
                e.Graphics.DrawImageUnscaled(image, 30, 10);
                e.Graphics.DrawString("SHOP META", new Font("Arial", 22, FontStyle.Bold), Brushes.Black, new Point(330, 60));
                e.Graphics.DrawString("THỐNG KÊ TỔNG THỂ HÓA ĐƠN", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(280, 120));
                e.Graphics.DrawString("Ngày xuất: " + DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(550, 200));
                e.Graphics.DrawString("_____________________________________________________________________________________________________________________________________", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(0, 205));
                e.Graphics.DrawImageUnscaled(btm, 0, 230);
            }
        }
        private void btThang2_Click(object sender, EventArgs e)
        {
            string time = dayNow.ToString("yyyy-MM-dd 23:59:59");
            string time2 = dayNow.ToString("yyyy-MM-dd 23:59:59");
            string time1 = dayNow.ToString("yyyy-MM-dd 00:00:00");
            DateTime date = new DateTime(DateTime.Parse(time).Year, DateTime.Parse(time).Month, DateTime.Parse(time).Day);
            if (date.Day != 1)
            {
                DataTable dt1 = bUS_Static.SumPriceBillInputBetween(date.ToString("yyyy-MM-01 00:00:00"), time2);
                foreach (DataRow item in dt1.Rows)
                {
                    if (item[0].ToString() == "")
                    {
                        txtTienIngredient.Text = "0";
                    }
                    else
                    {
                        txtTienIngredient.Text = item[0].ToString();
                    }
                }
                DataTable dt = bUS_Static.SumPriceDateTime(date.ToString("yyyy-MM-01 00:00:00"), time2);
                foreach (DataRow item in dt.Rows)
                {
                    if (item[0].ToString() == "")
                    {
                        txtTienHoaDon.Text = "0";
                    }
                    else
                    {
                        txtTienHoaDon.Text = item[0].ToString();
                    }
                }
            }
            else
            {
                DataTable dt1 = bUS_Static.SumPriceBillInputBetween(time1, time2);
                foreach (DataRow item in dt1.Rows)
                {
                    if (item[0].ToString() == "")
                    {
                        txtTienIngredient.Text = "0";
                    }
                    else
                    {
                        txtTienIngredient.Text = item[0].ToString();
                    }
                }
                DataTable dt = bUS_Static.SumPriceDateTime(time1, time2);
                foreach (DataRow item in dt.Rows)
                {
                    if (item[0].ToString() == "")
                    {
                        txtTienHoaDon.Text = "0";
                    }
                    else
                    {
                        txtTienHoaDon.Text = item[0].ToString();
                    }
                }
            }
            txtDanhThu.Text = "" + (float.Parse(txtTienHoaDon.Text) - float.Parse(txtTienIngredient.Text));
            dayStar2.Text = "" + date.ToString("yyyy/MM/01");
            dayEnd2.Text = "" + date;
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(txtTienHoaDon.Text, txtTienIngredient.Text, txtDanhThu.Text);
            chart2.Series["Tổng tiền hóa đơn"].Points.Clear();
            chart2.Series["Tổng tiền nguyên liệu"].Points.Clear();
            chart2.Series["Danh thu"].Points.Clear();
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("", typeof(string));
            dt2.Columns.Add("", typeof(string));
            dt2.Columns.Add("", typeof(string));
            dt2.Rows.Add(dataGridView1.Rows[0].Cells[0].Value.ToString(), dataGridView1.Rows[0].Cells[1].Value.ToString(), dataGridView1.Rows[0].Cells[2].Value.ToString());
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                chart2.Series["Tổng tiền hóa đơn"].Points.AddY(dt2.Rows[i][0]);
                chart2.Series["Tổng tiền nguyên liệu"].Points.AddY(dt2.Rows[i][1]);
                chart2.Series["Danh thu"].Points.AddY(dt2.Rows[i][2]);
            }
        }

        private void btNam2_Click(object sender, EventArgs e)
        {
            string time = dayNow.ToString("yyyy-MM-dd 23:59:59");
            string time1 = dayNow.ToString("yyyy-MM-dd 23:59:59");
            DateTime date = new DateTime(DateTime.Parse(time).Year, DateTime.Parse(time).Month, DateTime.Parse(time).Day);
            DataTable dt1 = bUS_Static.SumPriceBillInputBetween(date.ToString("yyyy-01-01 00:00:00"), time1);
            foreach (DataRow item in dt1.Rows)
            {
                if (item[0].ToString() == "")
                {
                    txtTienIngredient.Text = "0";
                }
                else
                {
                    txtTienIngredient.Text = item[0].ToString();
                }
            }
            DataTable dt = bUS_Static.SumPriceDateTime(date.ToString("yyyy-01-01 00:00:00"), time1);
            foreach (DataRow item in dt.Rows)
            {
                if (item[0].ToString() == "")
                {
                    txtTienHoaDon.Text = "0";
                }
                else
                {
                    txtTienHoaDon.Text = item[0].ToString();
                }
            }
            txtDanhThu.Text = "" + (float.Parse(txtTienHoaDon.Text) - float.Parse(txtTienIngredient.Text));
            dayStar2.Text = "" + date.ToString("yyyy/01/01");
            dayEnd2.Text = "" + date;
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(txtTienHoaDon.Text, txtTienIngredient.Text, txtDanhThu.Text);
            DataTable dt2 = new DataTable();
            chart2.Series["Tổng tiền hóa đơn"].Points.Clear();
            chart2.Series["Tổng tiền nguyên liệu"].Points.Clear();
            chart2.Series["Danh thu"].Points.Clear();
            dt2.Columns.Add("", typeof(string));
            dt2.Columns.Add("", typeof(string));
            dt2.Columns.Add("", typeof(string));
            dt2.Rows.Add(dataGridView1.Rows[0].Cells[0].Value.ToString(), dataGridView1.Rows[0].Cells[1].Value.ToString(), dataGridView1.Rows[0].Cells[2].Value.ToString());
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                chart2.Series["Tổng tiền hóa đơn"].Points.AddY(dt2.Rows[i][0]);
                chart2.Series["Tổng tiền nguyên liệu"].Points.AddY(dt2.Rows[i][1]);
                chart2.Series["Danh thu"].Points.AddY(dt2.Rows[i][2]);
            }
        }

        private void btThongKe2_Click(object sender, EventArgs e)
        {
            dayStar2.Format = DateTimePickerFormat.Custom;
            dayStar2.CustomFormat = "yyyy-MM-dd 00:00:00";
            dayEnd2.Format = DateTimePickerFormat.Custom;
            dayEnd2.CustomFormat = "yyyy-MM-dd 23:59:59";

            string dayStar = dayStar2.Text;
            string dayend = dayEnd2.Text;
            DataTable dt1 = bUS_Static.SumPriceBillInputBetween(dayStar, dayend);
            foreach (DataRow item in dt1.Rows)
            {
                if (item[0].ToString() == "")
                {
                    txtTienIngredient.Text = "0";
                }
                else
                {
                    txtTienIngredient.Text = item[0].ToString();
                }
            }
            DataTable dt = bUS_Static.SumPriceDateTime(dayStar, dayend);
            foreach (DataRow item in dt.Rows)
            {
                if (item[0].ToString() == "")
                {
                    txtTienHoaDon.Text = "0";
                }
                else
                {
                    txtTienHoaDon.Text = item[0].ToString();
                }
            }

            dayStar2.Format = DateTimePickerFormat.Custom;
            dayStar2.CustomFormat = "dd-MM-yyyy";
            dayEnd2.Format = DateTimePickerFormat.Custom;
            dayEnd2.CustomFormat = "dd-MM-yyy";

            txtDanhThu.Text = "" + (float.Parse(txtTienHoaDon.Text) - float.Parse(txtTienIngredient.Text));
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(txtTienHoaDon.Text, txtTienIngredient.Text, txtDanhThu.Text);
            chart2.ChartAreas["ChartArea1"].AxisX.Title = "Static";
            chart2.ChartAreas["ChartArea1"].AxisY.Title = "Total";
            DataTable dt2 = new DataTable();
            chart2.Series["Tổng tiền hóa đơn"].Points.Clear();
            chart2.Series["Tổng tiền nguyên liệu"].Points.Clear();
            chart2.Series["Danh thu"].Points.Clear();
            dt2.Columns.Add("", typeof(string));
            dt2.Columns.Add("", typeof(string));
            dt2.Columns.Add("", typeof(string));
            dt2.Rows.Add(dataGridView1.Rows[0].Cells[0].Value.ToString(), dataGridView1.Rows[0].Cells[1].Value.ToString(), dataGridView1.Rows[0].Cells[2].Value.ToString());
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                chart2.Series["Tổng tiền hóa đơn"].Points.AddY(dt2.Rows[i][0]);
                chart2.Series["Tổng tiền nguyên liệu"].Points.AddY(dt2.Rows[i][1]);
                chart2.Series["Danh thu"].Points.AddY(dt2.Rows[i][2]);
            }
        }

        private void rdChiTiet_CheckedChanged(object sender, EventArgs e)
        {
            btThang.Enabled = true;
            btNam.Enabled = true;

            chart1.Visible = false;
            btTK.Visible = false;
            btEx1.Enabled = true;
            guna2DataGridView1.Visible = true;
            guna2DataGridView3.Visible = true;
            guna2DataGridView4.Visible = true;

            btEx.Enabled = false;
            btEx1.Enabled = false;
            btEx2.Enabled = false;
            btIn1.Enabled = false;
            btIn2.Enabled = false;
            btIn3.Enabled = false;

            btThang3.SendToBack();
            btThang4.SendToBack();
            btNam3.SendToBack();
            btNam4.SendToBack();

            rdChart.Visible = false;
        }

        private void rbTongThe_CheckedChanged(object sender, EventArgs e)
        {
            btThang.Enabled = true;
            btNam.Enabled = true;
            btTK.FillColor = Color.FromArgb(0, 118, 212);
            btTK.Visible = true;
            chart1.Visible = false;
            rdChart.Visible = false;
            guna2DataGridView1.Visible = true;
            guna2DataGridView3.Visible = true;
            guna2DataGridView4.Visible = true;

            btEx.Enabled = false;
            btIn1.Enabled = false;
        }

        private void rbTongThe_Click(object sender, EventArgs e)
        {
        }

        private void rdChiTiet_Click(object sender, EventArgs e)
        {

        }
        Bitmap btm1;
        private void btIn3_Click(object sender, EventArgs e)
        {

            if(check == 0)
            {
                DataTable dt = new DataTable();
                dt = bUS_Static.StaticCustomer();
                CrystalReport8 crystalReport5 = new CrystalReport8();
                crystalReport5.SetDataSource(dt);
                Report report = new Report();
                report.crystalReportViewer1.ReportSource = crystalReport5;
                report.ShowDialog();
            }
            if(check == 1)
            {
                DataTable dt = new DataTable();
                dt = bUS_Static.StaticCustomerMonth();
                CrystalReport9 crystalReport5 = new CrystalReport9();
                crystalReport5.SetDataSource(dt);
                Report report = new Report();
                report.crystalReportViewer1.ReportSource = crystalReport5;
                report.ShowDialog();
            }
            if (check == 2)
            {
                DataTable dt = new DataTable();
                dt = bUS_Static.StaticCustomerYears();
                CrystalReport10 crystalReport5 = new CrystalReport10();
                crystalReport5.SetDataSource(dt);
                Report report = new Report();
                report.crystalReportViewer1.ReportSource = crystalReport5;
                report.ShowDialog();
            }
            //if (guna2DataGridView4.Rows.Count > 1)
            //{
            //    int height = guna2DataGridView4.Height;
            //    guna2DataGridView4.Width = 810;
            //    guna2DataGridView4.DefaultCellStyle.Font = new Font("Segoe UI", 7, FontStyle.Regular);
            //    guna2DataGridView4.Height = guna2DataGridView4.RowCount * guna2DataGridView4.RowTemplate.Height * 2;
            //    btm2 = new Bitmap(guna2DataGridView4.Width, guna2DataGridView4.Height);
            //    guna2DataGridView4.DrawToBitmap(btm2, new Rectangle(0, 0, guna2DataGridView4.Width, guna2DataGridView4.Height));
            //    guna2DataGridView4.Height = height;
            //    printPreviewDialog3.ShowDialog();
            //    guna2DataGridView4.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            //    guna2DataGridView4.Width = 1011;
            //}
            //else
            //{
            //    MessageBox.Show("Không có dữ liệu cần in");
            //}
        }
        Bitmap btm2;
        private void btIn2_Click(object sender, EventArgs e)
        {

            if(check == 0)
            {
                DataTable dt = new DataTable();
                dt = bUS_Static.StaticEmployee();
                CrystalReport5 crystalReport5 = new CrystalReport5();
                crystalReport5.SetDataSource(dt);
                Report report = new Report();
                report.crystalReportViewer1.ReportSource = crystalReport5;
                report.ShowDialog();
            }

            if (check == 1)
            {
                DataTable dt = new DataTable();
                dt = bUS_Static.StaticEmployeeWeek();
                CrystalReport6 crystalReport5 = new CrystalReport6();
                crystalReport5.SetDataSource(dt);
                Report report = new Report();
                report.crystalReportViewer1.ReportSource = crystalReport5;
                report.ShowDialog();
            }
            if (check == 2)
            {
                DataTable dt = new DataTable();
                dt = bUS_Static.StaticEmployeeYears();
                CrystalReport7 crystalReport5 = new CrystalReport7();
                crystalReport5.SetDataSource(dt);
                Report report = new Report();
                report.crystalReportViewer1.ReportSource = crystalReport5;
                report.ShowDialog();
            }
            //if (guna2DataGridView3.Rows.Count > 1)
            //{
            //    int height = guna2DataGridView3.Height;
            //    guna2DataGridView3.Width = 810;
            //    guna2DataGridView2.DefaultCellStyle.Font = new Font("Segoe UI", 7, FontStyle.Regular);
            //    guna2DataGridView3.Height = guna2DataGridView3.RowCount * guna2DataGridView3.RowTemplate.Height * 2;
            //    btm1 = new Bitmap(guna2DataGridView3.Width, guna2DataGridView3.Height);
            //    guna2DataGridView3.DrawToBitmap(btm1, new Rectangle(0, 0, guna2DataGridView3.Width, guna2DataGridView3.Height));
            //    guna2DataGridView3.Height = height;
            //    printPreviewDialog2.ShowDialog();
            //    guna2DataGridView3.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            //    guna2DataGridView3.Width = 1011;
            //}
            //else
            //{
            //    MessageBox.Show("Không có dữ liệu cần in");
            //}
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(image, 30, 10);
            e.Graphics.DrawString("SHOP META", new Font("Arial", 22, FontStyle.Bold), Brushes.Black, new Point(330, 60));
            e.Graphics.DrawString("THỐNG KÊ NHÂN VIÊN", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(280, 120));
            e.Graphics.DrawString("Ngày xuất: " + DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(550, 200));
            e.Graphics.DrawString("_____________________________________________________________________________________________________________________________________", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(0, 245));
            e.Graphics.DrawImage(btm1, 0, 300);
            e.Graphics.DrawString("Tổng tiền: " + txtTongTien.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(550, 250));
        }

        private void printDocument3_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(image, 30, 10);
            e.Graphics.DrawString("SHOP META", new Font("Arial", 22, FontStyle.Bold), Brushes.Black, new Point(330, 60));
            e.Graphics.DrawString("THỐNG KÊ KHÁCH HÀNG", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(280, 120));
            e.Graphics.DrawString("Ngày xuất: " + DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(550, 200));
            e.Graphics.DrawString("_____________________________________________________________________________________________________________________________________", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(0, 245));
            e.Graphics.DrawImage(btm2, 0, 300);
            e.Graphics.DrawString("Tổng tiền: " + txtTongTien.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(550, 250));
        }
        // xuất excel nhập nguyên liệu
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)guna2DataGridView2.DataSource;
            Export3(dt, "Danh sach", "DANH SÁCH NGUYÊN LIỆU NHẬP");
        }
        public void Export3(DataTable dt, string sheetName, string title)
        {

            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tạo phần đầu nếu muốn

            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "C1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Tahoma";

            head.Font.Size = "18";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "Mã bill";

            cl1.ColumnWidth = 13.5;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Tên nhân viên";

            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Ngày xuất";

            cl3.ColumnWidth = 40.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Tổng tiền";

            cl4.ColumnWidth = 40.0;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "D3");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 15;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,

            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.

            object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int r = 0; r < dt.Rows.Count; r++)

            {

                DataRow dr = dt.Rows[r];

                for (int c = 0; c < dt.Columns.Count; c++)

                {
                    arr[r, c] = dr[c];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 4;

            int columnStart = 1;

            int rowEnd = rowStart + dt.Rows.Count - 1;

            int columnEnd = dt.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Căn giữa cột STT

            Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
        }
        // xuất nhập nguyên liệu ra pdf
        Bitmap btm4;
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bUS_Static.getBillInputBetween(ngay1,ngay2);
            CrystalReport11 crystalReport5 = new CrystalReport11();
            crystalReport5.SetDataSource(dt);
            Report report = new Report();
            report.crystalReportViewer1.ReportSource = crystalReport5;
            report.ShowDialog();
            //if (guna2DataGridView2.Rows.Count > 1)
            //{
            //    int height = guna2DataGridView2.Height;
            //    guna2DataGridView2.Width = 810;
            //    guna2DataGridView2.DefaultCellStyle.Font = new Font("Segoe UI", 7, FontStyle.Regular);
            //    guna2DataGridView2.Height = guna2DataGridView2.RowCount * guna2DataGridView2.RowTemplate.Height * 2;
            //    btm4 = new Bitmap(guna2DataGridView2.Width, guna2DataGridView2.Height);
            //    guna2DataGridView2.DrawToBitmap(btm4, new Rectangle(0, 0, guna2DataGridView2.Width, guna2DataGridView2.Height));
            //    guna2DataGridView2.Height = height;
            //    printPreviewDialog4.ShowDialog();
            //    guna2DataGridView2.Width = 1011;
            //    guna2DataGridView2.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            //}
            //else
            //{
            //    MessageBox.Show("Không có dữ liệu cần in");
            //}
        }
        private void printDocument4_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PaperSize paperSize = new PaperSize("My Envelope", 1000, 630);
            paperSize.RawKind = (int)PaperKind.A2;

            printDocument4.DefaultPageSettings.PaperSize = paperSize;
            DataTable a = (DataTable)guna2DataGridView2.DataSource;
            e.Graphics.DrawImageUnscaled(image, 30, 10);
            e.Graphics.DrawString("SHOP META", new Font("Arial", 22, FontStyle.Bold), Brushes.Black, new Point(330, 60));
            e.Graphics.DrawString("THỐNG KÊ NGUYÊN LIỆU", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(280, 120));
            e.Graphics.DrawString("Ngày xuất: " + DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(550, 200));
            e.Graphics.DrawString("_____________________________________________________________________________________________________________________________________", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(0, 205));

            e.Graphics.DrawImageUnscaled(btm4, 0, 230);

        }
        // xuất excel danh thu
        private void guna2Button8_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("", typeof(string));
            dt.Columns.Add("", typeof(string));
            dt.Columns.Add("", typeof(string));
            dt.Rows.Add(dataGridView1.Rows[0].Cells[0].Value.ToString(), dataGridView1.Rows[0].Cells[1].Value.ToString(), dataGridView1.Rows[0].Cells[2].Value.ToString());
            Export4(dt, "Danh sach", "DOANH THU");
        }
        public void Export4(DataTable dt, string sheetName, string title)
        {

            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tạo phần đầu nếu muốn

            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "C1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Tahoma";

            head.Font.Size = "18";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "Tổng tiền hóa đơn";

            cl1.ColumnWidth = 25;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Tổng tiền nguyên liệu";

            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Doanh thu";

            cl3.ColumnWidth = 25;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "C3");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 15;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,

            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.

            object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int r = 0; r < dt.Rows.Count; r++)

            {

                DataRow dr = dt.Rows[r];

                for (int c = 0; c < dt.Columns.Count; c++)

                {
                    arr[r, c] = dr[c];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 4;

            int columnStart = 1;

            int rowEnd = rowStart + dt.Rows.Count - 1;

            int columnEnd = dt.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Căn giữa cột STT

            Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
        }
        private void guna2Button7_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                printPreviewDialog5.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu cần in");
            }
        }

        private void printDocument5_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("", typeof(string));
            dt.Columns.Add("", typeof(string));
            dt.Columns.Add("", typeof(string));
            dt.Rows.Add(dataGridView1.Rows[0].Cells[0].Value.ToString(), dataGridView1.Rows[0].Cells[1].Value.ToString(), dataGridView1.Rows[0].Cells[2].Value.ToString());
            e.Graphics.DrawImageUnscaled(image, 30, 10);
            e.Graphics.DrawString("SHOP META", new Font("Arial", 22, FontStyle.Bold), Brushes.Black, new Point(330, 60));
            e.Graphics.DrawString("THỐNG KÊ DOANH THU", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(280, 120));
            e.Graphics.DrawString("Ngày xuất: " + DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(550, 250));
            e.Graphics.DrawString("_____________________________________________________________________________________________________________________________________", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(0, 245));

            e.Graphics.DrawString("Tổng tiền hóa đơn\t\tTổng tiền nguyên liệu\t\tDoanh thu", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, 295));
            e.Graphics.DrawString("==============================================================================", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, 310));

            int pointY = 310;
            foreach (DataRow item in dt.Rows)
            {
                pointY += 25;
                e.Graphics.DrawString($"{item[0].ToString()}", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, pointY));
                e.Graphics.DrawString($"{item[1].ToString()}", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(335, pointY));
                e.Graphics.DrawString($"{item[2].ToString()}", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(565, pointY));
            }
            pointY += 25;
            e.Graphics.DrawString("==============================================================================", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, pointY));
            e.Graphics.DrawString("TỔNG TIỀN: " + txtDanhThu.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(550, pointY + 35));
        }

        private void rdChart_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Visible = true;
            btTK.Visible = false;
            guna2DataGridView1.Visible = false;
            guna2DataGridView3.Visible = false;
            guna2DataGridView4.Visible = false;

            btEx.Enabled = false;
            btEx1.Enabled = false;
            btEx2.Enabled = false;

            btIn1.Enabled = false;
            btIn2.Enabled = false;
            btIn3.Enabled = false;

            btThang.Enabled = false;
            btNam.Enabled = false;
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            try
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                decimal value = decimal.Parse(txtTongTien.Text, System.Globalization.NumberStyles.AllowThousands);
                txtTongTien.Text = String.Format(culture, "{0:N0}", value);
                txtTongTien.Select(txtTongTien.Text.Length, 0);
            }
            catch
            {
                txtTongTien.Text = "0";
            }
        }

        private void txtTongTien1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                decimal value = decimal.Parse(txtTongTien1.Text, System.Globalization.NumberStyles.AllowThousands);
                txtTongTien1.Text = String.Format(culture, "{0:N0}", value);
                txtTongTien1.Select(txtTongTien1.Text.Length, 0);
            }
            catch
            {
                txtTongTien1.Text = "0";
            }
        }

        private void txtTienHoaDon_TextChanged(object sender, EventArgs e)
        {
            try
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                decimal value = decimal.Parse(txtTienHoaDon.Text, System.Globalization.NumberStyles.AllowThousands);
                txtTienHoaDon.Text = String.Format(culture, "{0:N0}", value);
                txtTienHoaDon.Select(txtTienHoaDon.Text.Length, 0);
            }
            catch
            {
                txtTienHoaDon.Text = "0";
            }
        }

        private void txtTienIngredient_TextChanged(object sender, EventArgs e)
        {
            try
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                decimal value = decimal.Parse(txtTienIngredient.Text, System.Globalization.NumberStyles.AllowThousands);
                txtTienIngredient.Text = String.Format(culture, "{0:N0}", value);
                txtTienIngredient.Select(txtTienIngredient.Text.Length, 0);
            }
            catch
            {
                txtTienIngredient.Text = "0";
            }
        }

        private void txtDanhThu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                decimal value = decimal.Parse(txtDanhThu.Text, System.Globalization.NumberStyles.AllowThousands);
                txtDanhThu.Text = String.Format(culture, "{0:N0}", value);
                txtDanhThu.Select(txtDanhThu.Text.Length, 0);
            }
            catch
            {
                txtDanhThu.Text = "0";
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
