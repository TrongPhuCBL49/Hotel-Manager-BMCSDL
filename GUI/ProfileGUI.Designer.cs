namespace GUI
{
    partial class ProfileGUI
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
            this.grpDanhSach = new DevExpress.XtraEditors.GroupControl();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.dgvProfile = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FALSELOGIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SESSIONUSER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CONNECTTIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDLETIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grpChucNang = new DevExpress.XtraEditors.GroupControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuyBo = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.grpThongTin = new DevExpress.XtraEditors.GroupControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtIdleTime = new DevExpress.XtraEditors.TextEdit();
            this.txtConnectTime = new DevExpress.XtraEditors.TextEdit();
            this.txtSessionUser = new DevExpress.XtraEditors.TextEdit();
            this.txtFalseLogin = new DevExpress.XtraEditors.TextEdit();
            this.txtTenProfile = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDanhSach)).BeginInit();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpChucNang)).BeginInit();
            this.grpChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpThongTin)).BeginInit();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdleTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConnectTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSessionUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFalseLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenProfile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.gridSplitContainer1);
            this.grpDanhSach.Location = new System.Drawing.Point(15, 18);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(1192, 1027);
            this.grpDanhSach.TabIndex = 22;
            this.grpDanhSach.Text = "Danh sách profile";
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1.Grid = this.dgvProfile;
            this.gridSplitContainer1.Location = new System.Drawing.Point(3, 48);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.dgvProfile);
            this.gridSplitContainer1.Size = new System.Drawing.Size(1186, 976);
            this.gridSplitContainer1.TabIndex = 0;
            // 
            // dgvProfile
            // 
            this.dgvProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProfile.Location = new System.Drawing.Point(0, 0);
            this.dgvProfile.MainView = this.gridView1;
            this.dgvProfile.Name = "dgvProfile";
            this.dgvProfile.Size = new System.Drawing.Size(1186, 976);
            this.dgvProfile.TabIndex = 0;
            this.dgvProfile.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.TEN,
            this.FALSELOGIN,
            this.SESSIONUSER,
            this.CONNECTTIME,
            this.IDLETIME});
            this.gridView1.DetailHeight = 373;
            this.gridView1.GridControl = this.dgvProfile;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.MinWidth = 19;
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 80;
            // 
            // TEN
            // 
            this.TEN.Caption = "Tên profile";
            this.TEN.FieldName = "TEN";
            this.TEN.MinWidth = 19;
            this.TEN.Name = "TEN";
            this.TEN.Visible = true;
            this.TEN.VisibleIndex = 1;
            this.TEN.Width = 234;
            // 
            // FALSELOGIN
            // 
            this.FALSELOGIN.Caption = "False login";
            this.FALSELOGIN.FieldName = "FALSELOGIN";
            this.FALSELOGIN.MinWidth = 19;
            this.FALSELOGIN.Name = "FALSELOGIN";
            this.FALSELOGIN.Visible = true;
            this.FALSELOGIN.VisibleIndex = 2;
            this.FALSELOGIN.Width = 211;
            // 
            // SESSIONUSER
            // 
            this.SESSIONUSER.Caption = "Session user";
            this.SESSIONUSER.FieldName = "SESSIONUSER";
            this.SESSIONUSER.MinWidth = 19;
            this.SESSIONUSER.Name = "SESSIONUSER";
            this.SESSIONUSER.Visible = true;
            this.SESSIONUSER.VisibleIndex = 3;
            this.SESSIONUSER.Width = 200;
            // 
            // CONNECTTIME
            // 
            this.CONNECTTIME.Caption = "Connect time";
            this.CONNECTTIME.FieldName = "CONNECTTIME";
            this.CONNECTTIME.MinWidth = 19;
            this.CONNECTTIME.Name = "CONNECTTIME";
            this.CONNECTTIME.Visible = true;
            this.CONNECTTIME.VisibleIndex = 4;
            this.CONNECTTIME.Width = 200;
            // 
            // IDLETIME
            // 
            this.IDLETIME.Caption = "Idle time";
            this.IDLETIME.FieldName = "IDLETIME";
            this.IDLETIME.MinWidth = 19;
            this.IDLETIME.Name = "IDLETIME";
            this.IDLETIME.Visible = true;
            this.IDLETIME.VisibleIndex = 5;
            this.IDLETIME.Width = 224;
            // 
            // grpChucNang
            // 
            this.grpChucNang.Controls.Add(this.btnXoa);
            this.grpChucNang.Controls.Add(this.btnLuu);
            this.grpChucNang.Controls.Add(this.btnHuyBo);
            this.grpChucNang.Controls.Add(this.btnThem);
            this.grpChucNang.Location = new System.Drawing.Point(1212, 659);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(685, 386);
            this.grpChucNang.TabIndex = 21;
            this.grpChucNang.Text = "Chức năng";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(88, 255);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(226, 66);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(373, 255);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(226, 66);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Location = new System.Drawing.Point(373, 121);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(226, 66);
            this.btnHuyBo.TabIndex = 6;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(88, 121);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(226, 66);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.labelControl6);
            this.grpThongTin.Controls.Add(this.labelControl1);
            this.grpThongTin.Controls.Add(this.labelControl4);
            this.grpThongTin.Controls.Add(this.labelControl3);
            this.grpThongTin.Controls.Add(this.labelControl5);
            this.grpThongTin.Controls.Add(this.labelControl2);
            this.grpThongTin.Controls.Add(this.txtIdleTime);
            this.grpThongTin.Controls.Add(this.txtConnectTime);
            this.grpThongTin.Controls.Add(this.txtSessionUser);
            this.grpThongTin.Controls.Add(this.txtFalseLogin);
            this.grpThongTin.Controls.Add(this.txtTenProfile);
            this.grpThongTin.Controls.Add(this.txtID);
            this.grpThongTin.Location = new System.Drawing.Point(1212, 18);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(685, 634);
            this.grpThongTin.TabIndex = 20;
            this.grpThongTin.Text = "Thông tin profile";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(43, 460);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(166, 33);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Connect time:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(43, 113);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 33);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "ID:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(43, 374);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(158, 33);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Session user:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(43, 290);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(135, 33);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "False login:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(43, 548);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(115, 33);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Idle time:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(43, 201);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(138, 33);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Tên profile:";
            // 
            // txtIdleTime
            // 
            this.txtIdleTime.Location = new System.Drawing.Point(283, 544);
            this.txtIdleTime.Name = "txtIdleTime";
            this.txtIdleTime.Size = new System.Drawing.Size(345, 50);
            this.txtIdleTime.TabIndex = 2;
            this.txtIdleTime.Click += new System.EventHandler(this.txt_Click);
            // 
            // txtConnectTime
            // 
            this.txtConnectTime.Location = new System.Drawing.Point(283, 456);
            this.txtConnectTime.Name = "txtConnectTime";
            this.txtConnectTime.Size = new System.Drawing.Size(345, 50);
            this.txtConnectTime.TabIndex = 1;
            this.txtConnectTime.Click += new System.EventHandler(this.txt_Click);
            // 
            // txtSessionUser
            // 
            this.txtSessionUser.Location = new System.Drawing.Point(283, 365);
            this.txtSessionUser.Name = "txtSessionUser";
            this.txtSessionUser.Size = new System.Drawing.Size(345, 50);
            this.txtSessionUser.TabIndex = 2;
            this.txtSessionUser.Click += new System.EventHandler(this.txt_Click);
            // 
            // txtFalseLogin
            // 
            this.txtFalseLogin.Location = new System.Drawing.Point(283, 277);
            this.txtFalseLogin.Name = "txtFalseLogin";
            this.txtFalseLogin.Size = new System.Drawing.Size(345, 50);
            this.txtFalseLogin.TabIndex = 1;
            this.txtFalseLogin.Click += new System.EventHandler(this.txt_Click);
            // 
            // txtTenProfile
            // 
            this.txtTenProfile.Location = new System.Drawing.Point(283, 197);
            this.txtTenProfile.Name = "txtTenProfile";
            this.txtTenProfile.Size = new System.Drawing.Size(345, 50);
            this.txtTenProfile.TabIndex = 2;
            this.txtTenProfile.Click += new System.EventHandler(this.txt_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(283, 109);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(345, 50);
            this.txtID.TabIndex = 1;
            // 
            // ProfileGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.grpThongTin);
            this.Name = "ProfileGUI";
            this.Size = new System.Drawing.Size(1914, 1062);
            this.Load += new System.EventHandler(this.ProfileGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpDanhSach)).EndInit();
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpChucNang)).EndInit();
            this.grpChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpThongTin)).EndInit();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdleTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConnectTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSessionUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFalseLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenProfile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpDanhSach;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraGrid.GridControl dgvProfile;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn TEN;
        private DevExpress.XtraGrid.Columns.GridColumn FALSELOGIN;
        private DevExpress.XtraEditors.GroupControl grpChucNang;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnHuyBo;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.GroupControl grpThongTin;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTenProfile;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtIdleTime;
        private DevExpress.XtraEditors.TextEdit txtConnectTime;
        private DevExpress.XtraEditors.TextEdit txtSessionUser;
        private DevExpress.XtraEditors.TextEdit txtFalseLogin;
        private DevExpress.XtraGrid.Columns.GridColumn SESSIONUSER;
        private DevExpress.XtraGrid.Columns.GridColumn CONNECTTIME;
        private DevExpress.XtraGrid.Columns.GridColumn IDLETIME;
    }
}
