using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;
namespace BLL
{
    public class BLL
    {
        AliciDB aliciDB;
        SiparisDB siparisDB;
        UrunDB urunDB;
        Alici alici = new Alici();
        public BLL()
        {
            aliciDB = new AliciDB();
            siparisDB = new SiparisDB();
            urunDB = new UrunDB();
        }
        public List<Alici> TumAlicilar()
        {
            return aliciDB.Alicilar.Liste();
        }
        public List<Siparis> TumSiparisler()
        {
            return siparisDB.Siparisler.Liste();
        }
      
        public Alici AliciBul(int id)
        {
            if (id == 0)
            {
                throw new Exception("AlıcıID değeri boş olamaz");
            }

            var result = aliciDB.Alicilar.Bul(id);
            if (result == null)
            {
                throw new Exception("Alıcı bulunamadı");
            }

            return new Alici()
            {
                AliciID = result.AliciID,
                AliciAdi = result.AliciAdi,
                AliciSoyadi = result.AliciSoyadi,
                AliciAdresi = result.AliciAdresi,
                AliciTelefonu= result.AliciTelefonu
            };


        }
        public void AliciEkle(Alici alici)
        {
            aliciDB.Alicilar.Ekle(alici);
        }
        public void AliciGüncelle(Alici alici)
        {
            aliciDB.Alicilar.Guncelle(alici);
        }
        public void AliciSil(int id)
        {
            aliciDB.Alicilar.Sil(id);
        }
        public List<Urun> TumUrunler()
        {
            return urunDB.Urunler.Liste();
        }
        public Urun UrunBul(int id)
        {
            if (id == 0)
            {
                throw new Exception("UrunID değeri boş olamaz");
            }

            var result = urunDB.Urunler.Bul(id);
            if (result == null)
            {
                throw new Exception("Urun bulunamadı");
            }

            return new Urun()
            {
                UrunID = result.UrunID,
                UrunAdi = result.UrunAdi,
                UrunFiyat = result.UrunFiyat,
                StokAdedi=result.StokAdedi
            };

        }
        public void UrunEkle(Urun urun)
        {
            urunDB.Urunler.Ekle(urun);
        }
        public void UrunGüncelle(Urun urun)
        {
            urunDB.Urunler.Guncelle(urun);
        }
        public void UrunSil(int id)
        {
            urunDB.Urunler.Sil(id);
        }
        public void SiparisBul(int id)
        {
            siparisDB.Siparisler.Bul(id);
        }
        public int AliciAdiBul(string ad)
        {
            return siparisDB.Siparisler.AliciAdiBul(ad);
        }
        public int UrunAdiBul(string ad)
        {
            return siparisDB.Siparisler.UrunAdiBul(ad);
        }
        public void SiparisEkle(Siparis siparis)
        {
            siparisDB.Siparisler.Ekle(siparis);
        }
        public void SiparisGüncelle(Siparis siparis)
        {
            siparisDB.Siparisler.Guncelle(siparis);
        }
        public void SiparisSil(int id)
        {
            siparisDB.Siparisler.Sil(id);
        }
       
    }
}
