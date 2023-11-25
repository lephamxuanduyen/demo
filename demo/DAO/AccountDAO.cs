﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.DAO
{
    internal class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance 
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; } 
        }
        private AccountDAO() { }

        public bool login(string name, string pass)
        {
            string query = "pLogin @name , @pass";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {name, pass});
            return result.Rows.Count > 0;
        }
    }
}
