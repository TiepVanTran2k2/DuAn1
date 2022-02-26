using DAL_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLy
{


    public class BUS_Bill_Detail
    {
        DAL_Bill_Detail dal = new DAL_Bill_Detail();
        public bool InsertBillDetail(DTO_Bill_Detail billdetail)
        {
            return dal.InsertBillDetail(billdetail);
        }
        public List<DTO_Bill_Detail> getListBillDetail(int id)
        {
            List<DTO_Bill_Detail> listBillDetail = new List<DTO_Bill_Detail>();

            DataTable data = dal.GetListBillDetail(id);

            foreach(DataRow row in data.Rows)
            {
                DTO_Bill_Detail billDetail = new DTO_Bill_Detail(row);
                listBillDetail.Add(billDetail);
            }
            
            return listBillDetail;
        }
    }
}
