using System;
using demo.DTO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance 
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; } 
        }
        private AccountDAO() { }

        public List<Account> GetListAccount()
        {
            List<Account> listAc = new List<Account>();
            string query = "select * from NguoiBan";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Account ac = new Account(item);
                listAc.Add(ac);
            }
            return listAc;
        }

        public bool login(string name, string pass)
        {
            string query = "pLogin @name , @pass";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {name, pass});
            return result.Rows.Count > 0;
        }

        public bool InsertAccount( string name, string pass) 
        {
            string query = "spInsertAccount @name , @pass";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {name, pass});
            return result > 0;
        }

        public bool DeleteAccount(string name)
        {
            string query = "spDelAc @tendn";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name });
            return result > 0;
        }

        public bool UpdateAccount(string name, string pass)
        {
            string query = "spUpdate @tendn , @matkhau";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, pass });
            return result > 0;
        }

        public List<Account> SearchAccountByName(string name)
        {
            List<Account> listAccount = new List<Account>();
            string query = string.Format("select * from NguoiBan where TenNguoiBan like '%{0}%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Account ac = new Account(item);
                listAccount.Add(ac);
            }
            return listAccount;
        }
    }
}
