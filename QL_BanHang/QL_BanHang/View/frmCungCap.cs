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
    public partial class frmCungCap : Form
    {
        public frmCungCap()
        {
            InitializeComponent();
        }
        CungCapMod cc = new CungCapMod();
        CungCapObj ccObj = new CungCapObj();
        int flag = 0;
        private void Binding()
        {
            txtMaNCC.DataBindings.Clear();
            txtMaNCC.DataBindings.Add("Text", dgvCungCap.DataSource, "MaNCC");
            txtMaMH.DataBindings.Clear();
            txtMaMH.DataBindings.Add("Text", dgvCungCap.DataSource, "MaMH");
            txtSL.DataBindings.Clear();
            txtSL.DataBindings.Add("Text", dgvCungCap.DataSource, "SoLuong");
        }
        public void Dis_en(bool e)
        {
            txtMaNCC.Enabled = e;
            txtMaMH.Enabled = e;
            txtSL.Enabled = e;
            btnLuu.Enabled = e;
            btnSua.Enabled = !e;
            btnThem.Enabled = !e;
            btnHuy.Enabled = e;
            btnXoa.Enabled = !e;
        }
        private void clean()
        {
            txtMaNCC.Clear();
            txtMaMH.Clear();
            txtSL.Clear();

        }
        private void GanDuLieu(CungCapObj ccobj)
        {
            ccobj.MaNCC1 = txtMaNCC.Text.ToString().Trim();
            ccobj.MaMH1 = txtMaMH.Text.ToString().Trim();
            ccobj.SoLuong1 = txtSL.Text.ToString().Trim();
        }

        private void frmCungCap_Load(object sender, EventArgs e)
        {
            dgvCungCap.DataSource = cc.GetData();
            dgvCungCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dis_en(false);
            Binding();
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
                    if (cc.DeleteCungCap(txtMaNCC.Text.ToString().Trim()))
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
                frmCungCap_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            GanDuLieu(ccObj);
            if (flag == 0)   // thêm
            {
                if (cc.AddCungCap(ccObj))
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
                if (cc.UpdateCungCap(ccObj))
                {
                    MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //  frmNhanVien_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            frmCungCap_Load(sender, e);
            Dis_en(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmCungCap_Load(sender, e);
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
