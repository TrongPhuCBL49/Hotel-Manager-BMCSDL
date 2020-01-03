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
    public partial class ProfileGUI : DevExpress.XtraEditors.XtraUserControl
    {
        bool isThem = false;
        public ProfileGUI()
        {
            InitializeComponent();
        }

        private void ProfileGUI_Load(object sender, EventArgs e)
        {
            LoadProfile();
        }
        void LoadProfile()
        {
            dgvProfile.DataSource = ProfileBUS.Instance.DSProfile();
            BindingProfile();
            isThem = false;
            txtID.Enabled = false;
            btnHuyBo.Enabled = false;
            btnLuu.Enabled = false;
        }
        public void BindingProfile()
        {
            BindingSource source = new BindingSource();
            source.DataSource = ProfileBUS.Instance.DSProfile();
            source.DataSource = dgvProfile.DataSource;
            txtID.DataBindings.Add("Text", source, "ID", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTenProfile.DataBindings.Add("Text", source, "TEN", true, DataSourceUpdateMode.OnPropertyChanged);
            txtFalseLogin.DataBindings.Add("Text", source, "FALSELOGIN", true, DataSourceUpdateMode.OnPropertyChanged);
            txtSessionUser.DataBindings.Add("Text", source, "SESSIONUSER", true, DataSourceUpdateMode.OnPropertyChanged);
            txtConnectTime.DataBindings.Add("Text", source, "CONNECTTIME", true, DataSourceUpdateMode.OnPropertyChanged);
            txtIdleTime.DataBindings.Add("Text", source, "IDLETIME", true, DataSourceUpdateMode.OnPropertyChanged);
            dgvProfile.DataSource = source;
        }

        private void ClearText()
        {
            txtID.Text = "";
            txtTenProfile.Text = "";
            txtFalseLogin.Text = "";
            txtSessionUser.Text = "";
            txtConnectTime.Text = "";
            txtIdleTime.Text = "";
            txtID.Focus();
        }

        private void ClearBinding()
        {
            txtID.DataBindings.Clear();
            txtTenProfile.DataBindings.Clear();
            txtFalseLogin.DataBindings.Clear();
            txtSessionUser.DataBindings.Clear();
            txtConnectTime.DataBindings.Clear();
            txtIdleTime.DataBindings.Clear();
            dgvProfile.DataBindings.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isThem = true;
            ClearBinding();
            ClearText();
            txtID.Enabled = true;
            btnHuyBo.Enabled = true;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            dgvProfile.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (isThem)
            {
                if (ProfileBUS.Instance.ThemProfile(txtID.Text, txtTenProfile.Text, txtFalseLogin.Text, txtSessionUser.Text, txtConnectTime.Text, txtIdleTime.Text))
                    MessageBox.Show("Thêm profile thành công!");
                else
                    MessageBox.Show("Có lỗi xảy ra. Thêm profile thất bại!");
            }
            else
            {
                if (ProfileBUS.Instance.SuaProfile(txtID.Text, txtTenProfile.Text, txtFalseLogin.Text, txtSessionUser.Text, txtConnectTime.Text, txtIdleTime.Text))
                    MessageBox.Show("Chỉnh sửa profile thành công!");
                else
                    MessageBox.Show("Có lỗi xảy ra. Chỉnh sửa profile thất bại!");
            }
            LoadProfile();
            txtID.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuyBo.Enabled = false;
            dgvProfile.Enabled = true;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa profile: " + txtTenProfile.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (ProfileBUS.Instance.XoaProfile(txtID.Text))
                {
                    MessageBox.Show("Xóa profile thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearBinding();
                    LoadProfile();
                }
                else
                    MessageBox.Show("Xóa profile thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            BindingProfile();
            btnLuu.Enabled = false;
            btnHuyBo.Enabled = false;
            txtID.Enabled = false;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            dgvProfile.Enabled = true;
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
