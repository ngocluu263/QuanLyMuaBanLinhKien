using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using System.Data.Linq;

namespace QuanLyMuaBanLinhKien.View
{
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            DBQuanLyDataContext DB = new DBQuanLyDataContext();
            Table<NhaCungCap> NhaCungCap = DB.GetTable<NhaCungCap>();
            var query = from ncc in NhaCungCap
                        select ncc;
            gridNhaCungCap.DataSource = query;
        }
    }
}
