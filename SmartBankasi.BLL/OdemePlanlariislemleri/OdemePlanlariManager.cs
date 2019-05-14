using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartBankasi.DLL;

namespace SmartBankasi.BLL.OdemePlanlariislemleri
{
    public class OdemePlanlariManager : IOdemeler
    {
        //**********************************************************
        SmartBankDBEntities db = new SmartBankDBEntities();
        //**********************************************************

        public string OdemePlaniGuncelle(int OdemePlanlariID, decimal t1, DateTime? t1Tarih, decimal t2, DateTime? t2Tarih, decimal t3, DateTime? t3Tarih, decimal t4, DateTime? t4Tarih, decimal t5, DateTime? t5Tarih, decimal t6, DateTime? t6Tarih, decimal t7, DateTime t7Tarih, decimal t8, DateTime? t8Tarih, decimal t9, DateTime? t9Tarih, decimal t10, DateTime? t10Tarih, decimal t11, DateTime? t11Tarih, decimal t12, DateTime? t12Tarih, int kullaniciID)
        {
            throw new NotImplementedException();
        }

        public string OdemePlaniKaydet(decimal t1, DateTime? t1Tarih, decimal t2, DateTime? t2Tarih, decimal t3, DateTime? t3Tarih, decimal t4, DateTime? t4Tarih, decimal t5, DateTime? t5Tarih, decimal t6, DateTime? t6Tarih, decimal t7, DateTime t7Tarih, decimal t8, DateTime? t8Tarih, decimal t9, DateTime? t9Tarih, decimal t10, DateTime? t10Tarih, decimal t11, DateTime? t11Tarih, decimal t12, DateTime? t12Tarih, int kullaniciID)
        {
            try
            {
                OdemePlanlari ekle = new OdemePlanlari();
                ekle.Taksit1 = t1;
                ekle.Taksit1Tarihi = t1Tarih;
                //-
                ekle.Taksit2 = t2;
                ekle.Taksit2Tarihi = t2Tarih;
                //--
                ekle.Taksit3 = t3;
                ekle.Taksit3Tarihi = t3Tarih;
                //-*
                ekle.Taksit4 = t4;
                ekle.Taksit4Tarihi = t4Tarih;
                //**
                ekle.Taksit5 = t5;
                ekle.Taksit5Tarihi = t5Tarih;
                //**
                ekle.Taksit6 = t6;
                ekle.Taksit6Tarihi = t6Tarih;
                //***
                ekle.Taksit7 = t7;
                ekle.Taksit7Tarihi = t7Tarih;
                //***
                ekle.Taksit8 = t8;
                ekle.Taksit8Tarihi = t8Tarih;
                //**
                ekle.Taksit9 = t9;
                ekle.Taksit9Tarihi = t9Tarih;
                //*********
                ekle.Taksit10 = t10;
                ekle.Taksit10Tarihi = t10Tarih;
                //****
                ekle.Taksit11 = t11;
                ekle.Taksit11Tarihi = t11Tarih;
                //***
                ekle.Taksit12 = t12;
                ekle.Taksit12Tarihi = t12Tarih;

                db.OdemePlanlari.Add(ekle);

                if (db.SaveChanges()>0)
                {
                    return "Ödeme Planı eklendi";
                }
                return "Ödeme planı eklerken hata oluştu";
                
            }
            catch (Exception)
            {
                return "HATA ";
            }
        }

        public string OdemePlaniSil(int OdemePlanlariID)
        {
            throw new NotImplementedException();
        }

        public string GuncelleOdemeler(int musterituruId,int musteriId,int odemeplaniId,int kId)
        {
            try
            {
                var guncelle = db.Odemeler.Where(k => k.MusteriTuruID == musterituruId && k.MusteriID == musteriId && k.OdemePlaniID == odemeplaniId).FirstOrDefault();

                guncelle.MusteriID = musteriId;
                return "";

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
