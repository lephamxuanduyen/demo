using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.DTO
{
    public class Supply
    {
        private string id;
        private string name;
        private string dchi;
        private string sdt;
        private string dd;
        private string stk;

        public Supply(string id, string name, string dchi, string sdt, string dd, string stk)
        {
            this.Id = id;
            this.Name = name;
            this.Dchi = dchi;
            this.Sdt = sdt;
            this.Dd = dd;
            this.Stk = stk;
        }

        public Supply(DataRow row)
        {
            this.Id = row["MaNPP"].ToString();
            this.Name = row["TenNPP"].ToString();
            this.Dchi = row["Dchi_NPP"].ToString();
            this.Sdt = row["SDT_NPP"].ToString();
            this.Dd = row["DD_NPP"].ToString();
            this.Stk = row["STK_NPP"].ToString();
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Dchi { get => dchi; set => dchi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Dd { get => dd; set => dd = value; }
        public string Stk { get => stk; set => stk = value; }
    }
}
