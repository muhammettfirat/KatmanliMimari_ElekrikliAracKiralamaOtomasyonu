using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AliciDB
    {
        public AliciDB()
        {
            string strConn = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            Alicilar = new Alicilar(strConn);
            
        }

        public Alicilar Alicilar { get; set; }
    
    }
}
