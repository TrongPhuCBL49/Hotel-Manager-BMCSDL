namespace GUI
{
    partial class RoleGUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpChucNang = new DevExpress.XtraEditors.GroupControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuyBo = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.grpThongTin = new DevExpress.XtraEditors.GroupControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.cboIGia = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboITen = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboDPhong = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboIPhong = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboUGia = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.cboUTen = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.cboUPhong = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.cboSPhong = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenRole = new DevExpress.XtraEditors.TextEdit();
            this.grpDanhSach = new DevExpress.XtraEditors.GroupControl();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.dgvRole = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ITEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grpChucNang)).BeginInit();
            this.grpChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpThongTin)).BeginInit();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboITen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboUGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboUTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboUPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDanhSach)).BeginInit();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpChucNang
            // 
            this.grpChucNang.Controls.Add(this.btnXoa);
            this.grpChucNang.Controls.Add(this.btnLuu);
            this.grpChucNang.Controls.Add(this.btnHuyBo);
            this.grpChucNang.Controls.Add(this.btnThem);
            this.grpChucNang.Location = new System.Drawing.Point(1375, 4);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(570, 447);
            this.grpChucNang.TabIndex = 18;
            this.grpChucNang.Text = "Chức năng";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(46, 273);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(212, 70);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(313, 273);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(212, 70);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Location = new System.Drawing.Point(313, 130);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(212, 70);
            this.btnHuyBo.TabIndex = 10;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(46, 130);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(212, 70);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.txtID);
            this.grpThongTin.Controls.Add(this.cboIGia);
            this.grpThongTin.Controls.Add(this.cboITen);
            this.grpThongTin.Controls.Add(this.cboDPhong);
            this.grpThongTin.Controls.Add(this.cboIPhong);
            this.grpThongTin.Controls.Add(this.cboUGia);
            this.grpThongTin.Controls.Add(this.labelControl12);
            this.grpThongTin.Controls.Add(this.cboUTen);
            this.grpThongTin.Controls.Add(this.labelControl11);
            this.grpThongTin.Controls.Add(this.cboUPhong);
            this.grpThongTin.Controls.Add(this.labelControl10);
            this.grpThongTin.Controls.Add(this.labelControl5);
            this.grpThongTin.Controls.Add(this.labelControl9);
            this.grpThongTin.Controls.Add(this.cboSPhong);
            this.grpThongTin.Controls.Add(this.labelControl4);
            this.grpThongTin.Controls.Add(this.labelControl3);
            this.grpThongTin.Controls.Add(this.labelControl7);
            this.grpThongTin.Controls.Add(this.labelControl1);
            this.grpThongTin.Controls.Add(this.labelControl2);
            this.grpThongTin.Controls.Add(this.txtTenRole);
            this.grpThongTin.Location = new System.Drawing.Point(5, 4);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(1364, 447);
            this.grpThongTin.TabIndex = 17;
            this.grpThongTin.Text = "Thông tin Role";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(158, 177);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(362, 50);
            this.txtID.TabIndex = 20;
            // 
            // cboIGia
            // 
            this.cboIGia.Location = new System.Drawing.Point(1196, 354);
            this.cboIGia.Name = "cboIGia";
            this.cboIGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIGia.Size = new System.Drawing.Size(121, 50);
            this.cboIGia.TabIndex = 19;
            this.cboIGia.Click += new System.EventHandler(this.txt_Click);
            // 
            // cboITen
            // 
            this.cboITen.Location = new System.Drawing.Point(1196, 266);
            this.cboITen.Name = "cboITen";
            this.cboITen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboITen.Size = new System.Drawing.Size(121, 50);
            this.cboITen.TabIndex = 19;
            this.cboITen.Click += new System.EventHandler(this.txt_Click);
            // 
            // cboDPhong
            // 
            this.cboDPhong.Location = new System.Drawing.Point(1196, 178);
            this.cboDPhong.Name = "cboDPhong";
            this.cboDPhong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDPhong.Size = new System.Drawing.Size(121, 50);
            this.cboDPhong.TabIndex = 19;
            this.cboDPhong.Click += new System.EventHandler(this.txt_Click);
            // 
            // cboIPhong
            // 
            this.cboIPhong.Location = new System.Drawing.Point(1196, 88);
            this.cboIPhong.Name = "cboIPhong";
            this.cboIPhong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIPhong.Size = new System.Drawing.Size(121, 50);
            this.cboIPhong.TabIndex = 19;
            this.cboIPhong.Click += new System.EventHandler(this.txt_Click);
            // 
            // cboUGia
            // 
            this.cboUGia.Location = new System.Drawing.Point(784, 354);
            this.cboUGia.Name = "cboUGia";
            this.cboUGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboUGia.Size = new System.Drawing.Size(121, 50);
            this.cboUGia.TabIndex = 19;
            this.cboUGia.Click += new System.EventHandler(this.txt_Click);
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(993, 363);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(204, 33);
            this.labelControl12.TabIndex = 10;
            this.labelControl12.Text = "Thêm giá phòng:";
            // 
            // cboUTen
            // 
            this.cboUTen.Location = new System.Drawing.Point(784, 266);
            this.cboUTen.Name = "cboUTen";
            this.cboUTen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboUTen.Size = new System.Drawing.Size(121, 50);
            this.cboUTen.TabIndex = 19;
            this.cboUTen.Click += new System.EventHandler(this.txt_Click);
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(993, 275);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(207, 33);
            this.labelControl11.TabIndex = 10;
            this.labelControl11.Text = "Thêm tên phòng:";
            // 
            // cboUPhong
            // 
            this.cboUPhong.Location = new System.Drawing.Point(784, 178);
            this.cboUPhong.Name = "cboUPhong";
            this.cboUPhong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboUPhong.Size = new System.Drawing.Size(121, 50);
            this.cboUPhong.TabIndex = 19;
            this.cboUPhong.Click += new System.EventHandler(this.txt_Click);
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(594, 363);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(189, 34);
            this.labelControl10.TabIndex = 10;
            this.labelControl10.Text = "Sửa giá phòng:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(993, 186);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(138, 33);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Xóa phòng:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(594, 275);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(193, 34);
            this.labelControl9.TabIndex = 10;
            this.labelControl9.Text = "Sửa tên phòng:";
            // 
            // cboSPhong
            // 
            this.cboSPhong.Location = new System.Drawing.Point(784, 88);
            this.cboSPhong.Name = "cboSPhong";
            this.cboSPhong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSPhong.Size = new System.Drawing.Size(121, 50);
            this.cboSPhong.TabIndex = 19;
            this.cboSPhong.Click += new System.EventHandler(this.txt_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(594, 186);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(144, 34);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Sửa phòng:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(993, 97);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(161, 33);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Thêm phòng:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(594, 97);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(146, 33);
            this.labelControl7.TabIndex = 10;
            this.labelControl7.Text = "Xem phòng:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(34, 185);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 33);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "ID:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(34, 275);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(108, 33);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Tên role:";
            // 
            // txtTenRole
            // 
            this.txtTenRole.Location = new System.Drawing.Point(158, 266);
            this.txtTenRole.Name = "txtTenRole";
            this.txtTenRole.Size = new System.Drawing.Size(362, 50);
            this.txtTenRole.TabIndex = 2;
            this.txtTenRole.Click += new System.EventHandler(this.txt_Click);
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.gridSplitContainer1);
            this.grpDanhSach.Location = new System.Drawing.Point(8, 458);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(1937, 803);
            this.grpDanhSach.TabIndex = 16;
            this.grpDanhSach.Text = "Danh sách Roles";
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1.Grid = this.dgvRole;
            this.gridSplitContainer1.Location = new System.Drawing.Point(3, 48);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.dgvRole);
            this.gridSplitContainer1.Size = new System.Drawing.Size(1931, 752);
            this.gridSplitContainer1.TabIndex = 0;
            // 
            // dgvRole
            // 
            this.dgvRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRole.Location = new System.Drawing.Point(0, 0);
            this.dgvRole.MainView = this.gridView1;
            this.dgvRole.Name = "dgvRole";
            this.dgvRole.Size = new System.Drawing.Size(1931, 752);
            this.dgvRole.TabIndex = 0;
            this.dgvRole.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.TEN,
            this.SPHONG,
            this.IPHONG,
            this.UPHONG,
            this.DPHONG,
            this.UTEN,
            this.UGIA,
            this.ITEN,
            this.IGIA});
            this.gridView1.DetailHeight = 397;
            this.gridView1.GridControl = this.dgvRole;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.MinWidth = 18;
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 82;
            // 
            // TEN
            // 
            this.TEN.Caption = "Tên role";
            this.TEN.FieldName = "TEN";
            this.TEN.MinWidth = 18;
            this.TEN.Name = "TEN";
            this.TEN.Visible = true;
            this.TEN.VisibleIndex = 1;
            this.TEN.Width = 202;
            // 
            // SPHONG
            // 
            this.SPHONG.Caption = "Xem phòng";
            this.SPHONG.FieldName = "SPHONG";
            this.SPHONG.MinWidth = 18;
            this.SPHONG.Name = "SPHONG";
            this.SPHONG.Visible = true;
            this.SPHONG.VisibleIndex = 2;
            this.SPHONG.Width = 197;
            // 
            // IPHONG
            // 
            this.IPHONG.Caption = "Thêm phòng";
            this.IPHONG.FieldName = "IPHONG";
            this.IPHONG.MinWidth = 18;
            this.IPHONG.Name = "IPHONG";
            this.IPHONG.Visible = true;
            this.IPHONG.VisibleIndex = 3;
            this.IPHONG.Width = 213;
            // 
            // UPHONG
            // 
            this.UPHONG.Caption = "Sửa phòng";
            this.UPHONG.FieldName = "UPHONG";
            this.UPHONG.MinWidth = 18;
            this.UPHONG.Name = "UPHONG";
            this.UPHONG.Visible = true;
            this.UPHONG.VisibleIndex = 4;
            this.UPHONG.Width = 189;
            // 
            // DPHONG
            // 
            this.DPHONG.Caption = "Xóa phòng";
            this.DPHONG.FieldName = "DPHONG";
            this.DPHONG.MinWidth = 18;
            this.DPHONG.Name = "DPHONG";
            this.DPHONG.Visible = true;
            this.DPHONG.VisibleIndex = 5;
            this.DPHONG.Width = 175;
            // 
            // UTEN
            // 
            this.UTEN.Caption = "Sửa tên phòng";
            this.UTEN.FieldName = "UTEN";
            this.UTEN.MinWidth = 19;
            this.UTEN.Name = "UTEN";
            this.UTEN.Visible = true;
            this.UTEN.VisibleIndex = 6;
            this.UTEN.Width = 204;
            // 
            // UGIA
            // 
            this.UGIA.Caption = "Sửa giá phòng";
            this.UGIA.FieldName = "UGIA";
            this.UGIA.MinWidth = 19;
            this.UGIA.Name = "UGIA";
            this.UGIA.Visible = true;
            this.UGIA.VisibleIndex = 7;
            this.UGIA.Width = 194;
            // 
            // ITEN
            // 
            this.ITEN.Caption = "Thêm tên phòng";
            this.ITEN.FieldName = "ITEN";
            this.ITEN.MinWidth = 19;
            this.ITEN.Name = "ITEN";
            this.ITEN.Visible = true;
            this.ITEN.VisibleIndex = 8;
            this.ITEN.Width = 218;
            // 
            // IGIA
            // 
            this.IGIA.Caption = "Thêm giá phòng";
            this.IGIA.FieldName = "IGIA";
            this.IGIA.MinWidth = 19;
            this.IGIA.Name = "IGIA";
            this.IGIA.Visible = true;
            this.IGIA.VisibleIndex = 9;
            this.IGIA.Width = 217;
            // 
            // RoleGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.grpDanhSach);
            this.Name = "RoleGUI";
            this.Size = new System.Drawing.Size(1948, 1265);
            this.Load += new System.EventHandler(this.RoleGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpChucNang)).EndInit();
            this.grpChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpThongTin)).EndInit();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboITen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboUGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboUTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboUPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDanhSach)).EndInit();
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpChucNang;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnHuyBo;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.GroupControl grpThongTin;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTenRole;
        private DevExpress.XtraEditors.GroupControl grpDanhSach;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraGrid.GridControl dgvRole;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn TEN;
        private DevExpress.XtraGrid.Columns.GridColumn SPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn IPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn UPHONG;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.ComboBoxEdit cboIGia;
        private DevExpress.XtraEditors.ComboBoxEdit cboITen;
        private DevExpress.XtraEditors.ComboBoxEdit cboDPhong;
        private DevExpress.XtraEditors.ComboBoxEdit cboIPhong;
        private DevExpress.XtraEditors.ComboBoxEdit cboUGia;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.ComboBoxEdit cboUTen;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.ComboBoxEdit cboUPhong;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.ComboBoxEdit cboSPhong;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn DPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn UTEN;
        private DevExpress.XtraGrid.Columns.GridColumn UGIA;
        private DevExpress.XtraGrid.Columns.GridColumn ITEN;
        private DevExpress.XtraGrid.Columns.GridColumn IGIA;
    }
}
