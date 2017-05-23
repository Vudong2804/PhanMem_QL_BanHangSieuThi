using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using QL_BanHang.Model;
using QL_BanHang.Object;

namespace QL_BanHang.View
{
    public partial class frmQuayHang : Form
    {
        public frmQuayHang()
        {
            InitializeComponent();
        }
        QuayHangMod qh = new QuayHangMod();
        QuayHangObj qhObj = new QuayHangObj();
        int flag = 0;
        private void frmQuayHang_Load(object sender, EventArgs e)
        {
            dgvQuayHang.DataSource = qh.GetData();
            dgvQuayHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dis_en(false);
            Binding();
        }
        private void Binding()
        {
            txtMaQH.DataBindings.Clear();
            txtMaQH.DataBindings.Add("Text", dgvQuayHang.DataSource, "MaQH");
            txtTenQH.DataBindings.Clear();
            txtTenQH.DataBindings.Add("Text", dgvQuayHang.DataSource, "TenQuayHang");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvQuayHang.DataSource, "DiaChi");
            txtMaNQL.DataBindings.Clear();
            txtMaNQL.DataBindings.Add("Text", dgvQuayHang.DataSource, "MaNQL");
        }
        public void Dis_en(bool e)
        {
            txtMaQH.Enabled = e;
            txtTenQH.Enabled = e;
            txtDiaChi.Enabled = e;
            txtMaNQL.Enabled = e;
            btnLuu.Enabled = e;
            btnSua.Enabled = !e;
            btnThem.Enabled = !e;
            btnHuy.Enabled = e;
            btnXoa.Enabled = !e;
        }
        private void clean()
        {
            txtMaQH.Clear();
            txtMaNQL.Clear();
            txtTenQH.Clear();
            txtDiaChi.Clear();

        }
        private void GanDuLieu(QuayHangObj qhObj)
        {
            qhObj.MaQH1 = txtMaQH.Text.ToString().Trim();
            qhObj.TenQuayHang1 = txtTenQH.Text.ToString().Trim();
            qhObj.MaNQL1 = txtMaNQL.Text.ToString().Trim();
            qhObj.DiaChi1 = txtDiaChi.Text.ToString().Trim();
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
                    if (qh.DeleteQuayHang(txtMaQH.Text.ToString().Trim()))
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
                frmQuayHang_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            GanDuLieu(qhObj);
            if (flag == 0)   // thêm
            {
                if (qh.AddQuayHang(qhObj))
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
                if (qh.UpdateQuayHang(qhObj))
                {
                    MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //  frmNhanVien_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            frmQuayHang_Load(sender, e);
            Dis_en(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmQuayHang_Load(sender, e);
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
