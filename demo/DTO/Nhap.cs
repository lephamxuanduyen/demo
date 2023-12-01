using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.DTO
{
    public class Nhap
    {
        // TenSP, SoLuongNhap, GiaNhap, GiaNhap*SoLuongNhap 'ThanhTien', TenNPP, TongTienNhap
        private string tenSP;
        private int soLuongNhap;
        private int giaBan;
        private int giaNhap;
        private int thanhTien;
        private string tenNPP;
        private int tongTien;
        private string maNhap;
        public Nhap(string tenSP, int slNhap, int giaBan, int giaNhap, int thanhTien, string tenNPP, int tongTien, string maNhap) 
        {
            this.TenSP = tenSP;
            this.SoLuongNhap = slNhap;
            this.GiaBan = giaBan;
            this.GiaNhap = giaNhap;
            this.ThanhTien = thanhTien;
            this.TenNPP = tenNPP;
            this.TongTien = tongTien;
            this.MaNhap = maNhap;
        }

        public Nhap(DataRow row)
        {
            this.TenSP = row["TenSP"].ToString();
            this.SoLuongNhap = (int)row["SoLuongNhap"]; ;
            this.GiaBan = (int)row["GiaBan"]; ;
            this.GiaNhap = (int)row["GiaNhap"]; ;
            this.ThanhTien = (int)row["GiaNhap*SoLuongNhap"]; ;
            this.TenNPP = row["TenNPP"].ToString();
            this.TongTien = (int)row["TongTien"];
            this.MaNhap = row["MaNhap"].ToString();
        }

        public string TenSP { get => tenSP; set => tenSP = value; }
        public int SoLuongNhap { get => soLuongNhap; set => soLuongNhap = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
        public string TenNPP { get => tenNPP; set => tenNPP = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public int GiaNhap { get => giaNhap; set => giaNhap = value; }
        public int GiaBan { get => giaBan; set => giaBan = value; }
        public string MaNhap { get => maNhap; set => maNhap = value; }
    }
}
