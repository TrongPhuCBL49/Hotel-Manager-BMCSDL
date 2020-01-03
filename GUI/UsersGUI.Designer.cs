namespace GUI
{
    partial class UsersGUI
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
            this.cboChucDanh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboGioiTinh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCMND = new DevExpress.XtraEditors.TextEdit();
            this.txtTenNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.grpDanhSach = new DevExpress.XtraEditors.GroupControl();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.dgvNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Profile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Role = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Active = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grpChucNang)).BeginInit();
            this.grpChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpThongTin)).BeginInit();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboChucDanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGioiTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDanhSach)).BeginInit();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpChucNang
            // 
            this.grpChucNang.Controls.Add(this.btnXoa);
            this.grpChucNang.Controls.Add(this.btnLuu);
            this.grpChucNang.Controls.Add(this.btnHuyBo);
            this.grpChucNang.Controls.Add(this.btnThem);
            this.grpChucNang.Location = new System.Drawing.Point(1563, 7);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(649, 403);
            this.grpChucNang.TabIndex = 15;
            this.grpChucNang.Text = "Chức năng";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(49, 264);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(241, 62);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(353, 264);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(241, 62);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Location = new System.Drawing.Point(353, 138);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(241, 62);
            this.btnHuyBo.TabIndex = 10;
            this.btnHuyBo.Text = "Hủy bỏ";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(49, 138);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(241, 62);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.cboChucDanh);
            this.grpThongTin.Controls.Add(this.cboGioiTinh);
            this.grpThongTin.Controls.Add(this.cboNgaySinh);
            this.grpThongTin.Controls.Add(this.labelControl7);
            this.grpThongTin.Controls.Add(this.labelControl8);
            this.grpThongTin.Controls.Add(this.txtDiaChi);
            this.grpThongTin.Controls.Add(this.labelControl4);
            this.grpThongTin.Controls.Add(this.labelControl1);
            this.grpThongTin.Controls.Add(this.labelControl9);
            this.grpThongTin.Controls.Add(this.labelControl2);
            this.grpThongTin.Controls.Add(this.txtCMND);
            this.grpThongTin.Controls.Add(this.txtTenNhanVien);
            this.grpThongTin.Controls.Add(this.labelControl5);
            this.grpThongTin.Controls.Add(this.txtSDT);
            this.grpThongTin.Controls.Add(this.labelControl6);
            this.grpThongTin.Controls.Add(this.labelControl3);
            this.grpThongTin.Controls.Add(this.txtEmail);
            this.grpThongTin.Controls.Add(this.txtID);
            this.grpThongTin.Location = new System.Drawing.Point(5, 4);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(1552, 406);
            this.grpThongTin.TabIndex = 14;
            this.grpThongTin.Text = "Thông tin User";
            // 
            // cboChucDanh
            // 
            this.cboChucDanh.Location = new System.Drawing.Point(251, 138);
            this.cboChucDanh.Name = "cboChucDanh";
            this.cboChucDanh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboChucDanh.Size = new System.Drawing.Size(362, 50);
            this.cboChucDanh.TabIndex = 3;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.Location = new System.Drawing.Point(251, 272);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboGioiTinh.Size = new System.Drawing.Size(362, 50);
            this.cboGioiTinh.TabIndex = 7;
            // 
            // cboNgaySinh
            // 
            this.cboNgaySinh.EditValue = null;
            this.cboNgaySinh.Location = new System.Drawing.Point(251, 205);
            this.cboNgaySinh.Name = "cboNgaySinh";
            this.cboNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNgaySinh.Size = new System.Drawing.Size(362, 50);
            this.cboNgaySinh.TabIndex = 5;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(763, 142);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(83, 33);
            this.labelControl7.TabIndex = 10;
            this.labelControl7.Text = "CMND:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(763, 213);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(173, 34);
            this.labelControl8.TabIndex = 12;
            this.labelControl8.Text = "Số điện thoại:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(954, 272);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(531, 50);
            this.txtDiaChi.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(64, 276);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(113, 34);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Giới tính:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(64, 74);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(164, 33);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "ID Nhân viên:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(64, 142);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(144, 34);
            this.labelControl9.TabIndex = 10;
            this.labelControl9.Text = "Chức danh:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(763, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(131, 34);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Họ và tên:";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(954, 138);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(531, 50);
            this.txtCMND.TabIndex = 4;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(954, 70);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(531, 50);
            this.txtTenNhanVien.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(763, 276);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(95, 34);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Địa chỉ:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(954, 210);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(531, 50);
            this.txtSDT.TabIndex = 6;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(64, 341);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(74, 33);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Email:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(64, 214);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(126, 33);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Ngày sinh:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(251, 337);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(1234, 50);
            this.txtEmail.TabIndex = 9;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(251, 70);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(362, 50);
            this.txtID.TabIndex = 1;
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.gridSplitContainer1);
            this.grpDanhSach.Location = new System.Drawing.Point(8, 416);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(2204, 696);
            this.grpDanhSach.TabIndex = 13;
            this.grpDanhSach.Text = "Danh sách Users";
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1.Grid = this.dgvNhanVien;
            this.gridSplitContainer1.Location = new System.Drawing.Point(3, 48);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.dgvNhanVien);
            this.gridSplitContainer1.Size = new System.Drawing.Size(2198, 645);
            this.gridSplitContainer1.TabIndex = 0;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 0);
            this.dgvNhanVien.MainView = this.gridView1;
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(2198, 645);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDNhanVien,
            this.Ten,
            this.Username,
            this.Quota,
            this.Profile,
            this.Role,
            this.Active});
            this.gridView1.GridControl = this.dgvNhanVien;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // IDNhanVien
            // 
            this.IDNhanVien.Caption = "ID Nhân viên";
            this.IDNhanVien.FieldName = "IDNhanVien";
            this.IDNhanVien.Name = "IDNhanVien";
            this.IDNhanVien.Visible = true;
            this.IDNhanVien.VisibleIndex = 0;
            this.IDNhanVien.Width = 205;
            // 
            // Ten
            // 
            this.Ten.Caption = "Họ và tên";
            this.Ten.FieldName = "Ten";
            this.Ten.Name = "Ten";
            this.Ten.Visible = true;
            this.Ten.VisibleIndex = 1;
            this.Ten.Width = 344;
            // 
            // Username
            // 
            this.Username.Caption = "Username";
            this.Username.FieldName = "Username";
            this.Username.Name = "Username";
            this.Username.Visible = true;
            this.Username.VisibleIndex = 2;
            this.Username.Width = 309;
            // 
            // Quota
            // 
            this.Quota.Caption = "Quota";
            this.Quota.FieldName = "Quota";
            this.Quota.Name = "Quota";
            this.Quota.Visible = true;
            this.Quota.VisibleIndex = 3;
            this.Quota.Width = 157;
            // 
            // Profile
            // 
            this.Profile.Caption = "Profile";
            this.Profile.FieldName = "Profile";
            this.Profile.Name = "Profile";
            this.Profile.Visible = true;
            this.Profile.VisibleIndex = 4;
            this.Profile.Width = 318;
            // 
            // Role
            // 
            this.Role.Caption = "Role";
            this.Role.FieldName = "Role";
            this.Role.Name = "Role";
            this.Role.Visible = true;
            this.Role.VisibleIndex = 5;
            this.Role.Width = 312;
            // 
            // Active
            // 
            this.Active.Caption = "Active";
            this.Active.FieldName = "Active";
            this.Active.Name = "Active";
            this.Active.Visible = true;
            this.Active.VisibleIndex = 6;
            this.Active.Width = 166;
            // 
            // UsersGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.grpDanhSach);
            this.Name = "UsersGUI";
            this.Size = new System.Drawing.Size(2216, 1116);
            ((System.ComponentModel.ISupportInitialize)(this.grpChucNang)).EndInit();
            this.grpChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpThongTin)).EndInit();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboChucDanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGioiTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDanhSach)).EndInit();
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
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
        private DevExpress.XtraEditors.ComboBoxEdit cboChucDanh;
        private DevExpress.XtraEditors.ComboBoxEdit cboGioiTinh;
        private DevExpress.XtraEditors.DateEdit cboNgaySinh;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCMND;
        private DevExpress.XtraEditors.TextEdit txtTenNhanVien;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.GroupControl grpDanhSach;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraGrid.GridControl dgvNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn IDNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
        private DevExpress.XtraGrid.Columns.GridColumn Username;
        private DevExpress.XtraGrid.Columns.GridColumn Quota;
        private DevExpress.XtraGrid.Columns.GridColumn Profile;
        private DevExpress.XtraGrid.Columns.GridColumn Role;
        private DevExpress.XtraGrid.Columns.GridColumn Active;
    }
}
