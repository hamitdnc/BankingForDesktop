//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartBankasi.DLL
{
    using System;
    using System.Collections.Generic;
    
    public partial class KurumsalMusteriler
    {
        public int KurumsalMusterilerID { get; set; }
        public string KurumAdi { get; set; }
        public string KurumAdres { get; set; }
        public string Telefon1 { get; set; }
        public string Telefon2 { get; set; }
        public string Email { get; set; }
        public string Aciklama { get; set; }
        public Nullable<int> MusteriTuruID { get; set; }
        public Nullable<int> KullaniciID { get; set; }
    }
}
