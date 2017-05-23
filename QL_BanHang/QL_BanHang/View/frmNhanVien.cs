using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_BanHang.Object;
using System.Data.SqlClient;
using QL_BanHang.Model;

namespace QL_BanHang.View
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        NhanVienMod nv = new NhanVienMod();
        NhanVienObj nvObj = new NhanVienObj();
        int flag = 0;
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nv.GetData();
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dis_en(false);
            Binding();
        }
        private void Binding()
        {
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", dgvNhanVien.DataSource, "MaNV");
            txtTenNhanVien.DataBindings.Clear();
            txtTenNhanVien.DataBindings.Add("Text", dgvNhanVien.DataSource, "TenNV");
            dtNS.DataBindings.Clear();
            dtNS.DataBindings.Add("Text", dgvNhanVien.DataSource, "NS");
            cmbGT.DataBindings.Clear();
            cmbGT.DataBindings.Add("Text", dgvNhanVien.DataSource, "GT");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvNhanVien.DataSource, "DiaChi");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgvNhanVien.DataSource, "SDT");
            txtLuong.DataBindings.Clear();
            txtLuong.DataBindings.Add("Text", dgvNhanVien.DataSource, "Luong");
            txtNQL.DataBindings.Clear();
            txtNQL.DataBindings.Add("Text", dgvNhanVien.DataSource, "MaNQL");
            txtMaQH.DataBindings.Clear();
            txtMaQH.DataBindings.Add("Text", dgvNhanVien.DataSource, "MaQH");
        }
        public void Dis_en(bool e)
        {
            txtMaNV.Enabled = e;
            txtTenNhanVien.Enabled = e;
            txtDiaChi.Enabled = e;
            txtSDT.Enabled = e;
            txtLuong.Enabled = e;
            txtMaQH.Enabled = e;
            txtNQL.Enabled = e;
            cmbGT.Enabled = e;
            dtNS.Enabled = e;
            btnLuu.Enabled = e;
            btnSua.Enabled = !e;
            btnThem.Enabled = !e;
            btnHuy.Enabled = e;
            btnXoa.Enabled = !e;
        }
        private void clean()
        {
            txtMaNV.Clear();
            txtTenNhanVien.Clear();
            txtLuong.Clear();
            txtDiaChi.Clear();
            txtLuong.Clear();
            txtSDT.Clear();
            txtMaQH.Clear();
            txtNQL.Clear();
            dtNS.Value = DateTime.Now;

        }
        private void GanDuLieu(NhanVienObj nv1obj)
        {
            nv1obj.MaNV1 = txtMaNV.Text.ToString().Trim();
            nv1obj.TenNV1 = txtTenNhanVien.Text.ToString().Trim();
            nv1obj.NS1 = dtNS.Value;
            nv1obj.GT1 = cmbGT.Text.ToString().Trim();
            nv1obj.Luong1 = txtLuong.Text.ToString().Trim();
            nv1obj.MaNQL1 = txtNQL.Text.ToString().Trim();
            nv1obj.MaQH1 = txtMaQH.Text.ToString().Trim();
            nv1obj.SDT1 = txtSDT.Text.ToString().Trim();
            nv1obj.DiaChi1 = txtDiaChi.Text.ToString().Trim();
        }
        private void LoadConTroll()
        {
            cmbGT.Items.Clear();
            cmbGT.Items.Add("Nam");
            cmbGT.Items.Add("Nữ");

        }

        private void btnThem_Click(object sender, System.EventArgs e)
        {
            flag = 0;
            clean();
            Dis_en(true);
            LoadConTroll();
        }

        private void btnSua_Click(object sender, System.EventArgs e)
        {
            flag = 1;
            Dis_en(true);
            LoadConTroll();
        }

        private void btnXoa_Click(object sender, System.EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            {
                if (dr == DialogResult.Yes)
                {
                    if (nv.DeleteNhanVien(txtMaNV.Text.ToString().Trim()))
                    {
                        MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //frmNhanVien_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Xóakhông thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return;
                }
                frmNhanVien_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, System.EventArgs e)
        {
            GanDuLieu(nvObj);
            if (flag == 0)   // thêm
            {
                if (nv.AddNhanVien(nvObj))
                {
                    MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // frmNhanVien_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else            // sửa
            {
                if (nv.UpdateNhanVien(nvObj))
                {
                    MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //  frmNhanVien_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            frmNhanVien_Load(sender, e);
            Dis_en(false);
        }

        private void btnHuy_Click(object sender, System.EventArgs e)
        {
            frmNhanVien_Load(sender, e);
            Dis_en(false);
        }

        private void btnTroLai_Click(object sender, System.EventArgs e)
        {
            Form1 ds = new Form1();
            this.Hide();
            ds.Show();
        }
    }
}
