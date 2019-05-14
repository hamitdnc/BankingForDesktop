using SmartBankasi.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartBankasi.BLL.ililceSecimi
{
 public    class ililceGetir
    {
        SmartBankDBEntities db = new SmartBankDBEntities();
        public void illerListesi(ComboBox comboiller)
        {
            comboiller.DisplayMember = "SehirAdi";
            comboiller.ValueMember = "illerID";
            comboiller.DataSource= db.iller.ToList();
        }

        public void ilcelerListesi(ComboBox comboiller,ComboBox comboilceler)
        {
            comboilceler.DisplayMember = "ilceAdi";
            comboilceler.ValueMember = "ilcelerID";
            comboilceler.DataSource = db.ilceler.Where(k => k.ilID == (int)comboiller.SelectedValue).ToList();
        }
    }
}
