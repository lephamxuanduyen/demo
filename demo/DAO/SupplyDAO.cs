using demo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.DAO
{
    public class SupplyDAO
    {
        private static SupplyDAO instance;

        public static SupplyDAO Instance 
        { 
            get { if (instance == null) instance = new SupplyDAO(); return SupplyDAO.instance; }
            private set => instance = value; 
        }
        private SupplyDAO() { }
        public List<Supply> GetSuppliesList()
        {
            List<Supply> Supplylist = new List<Supply>();
            string query = "select * form NPP";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Supply supply = new Supply(item);
                Supplylist.Add(supply);
            }
            return Supplylist;
        }
        public bool InsertSupply(string name, string dchi, string sdt, string dd, string stk)
        {
            string query = "spInsertSupply @ten , @dchi , @sdt , @dd , @stk";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, dchi, sdt, dd, stk });
            return result > 0;
        }

        public bool updateSupply(string id, string name, string dchi, string sdt, string dd, string stk)
        {
            string query = "spUpdateSupply @id , @ten , @dchi , @sdt , @dd , @stk";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, name, dchi, sdt, dd, stk });
            return result > 0;
        }

        public bool deleteSupply(string id)
        {
            string query = "spDeleteSupply @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result > 0;
        }

        public List<Supply> SearchSupplyByName(string name)
        {
            List<Supply> listSupply = new List<Supply>();
            string query = string.Format("select * from NPP where TenNPP like N'%{0}%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Supply supply = new Supply(item);
                listSupply.Add(supply);
            }
            return listSupply;
        }

    }
}
