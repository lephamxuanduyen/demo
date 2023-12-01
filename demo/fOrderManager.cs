using demo.DAO;
using demo.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class fOrderManager : Form
    {
        public fOrderManager()
        {
            InitializeComponent();
            // loadCus();
            loadBill();
            addBillBinding();
        }

        #region Method

        // void loadCus()
        // {
        //     List<cus> cusList = cusDAO.Instance.GetCusList();
        // 
        //     foreach (cus item in cusList)
        //     {
        //         Button btn = new Button() { Width = cusDAO.cusWidth, Height = cusDAO.cusHeight};
        //         btn.Text = item.Id + Environment.NewLine + item.Name;
        //         btn.BackColor = Color.Aqua;
        //         btn.Click += btn_Click;
        //         btn.Tag = item;
        // 
        //         fltabCus.Controls.Add(btn);
        //     }
        // }

        // void showBill(string id)
        // {
        //     listView1.Items.Clear();
        //     List<demo.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByCus(id);
        // 
        //     foreach (demo.DTO.Menu item in listBillInfo)
        //     {
        //         ListViewItem lsvitem = new ListViewItem(item.ProdName.ToString());
        //         lsvitem.SubItems.Add(item.Count.ToString());
        //         lsvitem.SubItems.Add(item.TotalPrice.ToString());
        // 
        //         listView1.Items.Add(lsvitem);
        //     }
        // }

        void loadBill()
        {
            string query = "pTaoHoaDon";
            dataGridViewOrder.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        #endregion

        #region Events
        // void btn_Click(object sender, EventArgs e)
        // {
        //     string cusID = ((sender as Button).Tag as cus).Id;
        //     showBill(cusID);
        // }

        void addBillBinding()
        {
            tbTenSP.DataBindings.Add(new Binding("Text", dataGridViewOrder.DataSource, "TenSP"));
            numSL.DataBindings.Add(new Binding("Value", dataGridViewOrder.DataSource, "SoLuongBan"));
            tbMaDH.DataBindings.Add(new Binding("Text", dataGridViewOrder.DataSource, "MaDH"));
            tbKH.DataBindings.Add(new Binding("Text", dataGridViewOrder.DataSource, "TenKH"));
        }
        #endregion

        private void fTableManager_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void thôngTinTàiKhóaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile();
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }

        private void listViewBill_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fltabCus_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string madh = tbMaDH.Text;
            string tenkh = tbKH.Text;
            if (BillDAO.Instance.ThanhToan(madh, tenkh))
            {
                MessageBox.Show("Thanh toán thành công");
                loadBill();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thanh toán");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tensp = tbTenSP.Text;
            int sl = (int)numSL.Value;
            if (BillDAO.Instance.InsertBill(tensp, sl))
            {
                MessageBox.Show("Thêm sản phẩm thành công");
                loadBill();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm sản phẩm");
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            string tensp = tbTenSP.Text;
            if (BillDAO.Instance.RemoveBill(tensp))
            {
                MessageBox.Show("Xóa sản phẩm thành công");
                loadBill();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa sản phẩm");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string tensp = tbTenSP.Text;
            int sl = (int)numSL.Value;
            if (BillDAO.Instance.UpdateBill(tensp, sl))
            {
                MessageBox.Show("Sửa số lượng sản phẩm thành công");
                loadBill();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa số lượng sản phẩm");
            }
        }
    }
}
