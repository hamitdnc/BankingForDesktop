using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartBankasi.DLL;

namespace SmartBankasi.BLL.BireyselMusteriislemleri
{
  public   class BireyselMusterilerManager
    {

        //****************************************************
        SmartBankDBEntities db = new SmartBankDBEntities();
        //******************************************************
        public void BireyselMusteriListesi(GridControl GridListele)
        {
            GridListele.DataSource = db.BireyselMusteriler.ToList();
        }

        public void AdaGoreAra(GridControl GridAdAra,string isim)
        {
            //Contains ile arama yapıyoruz
            GridAdAra.DataSource = db.BireyselMusteriler.Where(x => x.Adi.Contains(isim)).ToList();
        }
        public void TCGoreAra(GridControl GridAdAra, string isim)
        {
            //Contains ile arama yapıyoruz
            GridAdAra.DataSource = db.BireyselMusteriler.Where(x => x.TC.Contains(isim)).ToList();
        }
    }
}
