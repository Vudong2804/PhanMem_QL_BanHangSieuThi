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
    public partial class frmNguoiQuanLy : Form
    {
        public frmNguoiQuanLy()
        {
            InitializeComponent();
        }
        // khởi tạo đối tượng
        NguoiQuanLyMod nql = new NguoiQuanLyMod();
        NguoiQuanLyObj nqlObj = new NguoiQuanLyObj();
        int flag = 0;
        private void frmNguoiQuanLy_Load(object sender, EventArgs e)
        {
            dgvNQL.DataSource = nql.GetData();
            dgvNQL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dis_en(false);
            Binding();
        }
       
        public void Dis_en(bool e)
        {
            txtTenNQL.Enabled = e;
            txtNQL.Enabled = e;
            txtDiaChi.Enabled = e;
            txtSDT.Enabled = e;
            dtNgayNC.Enabled = e;
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
            txtNQL.Clear();
            txtTenNQL.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            dtNS.Value = DateTime.Now;
            dtNgayNC.Value = DateTime.Now;


        }
        private void GanDuLieu(NguoiQuanLyObj nqlObj)
        {
            nqlObj.MaNQL1 = txtNQL.Text.ToString().Trim();
            nqlObj.TenNQL1 = txtTenNQL.Text.ToString().Trim();
            nqlObj.NS1 = dtNS.Value;
            nqlObj.GT1 = cmbGT.Text.ToString().Trim();
            nqlObj.SDT1 = txtSDT.Text.ToString().Trim();
            nqlObj.DiaChi1 = txtDiaChi.Text.ToString().Trim();
            nqlObj.NgayNC1 = dtNgayNC.Value;

        }
        private void Binding()
        {
            txtNQL.DataBindings.Clear();
            txtNQL.DataBindings.Add("Text", dgvNQL.DataSource, "MaNQL");
            txtTenNQL.DataBindings.Clear();
            txtTenNQL.DataBindings.Add("Text", dgvNQL.DataSource, "TenNQL");
            dtNS.DataBindings.Clear();
            dtNS.DataBindings.Add("Text", dgvNQL.DataSource, "NS");
            cmbGT.DataBindings.Clear();
            cmbGT.DataBindings.Add("Text", dgvNQL.DataSource, "GT");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvNQL.DataSource, "DiaChi");
            dtNgayNC.DataBindings.Clear();
            dtNgayNC.DataBindings.Add("Text", dgvNQL.DataSource, "NgayNC");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgvNQL.DataSource, "SDT");

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
            flag = 0;
            Dis_en(true);
            LoadConTroll();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            {
                if (dr == DialogResult.Yes)
                {
                    if (nql.DeleteNguoiQuanLy(txtNQL.Text.ToString().Trim()))
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
                frmNguoiQuanLy_Load(sender, e);

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            GanDuLieu(nqlObj);
            if (flag == 0)   // thêm
            {
                if (nql.AddNguoiQuanLy(nqlObj))
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
                if (nql.UpdateNguoiQuanLy(nqlObj))
                {
                    MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //  frmNhanVien_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            frmNguoiQuanLy_Load(sender, e);
            Dis_en(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmNguoiQuanLy_Load(sender, e);
            Dis_en(false);
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            Form1 ds = new Form1();
            this.Hide();            // đóng form cũ lại
            ds.Show();
        }
    }
}
