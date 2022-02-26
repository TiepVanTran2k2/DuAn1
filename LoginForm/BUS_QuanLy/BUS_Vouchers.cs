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
    public class BUS_Vouchers
    {
        DAL_Vouchers vouchers = new DAL_Vouchers();
        public DataTable searchVoucher(int id)
        {
            return vouchers.searchVoucher(id);
        }
        public bool deleteVoucher(string id_voucher)
        {
            return vouchers.deleteVoucher(id_voucher);
        }
        public int getTypeVoucherById(string id_voucher)
        {
            return vouchers.getTypeVoucherById(id_voucher);
        }
        public DataTable getSale()
        {
            return vouchers.getSale();
        }
        public DataTable getData()
        {
            return vouchers.getData();
        }
        public bool InsertDatevoucher(DTO_Vouchers voucher)
        {
            return vouchers.InsertDatevoucher(voucher);
        }
        public DataTable searchDataVoucher(int id)
        {
            return vouchers.searchDataVoucher(id);
        }
        public DataTable getCountSaleVoucher(int id)
        {
            return vouchers.getCountSaleVoucher(id);
        }
        public bool deleteVoucher(int id, string a, string b)
        {
            return vouchers.deleteVoucher(id,a,b);
        }
        public DataTable getConfigurationSale(int id)
        {
            return vouchers.getConfigurationSale(id);
        }
        public DataTable getEmailSendVoucher(int reward)
        {
            return vouchers.getEmailSendVoucher(reward);
        }
        public DTO_Vouchers getVoucherSendMail(int voucher)
        {
            DataTable table = vouchers.getVoucherSendMail(voucher);
            if(table.Rows.Count > 0)
            {
                DTO_Vouchers vou = new DTO_Vouchers(table.Rows[0]);
                return vou;
            }
            return null;
        }
        public bool UpdateVoucherForSend(string id_vouchers)
        {
            return vouchers.UpdateVoucherForSend(id_vouchers);
        }
    }
}
