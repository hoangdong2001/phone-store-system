namespace QuanLyShopDienThoai
{
    partial class frmNH
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTaoNH = new System.Windows.Forms.Button();
            this.txtNgayNH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaNH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnEditNH = new System.Windows.Forms.Panel();
            this.btnXoaHH = new System.Windows.Forms.Button();
            this.btnThemHH = new System.Windows.Forms.Button();
            this.btnKtraNH = new System.Windows.Forms.Button();
            this.btnUpdateNH = new System.Windows.Forms.Button();
            this.btnAddNH = new System.Windows.Forms.Button();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtXuatxu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvChiTietNH = new System.Windows.Forms.DataGridView();
            this.clMaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.pnEditNH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTaoNH);
            this.panel1.Controls.Add(this.txtNgayNH);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtMaNH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(25, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 75);
            this.panel1.TabIndex = 18;
            // 
            // btnTaoNH
            // 
            this.btnTaoNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoNH.Location = new System.Drawing.Point(328, 25);
            this.btnTaoNH.Name = "btnTaoNH";
            this.btnTaoNH.Size = new System.Drawing.Size(75, 23);
            this.btnTaoNH.TabIndex = 20;
            this.btnTaoNH.Text = "Tạo";
            this.btnTaoNH.UseVisualStyleBackColor = true;
            this.btnTaoNH.Click += new System.EventHandler(this.btnTaoNH_Click);
            // 
            // txtNgayNH
            // 
            this.txtNgayNH.Location = new System.Drawing.Point(160, 38);
            this.txtNgayNH.Name = "txtNgayNH";
            this.txtNgayNH.Size = new System.Drawing.Size(138, 22);
            this.txtNgayNH.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ngày nhập:";
            // 
            // txtMaNH
            // 
            this.txtMaNH.Location = new System.Drawing.Point(160, 10);
            this.txtMaNH.Name = "txtMaNH";
            this.txtMaNH.Size = new System.Drawing.Size(138, 22);
            this.txtMaNH.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã nhập hàng:";
            // 
            // pnEditNH
            // 
            this.pnEditNH.Controls.Add(this.btnXoaHH);
            this.pnEditNH.Controls.Add(this.btnThemHH);
            this.pnEditNH.Controls.Add(this.btnKtraNH);
            this.pnEditNH.Controls.Add(this.btnUpdateNH);
            this.pnEditNH.Controls.Add(this.btnAddNH);
            this.pnEditNH.Controls.Add(this.txtSL);
            this.pnEditNH.Controls.Add(this.label6);
            this.pnEditNH.Controls.Add(this.txtDongia);
            this.pnEditNH.Controls.Add(this.label5);
            this.pnEditNH.Controls.Add(this.txtXuatxu);
            this.pnEditNH.Controls.Add(this.label4);
            this.pnEditNH.Controls.Add(this.txtTenHH);
            this.pnEditNH.Controls.Add(this.label3);
            this.pnEditNH.Controls.Add(this.txtMaHH);
            this.pnEditNH.Controls.Add(this.label2);
            this.pnEditNH.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnEditNH.Location = new System.Drawing.Point(25, 100);
            this.pnEditNH.Name = "pnEditNH";
            this.pnEditNH.Size = new System.Drawing.Size(664, 207);
            this.pnEditNH.TabIndex = 19;
            // 
            // btnXoaHH
            // 
            this.btnXoaHH.AutoSize = true;
            this.btnXoaHH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoaHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHH.Location = new System.Drawing.Point(234, 167);
            this.btnXoaHH.Name = "btnXoaHH";
            this.btnXoaHH.Size = new System.Drawing.Size(46, 27);
            this.btnXoaHH.TabIndex = 31;
            this.btnXoaHH.Text = "Xóa";
            this.btnXoaHH.UseVisualStyleBackColor = true;
            this.btnXoaHH.Click += new System.EventHandler(this.btnXoaHH_Click);
            // 
            // btnThemHH
            // 
            this.btnThemHH.AutoSize = true;
            this.btnThemHH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHH.Location = new System.Drawing.Point(160, 167);
            this.btnThemHH.Name = "btnThemHH";
            this.btnThemHH.Size = new System.Drawing.Size(58, 27);
            this.btnThemHH.TabIndex = 30;
            this.btnThemHH.Text = "Thêm";
            this.btnThemHH.UseVisualStyleBackColor = true;
            this.btnThemHH.Click += new System.EventHandler(this.btnThemHH_Click);
            // 
            // btnKtraNH
            // 
            this.btnKtraNH.AutoSize = true;
            this.btnKtraNH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKtraNH.Location = new System.Drawing.Point(346, 13);
            this.btnKtraNH.Name = "btnKtraNH";
            this.btnKtraNH.Size = new System.Drawing.Size(70, 27);
            this.btnKtraNH.TabIndex = 29;
            this.btnKtraNH.Text = "Kiểm tra";
            this.btnKtraNH.UseVisualStyleBackColor = true;
            this.btnKtraNH.Click += new System.EventHandler(this.btnKtraNH_Click);
            // 
            // btnUpdateNH
            // 
            this.btnUpdateNH.AutoSize = true;
            this.btnUpdateNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateNH.Location = new System.Drawing.Point(54, 167);
            this.btnUpdateNH.Name = "btnUpdateNH";
            this.btnUpdateNH.Size = new System.Drawing.Size(90, 27);
            this.btnUpdateNH.TabIndex = 28;
            this.btnUpdateNH.Text = "Cập nhật";
            this.btnUpdateNH.UseVisualStyleBackColor = true;
            this.btnUpdateNH.Click += new System.EventHandler(this.btnUpdateNH_Click);
            // 
            // btnAddNH
            // 
            this.btnAddNH.AutoSize = true;
            this.btnAddNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNH.Location = new System.Drawing.Point(319, 167);
            this.btnAddNH.Name = "btnAddNH";
            this.btnAddNH.Size = new System.Drawing.Size(97, 27);
            this.btnAddNH.TabIndex = 27;
            this.btnAddNH.Text = "Nhập hàng";
            this.btnAddNH.UseVisualStyleBackColor = true;
            this.btnAddNH.Click += new System.EventHandler(this.btnAddNH_Click);
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(160, 127);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(256, 22);
            this.txtSL.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Số lượng:";
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(160, 99);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(256, 22);
            this.txtDongia.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Giá tiền:";
            // 
            // txtXuatxu
            // 
            this.txtXuatxu.Location = new System.Drawing.Point(160, 71);
            this.txtXuatxu.Name = "txtXuatxu";
            this.txtXuatxu.Size = new System.Drawing.Size(256, 22);
            this.txtXuatxu.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Xuất xứ:";
            // 
            // txtTenHH
            // 
            this.txtTenHH.Location = new System.Drawing.Point(160, 43);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(256, 22);
            this.txtTenHH.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tên hàng hóa:";
            // 
            // txtMaHH
            // 
            this.txtMaHH.Location = new System.Drawing.Point(160, 15);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(180, 22);
            this.txtMaHH.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã hàng hóa:";
            // 
            // dgvChiTietNH
            // 
            this.dgvChiTietNH.AllowUserToAddRows = false;
            this.dgvChiTietNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietNH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaHH,
            this.clTenHH,
            this.clDonGia,
            this.clSL,
            this.clThanhTien});
            this.dgvChiTietNH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietNH.Location = new System.Drawing.Point(25, 307);
            this.dgvChiTietNH.Name = "dgvChiTietNH";
            this.dgvChiTietNH.ReadOnly = true;
            this.dgvChiTietNH.RowHeadersWidth = 51;
            this.dgvChiTietNH.RowTemplate.Height = 24;
            this.dgvChiTietNH.Size = new System.Drawing.Size(664, 203);
            this.dgvChiTietNH.TabIndex = 20;
            this.dgvChiTietNH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietNH_CellClick);
            // 
            // clMaHH
            // 
            this.clMaHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clMaHH.DataPropertyName = "MaHH";
            this.clMaHH.HeaderText = "Mã";
            this.clMaHH.MinimumWidth = 6;
            this.clMaHH.Name = "clMaHH";
            this.clMaHH.ReadOnly = true;
            this.clMaHH.Width = 56;
            // 
            // clTenHH
            // 
            this.clTenHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clTenHH.DataPropertyName = "TenHH";
            this.clTenHH.HeaderText = "Tên hàng hóa";
            this.clTenHH.MinimumWidth = 6;
            this.clTenHH.Name = "clTenHH";
            this.clTenHH.ReadOnly = true;
            this.clTenHH.Width = 126;
            // 
            // clDonGia
            // 
            this.clDonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clDonGia.DataPropertyName = "DonGia";
            this.clDonGia.HeaderText = "Đơn giá";
            this.clDonGia.MinimumWidth = 6;
            this.clDonGia.Name = "clDonGia";
            this.clDonGia.ReadOnly = true;
            this.clDonGia.Width = 86;
            // 
            // clSL
            // 
            this.clSL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clSL.DataPropertyName = "SL";
            this.clSL.HeaderText = "Số lượng";
            this.clSL.MinimumWidth = 6;
            this.clSL.Name = "clSL";
            this.clSL.ReadOnly = true;
            this.clSL.Width = 93;
            // 
            // clThanhTien
            // 
            this.clThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clThanhTien.DataPropertyName = "ThanhTien";
            this.clThanhTien.HeaderText = "Thành tièn";
            this.clThanhTien.MinimumWidth = 6;
            this.clThanhTien.Name = "clThanhTien";
            this.clThanhTien.ReadOnly = true;
            // 
            // frmNH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 535);
            this.Controls.Add(this.dgvChiTietNH);
            this.Controls.Add(this.pnEditNH);
            this.Controls.Add(this.panel1);
            this.Name = "frmNH";
            this.Padding = new System.Windows.Forms.Padding(25);
            this.Text = "Nhập hàng";
            this.Load += new System.EventHandler(this.frmNH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnEditNH.ResumeLayout(false);
            this.pnEditNH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNgayNH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaNH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnEditNH;
        private System.Windows.Forms.Button btnKtraNH;
        private System.Windows.Forms.Button btnUpdateNH;
        private System.Windows.Forms.Button btnAddNH;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtXuatxu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvChiTietNH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThanhTien;
        private System.Windows.Forms.Button btnXoaHH;
        private System.Windows.Forms.Button btnThemHH;
        private System.Windows.Forms.Button btnTaoNH;
    }
}