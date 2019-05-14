using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartBankasi.DLL;
using System.Windows.Forms;

namespace SmartBankasi.BLL.MusteriTurleriislemleri
{
   public  class MusteriTurleriManager:IMusteriturleri
    {
        //******************************************************
        SmartBankDBEntities db = new SmartBankDBEntities();
        //******************************************************

        public void  MusteriTurleri(ComboBox comboMusteriTurleri)
        {
            comboMusteriTurleri.DisplayMember = "TurAdi";
            comboMusteriTurleri.ValueMember = "MusteriTurleriID";
            comboMusteriTurleri.DataSource = db.MusteriTurleri.ToList();
        }
        public List<MusteriTurleri> MusteriTurleri()
        {
            //comboMusteriTurleri.DataSource = db.MusteriTurleri.ToList();
            return db.MusteriTurleri.ToList();
        }
      //------------------------------------
        public string isim;
        public string soyisim;
        //----------------------------------
        public void KurumsalMusteriGetir(string tc)
        {
            var kurMus = db.KurumsalYetkililer.Where(k => k.TC == tc).FirstOrDefault();
            isim= kurMus.Adi;
            soyisim=kurMus.Soyadi ;
        }
        public void BireyselMusteriGetir(string tc)
        {
            var birMus = db.BireyselMusteriler.Where(k => k.TC == tc).FirstOrDefault();
            isim = birMus.Adi;
            soyisim = birMus.Soyadi;
        }


    }
}
