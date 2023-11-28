using demo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set => instance = value; 
        }
        private BillDAO() { }

        // thành công: bill ID
        // thất bại: "null"
        public string GetUnCheckBillIdByCusId(string id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select MaDH, TgBan from HoaDon where MaDH = " + id);

            if (data.Rows.Count >0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.Id;
            }
            return "null";
        }
    }
}
