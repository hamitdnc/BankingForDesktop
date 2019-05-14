using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartBankasi.UI
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        FrmPersoneller frm_p;
        private void barButtonItemPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_p==null|| frm_p.IsDisposed)
            {
                frm_p = new FrmPersoneller();
                frm_p.MdiParent = this;
                frm_p.Show();
            }

        }

        FrmUrunler frm_urun;
        private void barButtonItemUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_urun==null || frm_urun.IsDisposed)
            {
                frm_urun = new FrmUrunler();
                frm_urun.MdiParent = this;
                frm_urun.Show();
            }

        }

        FrmTaksitler frm_tak;
        private void barButtonItemTaksitlendirme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_tak==null || frm_tak.IsDisposed)
            {
                frm_tak = new FrmTaksitler();
                frm_tak.MdiParent = this;
                frm_tak.Show();
            }

        }

        FrmMusteriler frmBirMusteri;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmBirMusteri==null|| frmBirMusteri.IsDisposed)
            {
                frmBirMusteri = new FrmMusteriler();
                frmBirMusteri.MdiParent = this;
                frmBirMusteri.Show();
            }

        }
    }
}
