using demo.DAO;
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
    public partial class fAccountProfile : Form
    {
        public fAccountProfile()
        {
            InitializeComponent();
            showNhap();
            addNhapBinding();
        }

        #region method
        void showNhap()
        {
            string query = "spTaoDonNhap";
            dataGridViewNhap.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void addNhapBinding()
        {
            tbTenSP.DataBindings.Add(new Binding("Text", dataGridViewNhap.DataSource, "TenSP"));
            numSL.DataBindings.Add(new Binding("Value", dataGridViewNhap.DataSource, "SoLuongNhap"));
            numBan.DataBindings.Add(new Binding("Value", dataGridViewNhap.DataSource, "GiaBan"));
            numNhap.DataBindings.Add(new Binding("Value", dataGridViewNhap.DataSource, "GiaNhap"));
            tbMaNhap.DataBindings.Add(new Binding("Text", dataGridViewNhap.DataSource, "MaNhap"));
            tbNPP.DataBindings.Add(new Binding("Text", dataGridViewNhap.DataSource, "TenNPP"));
        }
        #endregion

        #region event

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tensp = tbTenSP.Text;
            int sl = (int)numSL.Value;
            int giaban = (int)numNhap.Value;
            int gianhap = (int)numBan.Value;
            dataGridViewNhap.DataSource = NhapDAO.Instance.InsertNhap(tensp, sl, giaban, gianhap);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string tensp = tbTenSP.Text;
            int sl = (int)numSL.Value;
            int giaban = (int)numNhap.Value;
            int gianhap = (int)numBan.Value;
            dataGridViewNhap.DataSource = NhapDAO.Instance.UpdateNhap(tensp, sl, giaban, gianhap);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            string tensp = tbTenSP.Text;
            dataGridViewNhap.DataSource = NhapDAO.Instance.DeleteNhap(tensp);
        }

        #endregion

        private void fAccountProfile_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void laName_Click(object sender, EventArgs e)
        {

        }

        
    }
}
