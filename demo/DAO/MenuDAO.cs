using System;
using demo.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace demo.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance 
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; } 
            private set => instance = value; 
        }
        private MenuDAO() { }

        public List<Menu> GetListMenuByCus(string id)
        {
            List<Menu> listMenu = new List<Menu>();

            string query = "select MaSP, SoLuongBan, ThanhTien from HOADON hd join HOADON_CHITIET hdct on hd.MaDH = hdct.MaDH where MaKH = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
