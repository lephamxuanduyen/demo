using demo.DTO;
// using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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

        public bool InsertBill(string tensp, int sl)
        {
            string query = "pAddProd @tenSP , @sl";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {tensp, sl});
            return result > 0;
        }

        public bool RemoveBill(string tensp)
        {
            string query = "pRemoveProd @tenSP";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {tensp});
            return result > 0;
        }

        public bool UpdateBill(string tensp, int sl)
        {
            string query = "spUpdateProd @tenSP , @sl";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tensp, sl });
            return result > 0;
        }

        public bool ThanhToan(string maDH, string tenKH) 
        {
            string query = "spThanhToan @maDH , @tenKH";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maDH, tenKH});
            return result > 0;  
        }
    }
}
