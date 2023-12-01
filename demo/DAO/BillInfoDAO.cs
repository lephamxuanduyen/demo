
// sing demo.DTO;
// sing System;
// sing System.Collections.Generic;
// sing System.Data;
// sing System.Linq;
// sing System.Text;
// sing System.Threading.Tasks;
// 
// amespace demo.DAO
// 
//    public class BillInfoDAO
//    {
//        private static BillInfoDAO instance;
// 
//        public static BillInfoDAO Instance 
//        { 
//            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; } 
//            private set => instance = value;
//        }
//        private BillInfoDAO() { }
//        public List<billInfor> getListBIllInfor(string id) 
//        {
//            List<billInfor> listBillInfo = new List<billInfor>();
// 
//            DataTable data = DataProvider.Instance.ExecuteQuery("select * from hoadon_chitiet where MaDH = " + id);
// 
//            foreach (DataRow item in data.Rows) 
//            {
//                billInfor info = new billInfor(item);
//                listBillInfo.Add(info);
//            }
// 
//            return listBillInfo;
//        }
//    }
// 