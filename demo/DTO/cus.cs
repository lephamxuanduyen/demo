using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.DTO
{
    public class cus
    {
        private string id;
        private string name;
        private string address;
        public cus(string id, string name, string address)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
        }

        public cus(DataRow row)
        {
            this.Id = row["MaKH"].ToString();
            this.Name= row["TenKH"].ToString();
            this.Address= row["DchiKH"].ToString();
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
    }
}
