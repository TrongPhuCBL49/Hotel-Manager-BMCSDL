namespace GUI
{
    partial class test
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
            this.dgvPhong = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIA = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grpDanhSach)).BeginInit();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.gridSplitContainer1);
            this.grpDanhSach.Location = new System.Drawing.Point(204, 19);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(1112, 808);
            this.grpDanhSach.TabIndex = 17;
            this.grpDanhSach.Text = "Danh sách phòng";
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1.Grid = this.dgvPhong;
            this.gridSplitContainer1.Location = new System.Drawing.Point(3, 48);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.dgvPhong);
            this.gridSplitContainer1.Size = new System.Drawing.Size(1106, 757);
            this.gridSplitContainer1.TabIndex = 0;
            // 
            // dgvPhong
            // 
            this.dgvPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhong.Location = new System.Drawing.Point(0, 0);
            this.dgvPhong.MainView = this.gridView1;
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.Size = new System.Drawing.Size(1106, 757);
            this.dgvPhong.TabIndex = 0;
            this.dgvPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDPHONG,
            this.TENPHONG,
            this.GIA});
            this.gridView1.GridControl = this.dgvPhong;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // IDPHONG
            // 
            this.IDPHONG.Caption = "ID Phòng";
            this.IDPHONG.FieldName = "IDPHONG";
            this.IDPHONG.Name = "IDPHONG";
            this.IDPHONG.Visible = true;
            this.IDPHONG.VisibleIndex = 0;
            this.IDPHONG.Width = 162;
            // 
            // TENPHONG
            // 
            this.TENPHONG.Caption = "Tên phòng";
            this.TENPHONG.FieldName = "TENPHONG";
            this.TENPHONG.Name = "TENPHONG";
            this.TENPHONG.Visible = true;
            this.TENPHONG.VisibleIndex = 1;
            this.TENPHONG.Width = 257;
            // 
            // GIA
            // 
            this.GIA.Caption = "Giá";
            this.GIA.FieldName = "GIA";
            this.GIA.Name = "GIA";
            this.GIA.Visible = true;
            this.GIA.VisibleIndex = 2;
            this.GIA.Width = 396;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpDanhSach);
            this.Name = "test";
            this.Size = new System.Drawing.Size(1520, 846);
            ((System.ComponentModel.ISupportInitialize)(this.grpDanhSach)).EndInit();
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpDanhSach;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraGrid.GridControl dgvPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn IDPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn TENPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn GIA;
    }
}
