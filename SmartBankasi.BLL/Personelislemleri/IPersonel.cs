using SmartBankasi.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid;

namespace SmartBankasi.BLL.Personelislemleri
{
    interface IPersonel
    {
        List<Personeller> PersonelListesi();
      void  PersonelListesi(GridControl gridPersonel);
        string PersonelKaydet(string tc, string adi, string soyadi, bool medenihali,string cinsiyet, DateTime dogumtarihi, string dogumyeri, string resim);
        string PersonelGuncelle(int personellerId,string tc, string adi, string soyadi, bool medenihali, string cinsiyet, DateTime dogumtarihi, string dogumyeri, string resim);
        string PersonelSil(int personellerId);

    }
}
