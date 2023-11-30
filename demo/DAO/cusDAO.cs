using demo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.DAO
{
    public class cusDAO
    {
        private static cusDAO instance;

        public static cusDAO Instance 
        {
            get { if (instance == null) instance = new cusDAO(); return cusDAO.instance; }
            private set { instance = value; }
        }

        // public static int cusWidth = 120;
        // public static int cusHeight = 60;
        private cusDAO() { }
        public List<cus> GetCusList()
        {
            List<cus> cusList = new List<cus>();

            DataTable data = DataProvider.Instance.ExecuteQuery("spGetCusList");

            foreach (DataRow item in data.Rows)
            {
                cus Cus = new cus(item);
                cusList.Add(Cus);
            }
            return cusList;
        }
        public bool InsertCus(string name, string dchi)
        {
            string query = "spInsertCus @ten , @dchi";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, dchi});
            return result > 0;
        }

        public bool UpdateCus(string maKH,string name, string dchi)
        {
            string query = "spUpdateCus @idKH , @TenKH , @dchi";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maKH,name, dchi });
            return result > 0;
        }

        public bool DeleteCus(string maKH)
        {
            string query = "spDeleteCus @idKH";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maKH });
            return result > 0;
        }
        public List<cus> SearchCustomersByName(string name)
        {
            List<cus> CusList = new List<cus>();
            string query = string.Format("select * from khachhang where TenKH like N'%{0}%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                cus prod = new cus(item);
                CusList.Add(prod);
            }
            return CusList;
        }
    }
}