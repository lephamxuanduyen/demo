﻿using demo.DAO;
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

namespace demo
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            LoadAcList();
            loadCusList();
            loadProdList();
            loadCateList();
            loadLSNhap();
            loadNPPList();
            loadDT();
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
            string query = "select TenSP, DonVi, GiaBan, GiaNhap, TonKho from HANG";
            dataGridView2.DataSource = DataProvider.Instance.ExecuteQuery(query);
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

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

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

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
    }
}
