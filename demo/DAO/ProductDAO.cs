using System;
using demo.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace demo.DAO
{
    public class ProductDAO
    {
        private static ProductDAO instance;

        public static ProductDAO Instance
        {
            get { if (instance == null) instance = new ProductDAO(); return ProductDAO.instance; }
            private set => instance = value;
        }
        private ProductDAO() { }
        public List<Product> GetListProducts()
        {
            List<Product> listProduct = new List<Product>();
            string query = "select MaSP, TenSP, DonVi, GiaBan, GiaNhap, TonKho, TenLoaiHang from HANG h join LoaiHang lh on h.MaLoaiHang = lh.MaLoaiHang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Product prod = new Product(item);
                listProduct.Add(prod);
            }
            return listProduct;
        }

        public bool InsertProd(string name, string donvi, int giaban, int gianhap, string loai)
        {
            string query = "spInsertProd @ten , @donvi , @giaban , @gianhap , @loai ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, donvi, giaban, gianhap, loai });
            return result > 0;
        }

        public bool updateProd(string name, string donvi, int giaban, int gianhap, string maloai, string masp)
        {
            string query = "spUpdateProd @ten , @donvi , @giaban , @gianhap ,  @loai , @masp";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, donvi, giaban, gianhap, maloai, masp });
            return result > 0;
        }

        public bool deleteProd(string masp)
        {
            string query = "spDeleteProd @masp";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { masp });
            return result > 0;
        }

        public List<Product> SearchProductsByName(string name)
        {
            List<Product> listProduct = new List<Product>();
            string query = string.Format("select * from Hang where TenSP like N'%{0}%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Product prod = new Product(item);
                listProduct.Add(prod);
            }
            return listProduct;
        }


    }
}