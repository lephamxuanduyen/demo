using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.DTO
{
    public class cate
    {
        private string idCate;
        private string nameCate;
        public cate(string idCate, string nameCate)
        {
            this.IdCate = idCate;
            this.NameCate = nameCate;
        }
        public cate(DataRow row)
        {
            this.IdCate = row["MaLoaiHang"].ToString();
            this.NameCate = row["TenLoaiHang"].ToString();
        }

        public string IdCate { get => idCate; set => idCate = value; }
        public string NameCate { get => nameCate; set => nameCate = value; }
    }
}
