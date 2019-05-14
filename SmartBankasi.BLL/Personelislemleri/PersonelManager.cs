using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid;
using SmartBankasi.DLL;

namespace SmartBankasi.BLL.Personelislemleri
{
    public class PersonelManager : IPersonel
    {
        //*********************************************************************
        SmartBankDBEntities db = new SmartBankDBEntities();


        public string PersonelGuncelle(int personellerId, string tc, string adi, string soyadi, bool medenihali, string cinsiyet, DateTime dogumtarihi, string dogumyeri, string resim)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(adi) && !string.IsNullOrWhiteSpace(soyadi))
                {
                    Personeller guncelle = db.Personeller.Where(p => p.PersonellerID == personellerId).FirstOrDefault();
                    guncelle.TC = tc;
                    guncelle.Adi = adi;
                    guncelle.Soyadi = soyadi;
                    guncelle.Cinsiyet = cinsiyet;
                    guncelle.MedeniHali = medenihali;
                    guncelle.DogumYeri = dogumyeri;
                    guncelle.DogumTarihi = dogumtarihi;
                    guncelle.Resim = resim;

                    if (db.SaveChanges() > 0)
                    {
                        return adi + " isimli personel başarılı bir şekilde güncellendi";
                    }
                    return "Güncelleme  başarısız";
                }
                return "Boş alanları doldurun";

            }
            catch (Exception)
            {

                throw;
            }
        }

        public string PersonelKaydet(string tc, string adi, string soyadi, bool medenihali, string cinsiyet, DateTime dogumtarihi, string dogumyeri, string resim)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(adi) && !string.IsNullOrWhiteSpace(soyadi))
                {
                    Personeller ekle = new Personeller();
                    ekle.TC = tc;
                    ekle.Adi = adi;
                    ekle.Soyadi = soyadi;
                    ekle.Cinsiyet = cinsiyet;
                    ekle.MedeniHali = medenihali;
                    ekle.DogumYeri = dogumyeri;
                    ekle.DogumTarihi = dogumtarihi;
                    ekle.Resim = resim;
                    db.Personeller.Add(ekle);

                    if (db.SaveChanges()>0)
                    {
                        return adi + " isimli personel başarılı bir şekilde eklendi";
                    }
                    return "Ekleme olmadı";
                }
                return "Boş alanları doldurun";

            }
            catch (Exception)
            {

                throw;
            }
        }

        //********************************************************
        public List<Personeller> PersonelListesi()
        {
            return db.Personeller.ToList();
        }

        public void PersonelListesi(GridControl gridPersonel)
        {
            gridPersonel.DataSource = db.Personeller.ToList();
        }

        public string PersonelSil(int personellerId)
        {
            throw new NotImplementedException();
        }
    }
}
