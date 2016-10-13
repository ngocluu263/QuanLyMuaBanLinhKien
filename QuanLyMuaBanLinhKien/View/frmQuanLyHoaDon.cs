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
using System.Data.Linq;

using DataAccessLayer;

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

        private void frmQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            DBQuanLyDataContext DB = new DBQuanLyDataContext();
            Table<HoaDon> HoaDon = DB.GetTable<HoaDon>();
            Table<KhachHang> KhachHang = DB.GetTable<KhachHang>();
            Table<NhanVien> NhanVien = DB.GetTable<NhanVien>();
            var query = from hd in HoaDon
                        join kh in KhachHang on hd.maKhachHang equals kh.maKhachHang
                        join nv in NhanVien on hd.maNhanVien equals nv.maNhanVien
                        select new
                        {
                            hd.maHoaDon, kh.tenKhachHang, nv.tenNhanVien, hd.ngayLap, hd.tongTien
                        };
            gridHoaDon.DataSource = query;
        }
    }
}