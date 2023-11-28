using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.DTO
{
    public class Menu
    {
        public Menu(string prodName, int count, float totalPrice = 0)
        {
            this.ProdName = prodName;
            this.Count = count;
            this.TotalPrice = totalPrice;
        }
        public Menu(DataRow row)
        {
            this.ProdName = row["MaSP"].ToString();
            this.Count = (int)row["SoLuongBan"];
            this.TotalPrice = (float)Convert.ToDouble(row["ThanhTien"].ToString());
        }

        private string prodName;

        private int count;


        private float totalPrice;

        public int Count { get => count; set => count = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
        public string ProdName { get => prodName; set => prodName = value; }
    }
}
