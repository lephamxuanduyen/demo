using demo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.DAO
{
    public class cateDAO
    {
        private static cateDAO instance;

        public static cateDAO Instance 
        { 
            get { if (instance == null) instance = new cateDAO(); return cateDAO.instance; } 
            set => instance = value; 
        }
        private cateDAO() { }
        public List<cate> GetListCate()
        {
            List<cate> ListCate = new List<cate>();
            string query = "select * from LOAIHANG";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows) 
            {
                cate Cate = new cate(item);
                ListCate.Add(Cate);
            }
            return ListCate;
        }
        public bool InsertCate(string name)
        {
            string query = "spInsertCate @name";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name});
            return result > 0;
        }

        public bool updateCate(string id ,string name)
        {
            string query = "spUpdateCate @IdCate , @name";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, name });
            return result > 0;
        }

        public bool deleteCate(string id)
        {
            string query = "spDeleteCate @idCate";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result > 0;
        }

        public List<cate> SearchCateByName(string name)
        {
            List<cate> listcate = new List<cate>();
            string query = string.Format("select * from LoaiHang where TenLoaiHang like N'%{0}%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                cate Cate = new cate(item);
                listcate.Add(Cate);
            }
            return listcate;
        }
    }
}
