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
            // TODO: This line of code loads data into the 'qLBHDataSet.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.qLBHDataSet.SanPham);
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