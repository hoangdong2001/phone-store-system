namespace PhoneStoreSystem
{
    partial class frmHD
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
            this.txtNgayHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnEditHD = new System.Windows.Forms.Panel();
            this.btnXoaHH = new System.Windows.Forms.Button();
            this.btnThemHH = new System.Windows.Forms.Button();
            this.btnUpdateHD = new System.Windows.Forms.Button();
            this.tvTotalPrice = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tvPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tvProductName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tvTongTien = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.clProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.pnEditHD.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNgayHD);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtOrderNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(25, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 88);
            this.panel1.TabIndex = 16;
            // 
            // txtNgayHD
            // 
            this.txtNgayHD.Location = new System.Drawing.Point(152, 44);
            this.txtNgayHD.Name = "txtNgayHD";
            this.txtNgayHD.Size = new System.Drawing.Size(143, 22);
            this.txtNgayHD.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ngày lập:";
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Location = new System.Drawing.Point(152, 16);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(143, 22);
            this.txtOrderNumber.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số hóa đơn:";
            // 
            // pnEditHD
            // 
            this.pnEditHD.Controls.Add(this.btnXoaHH);
            this.pnEditHD.Controls.Add(this.btnThemHH);
            this.pnEditHD.Controls.Add(this.btnUpdateHD);
            this.pnEditHD.Controls.Add(this.tvTotalPrice);
            this.pnEditHD.Controls.Add(this.label10);
            this.pnEditHD.Controls.Add(this.txtQuantity);
            this.pnEditHD.Controls.Add(this.label8);
            this.pnEditHD.Controls.Add(this.tvPrice);
            this.pnEditHD.Controls.Add(this.label7);
            this.pnEditHD.Controls.Add(this.tvProductName);
            this.pnEditHD.Controls.Add(this.label4);
            this.pnEditHD.Controls.Add(this.txtProductID);
            this.pnEditHD.Controls.Add(this.label3);
            this.pnEditHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnEditHD.Location = new System.Drawing.Point(25, 113);
            this.pnEditHD.Name = "pnEditHD";
            this.pnEditHD.Size = new System.Drawing.Size(600, 215);
            this.pnEditHD.TabIndex = 17;
            // 
            // btnXoaHH
            // 
            this.btnXoaHH.AutoSize = true;
            this.btnXoaHH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoaHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHH.Location = new System.Drawing.Point(237, 177);
            this.btnXoaHH.Name = "btnXoaHH";
            this.btnXoaHH.Size = new System.Drawing.Size(46, 27);
            this.btnXoaHH.TabIndex = 28;
            this.btnXoaHH.Text = "Xóa";
            this.btnXoaHH.UseVisualStyleBackColor = true;
            this.btnXoaHH.Click += new System.EventHandler(this.btnXoaHH_Click);
            // 
            // btnThemHH
            // 
            this.btnThemHH.AutoSize = true;
            this.btnThemHH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHH.Location = new System.Drawing.Point(152, 177);
            this.btnThemHH.Name = "btnThemHH";
            this.btnThemHH.Size = new System.Drawing.Size(58, 27);
            this.btnThemHH.TabIndex = 27;
            this.btnThemHH.Text = "Thêm";
            this.btnThemHH.UseVisualStyleBackColor = true;
            this.btnThemHH.Click += new System.EventHandler(this.btnThemHH_Click);
            // 
            // btnUpdateHD
            // 
            this.btnUpdateHD.AutoSize = true;
            this.btnUpdateHD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateHD.Location = new System.Drawing.Point(487, 177);
            this.btnUpdateHD.Name = "btnUpdateHD";
            this.btnUpdateHD.Size = new System.Drawing.Size(83, 27);
            this.btnUpdateHD.TabIndex = 26;
            this.btnUpdateHD.Text = "Cập nhật";
            this.btnUpdateHD.UseVisualStyleBackColor = true;
            this.btnUpdateHD.Click += new System.EventHandler(this.btnUpdateHD_Click);
            // 
            // tvTotalPrice
            // 
            this.tvTotalPrice.AutoSize = true;
            this.tvTotalPrice.Location = new System.Drawing.Point(152, 142);
            this.tvTotalPrice.Name = "tvTotalPrice";
            this.tvTotalPrice.Size = new System.Drawing.Size(0, 17);
            this.tvTotalPrice.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(66, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Thành tiền:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(152, 108);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(143, 22);
            this.txtQuantity.TabIndex = 23;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Số lượng:";
            // 
            // tvPrice
            // 
            this.tvPrice.AutoSize = true;
            this.tvPrice.Location = new System.Drawing.Point(152, 78);
            this.tvPrice.Name = "tvPrice";
            this.tvPrice.Size = new System.Drawing.Size(0, 17);
            this.tvPrice.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Đơn giá:";
            // 
            // tvProductName
            // 
            this.tvProductName.AutoSize = true;
            this.tvProductName.Location = new System.Drawing.Point(152, 51);
            this.tvProductName.Name = "tvProductName";
            this.tvProductName.Size = new System.Drawing.Size(0, 17);
            this.tvProductName.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tên hàng hóa:";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(152, 17);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(143, 22);
            this.txtProductID.TabIndex = 17;
            this.txtProductID.Leave += new System.EventHandler(this.txtProductID_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mã hàng hóa:";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.AutoSize = true;
            this.btnThanhToan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(487, 10);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(101, 27);
            this.btnThanhToan.TabIndex = 28;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThanhToan);
            this.panel2.Controls.Add(this.tvTongTien);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(25, 513);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 43);
            this.panel2.TabIndex = 18;
            // 
            // tvTongTien
            // 
            this.tvTongTien.AutoSize = true;
            this.tvTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvTongTien.Location = new System.Drawing.Point(124, 12);
            this.tvTongTien.Name = "tvTongTien";
            this.tvTongTien.Size = new System.Drawing.Size(0, 20);
            this.tvTongTien.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng tiền:";
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clProductID,
            this.clProductName,
            this.clPrice,
            this.clQuantity,
            this.clTotalPrice});
            this.dgvOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrder.Location = new System.Drawing.Point(25, 328);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.Size = new System.Drawing.Size(600, 185);
            this.dgvOrder.TabIndex = 19;
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellClick);
            // 
            // clProductID
            // 
            this.clProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clProductID.DataPropertyName = "ProductID";
            this.clProductID.HeaderText = "Mã";
            this.clProductID.MinimumWidth = 6;
            this.clProductID.Name = "clProductID";
            this.clProductID.ReadOnly = true;
            this.clProductID.Width = 56;
            // 
            // clProductName
            // 
            this.clProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clProductName.DataPropertyName = "ProductName";
            this.clProductName.HeaderText = "Tên hàng hóa";
            this.clProductName.MinimumWidth = 6;
            this.clProductName.Name = "clProductName";
            this.clProductName.ReadOnly = true;
            this.clProductName.Width = 126;
            // 
            // clPrice
            // 
            this.clPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clPrice.DataPropertyName = "Price";
            this.clPrice.HeaderText = "Giá";
            this.clPrice.MinimumWidth = 6;
            this.clPrice.Name = "clPrice";
            this.clPrice.ReadOnly = true;
            this.clPrice.Width = 59;
            // 
            // clQuantity
            // 
            this.clQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clQuantity.DataPropertyName = "Quantity";
            this.clQuantity.HeaderText = "Số lượng";
            this.clQuantity.MinimumWidth = 6;
            this.clQuantity.Name = "clQuantity";
            this.clQuantity.ReadOnly = true;
            this.clQuantity.Width = 93;
            // 
            // clTotalPrice
            // 
            this.clTotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTotalPrice.DataPropertyName = "TotalPrice";
            this.clTotalPrice.HeaderText = "Thành tiền";
            this.clTotalPrice.MinimumWidth = 6;
            this.clTotalPrice.Name = "clTotalPrice";
            this.clTotalPrice.ReadOnly = true;
            // 
            // frmHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 581);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnEditHD);
            this.Controls.Add(this.panel1);
            this.Name = "frmHD";
            this.Padding = new System.Windows.Forms.Padding(25);
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.frmHD_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnEditHD.ResumeLayout(false);
            this.pnEditHD.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNgayHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnEditHD;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnThemHH;
        private System.Windows.Forms.Button btnUpdateHD;
        private System.Windows.Forms.Label tvTotalPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label tvPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label tvProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tvTongTien;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Button btnXoaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTotalPrice;
    }
}