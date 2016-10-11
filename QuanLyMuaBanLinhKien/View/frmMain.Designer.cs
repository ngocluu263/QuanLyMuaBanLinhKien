namespace QuanLyMuaBanLinhKien
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barHangHoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaiHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoHoaDonMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoaDon = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuatNhanVienExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnInDanhSachNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.ribBanHang = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribQuanLy = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribKhachHangGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribNhanVienGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribHoaDonGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribTaiKhoan = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribGioiThieu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.btnNhaCungCap = new DevExpress.XtraBars.BarButtonItem();
            this.btnSearch = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barHangHoa,
            this.btnLoaiHang,
            this.btnTaoHoaDonMoi,
            this.btnKhachHang,
            this.barButtonItem3,
            this.barButtonItem4,
            this.btnHoaDon,
            this.barButtonItem5,
            this.barButtonItem6,
            this.btnNhanVien,
            this.btnXuatNhanVienExcel,
            this.btnInDanhSachNhanVien,
            this.btnNhaCungCap,
            this.btnSearch});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 26;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribBanHang,
            this.ribQuanLy,
            this.ribHeThong,
            this.ribTaiKhoan,
            this.ribGioiThieu});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl1.Size = new System.Drawing.Size(1022, 133);
            // 
            // barHangHoa
            // 
            this.barHangHoa.Caption = "Hàng Hóa";
            this.barHangHoa.Glyph = ((System.Drawing.Image)(resources.GetObject("barHangHoa.Glyph")));
            this.barHangHoa.Id = 4;
            this.barHangHoa.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barHangHoa.LargeGlyph")));
            this.barHangHoa.Name = "barHangHoa";
            this.barHangHoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barHangHoa_ItemClick);
            // 
            // btnLoaiHang
            // 
            this.btnLoaiHang.Caption = "Loại Hàng";
            this.btnLoaiHang.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLoaiHang.Glyph")));
            this.btnLoaiHang.Id = 5;
            this.btnLoaiHang.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnLoaiHang.LargeGlyph")));
            this.btnLoaiHang.Name = "btnLoaiHang";
            // 
            // btnTaoHoaDonMoi
            // 
            this.btnTaoHoaDonMoi.Caption = "Hóa Đơn Mới";
            this.btnTaoHoaDonMoi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnTaoHoaDonMoi.Glyph")));
            this.btnTaoHoaDonMoi.Id = 6;
            this.btnTaoHoaDonMoi.ImageUri.Uri = "AddItem";
            this.btnTaoHoaDonMoi.Name = "btnTaoHoaDonMoi";
            this.btnTaoHoaDonMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoPhieu_ItemClick);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Caption = "Khách Hàng";
            this.btnKhachHang.Glyph = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.Glyph")));
            this.btnKhachHang.Id = 7;
            this.btnKhachHang.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.LargeGlyph")));
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhachHang_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "In Danh Sách";
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 11;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Xuất Ra Excel";
            this.barButtonItem4.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.Glyph")));
            this.barButtonItem4.Id = 12;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Caption = "Danh sách";
            this.btnHoaDon.Glyph = ((System.Drawing.Image)(resources.GetObject("btnHoaDon.Glyph")));
            this.btnHoaDon.Id = 16;
            this.btnHoaDon.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnHoaDon.LargeGlyph")));
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHoaDon_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "In danh sách";
            this.barButtonItem5.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.Glyph")));
            this.barButtonItem5.Id = 17;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Xuất ra Excel";
            this.barButtonItem6.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.Glyph")));
            this.barButtonItem6.Id = 18;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Danh Sách Nhân Viên";
            this.btnNhanVien.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Glyph")));
            this.btnNhanVien.Id = 21;
            this.btnNhanVien.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.LargeGlyph")));
            this.btnNhanVien.Name = "btnNhanVien";
            // 
            // btnXuatNhanVienExcel
            // 
            this.btnXuatNhanVienExcel.Caption = "Xuất Ra Excel";
            this.btnXuatNhanVienExcel.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXuatNhanVienExcel.Glyph")));
            this.btnXuatNhanVienExcel.Id = 22;
            this.btnXuatNhanVienExcel.Name = "btnXuatNhanVienExcel";
            // 
            // btnInDanhSachNhanVien
            // 
            this.btnInDanhSachNhanVien.Caption = "In Danh Sách";
            this.btnInDanhSachNhanVien.Glyph = ((System.Drawing.Image)(resources.GetObject("btnInDanhSachNhanVien.Glyph")));
            this.btnInDanhSachNhanVien.Id = 23;
            this.btnInDanhSachNhanVien.Name = "btnInDanhSachNhanVien";
            // 
            // ribBanHang
            // 
            this.ribBanHang.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4});
            this.ribBanHang.Name = "ribBanHang";
            this.ribBanHang.Text = "CHỨC NĂNG";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTaoHoaDonMoi);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnHoaDon);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Bán Hàng";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Thống Kê";
            // 
            // ribQuanLy
            // 
            this.ribQuanLy.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribKhachHangGroup,
            this.ribNhanVienGroup,
            this.ribHoaDonGroup,
            this.ribbonPageGroup3,
            this.ribbonPageGroup2});
            this.ribQuanLy.Name = "ribQuanLy";
            this.ribQuanLy.Text = "QUẢN LÝ";
            // 
            // ribKhachHangGroup
            // 
            this.ribKhachHangGroup.ItemLinks.Add(this.btnKhachHang);
            this.ribKhachHangGroup.ItemLinks.Add(this.barButtonItem4);
            this.ribKhachHangGroup.ItemLinks.Add(this.barButtonItem3);
            this.ribKhachHangGroup.Name = "ribKhachHangGroup";
            this.ribKhachHangGroup.Text = "Khách Hàng";
            // 
            // ribNhanVienGroup
            // 
            this.ribNhanVienGroup.ItemLinks.Add(this.btnNhanVien);
            this.ribNhanVienGroup.ItemLinks.Add(this.btnXuatNhanVienExcel);
            this.ribNhanVienGroup.ItemLinks.Add(this.btnInDanhSachNhanVien);
            this.ribNhanVienGroup.Name = "ribNhanVienGroup";
            this.ribNhanVienGroup.Text = "Nhân Viên";
            // 
            // ribHoaDonGroup
            // 
            this.ribHoaDonGroup.Name = "ribHoaDonGroup";
            this.ribHoaDonGroup.Text = "Báo Cáo";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barHangHoa);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnLoaiHang);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnNhaCungCap);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Hàng Hóa";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSearch);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Tìm Kiếm";
            // 
            // ribHeThong
            // 
            this.ribHeThong.Name = "ribHeThong";
            this.ribHeThong.Text = "HỆ THỐNG";
            // 
            // ribTaiKhoan
            // 
            this.ribTaiKhoan.Name = "ribTaiKhoan";
            this.ribTaiKhoan.Text = "TÀI KHOẢN";
            // 
            // ribGioiThieu
            // 
            this.ribGioiThieu.Name = "ribGioiThieu";
            this.ribGioiThieu.Text = "GIỚI THIỆU";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // btnNhaCungCap
            // 
            this.btnNhaCungCap.Caption = "Nhà Cung Cấp";
            this.btnNhaCungCap.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNhaCungCap.Glyph")));
            this.btnNhaCungCap.Id = 24;
            this.btnNhaCungCap.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNhaCungCap.LargeGlyph")));
            this.btnNhaCungCap.Name = "btnNhaCungCap";
            // 
            // btnSearch
            // 
            this.btnSearch.Caption = "Tìm Kiếm";
            this.btnSearch.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSearch.Glyph")));
            this.btnSearch.Id = 25;
            this.btnSearch.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSearch.LargeGlyph")));
            this.btnSearch.Name = "btnSearch";
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 448);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý mua bán linh kiện máy tính";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribBanHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribQuanLy;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribTaiKhoan;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribGioiThieu;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribKhachHangGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribNhanVienGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribHoaDonGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barHangHoa;
        private DevExpress.XtraBars.BarButtonItem btnLoaiHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnTaoHoaDonMoi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnKhachHang;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem btnHoaDon;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnXuatNhanVienExcel;
        private DevExpress.XtraBars.BarButtonItem btnInDanhSachNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnNhaCungCap;
        private DevExpress.XtraBars.BarButtonItem btnSearch;
    }
}

