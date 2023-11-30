using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.DTO
{
    public class Account
    {
        private string tenNguoiBan;
        private string matKhau;
        public Account(string tenNguoiBan, string matKhau)
        {
            this.TenNguoiBan = tenNguoiBan;
            this.MatKhau = matKhau;
        }

        public Account(DataRow row) 
        {
            this.TenNguoiBan = row["TenNguoiBan"].ToString();
            this.MatKhau = row["MatKhau"].ToString();
        }
        public string TenNguoiBan { get => tenNguoiBan; set => tenNguoiBan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
    }
}
