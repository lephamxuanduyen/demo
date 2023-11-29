using demo.DAO;
using demo.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace demo
{
    public partial class fAdmin : Form
    {
        BindingSource ListProd = new BindingSource();

        public fAdmin()
        {
            InitializeComponent();
            load();
        }
        #region method

        List<Product> searchProdByName(string name)
        {
            List<Product> productsList = ProductDAO.Instance.SearchProductsByName(name);
            return productsList;
        }
        void load()
        {
            dataGridView2.DataSource = ListProd;

            LoadAcList();
            loadCusList();
            loadProdList();
            loadCateList();
            loadLSNhap();
            loadNPPList();
            loadDT();
            AddProdBinding();
        }

        void LoadAcList() 
        {
            string query = "select * from NguoiBan";

            dataGridView6.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void loadCusList()
        {
            string query = "select * from KHACHHANG";
            dataGridView1.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void loadProdList()
        {
            ListProd.DataSource = ProductDAO.Instance.GetListProducts();
            // string query = "select TenSP, DonVi, GiaBan, GiaNhap, TonKho from HANG";
            // dataGridView2.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void loadCateList()
        {
            string query = "select * from LOAIHANG";
            dataGridView3.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void loadLSNhap()
        {
            string query = "pLichSuNhap";
            dataGridView8.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void loadNPPList()
        {
            string query = "select * from NPP";
            dataGridView5.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void loadDT()
        {
            string query = "pDoanhThu";
            dataGridView7.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            string name =  tbName.Text;
            string donvi = tbDonvi.Text;
            int giaban = (int)numNhap.Value;
            int giahap = (int)numBan.Value;
            string maloai = tbLoaiHang.Text;

            if (ProductDAO.Instance.InsertProd(name, donvi, giaban, giahap, maloai))
            {
                MessageBox.Show("Thêm sản phẩm thành công");
                loadProdList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm sản phẩm");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string donvi = tbDonvi.Text;
            int giaban = (int)numNhap.Value;
            int giahap = (int)numBan.Value;
            string maloai = tbLoaiHang.Text;
            string masp = tbIDProd.Text;

            if (ProductDAO.Instance.updateProd(name, donvi, giaban, giahap, maloai, masp))
            {
                MessageBox.Show("Sửa sản phẩm thành công");
                loadProdList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa sản phẩm");
            }
        }

        private void laName_Click(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string masp = tbIDProd.Text;

            if (ProductDAO.Instance.deleteProd( masp))
            {
                MessageBox.Show("Xóa sản phẩm thành công");
                loadProdList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa sản phẩm");
            }
        }

        

        private void label6_Click(object sender, EventArgs e)
        {
            
        }
       
        private void fAdmin_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #region event
        private void btnView_Click(object sender, EventArgs e)
        {
            loadProdList();
        }

        void AddProdBinding()
        {
            tbIDProd.DataBindings.Add(new Binding("Text", dataGridView2.DataSource,"MaSP", true, DataSourceUpdateMode.Never));
            tbName.DataBindings.Add(new Binding("Text", dataGridView2.DataSource, "TenSP", true, DataSourceUpdateMode.Never));
            tbDonvi.DataBindings.Add(new Binding("Text", dataGridView2.DataSource, "Donvi", true, DataSourceUpdateMode.Never));
            numNhap.DataBindings.Add(new Binding("Value", dataGridView2.DataSource, "GiaNhap", true, DataSourceUpdateMode.Never));
            numBan.DataBindings.Add(new Binding("Value", dataGridView2.DataSource, "GiaBan", true, DataSourceUpdateMode.Never));
            tbLoaiHang.DataBindings.Add(new Binding("Text", dataGridView2.DataSource,"MaLoaiHang", true, DataSourceUpdateMode.Never));

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //vgbnm
            ListProd.DataSource = searchProdByName(textBoxSearchName.Text);
        }
        #endregion
    }
}
 