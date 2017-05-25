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
using System.Data.SqlClient;

namespace QL_BanHang.View
{
    public partial class frmKho : Form
    {
        public frmKho()
        {
            InitializeComponent();
        }
        KhoMod kho = new KhoMod();
        KhoObj k = new KhoObj();
        int flag = 0;

        private void frmKho_Load(object sender, EventArgs e)
        {
            dgvKho.DataSource = kho.GetData();
            dgvKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dis_en(false);
            Binding();
        }
        private void Binding()
        {
            txtMaKho.DataBindings.Clear();
            txtMaKho.DataBindings.Add("Text", dgvKho.DataSource, "MaKho");
            txtTenKho.DataBindings.Clear();
            txtTenKho.DataBindings.Add("Text", dgvKho.DataSource, "TenKho");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvKho.DataSource, "DiaChi");
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", dgvKho.DataSource, "MaNV");
        }
        public void Dis_en(bool e)
        {
            txtMaNV.Enabled = e;
            txtTenKho.Enabled = e;
            txtDiaChi.Enabled = e;
            txtMaKho.Enabled = e;
            btnLuu.Enabled = e;
            btnSua.Enabled = !e;
            btnThem.Enabled = !e;
            btnHuy.Enabled = e;
            btnXoa.Enabled = !e;
        }
        private void clean()
        {
            txtMaNV.Clear();
            txtTenKho.Clear();
            txtMaKho.Clear();
            txtDiaChi.Clear();

        }
        private void GanDuLieu(KhoObj Kobj)
        {
            Kobj.MaNV1 = txtMaNV.Text.ToString().Trim();
            Kobj.TenKho1 = txtTenKho.Text.ToString().Trim();
            Kobj.MaKho1 = txtMaKho.Text.ToString().Trim();
            Kobj.DiaChi1 = txtDiaChi.Text.ToString().Trim();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            clean();
            Dis_en(true);
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
                    if (kho.DeleteKho(txtMaKho.Text.ToString().Trim()))
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
                frmKho_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            GanDuLieu(k);
            if (flag == 0)   // thêm
            {
                if (kho.AddKho(k))
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
                if (kho.UpdateKho(k))
                {
                    MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //  frmNhanVien_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            frmKho_Load(sender, e);
            Dis_en(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmKho_Load(sender, e);
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
