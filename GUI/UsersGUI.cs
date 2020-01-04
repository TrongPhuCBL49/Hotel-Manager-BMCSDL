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
    public partial class UsersGUI : DevExpress.XtraEditors.XtraUserControl
    {
        bool isThem = false;
        public UsersGUI()
        {
            InitializeComponent();
        }

        private void UsersGUI_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }
        void LoadUsers()
        {
            dgvUsers.DataSource = UsersBUS.Instance.DSUsers();
            //LoadNhanVien();
            LoadProfile();
            LoadActive();
            LoadRole();
            BindingUsers();
            isThem = false;
            cboNhanVien.Enabled = false;
            txtUsername.Enabled = false;
            btnHuyBo.Enabled = false;
            btnLuu.Enabled = false;
        }
        void LoadNhanVien()
        {
            DataTable dtbNhanVien = NhanVienBUS.Instance.DSNhanVien();
            foreach (DataRow row in dtbNhanVien.Rows)
                cboNhanVien.Properties.Items.Add(row["TEN"]);
        }
        void LoadProfile()
        {
            DataTable dtbProfile = ProfileBUS.Instance.DSProfile();
            foreach (DataRow row in dtbProfile.Rows)
                cboProfile.Properties.Items.Add(row["TEN"]);
        }
        void LoadRole()
        {
            DataTable dtbRole = RoleBUS.Instance.DSRole();
            foreach (DataRow row in dtbRole.Rows)
                cboRole.Properties.Items.Add(row["TEN"]);
        }
        void LoadActive()
        {
            List<string> Active = new List<string>();
            Active.Add("1");
            Active.Add("0");
            cboActive.Properties.Items.AddRange(Active);
        }
        public void BindingUsers()
        {
            BindingSource source = new BindingSource();
            source.DataSource = UsersBUS.Instance.DSUsers();
            source.DataSource = dgvUsers.DataSource;
            cboNhanVien.DataBindings.Add("Text", source, "TEN", true, DataSourceUpdateMode.OnPropertyChanged);
            txtUsername.DataBindings.Add("Text", source, "USERNAME", true, DataSourceUpdateMode.OnPropertyChanged);
            cboProfile.DataBindings.Add("Text", source, "PROFILE", true, DataSourceUpdateMode.OnPropertyChanged);
            cboRole.DataBindings.Add("Text", source, "ROLE", true, DataSourceUpdateMode.OnPropertyChanged);
            txtQuota.DataBindings.Add("Text", source, "QUOTA", true, DataSourceUpdateMode.OnPropertyChanged);
            cboActive.DataBindings.Add("Text", source, "ACTIVE", true, DataSourceUpdateMode.OnPropertyChanged);
            dgvUsers.DataSource = source;
        }

        private void ClearText()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtQuota.Text = "";
            txtUsername.Focus();
        }

        private void ClearBinding()
        {
            cboNhanVien.DataBindings.Clear();
            txtUsername.DataBindings.Clear();
            txtPassword.DataBindings.Clear();
            cboProfile.DataBindings.Clear();
            cboRole.DataBindings.Clear();
            txtQuota.DataBindings.Clear();
            cboActive.DataBindings.Clear();
            dgvUsers.DataBindings.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isThem = true;
            ClearBinding();
            ClearText();
            cboNhanVien.Enabled = true;
            txtUsername.Enabled = true;
            btnHuyBo.Enabled = true;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            dgvUsers.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (isThem)
            {
                if (UsersBUS.Instance.ThemUsers(cboNhanVien.Text, txtUsername.Text, txtPassword.Text, cboProfile.Text, cboRole.Text, txtQuota.Text, cboActive.Text))
                    MessageBox.Show("Thêm User thành công!");
                else
                    MessageBox.Show("Có lỗi xảy ra. Thêm User thất bại!");
            }
            else
            {
                if (UsersBUS.Instance.SuaUsers(cboNhanVien.Text, txtUsername.Text, txtPassword.Text, cboProfile.Text, cboRole.Text, txtQuota.Text, cboActive.Text))
                    MessageBox.Show("Chỉnh sửa User thành công!");
                else
                    MessageBox.Show("Có lỗi xảy ra. Chỉnh sửa User thất bại!");
            }
            LoadUsers();
            cboNhanVien.Enabled = false;
            txtUsername.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuyBo.Enabled = false;
            dgvUsers.Enabled = true;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa User: " + txtUsername.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (UsersBUS.Instance.XoaUsers(txtUsername.Text))
                {
                    MessageBox.Show("Xóa User thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearBinding();
                    LoadUsers();
                }
                else
                    MessageBox.Show("Xóa User thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            BindingUsers();
            btnLuu.Enabled = false;
            btnHuyBo.Enabled = false;
            cboNhanVien.Enabled = false;
            txtUsername.Enabled = false;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            dgvUsers.Enabled = true;
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
