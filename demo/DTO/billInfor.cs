using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.DTO
{
    public class billInfor
    {
        public billInfor(int billId, int prodId, int count) 
        {
            this.billID = billId;
            this.prodID = prodId;
            this.count = count;
        }

        public billInfor(DataRow row) 
        {
            this.billID = (int)row["MaDH"];
            this.prodID = (int)row["MaSP"];
            this.count = (int)row["SoLuongBan"];
        }

        private int count;
        private int prodID;
        private int billID;

        public int BillID { get => billID; set => billID = value; }
        public int ProdID { get => prodID; set => prodID = value; }
        public int Count { get => count; set => count = value; }


    }
}
