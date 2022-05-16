using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SiparisDB
    {
        public SiparisDB()
        {
            string strConn = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            Siparisler = new Siparisler(strConn);
          
        }

        public Siparisler Siparisler { get; set; }
       
    }
}
