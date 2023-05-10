namespace PhoneStoreSystem
{
    partial class frmTK
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaTK = new System.Windows.Forms.TextBox();
            this.txtNgayTK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddTK = new System.Windows.Forms.Button();
            this.btnUpdateTK = new System.Windows.Forms.Button();
            this.btnKtraTK = new System.Windows.Forms.Button();
            this.txtStatisticIncome = new System.Windows.Forms.TextBox();
            this.txtStatisticOutcome = new System.Windows.Forms.TextBox();
            this.txtRevenue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thóng kê:";
            // 
            // txtMaTK
            // 
            this.txtMaTK.Location = new System.Drawing.Point(141, 52);
            this.txtMaTK.Name = "txtMaTK";
            this.txtMaTK.Size = new System.Drawing.Size(109, 22);
            this.txtMaTK.TabIndex = 1;
            // 
            // txtNgayTK
            // 
            this.txtNgayTK.Location = new System.Drawing.Point(141, 80);
            this.txtNgayTK.Name = "txtNgayTK";
            this.txtNgayTK.Size = new System.Drawing.Size(152, 22);
            this.txtNgayTK.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày lập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng StatisticIncome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tổng StatisticOutcome:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Doanh StatisticIncome:";
            // 
            // btnAddTK
            // 
            this.btnAddTK.AutoSize = true;
            this.btnAddTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTK.Location = new System.Drawing.Point(216, 257);
            this.btnAddTK.Name = "btnAddTK";
            this.btnAddTK.Size = new System.Drawing.Size(126, 27);
            this.btnAddTK.TabIndex = 10;
            this.btnAddTK.Text = "Thêm thống kê";
            this.btnAddTK.UseVisualStyleBackColor = true;
            this.btnAddTK.Click += new System.EventHandler(this.btnAddTK_Click);
            // 
            // btnUpdateTK
            // 
            this.btnUpdateTK.AutoSize = true;
            this.btnUpdateTK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTK.Location = new System.Drawing.Point(48, 257);
            this.btnUpdateTK.Name = "btnUpdateTK";
            this.btnUpdateTK.Size = new System.Drawing.Size(83, 27);
            this.btnUpdateTK.TabIndex = 11;
            this.btnUpdateTK.Text = "Cập nhật";
            this.btnUpdateTK.UseVisualStyleBackColor = true;
            this.btnUpdateTK.Click += new System.EventHandler(this.btnUpdateTK_Click);
            // 
            // btnKtraTK
            // 
            this.btnKtraTK.AutoSize = true;
            this.btnKtraTK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKtraTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKtraTK.Location = new System.Drawing.Point(141, 108);
            this.btnKtraTK.Name = "btnKtraTK";
            this.btnKtraTK.Size = new System.Drawing.Size(78, 27);
            this.btnKtraTK.TabIndex = 12;
            this.btnKtraTK.Text = "Kiểm tra";
            this.btnKtraTK.UseVisualStyleBackColor = true;
            this.btnKtraTK.Click += new System.EventHandler(this.btnKtraTK_Click);
            // 
            // txtStatisticIncome
            // 
            this.txtStatisticIncome.Location = new System.Drawing.Point(141, 152);
            this.txtStatisticIncome.Name = "txtStatisticIncome";
            this.txtStatisticIncome.Size = new System.Drawing.Size(201, 22);
            this.txtStatisticIncome.TabIndex = 13;
            // 
            // txtStatisticOutcome
            // 
            this.txtStatisticOutcome.Location = new System.Drawing.Point(141, 178);
            this.txtStatisticOutcome.Name = "txtStatisticOutcome";
            this.txtStatisticOutcome.Size = new System.Drawing.Size(201, 22);
            this.txtStatisticOutcome.TabIndex = 14;
            // 
            // txtRevenue
            // 
            this.txtRevenue.Location = new System.Drawing.Point(141, 204);
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.Size = new System.Drawing.Size(201, 22);
            this.txtRevenue.TabIndex = 15;
            // 
            // frmTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 326);
            this.Controls.Add(this.txtRevenue);
            this.Controls.Add(this.txtStatisticOutcome);
            this.Controls.Add(this.txtStatisticIncome);
            this.Controls.Add(this.btnKtraTK);
            this.Controls.Add(this.btnUpdateTK);
            this.Controls.Add(this.btnAddTK);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNgayTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaTK);
            this.Controls.Add(this.label1);
            this.Name = "frmTK";
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.frmTK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaTK;
        private System.Windows.Forms.TextBox txtNgayTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddTK;
        private System.Windows.Forms.Button btnUpdateTK;
        private System.Windows.Forms.Button btnKtraTK;
        private System.Windows.Forms.TextBox txtStatisticIncome;
        private System.Windows.Forms.TextBox txtStatisticOutcome;
        private System.Windows.Forms.TextBox txtRevenue;
    }
}