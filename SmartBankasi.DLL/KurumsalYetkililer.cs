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
    
    public partial class KurumsalYetkililer
    {
        public int KurumsalYetkililerID { get; set; }
        public string TC { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Gorevi { get; set; }
        public string Telefon1 { get; set; }
        public string Telefon2 { get; set; }
        public string Email { get; set; }
        public Nullable<int> KurumsalMusteriID { get; set; }
        public Nullable<int> KullaniciID { get; set; }
    }
}
