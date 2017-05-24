using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_BanHang.Model;
using QL_BanHang.Object;

namespace QL_BanHang.View
{
    public partial class frmMatHang : Form
    {
        public frmMatHang()
        {
            InitializeComponent();
        }
        MatHangMod mh = new MatHangMod();
        MatHangObj mhObj = new MatHangObj();
        int flag = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {

            flag = 0;
            clean();
            Dis_en(true);
        }

        private void frmMatHang_Load(object sender, EventArgs e)
        {
            DataTable dtMH = new System.Data.DataTable();
            dgvMatHang.DataSource = mh.GetData();
            dgvMatHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dis_en(false);
            Binding();
        }
        private void Binding()
        {
            txtMaMH.DataBindings.Clear();
            txtMaMH.DataBindings.Add("Text", dgvMatHang.DataSource, "MaMH");
            txtTenMH.DataBindings.Clear();
            txtTenMH.DataBindings.Add("Text", dgvMatHang.DataSource, "TenMH");
            txtMaNCC.DataBindings.Clear();
            txtMaNCC.DataBindings.Add("Text", dgvMatHang.DataSource, "MaNCC");
            txtMaKho.DataBindings.Clear();
            txtMaKho.DataBindings.Add("Text", dgvMatHang.DataSource, "MaKho");
            txtDG.DataBindings.Clear();
            txtDG.DataBindings.Add("Text", dgvMatHang.DataSource, "DonGia");
            txtMaQH.DataBindings.Clear();
            txtMaQH.DataBindings.Add("Text", dgvMatHang.DataSource, "MaQH");
        }
        public void Dis_en(bool e)
        {
            txtMaMH.Enabled = e;
            txtTenMH.Enabled = e;
            txtMaNCC.Enabled = e;
            txtMaKho.Enabled = e;
            txtMaQH.Enabled = e;
            txtDG.Enabled = e;
            btnLuu.Enabled = e;
            btnSua.Enabled = !e;
            btnThem.Enabled = !e;
            btnHuy.Enabled = e;
            btnXoa.Enabled = !e;
        }
        private void clean()
        {
            txtMaMH.Clear();
            txtTenMH.Clear();
            txtMaNCC.Clear();
            txtMaKho.Clear();
            txtDG.Clear();
            txtMaQH.Clear();

        }
        private void GanDuLieu(MatHangObj mhobj)
        {
            mhobj.MaMH1 = txtMaMH.Text.ToString().Trim();
            mhobj.TenMH1 = txtTenMH.Text.ToString().Trim();
            mhobj.MaNCC1 = txtMaNCC.Text.ToString().Trim();
            mhobj.MaKho1 = txtMaKho.Text.ToString().Trim();
            mhobj.MaQH1 = txtMaQH.Text.ToString().Trim();
            mhobj.DonGia1 = txtDG.Text.ToString().Trim();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            flag = 1;
            Dis_en(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            {
                if (dr == DialogResult.Yes)
                {
                    if (mh.DeleteMatHang(txtMaMH.Text.ToString().Trim()))
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
                frmMatHang_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            GanDuLieu(mhObj);
            if (flag == 0)   // thêm
            {
                if (mh.AddMatHang(mhObj))
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
                if (mh.UpdateMatHang(mhObj))
                {
                    MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //  frmNhanVien_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            frmMatHang_Load(sender, e);
            Dis_en(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmMatHang_Load(sender, e);
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
