
namespace saleManagement
{
    partial class statistical
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
            this.incomingStockGridView = new System.Windows.Forms.DataGridView();
            this.outgoingStockGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.incomingStockGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outgoingStockGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // incomingStockGridView
            // 
            this.incomingStockGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.incomingStockGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incomingStockGridView.Location = new System.Drawing.Point(21, 53);
            this.incomingStockGridView.Name = "incomingStockGridView";
            this.incomingStockGridView.RowHeadersWidth = 51;
            this.incomingStockGridView.RowTemplate.Height = 24;
            this.incomingStockGridView.Size = new System.Drawing.Size(568, 523);
            this.incomingStockGridView.TabIndex = 0;
            // 
            // outgoingStockGridView
            // 
            this.outgoingStockGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.outgoingStockGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outgoingStockGridView.Location = new System.Drawing.Point(618, 53);
            this.outgoingStockGridView.Name = "outgoingStockGridView";
            this.outgoingStockGridView.RowHeadersWidth = 51;
            this.outgoingStockGridView.RowTemplate.Height = 24;
            this.outgoingStockGridView.Size = new System.Drawing.Size(568, 523);
            this.outgoingStockGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Incoming Stocks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(799, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Outgoing Stocks";
            // 
            // statistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 616);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outgoingStockGridView);
            this.Controls.Add(this.incomingStockGridView);
            this.Name = "statistical";
            this.Text = "Statistical";
            ((System.ComponentModel.ISupportInitialize)(this.incomingStockGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outgoingStockGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView incomingStockGridView;
        private System.Windows.Forms.DataGridView outgoingStockGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}