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
using QuanLyMuaBanLinhKien.Enum;

using DataAccessLayer;
using System.Data.Linq;

namespace QuanLyMuaBanLinhKien
{
    public partial class frmQuanLyHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public frmQuanLyHangHoa(AccountType Type)
        {
            InitializeComponent();
            if(Type == AccountType.Saler)
            {
                DeactiveButton();
            }
        }

        private void frmQuanLyHangHoa_Load(object sender, EventArgs e)
        {
            DBQuanLyDataContext DB = new DBQuanLyDataContext();
            Table<SanPham> SanPham = DB.GetTable<SanPham>();
            Table<NhaCungCap> NhaCungCap = DB.GetTable<NhaCungCap>();
            Table<LoaiHang> LoaiHang = DB.GetTable<LoaiHang>();
            var query = from sp in SanPham
                        join ncc in NhaCungCap on sp.maNhaCungCap equals ncc.maNhaCungCap
                        join lh in LoaiHang on sp.maLoaiHang equals lh.maLoaiHang
                        select new {sp.maSanPham, sp.tenSanPham, lh.tenLoaiHang, ncc.tenNhaCungCap, sp.donViTinh, sp.donGia, sp.soLuongTon };
            gridHangHoa.DataSource = query;
        }

        private void DeactiveButton()
        {
            btnAddGood.Enabled = false;
            btnDeleteGood.Enabled = false;
            btnEditGood.Enabled = false;
            btnExportGoodList.Enabled = false;
            btnPrintGoodList.Enabled = false;
        }

        private void ActiveTextbox(bool active)
        {

        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}