using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyMuaBanLinhKien.View;

namespace QuanLyMuaBanLinhKien
{
    public partial class frmQuanLyHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public frmQuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmThemHoaDon frmThem = new frmThemHoaDon();
            frmThem.Show();
        }
    }
}