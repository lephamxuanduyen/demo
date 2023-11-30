using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.DAO
{
    public class cateDAO
    {
        private static cateDAO instance;

        public static cateDAO Instance { get => instance; set => instance = value; }
    }
}
