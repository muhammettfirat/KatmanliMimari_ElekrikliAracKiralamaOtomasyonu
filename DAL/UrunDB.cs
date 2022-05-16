using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UrunDB
    {
        public UrunDB()
        {
            string strConn = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            Urunler= new Urunler(strConn);
           
        }

        public Urunler Urunler { get; set; }
      
    }
}
