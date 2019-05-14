using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartBankasi.DLL;

namespace SmartBankasi.BLL.Urunislemleri
{
    public class UrunManager : IUrunler
    {

        SmartBankDBEntities db = new SmartBankDBEntities();
        #region Ürün Detaylari
        public string UrunDetayGuncelle(int urundetaylarId, string detaybilgisi, int urunId)
        {
            throw new NotImplementedException();
        }

        public string UrunDetayKaydet(string detaybilgisi, int urunId)
        {
            throw new NotImplementedException();
        }

        public List<UrunDetaylari> UrunDetaylariListesi()
        {
            throw new NotImplementedException();
        }

        public List<UrunDetaylari> UrunDetaylariListesi(int urunId)
        {
            throw new NotImplementedException();
        }

        public string UrunDetaySil(int urundetaylarId)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Ürünler

        public string UrunGuncelle(int urunlerId, string urunadi, int urunturuId, string aciklama)
        {
            try
            {
                Urunler guncelle = db.Urunler.Where(k => k.UrunlerID == urunlerId).FirstOrDefault();
                if (guncelle!=null)
                {
                    if (!string.IsNullOrWhiteSpace(urunadi) && urunturuId > 0)
                    {
                        guncelle.UrunAdi = urunadi;
                        guncelle.UrunTuruID = urunturuId;
                        guncelle.Aciklama = aciklama;
                        if (db.SaveChanges() > 0)
                        {
                            urunlerId = 0;
                            return urunadi + " " + "adlı ürün başarılı bir şekilde güncellendi";
                        }
                        return "Ürün güncelleme başarısız";
                    }
                    return "Boş alanları doldurun";
                }
                return "Seçim yapmadınız";
            }
            catch (Exception)
            {
                return "Güncelleme esnasında hata oluştu";
            }
        }

        public string UrunKaydet(string urunadi, int urunturuId, string aciklama)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(urunadi)&& urunturuId>0)
                {
                    Urunler ekle = new Urunler();
                    ekle.UrunAdi = urunadi;
                    ekle.UrunTuruID = urunturuId;
                    ekle.Aciklama = aciklama;
                    db.Urunler.Add(ekle);
                    if (db.SaveChanges()>0)
                    {
                        return urunadi + " " + "adlı ürün başarılı bir şekilde eklendi";
                    }
                    return "Ürün ekleme başarısız";
                }
                return "Boş alanları doldurun";
            }
            catch (Exception)
            {
                return "Hata";
            }
        }

        public List<Urunler> UrunListesi()
        {
            throw new NotImplementedException();
        }

        public string UrunSil(int urunlerId)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Ürün Türleri
        public string UrunTuruGuncelle(int urunturleriId, string adi, string aciklama)
        {
            throw new NotImplementedException();
        }

        public string UrunTuruKaydet(string adi, string aciklama)
        {
            throw new NotImplementedException();
        }

        public string UrunTuruSil(int urunturleriId)
        {
            throw new NotImplementedException();
        } 
        #endregion
    }
}
