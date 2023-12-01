using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.DAO
{
    public class NhapDAO
    {
        private static NhapDAO instance;

        public static NhapDAO Instance 
        { 
            get { if (instance == null) instance = new NhapDAO(); return NhapDAO.instance; }
            private set => instance = value; 
        }

        private NhapDAO() { }

        public bool InsertNhap(string tensp, int sl, int giaban, int gianhap)
        {
            string query = "spInsertNhap @tensp , @sl , @giaban , @gianhap";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tensp, sl, giaban, gianhap });
            return result > 0;
        }

        public bool UpdateNhap(string tensp, int sl, int giaban, int gianhap)
        {
            string query = "sUpdateNhap @tensp , @sl , @giaban , @gianhap";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tensp, sl, giaban, gianhap });
            return result > 0;
        }

        public bool DeleteNhap(string tensp)
        {
            string query = "spDeleteNhap @tensp";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tensp });
            return result > 0;
        }

        public bool Nhap(string tensp, string tenNPP)
        {
            string query = "spNhap @id , @tenNPP";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tensp, tenNPP });
            return result > 0;
        }
    }
}
