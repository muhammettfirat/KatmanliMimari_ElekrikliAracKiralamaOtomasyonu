using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Alicilar : ICRUD<Alici>
    {
        SqlConnection Conn;
        public Alicilar(string strConn)
        {
            Conn = new SqlConnection(strConn);
        }

        public Alici Bul(int id)
        {
            Conn.Open();
            Alici alici = new Alici();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Alicilar WHERE AliciID=@ID", Conn);
            cmd.Parameters.AddWithValue("@ID", id);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            alici.AliciID = -1;
            if (dr.HasRows)
            {
                alici.AliciID = Convert.ToInt32(dr[0]);
                alici.AliciAdi = dr.GetString(1);
                alici.AliciSoyadi = dr.GetString(2);
                alici.AliciAdresi = dr.GetString(3);
                alici.AliciTelefonu = dr.GetString(4);
            }
            Conn.Close();
            return alici;
        }

        public void Ekle(Alici model)
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Alicilar VALUES(@ad,@soyad,@adres,@tel)", Conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ad", model.AliciAdi);
            cmd.Parameters.AddWithValue("@soyad", model.AliciSoyadi);
            cmd.Parameters.AddWithValue("@adres", model.AliciAdresi);
           cmd.Parameters.AddWithValue("@tel", model.AliciTelefonu);

            cmd.ExecuteNonQuery();
            
            
            Conn.Close();
        }

        public void Guncelle(Alici model)  
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Alicilar SET AliciAdi=@ad,AliciSoyadi=@soyad,AliciAdresi=@adres,AliciTelefonu=@tel WHERE AliciID = @ID", Conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID", model.AliciID);
            cmd.Parameters.AddWithValue("@ad", model.AliciAdi);
            cmd.Parameters.AddWithValue("@soyad", model.AliciSoyadi);
            cmd.Parameters.AddWithValue("@adres", model.AliciAdresi);
           cmd.Parameters.AddWithValue("@tel", model.AliciTelefonu);

            cmd.ExecuteNonQuery();
            Conn.Close();
        }

        public List<Alici> Liste()
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Alicilar", Conn);

            SqlDataReader dr = cmd.ExecuteReader();
            List<Alici> alicilar = new List<Alici>();
            while (dr.Read())
            {
                Alici alici = new Alici();
                alici.AliciID = Convert.ToInt32(dr[0]);
                alici.AliciAdi = dr.GetString(1);
                alici.AliciSoyadi = dr.GetString(2);
                alici.AliciAdresi = dr.GetString(3);
                alici.AliciTelefonu = dr.GetString(4);

                alicilar.Add(alici);
            }
            Conn.Close();
            return alicilar;
        }

        public void Sil(int id)
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Alicilar WHERE AliciID=@ID", Conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.ExecuteNonQuery();
            Conn.Close();
        }
        public int AliciSayisi()
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT count(*) FROM Alicilar", Conn);
            int sonuc = Convert.ToInt32(cmd.ExecuteScalar());
            Conn.Close();
            return sonuc;
        }
    }
}
