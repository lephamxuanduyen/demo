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
        BindingSource ListAccount = new BindingSource();
        BindingSource ListCustomer = new BindingSource();
        BindingSource ListCate = new BindingSource();

        public fAdmin()
        {
            InitializeComponent();
            load();
        }
        #region method

        List<Supply> searchSupplyByName(string name)
        {
            List<Supply> supplyList = SupplyDAO.Instance.SearchSupplyByName(name);
            return supplyList;
        }

        List<cate> searchCateByName(string name)
        {
            List<cate> cateList = cateDAO.Instance.SearchCateByName(name);
            return cateList;
        }

        List<Product> searchProdByName(string name)
        {
            List<Product> productsList = ProductDAO.Instance.SearchProductsByName(name);
            return productsList;
        }

        List<Account> searchAccountByName(string name)
        {
            List<Account> accountsList = AccountDAO.Instance.SearchAccountByName(name);
            return accountsList;
        }

        List<cus> searchCustomerByName(string name)
        {
            List<cus> CustomerList = cusDAO.Instance.SearchCustomersByName(name);
            return CustomerList;
        }
       
        void load()
        {
            dataGridView2.DataSource = ListProd;
            dataGridView6.DataSource = ListAccount;
            dataGridView1.DataSource = ListCustomer;
            dataGridView3.DataSource = ListCate;

            loadCusList();
            loadProdList();
            LoadAcList();
            loadCateList();
            loadLSNhap();
            loadNPPList();
            loadDT();
            AddProdBinding();
            AddAccountBinding();
            AddCusBinding();
            AddCateBinding();
            AddSupplyBinding();
        }

        void LoadAcList() 
        {
            ListAccount.DataSource = AccountDAO.Instance.GetListAccount();
            // string query = "select * from NguoiBan";
            // dataGridView6.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void loadCusList()
        {
            // ListCustomer.DataSource = cusDAO.Instance.GetCusList();
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
            // ListCate.DataSource = cateDAO.Instance.GetListCate();
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

        void AddCateBinding()
        {
            tbIDCate.DataBindings.Add(new Binding("Text", dataGridView3.DataSource, "MaLoaiHang", true, DataSourceUpdateMode.Never));
            tbCate.DataBindings.Add(new Binding("Text", dataGridView3.DataSource, "TenLoaiHang", true, DataSourceUpdateMode.Never));
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

        void AddCusBinding()
        {
            tbCusID.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MaKH",true, DataSourceUpdateMode.Never));
            tbCusName.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "TenKH", true, DataSourceUpdateMode.Never));
            tbCusAdd.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "DchiKH", true,DataSourceUpdateMode.Never));
        }

        void AddAccountBinding()
        {
            tbTenDN.DataBindings.Add(new Binding("Text", dataGridView6.DataSource, "TenNguoiBan", true, DataSourceUpdateMode.Never));
            tbMatKhau.DataBindings.Add(new Binding("Text", dataGridView6.DataSource, "MatKhau", true, DataSourceUpdateMode.Never));
        }

        void AddSupplyBinding()
        {
            tbIdNpp.DataBindings.Add(new Binding("Text", dataGridView5.DataSource, "MaNPP", true, DataSourceUpdateMode.Never));
            tbTenNPP.DataBindings.Add(new Binding("Text", dataGridView5.DataSource, "TenNPP", true, DataSourceUpdateMode.Never));
            tbDchiNPP.DataBindings.Add(new Binding("Text", dataGridView5.DataSource, "Dchi_NPP", true, DataSourceUpdateMode.Never));
            tbSdtNPP.DataBindings.Add(new Binding("Text", dataGridView5.DataSource, "SDT_NPP", true, DataSourceUpdateMode.Never));
            tbDdNPP.DataBindings.Add(new Binding("Text", dataGridView5.DataSource, "DD_NPP", true, DataSourceUpdateMode.Never));
            tbStkNPP.DataBindings.Add(new Binding("Text", dataGridView5.DataSource, "STK_NPP", true, DataSourceUpdateMode.Never));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ListProd.DataSource = searchProdByName(textBoxSearchName.Text);
        }
        #endregion

        private void button17_Click(object sender, EventArgs e)
        {
            LoadAcList();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string name = tbTenDN.Text;
            string pass = tbMatKhau.Text;
            if (AccountDAO.Instance.InsertAccount(name, pass))
            {
                MessageBox.Show("Thêm tài khoản thành công");
                LoadAcList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm tài khoản");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string name = tbTenDN.Text;
            if (AccountDAO.Instance.DeleteAccount(name))
            {
                MessageBox.Show("Xóa tài khoản thành công");
                LoadAcList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa tài khoản");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string name = tbTenDN.Text;
            string pass = tbMatKhau.Text;
            if (AccountDAO.Instance.UpdateAccount(name, pass))
            {
                MessageBox.Show("Sửa tài khoản thành công");
                LoadAcList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa tài khoản");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ListAccount.DataSource = searchAccountByName(tbSearchAccByName.Text);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            loadCusList();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            string tenKH = tbCusName.Text;
            string dchiKH = tbCusAdd.Text;

            if (cusDAO.Instance.InsertCus(tenKH, dchiKH))
            {
                MessageBox.Show("Thêm thông tin khách hàng thành công");
                loadCusList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thông tin khách hàng");
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            string maKH = tbCusID.Text;
            string TenKH = tbCusName.Text;
            string dchi = tbCusAdd.Text;
            if (cusDAO.Instance.UpdateCus(maKH, TenKH, dchi))
            {
                MessageBox.Show("Sửa thông tin khách hàng thành công");
                loadCusList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thông tin khách hàng");
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            string maKH = tbCusID.Text;
            if (cusDAO.Instance.DeleteCus(maKH))
            {
                MessageBox.Show("Xóa khách hàng thành công");
                loadCusList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa khách hàng");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = searchCustomerByName(textBoxSearchCusByName.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadCateList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string name = tbCate.Text;
            if (cateDAO.Instance.InsertCate(name))
            {
                MessageBox.Show("Thêm loại hàng thành công");
                loadCateList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm loại hàng");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id = tbIDCate.Text;
            string name = tbCate.Text;
            if (cateDAO.Instance.updateCate(id, name))
            {
                MessageBox.Show("Sửa thông tin loại hàng thành công");
                loadCateList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thông tin loại hàng");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = tbIDCate.Text;
            if (cateDAO.Instance.deleteCate(id))
            {
                MessageBox.Show("Xóa loại hàng thành công");
                loadCateList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa loại hàng");
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string name = tbSearchByCate.Text;
            dataGridView3.DataSource = searchCateByName(name);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string name = tbTenNPP.Text;
            string dchi = tbDchiNPP.Text;
            string sdt = tbSdtNPP.Text;
            string dd = tbDdNPP.Text;   
            string stk = tbStkNPP.Text;
            if (SupplyDAO.Instance.InsertSupply(name, dchi, sdt, dd, stk))
            {
                MessageBox.Show("Thêm nhà phân phối thành công");
                loadNPPList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm nhà phân phối");
            }
                
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string id = tbIdNpp.Text;
            string name = tbTenNPP.Text;
            string dchi = tbDchiNPP.Text;
            string sdt = tbSdtNPP.Text;
            string dd = tbDdNPP.Text;
            string stk = tbStkNPP.Text;
            if (SupplyDAO.Instance.updateSupply(id, name, dchi, sdt, dd, stk))
            {
                MessageBox.Show("Sửa nhà phân phối thành công");
                loadNPPList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa nhà phân phối");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string id = tbIdNpp.Text;
            if (SupplyDAO.Instance.deleteSupply(id))
            {
                MessageBox.Show("Xóa nhà phân phối thành công");
                loadNPPList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa nhà phân phối");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            loadNPPList();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string name = tbSearchSupplyByName.Text;
            dataGridView5.DataSource = searchSupplyByName(name);
        }
    }
}
 