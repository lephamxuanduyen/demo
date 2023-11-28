﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.DTO
{
    public class Product
    {
        private string maSP;
        private string tenSP;
        private string donvi;
        private int giaNhap;
        private int giaBan;
        private string maLoaiHang;

        public Product(string maSP, string tenSP, string donvi, int giaNhap, int giaBan, string maLoaiHang)
        {
            this.MaSP = maSP;
            this.TenSP = tenSP;
            this.Donvi = donvi;
            this.GiaNhap = giaNhap;
            this.GiaBan = giaBan;
            this.MaLoaiHang = maLoaiHang;
        }

        public Product(DataRow row)
        {
            this.MaSP = row["MaSP"].ToString();
            this.TenSP = row["TenSP"].ToString();
            this.Donvi = row["DonVi"].ToString();
            this.GiaNhap = (int)row["GiaNhap"];
            this.GiaBan = (int)row["GiaBan"];
            this.MaLoaiHang = row["MaLoaiHang"].ToString();
        }

        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public string Donvi { get => donvi; set => donvi = value; }
        public int GiaNhap { get => giaNhap; set => giaNhap = value; }
        public int GiaBan { get => giaBan; set => giaBan = value; }
        public string MaLoaiHang { get => maLoaiHang; set => maLoaiHang = value; }
    }
}
