namespace QL_BanHang.View
{
    partial class frmNguoiQuanLy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTroLai = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtNgayNC = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGT = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNQL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtNS = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenNQL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvNQL = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNQL)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTroLai
            // 
            this.btnTroLai.Location = new System.Drawing.Point(860, 499);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(75, 52);
            this.btnTroLai.TabIndex = 23;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.UseVisualStyleBackColor = true;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(407, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 29);
            this.label9.TabIndex = 22;
            this.label9.Text = "Người Quản Lý";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtNgayNC);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cmbGT);
            this.groupBox3.Controls.Add(this.btnHuy);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btnLuu);
            this.groupBox3.Controls.Add(this.txtSDT);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtNQL);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dtNS);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtDiaChi);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtTenNQL);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(22, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(913, 208);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin người quản lý";
            // 
            // dtNgayNC
            // 
            this.dtNgayNC.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayNC.Location = new System.Drawing.Point(108, 85);
            this.dtNgayNC.Name = "dtNgayNC";
            this.dtNgayNC.Size = new System.Drawing.Size(182, 20);
            this.dtNgayNC.TabIndex = 21;
            this.dtNgayNC.Value = new System.DateTime(2017, 4, 12, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ngày Nhậm Chức";
            // 
            // cmbGT
            // 
            this.cmbGT.FormattingEnabled = true;
            this.cmbGT.Location = new System.Drawing.Point(388, 50);
            this.cmbGT.Name = "cmbGT";
            this.cmbGT.Size = new System.Drawing.Size(182, 21);
            this.cmbGT.TabIndex = 19;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(741, 145);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 45);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(598, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Số điện thoại";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(593, 145);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 45);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(685, 54);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(182, 20);
            this.txtSDT.TabIndex = 17;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(422, 145);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 45);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(260, 145);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 45);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(108, 145);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 45);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tên Người Quản Lý";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Giới Tính";
            // 
            // txtNQL
            // 
            this.txtNQL.Location = new System.Drawing.Point(108, 19);
            this.txtNQL.Name = "txtNQL";
            this.txtNQL.Size = new System.Drawing.Size(182, 20);
            this.txtNQL.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Người Quản Lý";
            // 
            // dtNS
            // 
            this.dtNS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNS.Location = new System.Drawing.Point(388, 19);
            this.dtNS.Name = "dtNS";
            this.dtNS.Size = new System.Drawing.Size(182, 20);
            this.dtNS.TabIndex = 11;
            this.dtNS.Value = new System.DateTime(2017, 4, 12, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ngày Sinh";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(685, 19);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(182, 20);
            this.txtDiaChi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(598, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Địa Chỉ";
            // 
            // txtTenNQL
            // 
            this.txtTenNQL.Location = new System.Drawing.Point(108, 50);
            this.txtTenNQL.Name = "txtTenNQL";
            this.txtTenNQL.Size = new System.Drawing.Size(182, 20);
            this.txtTenNQL.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvNQL);
            this.groupBox1.Location = new System.Drawing.Point(22, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(913, 241);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách người quản lý";
            // 
            // dgvNQL
            // 
            this.dgvNQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNQL.Location = new System.Drawing.Point(9, 31);
            this.dgvNQL.Name = "dgvNQL";
            this.dgvNQL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNQL.Size = new System.Drawing.Size(901, 204);
            this.dgvNQL.TabIndex = 0;
            // 
            // frmNguoiQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 557);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNguoiQuanLy";
            this.Text = "frmNguoiQuanLy";
            this.Load += new System.EventHandler(this.frmNguoiQuanLy_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNQL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtNgayNC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGT;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNQL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtNS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenNQL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNQL;
    }
}