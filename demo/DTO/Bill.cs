using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.DTO
{
    public class Bill
    {
        private string tenSP;
        private int sL;
        private int giaBan;
        private int thanhTien;
        private string maDH;
        private string tenKH;
        private int tongTien;

        public Bill(string tenSP, int sL, int giaBan, int thanhTien, string maDH, string tenKH, int tongTien)
        {
            this.TenSP = tenSP;
            this.SL = sL;
            this.GiaBan = giaBan;
            this.ThanhTien = thanhTien;
            this.MaDH = maDH;
            this.TenKH = tenKH;
            this.TongTien = tongTien;
        }

        public Bill(DataRow row) 
        {
            this.TenSP = row["TenSP"].ToString();
            this.SL = (int)row["SoLuongBan"];
            this.GiaBan = (int)row["GiaBan"];
            this.ThanhTien = (int)row["ThanhTien"];
            this.MaDH = row["MaDH"].ToString();
            this.TenKH = row["TenKH"].ToString();
            this.TongTien = (int)row["TongTien"];
        }

        public string TenSP { get => tenSP; set => tenSP = value; }
        public int SL { get => sL; set => sL = value; }
        public int GiaBan { get => giaBan; set => giaBan = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
        public string MaDH { get => maDH; set => maDH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
    }
}
