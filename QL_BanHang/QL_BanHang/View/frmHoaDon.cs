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
   
    public partial class frmHoaDon : Form
    {
        HoaDonBanHangMod hdbh = new HoaDonBanHangMod();
        HoaDonBanHangObj hdbhObj = new HoaDonBanHangObj();
        ChiTietHoaDonMod cthd = new ChiTietHoaDonMod();
        ChiTietHoaDonObj cthdObj = new ChiTietHoaDonObj();
        int flag = 0;
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = hdbh.GetData();
            dgvHDBH.DataSource = dt;
            Binding();
            // Binding1();
            Dis_en(false);
        }
        private void Binding()
        {
            txtMaHD.DataBindings.Clear();
            txtMaHD.DataBindings.Add("Text", dgvHDBH.DataSource, "MaHD");
            dtNgayLamHD.DataBindings.Clear();
            dtNgayLamHD.DataBindings.Add("Text", dgvHDBH.DataSource, "NgayLamHD");
            txtTenNV.DataBindings.Clear();
            txtTenNV.DataBindings.Add("Text", dgvHDBH.DataSource, "TenNV");
            cmbKhachHang.DataBindings.Clear();
            cmbKhachHang.DataBindings.Add("Text", dgvHDBH.DataSource, "TenKH");
            //txtTongTien.DataBindings.Clear();
            //txtTongTien.DataBindings.Add("Text", dgvHDBH.DataSource, "TongTien");
        }
        private void Binding1()
        {
            cmbHangHoa.DataBindings.Clear();
            cmbHangHoa.DataBindings.Add("Text", dgvCTHD.DataSource, "TenMH");
            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", dgvCTHD.DataSource, "DonGia");
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dgvCTHD.DataSource, "SoLuong");
            txtThanhTien.DataBindings.Clear();
            txtThanhTien.DataBindings.Add("Text", dgvCTHD.DataSource, "ThanhTien");
        }
        private void Load_cmbKhachhang()
        {
            KhachHangMod kh = new KhachHangMod();
            cmbKhachHang.DataSource = kh.GetData();
            cmbKhachHang.DisplayMember = "TenKH";
            cmbKhachHang.ValueMember = "MaKH";
        }
        private void Load_cmbHangHoa()
        {
            MatHangMod hh = new MatHangMod();
            cmbHangHoa.DataSource = hh.GetData();
            cmbHangHoa.DisplayMember = "TenMH";
            cmbHangHoa.ValueMember = "MaMH";
        }
        private void Clear()
        {
            txtMaHD.Text = "";
            txtTenNV.Text = "";
            dtNgayLamHD.Text = "";
            //  txtTongTien.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            txtThanhTien.Text = "";
            Load_cmbKhachhang();
        }
        private void Dis_en(bool e)
        {
            txtMaHD.Enabled = e;
            txtTenNV.Enabled = e;
            cmbKhachHang.Enabled = e;
            dtNgayLamHD.Enabled = e;
            txtDonGia.Enabled = e;
            txtThanhTien.Enabled = e;
            // txtTongTien.Enabled = e;
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThemMH.Enabled = !e;
            btnBotMH.Enabled = !e;
            cmbHangHoa.Enabled = e;
            txtSoLuong.Enabled = e;
            btnLuu2.Enabled = false;
        }
        private void GanDuLieu(HoaDonBanHangObj hdbhObj)
        {
            hdbhObj.MaHD1 = txtMaHD.Text.ToString().Trim();
            hdbhObj.MaNV1 = txtTenNV.Text.ToString().Trim();
            hdbhObj.MaKH1 = cmbKhachHang.SelectedValue.ToString();
            hdbhObj.NgayLamHD1 = dtNgayLamHD.Value;
            // hdbhObj.TongTien1 = txtTongTien.Text.ToString().Trim();
        }
        private void GanDuLieu1(ChiTietHoaDonObj cthdObj)
        {
            cthdObj.MaHD1 = txtMaHD.Text.ToString().Trim();
            cthdObj.MaMH1 = cmbHangHoa.SelectedValue.ToString();
            cthdObj.SoLuong1 = txtSoLuong.Text.ToString().Trim();
            cthdObj.DonGia1 = txtDonGia.Text.ToString().Trim();
            cthdObj.ThanhTien1 = txtThanhTien.Text.ToString().Trim();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Dis_en(true);
            Clear();
            Load_cmbHangHoa();
            Load_cmbKhachhang();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            GanDuLieu(hdbhObj);

            if (hdbh.AddHoaDonBanHang(hdbhObj))
            {
                GanDuLieu1(cthdObj);
                if (cthd.AddChiTietHoaDon(cthdObj))
                    MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm chi tiết không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Thêm hóa đơn không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            frmHoaDon_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            {
                if (dr == DialogResult.Yes)
                {
                    cthd.DeleteChiTietHoaDon(txtMaHD.Text.ToString().Trim());
                    if (hdbh.DeleteHoaDonBanHang(txtMaHD.Text.ToString().Trim()))
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
                frmHoaDon_Load(sender, e);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmHoaDon_Load(sender, e);
            Dis_en(false);
        }

        private void btnThemMH_Click(object sender, EventArgs e)
        {
            cmbHangHoa.Enabled = true;
            txtSoLuong.Enabled = true;
            txtDonGia.Enabled = true;
            txtThanhTien.Enabled = true;
            btnLuu2.Enabled = true;
            btnHuy.Enabled = true;
            Load_cmbHangHoa();
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtThanhTien.Clear();
        }

        private void btnBotMH_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            {
                if (dr == DialogResult.Yes)
                {
                    if (cthd.DeleteChiTietHoaDon(txtMaHD.Text.ToString().Trim()))
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
                frmHoaDon_Load(sender, e);
            }
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new System.Data.DataTable();
                dt = cthd.GetData(txtMaHD.Text.Trim());
                dgvCTHD.DataSource = dt;


            }
            catch
            {
                dgvCTHD.DataSource = null;
            }
            Binding1();
        }

        private void txtThanhTien_MouseClick(object sender, MouseEventArgs e)
        {
            txtThanhTien.Text = (Int32.Parse(txtDonGia.Text) * Int32.Parse(txtSoLuong.Text)).ToString();
        }

        private void btnLuu2_Click(object sender, EventArgs e)
        {
            GanDuLieu1(cthdObj);
            if (cthd.AddChiTietHoaDon(cthdObj))
                MessageBox.Show("Thêm chi tiết thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Thêm chi tiết không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            Form1 ds = new Form1();
            this.Hide();
            ds.Show();
        }
    }
}
