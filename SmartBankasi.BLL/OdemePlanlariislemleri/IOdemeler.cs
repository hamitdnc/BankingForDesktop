using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBankasi.BLL.OdemePlanlariislemleri
{
    interface IOdemeler
    {
        string OdemePlaniKaydet(decimal t1, DateTime? t1Tarih, decimal t2, DateTime? t2Tarih, decimal t3, DateTime? t3Tarih, decimal t4, DateTime? t4Tarih, decimal t5, DateTime? t5Tarih, decimal t6, DateTime? t6Tarih, decimal t7, DateTime t7Tarih, decimal t8, DateTime? t8Tarih, decimal t9, DateTime? t9Tarih, decimal t10, DateTime? t10Tarih, decimal t11, DateTime? t11Tarih, decimal t12, DateTime? t12Tarih, int kullaniciID);
        //-*******************************
        string OdemePlaniGuncelle(int OdemePlanlariID,decimal t1, DateTime? t1Tarih, decimal t2, DateTime? t2Tarih, decimal t3, DateTime? t3Tarih, decimal t4, DateTime? t4Tarih, decimal t5, DateTime? t5Tarih, decimal t6, DateTime? t6Tarih, decimal t7, DateTime t7Tarih, decimal t8, DateTime? t8Tarih, decimal t9, DateTime? t9Tarih, decimal t10, DateTime? t10Tarih, decimal t11, DateTime? t11Tarih, decimal t12, DateTime? t12Tarih, int kullaniciID);
        //*************
        string OdemePlaniSil(int OdemePlanlariID);


    }
}
