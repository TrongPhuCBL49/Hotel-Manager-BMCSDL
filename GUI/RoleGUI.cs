using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;

namespace GUI
{
    public partial class RoleGUI : DevExpress.XtraEditors.XtraUserControl
    {
        bool isThem = false;
        public RoleGUI()
        {
            InitializeComponent();
        }

        private void RoleGUI_Load(object sender, EventArgs e)
        {
            LoadRole();
        }
        void LoadRole()
        {
            dgvRole.DataSource = RoleBUS.Instance.DSRole();
            LoadTrangThai();
            BindingRole();
            isThem = false;
            txtID.Enabled = false;
            txtTenRole.Enabled = false;
            btnHuyBo.Enabled = false;
            btnLuu.Enabled = false;
        }
        void LoadTrangThai()
        {
            List<string> TrangThai = new List<string>();
            TrangThai.Add("1");
            TrangThai.Add("0");
            cboSPhong.Properties.Items.AddRange(TrangThai);
            cboIPhong.Properties.Items.AddRange(TrangThai);
            cboUPhong.Properties.Items.AddRange(TrangThai);
            cboDPhong.Properties.Items.AddRange(TrangThai);
            cboUGia.Properties.Items.AddRange(TrangThai);
            cboIGia.Properties.Items.AddRange(TrangThai);
            cboUTen.Properties.Items.AddRange(TrangThai);
            cboITen.Properties.Items.AddRange(TrangThai);
        }
        public void BindingRole()
        {
            BindingSource source = new BindingSource();
            source.DataSource = RoleBUS.Instance.DSRole();
            source.DataSource = dgvRole.DataSource;
            txtID.DataBindings.Add("Text", source, "ID", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTenRole.DataBindings.Add("Text", source, "TEN", true, DataSourceUpdateMode.OnPropertyChanged);
            cboSPhong.DataBindings.Add("Text", source, "SPHONG", true, DataSourceUpdateMode.OnPropertyChanged);
            cboIPhong.DataBindings.Add("Text", source, "IPHONG", true, DataSourceUpdateMode.OnPropertyChanged);
            cboUPhong.DataBindings.Add("Text", source, "UPHONG", true, DataSourceUpdateMode.OnPropertyChanged);
            cboDPhong.DataBindings.Add("Text", source, "DPHONG", true, DataSourceUpdateMode.OnPropertyChanged);
            cboUTen.DataBindings.Add("Text", source, "UTEN", true, DataSourceUpdateMode.OnPropertyChanged);
            cboITen.DataBindings.Add("Text", source, "ITEN", true, DataSourceUpdateMode.OnPropertyChanged);
            cboUGia.DataBindings.Add("Text", source, "UGIA", true, DataSourceUpdateMode.OnPropertyChanged);
            cboIGia.DataBindings.Add("Text", source, "IGIA", true, DataSourceUpdateMode.OnPropertyChanged);
            dgvRole.DataSource = source;
        }

        private void ClearText()
        {
            txtID.Text = "";
            txtTenRole.Text = "";
            txtID.Focus();
        }

        private void ClearBinding()
        {
            txtID.DataBindings.Clear();
            txtTenRole.DataBindings.Clear();
            cboSPhong.DataBindings.Clear();
            cboIPhong.DataBindings.Clear();
            cboUPhong.DataBindings.Clear();
            cboDPhong.DataBindings.Clear();
            cboUTen.DataBindings.Clear();
            cboITen.DataBindings.Clear();
            cboUGia.DataBindings.Clear();
            cboIGia.DataBindings.Clear();
            dgvRole.DataBindings.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isThem = true;
            ClearBinding();
            ClearText();
            txtID.Enabled = true;
            txtTenRole.Enabled = true;
            btnHuyBo.Enabled = true;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            dgvRole.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (isThem)
            {
                if (RoleBUS.Instance.ThemRole(txtID.Text, txtTenRole.Text, cboSPhong.Text, cboIPhong.Text, cboUPhong.Text, cboDPhong.Text, cboUTen.Text, cboITen.Text, cboUGia.Text, cboIGia.Text))
                    MessageBox.Show("Thêm Role thành công!");
                else
                    MessageBox.Show("Có lỗi xảy ra. Thêm Role thất bại!");
            }
            else
            {
                if (RoleBUS.Instance.SuaRole(txtID.Text, txtTenRole.Text, cboSPhong.Text, cboIPhong.Text, cboUPhong.Text, cboDPhong.Text, cboUTen.Text, cboITen.Text, cboUGia.Text, cboIGia.Text))
                    MessageBox.Show("Chỉnh sửa Role thành công!");
                else
                    MessageBox.Show("Có lỗi xảy ra. Chỉnh sửa Role thất bại!");
            }
            LoadRole();
            txtID.Enabled = false;
            txtTenRole.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuyBo.Enabled = false;
            dgvRole.Enabled = true;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa Role: " + txtTenRole.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (RoleBUS.Instance.XoaRole(txtTenRole.Text))
                {
                    MessageBox.Show("Xóa Role thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearBinding();
                    LoadRole();
                }
                else
                    MessageBox.Show("Xóa Role thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            BindingRole();
            btnLuu.Enabled = false;
            btnHuyBo.Enabled = false;
            txtID.Enabled = false;
            txtTenRole.Enabled = false;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            dgvRole.Enabled = true;
        }

        private void txt_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            ClearBinding();
            btnHuyBo.Enabled = true;
            btnLuu.Enabled = true;
        }
    }
}
