using demo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.DAO
{
    public class cusDAO
    {
        private static cusDAO instance;

        public static cusDAO Instance 
        {
            get { if (instance == null) instance = new cusDAO(); return instance; }
            private set { instance = value; }
        }

        public static int cusWidth = 120;
        public static int cusHeight = 60;
        private cusDAO() { }
        public List<cus> loadCusList()
        {
            List<cus> cusList = new List<cus>();

            DataTable data = DataProvider.Instance.ExecuteQuery("spGetCusList");

            foreach (DataRow item in data.Rows)
            {
                cus Cus = new cus(item);
                cusList.Add(Cus);
            }
            return cusList;
        }
    }
}
