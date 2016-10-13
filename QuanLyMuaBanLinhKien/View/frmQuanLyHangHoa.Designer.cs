namespace QuanLyMuaBanLinhKien
{
    partial class frmQuanLyHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyHangHoa));
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnAddGood = new DevExpress.XtraNavBar.NavBarItem();
            this.btnEditGood = new DevExpress.XtraNavBar.NavBarItem();
            this.btnDeleteGood = new DevExpress.XtraNavBar.NavBarItem();
            this.btnSearchGood = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnPrintGoodList = new DevExpress.XtraNavBar.NavBarItem();
            this.btnExportGoodList = new DevExpress.XtraNavBar.NavBarItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gridHangHoa = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.btnAddGood,
            this.btnEditGood,
            this.btnDeleteGood,
            this.btnSearchGood,
            this.btnPrintGoodList,
            this.btnExportGoodList});
            this.navBarControl1.Location = new System.Drawing.Point(0, 1);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 165;
            this.navBarControl1.Size = new System.Drawing.Size(165, 440);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Quản Lý";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnAddGood),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnEditGood),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnDeleteGood),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnSearchGood)});
            this.navBarGroup1.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup1.LargeImage")));
            this.navBarGroup1.Name = "navBarGroup1";
            this.navBarGroup1.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup1.SmallImage")));
            // 
            // btnAddGood
            // 
            this.btnAddGood.Caption = "Thêm";
            this.btnAddGood.Name = "btnAddGood";
            this.btnAddGood.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnAddGood.SmallImage")));
            // 
            // btnEditGood
            // 
            this.btnEditGood.Caption = "Sửa";
            this.btnEditGood.Name = "btnEditGood";
            this.btnEditGood.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnEditGood.SmallImage")));
            // 
            // btnDeleteGood
            // 
            this.btnDeleteGood.Caption = "Xóa";
            this.btnDeleteGood.Name = "btnDeleteGood";
            this.btnDeleteGood.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteGood.SmallImage")));
            // 
            // btnSearchGood
            // 
            this.btnSearchGood.Caption = "Tìm Kiếm";
            this.btnSearchGood.Name = "btnSearchGood";
            this.btnSearchGood.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnSearchGood.SmallImage")));
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Xuất";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnPrintGoodList),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnExportGoodList)});
            this.navBarGroup2.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup2.LargeImage")));
            this.navBarGroup2.Name = "navBarGroup2";
            this.navBarGroup2.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup2.SmallImage")));
            // 
            // btnPrintGoodList
            // 
            this.btnPrintGoodList.Caption = "In danh sách";
            this.btnPrintGoodList.Name = "btnPrintGoodList";
            this.btnPrintGoodList.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnPrintGoodList.SmallImage")));
            // 
            // btnExportGoodList
            // 
            this.btnExportGoodList.Caption = "Xuất ra Excel";
            this.btnExportGoodList.Name = "btnExportGoodList";
            this.btnExportGoodList.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnExportGoodList.SmallImage")));
            // 
            // layoutControl1
            // 
            this.layoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControl1.Controls.Add(this.textEdit4);
            this.layoutControl1.Controls.Add(this.comboBoxEdit1);
            this.layoutControl1.Controls.Add(this.gridHangHoa);
            this.layoutControl1.Controls.Add(this.textEdit5);
            this.layoutControl1.Controls.Add(this.textEdit3);
            this.layoutControl1.Controls.Add(this.textEdit2);
            this.layoutControl1.Controls.Add(this.textEdit1);
            this.layoutControl1.Location = new System.Drawing.Point(159, 1);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(478, 134, 420, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(677, 438);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(416, 60);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(249, 20);
            this.textEdit4.StyleController = this.layoutControl1;
            this.textEdit4.TabIndex = 12;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(416, 36);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(249, 20);
            this.comboBoxEdit1.StyleController = this.layoutControl1;
            this.comboBoxEdit1.TabIndex = 11;
            this.comboBoxEdit1.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // gridHangHoa
            // 
            this.gridHangHoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridHangHoa.Location = new System.Drawing.Point(12, 84);
            this.gridHangHoa.MainView = this.gridView1;
            this.gridHangHoa.Name = "gridHangHoa";
            this.gridHangHoa.ShowOnlyPredefinedDetails = true;
            this.gridHangHoa.Size = new System.Drawing.Size(653, 342);
            this.gridHangHoa.TabIndex = 10;
            this.gridHangHoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridHangHoa;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // textEdit5
            // 
            this.textEdit5.Location = new System.Drawing.Point(88, 60);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Size = new System.Drawing.Size(248, 20);
            this.textEdit5.StyleController = this.layoutControl1;
            this.textEdit5.TabIndex = 8;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(88, 36);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(248, 20);
            this.textEdit3.StyleController = this.layoutControl1;
            this.textEdit3.TabIndex = 6;
            this.textEdit3.EditValueChanged += new System.EventHandler(this.textEdit3_EditValueChanged);
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(416, 12);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(249, 20);
            this.textEdit2.StyleController = this.layoutControl1;
            this.textEdit2.TabIndex = 5;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(88, 12);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(248, 20);
            this.textEdit1.StyleController = this.layoutControl1;
            this.textEdit1.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem7,
            this.layoutControlItem4,
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(677, 438);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(328, 24);
            this.layoutControlItem1.Text = "Mã Hàng:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(73, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textEdit2;
            this.layoutControlItem2.Location = new System.Drawing.Point(328, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(329, 24);
            this.layoutControlItem2.Text = "Tên Hàng:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(73, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.textEdit3;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(328, 24);
            this.layoutControlItem3.Text = "Nhà Cung Cấp:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(73, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.textEdit5;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(328, 24);
            this.layoutControlItem5.Text = "Số Lượng Tồn:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(73, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.gridHangHoa;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(657, 346);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.comboBoxEdit1;
            this.layoutControlItem4.Location = new System.Drawing.Point(328, 24);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(130, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(329, 24);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "Đơn Vị Tính:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(73, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.textEdit4;
            this.layoutControlItem6.Location = new System.Drawing.Point(328, 48);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(329, 24);
            this.layoutControlItem6.Text = "Đơn Giá:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(73, 13);
            // 
            // frmQuanLyHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 440);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.navBarControl1);
            this.Name = "frmQuanLyHangHoa";
            this.Text = "Quản Lý Hàng Hóa";
            this.Load += new System.EventHandler(this.frmQuanLyHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem btnAddGood;
        private DevExpress.XtraNavBar.NavBarItem btnEditGood;
        private DevExpress.XtraNavBar.NavBarItem btnDeleteGood;
        private DevExpress.XtraNavBar.NavBarItem btnSearchGood;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem btnPrintGoodList;
        private DevExpress.XtraNavBar.NavBarItem btnExportGoodList;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraGrid.GridControl gridHangHoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
    }
}