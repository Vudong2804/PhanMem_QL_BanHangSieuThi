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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        KhachHangMod kh = new KhachHangMod();
        KhachHangObj khObj = new KhachHangObj();
        int flag = 0;
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = kh.GetData();
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dis_en(false);
            Binding();
        }
        private void Binding()
        {
            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("Text", dgvKhachHang.DataSource, "MaKH");
            txtTenKH.DataBindings.Clear();
            txtTenKH.DataBindings.Add("Text", dgvKhachHang.DataSource, "TenKH");
            dtNgaySinh.DataBindings.Clear();
            dtNgaySinh.DataBindings.Add("Text", dgvKhachHang.DataSource, "NS");
            cmbGT.DataBindings.Clear();
            cmbGT.DataBindings.Add("Text", dgvKhachHang.DataSource, "GT");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvKhachHang.DataSource, "DiaChi");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgvKhachHang.DataSource, "SDT");
        }
        public void Dis_en(bool e)
        {
            txtMaKH.Enabled = e;
            txtTenKH.Enabled = e;
            txtDiaChi.Enabled = e;
            txtSDT.Enabled = e;
            cmbGT.Enabled = e;
            dtNgaySinh.Enabled = e;
            btnLuu.Enabled = e;
            btnSua.Enabled = !e;
            btnThem.Enabled = !e;
            btnHuy.Enabled = e;
            btnXoa.Enabled = !e;
        }
        private void clean()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            dtNgaySinh.Value = DateTime.Now;

        }
        private void GanDuLieu(KhachHangObj Khobj)
        {
            Khobj.MaKH1 = txtMaKH.Text.ToString().Trim();
            Khobj.TenKH1 = txtTenKH.Text.ToString().Trim();
            Khobj.NS1 = dtNgaySinh.Value;
            Khobj.GT1 = cmbGT.Text.ToString().Trim();
            Khobj.SDT1 = txtSDT.Text.ToString().Trim();
            Khobj.DiaChi1 = txtDiaChi.Text.ToString().Trim();
        }
        private void LoadConTroll()
        {
            cmbGT.Items.Clear();
            cmbGT.Items.Add("Nam");
            cmbGT.Items.Add("Nữ");

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            clean();
            Dis_en(true);
            LoadConTroll();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            Dis_en(true);
            LoadConTroll();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            {
                if (dr == DialogResult.Yes)
                {
                    if (kh.DeleteKhachHang(txtMaKH.Text.ToString().Trim()))
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
                frmKhachHang_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            GanDuLieu(khObj);
            if (flag == 0)   // thêm
            {
                if (kh.AddKhachHang(khObj))
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
                if (kh.UpdateKhachHang(khObj))
                {
                    MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //  frmNhanVien_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            frmKhachHang_Load(sender, e);
            Dis_en(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender, e);
            Dis_en(false);
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            Form1 ds = new Form1();
            this.Hide();
            ds.Show();
        }
    }
}
