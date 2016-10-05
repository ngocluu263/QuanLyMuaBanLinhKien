using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyMuaBanLinhKien
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public Form CheckAvailable(Type fType)
        {
            foreach(var f in MdiChildren)
            {
                if(f.GetType() == fType)
                {
                    return f;
                }
            }
            return null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTaoPhieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form BanHangForm = CheckAvailable(typeof(frmBanHang));
            if(BanHangForm != null)
            {
                BanHangForm.Activate();
            } else
            {
                frmBanHang bh = new frmBanHang();
                bh.MdiParent = this;
                bh.Show();
            }
        }

        private void btnKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = CheckAvailable(typeof(frmQuanLyKhachHang));
            if(form != null)
            {
                form.Activate();
            } else
            {
                frmQuanLyKhachHang KhachHangForm = new frmQuanLyKhachHang();
                KhachHangForm.MdiParent = this;
                KhachHangForm.Show();
            }
        }

        private void barHangHoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = CheckAvailable(typeof(frmQuanLyHangHoa));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                frmQuanLyHangHoa frmHangHoa = new frmQuanLyHangHoa(Enum.AccountType.Saler);
                frmHangHoa.MdiParent = this;
                frmHangHoa.Show();
            }
        }

        private void btnHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = CheckAvailable(typeof(frmQuanLyHoaDon));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                frmQuanLyHoaDon frmHoaDon = new frmQuanLyHoaDon();
                frmHoaDon.MdiParent = this;
                frmHoaDon.Show();
            }
        }
    }
}
