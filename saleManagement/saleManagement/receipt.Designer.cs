
namespace saleManagement
{
    partial class receipt
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIdAccountant = new System.Windows.Forms.TextBox();
            this.tbIdReceipt = new System.Windows.Forms.TextBox();
            this.tbIdItem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.itemGridView = new System.Windows.Forms.DataGridView();
            this.idItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNameItem = new System.Windows.Forms.TextBox();
            this.btnAddReceipt = new System.Windows.Forms.Button();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.detailReceiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleManagementDataSet = new saleManagement.saleManagementDataSet();
            this.receiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receiptTableAdapter = new saleManagement.saleManagementDataSetTableAdapters.receiptTableAdapter();
            this.receiptBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.detailReceiptTableAdapter = new saleManagement.saleManagementDataSetTableAdapters.detailReceiptTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.receiptBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idReceiptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAccountantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.saleManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailReceiptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleManagementDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Receipt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Accnoutant";
            // 
            // createDate
            // 
            this.createDate.Location = new System.Drawing.Point(146, 83);
            this.createDate.Name = "createDate";
            this.createDate.Size = new System.Drawing.Size(200, 22);
            this.createDate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Creation Date";
            // 
            // tbIdAccountant
            // 
            this.tbIdAccountant.Location = new System.Drawing.Point(146, 51);
            this.tbIdAccountant.Name = "tbIdAccountant";
            this.tbIdAccountant.Size = new System.Drawing.Size(200, 22);
            this.tbIdAccountant.TabIndex = 4;
            // 
            // tbIdReceipt
            // 
            this.tbIdReceipt.Location = new System.Drawing.Point(146, 12);
            this.tbIdReceipt.Name = "tbIdReceipt";
            this.tbIdReceipt.Size = new System.Drawing.Size(200, 22);
            this.tbIdReceipt.TabIndex = 5;
            // 
            // tbIdItem
            // 
            this.tbIdItem.Location = new System.Drawing.Point(147, 197);
            this.tbIdItem.Name = "tbIdItem";
            this.tbIdItem.Size = new System.Drawing.Size(200, 22);
            this.tbIdItem.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID Item ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Price per item";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(74, 342);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(167, 30);
            this.btnAddItem.TabIndex = 13;
            this.btnAddItem.Text = "Add Item to list";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // itemGridView
            // 
            this.itemGridView.AllowUserToAddRows = false;
            this.itemGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idItem,
            this.nameItem,
            this.quantity,
            this.price});
            this.itemGridView.Location = new System.Drawing.Point(25, 389);
            this.itemGridView.Name = "itemGridView";
            this.itemGridView.RowHeadersWidth = 51;
            this.itemGridView.RowTemplate.Height = 24;
            this.itemGridView.Size = new System.Drawing.Size(613, 348);
            this.itemGridView.TabIndex = 14;
            // 
            // idItem
            // 
            this.idItem.HeaderText = "ID Item";
            this.idItem.MinimumWidth = 6;
            this.idItem.Name = "idItem";
            this.idItem.ReadOnly = true;
            // 
            // nameItem
            // 
            this.nameItem.HeaderText = "Name Item";
            this.nameItem.MinimumWidth = 6;
            this.nameItem.Name = "nameItem";
            this.nameItem.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Name Item";
            // 
            // tbNameItem
            // 
            this.tbNameItem.Location = new System.Drawing.Point(147, 233);
            this.tbNameItem.Name = "tbNameItem";
            this.tbNameItem.Size = new System.Drawing.Size(200, 22);
            this.tbNameItem.TabIndex = 15;
            // 
            // btnAddReceipt
            // 
            this.btnAddReceipt.Location = new System.Drawing.Point(451, 147);
            this.btnAddReceipt.Name = "btnAddReceipt";
            this.btnAddReceipt.Size = new System.Drawing.Size(187, 67);
            this.btnAddReceipt.TabIndex = 17;
            this.btnAddReceipt.Text = "Create Receipt";
            this.btnAddReceipt.UseVisualStyleBackColor = true;
            this.btnAddReceipt.Click += new System.EventHandler(this.btnAddReceipt_Click);
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(147, 273);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(200, 22);
            this.tbQuantity.TabIndex = 18;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(147, 305);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(200, 22);
            this.tbPrice.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(393, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "You should add the item to the list before creating the receipt";
            // 
            // detailReceiptBindingSource
            // 
            this.detailReceiptBindingSource.DataMember = "detailReceipt";
            this.detailReceiptBindingSource.DataSource = this.saleManagementDataSet;
            // 
            // saleManagementDataSet
            // 
            this.saleManagementDataSet.DataSetName = "saleManagementDataSet";
            this.saleManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receiptBindingSource
            // 
            this.receiptBindingSource.DataMember = "receipt";
            this.receiptBindingSource.DataSource = this.saleManagementDataSet;
            // 
            // receiptTableAdapter
            // 
            this.receiptTableAdapter.ClearBeforeFill = true;
            // 
            // receiptBindingSource1
            // 
            this.receiptBindingSource1.DataMember = "receipt";
            this.receiptBindingSource1.DataSource = this.saleManagementDataSet;
            // 
            // detailReceiptTableAdapter
            // 
            this.detailReceiptTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(819, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(311, 39);
            this.label9.TabIndex = 22;
            this.label9.Text = "DETAIL RECEIPT";
            // 
            // receiptBindingSource2
            // 
            this.receiptBindingSource2.DataMember = "receipt";
            this.receiptBindingSource2.DataSource = this.saleManagementDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idReceiptDataGridViewTextBoxColumn,
            this.idAccountantDataGridViewTextBoxColumn,
            this.creationDateDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.receiptBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(689, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(559, 654);
            this.dataGridView1.TabIndex = 23;
            // 
            // idReceiptDataGridViewTextBoxColumn
            // 
            this.idReceiptDataGridViewTextBoxColumn.DataPropertyName = "idReceipt";
            this.idReceiptDataGridViewTextBoxColumn.HeaderText = "idReceipt";
            this.idReceiptDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idReceiptDataGridViewTextBoxColumn.Name = "idReceiptDataGridViewTextBoxColumn";
            // 
            // idAccountantDataGridViewTextBoxColumn
            // 
            this.idAccountantDataGridViewTextBoxColumn.DataPropertyName = "idAccountant";
            this.idAccountantDataGridViewTextBoxColumn.HeaderText = "idAccountant";
            this.idAccountantDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idAccountantDataGridViewTextBoxColumn.Name = "idAccountantDataGridViewTextBoxColumn";
            // 
            // creationDateDataGridViewTextBoxColumn
            // 
            this.creationDateDataGridViewTextBoxColumn.DataPropertyName = "creationDate";
            this.creationDateDataGridViewTextBoxColumn.HeaderText = "creationDate";
            this.creationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.creationDateDataGridViewTextBoxColumn.Name = "creationDateDataGridViewTextBoxColumn";
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "totalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "totalPrice";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            // 
            // receiptBindingSource3
            // 
            this.receiptBindingSource3.DataMember = "receipt";
            this.receiptBindingSource3.DataSource = this.saleManagementDataSet;
            // 
            // saleManagementDataSetBindingSource
            // 
            this.saleManagementDataSetBindingSource.DataSource = this.saleManagementDataSet;
            this.saleManagementDataSetBindingSource.Position = 0;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(476, 252);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(137, 43);
            this.btnExport.TabIndex = 24;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 758);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.btnAddReceipt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbNameItem);
            this.Controls.Add(this.itemGridView);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbIdItem);
            this.Controls.Add(this.tbIdReceipt);
            this.Controls.Add(this.tbIdAccountant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.createDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "receipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.receipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailReceiptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleManagementDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker createDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIdAccountant;
        private System.Windows.Forms.TextBox tbIdReceipt;
        private System.Windows.Forms.TextBox tbIdItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.DataGridView itemGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNameItem;
        private System.Windows.Forms.Button btnAddReceipt;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label8;
        private saleManagementDataSet saleManagementDataSet;
        private System.Windows.Forms.BindingSource receiptBindingSource;
        private saleManagementDataSetTableAdapters.receiptTableAdapter receiptTableAdapter;
        private System.Windows.Forms.BindingSource receiptBindingSource1;
        private System.Windows.Forms.BindingSource detailReceiptBindingSource;
        private saleManagementDataSetTableAdapters.detailReceiptTableAdapter detailReceiptTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource receiptBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReceiptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAccountantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource receiptBindingSource3;
        private System.Windows.Forms.BindingSource saleManagementDataSetBindingSource;
        private System.Windows.Forms.Button btnExport;
    }
}