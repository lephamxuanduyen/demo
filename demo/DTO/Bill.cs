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
        public Bill(string id, DateTime? tgBan) 
        {
            this.Id = id;
            this.TgBan = tgBan;
        }

        public Bill(DataRow row) 
        {
            this.Id = row["MaDH"].ToString();
            this.TgBan = (DateTime?)row["TgBan"];
        }

        private DateTime? tgBan;
        private string id;

        public string Id { get => id; set => id = value; }
        public DateTime? TgBan { get => tgBan; set => tgBan = value; }
    }
}
