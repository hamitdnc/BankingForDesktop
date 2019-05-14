using SmartBankasi.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBankasi.BLL.Urunislemleri
{
    interface IUrunler
    {
        //Ürün türlerini bir combobox ta listeleyin eğer vakit kalırda manager de yükleme kodlarını yapın
        //***************Urunler
        string UrunKaydet(string urunadi, int urunturuId, string aciklama);
        string UrunGuncelle(int urunlerId,string urunadi, int urunturuId, string aciklama);
        string UrunSil(int urunlerId);
        List<Urunler> UrunListesi();
        //***Urun Detaylari
        string UrunDetayKaydet(string detaybilgisi, int urunId);
        string UrunDetayGuncelle(int urundetaylarId,string detaybilgisi, int urunId);
        string UrunDetaySil(int urundetaylarId);
        List<UrunDetaylari> UrunDetaylariListesi();
        List<UrunDetaylari> UrunDetaylariListesi(int urunId);
        //**************Ürün Türleri
        string UrunTuruKaydet(string adi, string aciklama);
        string UrunTuruGuncelle(int urunturleriId,string adi, string aciklama);
        string UrunTuruSil(int urunturleriId);

    }
}
