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
            loadCus();
        }

        #region Method

        void loadCus()
        {
            List<cus> cusList = cusDAO.Instance.loadCusList();

            foreach (cus item in cusList)
            {
                Button btn = new Button() { Width = cusDAO.cusWidth, Height = cusDAO.cusHeight};
                btn.Text = item.Id + Environment.NewLine + item.Name;
                btn.BackColor = Color.Aqua;
                fltabCus.Controls.Add(btn);
            }
        }
        #endregion

        #region Events
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

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
