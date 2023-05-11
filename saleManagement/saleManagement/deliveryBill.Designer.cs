
namespace saleManagement
{
    partial class deliveryBill
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
            this.tbIdDeliveryBill = new System.Windows.Forms.TextBox();
            this.tbIdAccountant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIdOrder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.createDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.rbBeingTransported = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.rbDelivered = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.rbPaid = new System.Windows.Forms.RadioButton();
            this.rbUnpaid = new System.Windows.Forms.RadioButton();
            this.btnCreateDeliveryBill = new System.Windows.Forms.Button();
            this.orderGridView = new System.Windows.Forms.DataGridView();
            this.idOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleManagementDataSet = new saleManagement.saleManagementDataSet();
            this.ordersTableAdapter = new saleManagement.saleManagementDataSetTableAdapters.ordersTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDeliveryBillDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOrderDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAccountantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.deliveryBillTableAdapter = new saleManagement.saleManagementDataSetTableAdapters.deliveryBillTableAdapter();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleManagementDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBillBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Delivery Bill";
            // 
            // tbIdDeliveryBill
            // 
            this.tbIdDeliveryBill.Location = new System.Drawing.Point(158, 22);
            this.tbIdDeliveryBill.Name = "tbIdDeliveryBill";
            this.tbIdDeliveryBill.Size = new System.Drawing.Size(200, 22);
            this.tbIdDeliveryBill.TabIndex = 1;
            // 
            // tbIdAccountant
            // 
            this.tbIdAccountant.Location = new System.Drawing.Point(158, 58);
            this.tbIdAccountant.Name = "tbIdAccountant";
            this.tbIdAccountant.Size = new System.Drawing.Size(200, 22);
            this.tbIdAccountant.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Accountant";
            // 
            // tbIdOrder
            // 
            this.tbIdOrder.Location = new System.Drawing.Point(158, 98);
            this.tbIdOrder.Name = "tbIdOrder";
            this.tbIdOrder.Size = new System.Drawing.Size(200, 22);
            this.tbIdOrder.TabIndex = 5;
            this.tbIdOrder.Text = "Click on the right tablel to select";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID Order";
            // 
            // createDate
            // 
            this.createDate.Location = new System.Drawing.Point(158, 143);
            this.createDate.Name = "createDate";
            this.createDate.Size = new System.Drawing.Size(200, 22);
            this.createDate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Creation Date";
            // 
            // rbBeingTransported
            // 
            this.rbBeingTransported.AutoSize = true;
            this.rbBeingTransported.Location = new System.Drawing.Point(12, 12);
            this.rbBeingTransported.Name = "rbBeingTransported";
            this.rbBeingTransported.Size = new System.Drawing.Size(141, 21);
            this.rbBeingTransported.TabIndex = 8;
            this.rbBeingTransported.TabStop = true;
            this.rbBeingTransported.Text = "being transported";
            this.rbBeingTransported.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Order status";
            // 
            // rbDelivered
            // 
            this.rbDelivered.AutoSize = true;
            this.rbDelivered.Location = new System.Drawing.Point(12, 39);
            this.rbDelivered.Name = "rbDelivered";
            this.rbDelivered.Size = new System.Drawing.Size(87, 21);
            this.rbDelivered.TabIndex = 10;
            this.rbDelivered.TabStop = true;
            this.rbDelivered.Text = "delivered";
            this.rbDelivered.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Payment status";
            // 
            // rbPaid
            // 
            this.rbPaid.AutoSize = true;
            this.rbPaid.Location = new System.Drawing.Point(12, 42);
            this.rbPaid.Name = "rbPaid";
            this.rbPaid.Size = new System.Drawing.Size(56, 21);
            this.rbPaid.TabIndex = 12;
            this.rbPaid.TabStop = true;
            this.rbPaid.Text = "paid";
            this.rbPaid.UseVisualStyleBackColor = true;
            // 
            // rbUnpaid
            // 
            this.rbUnpaid.AutoSize = true;
            this.rbUnpaid.Location = new System.Drawing.Point(13, 15);
            this.rbUnpaid.Name = "rbUnpaid";
            this.rbUnpaid.Size = new System.Drawing.Size(72, 21);
            this.rbUnpaid.TabIndex = 13;
            this.rbUnpaid.TabStop = true;
            this.rbUnpaid.Text = "unpaid";
            this.rbUnpaid.UseVisualStyleBackColor = true;
            // 
            // btnCreateDeliveryBill
            // 
            this.btnCreateDeliveryBill.Location = new System.Drawing.Point(72, 376);
            this.btnCreateDeliveryBill.Name = "btnCreateDeliveryBill";
            this.btnCreateDeliveryBill.Size = new System.Drawing.Size(217, 46);
            this.btnCreateDeliveryBill.TabIndex = 14;
            this.btnCreateDeliveryBill.Text = "Create Delivery Bill";
            this.btnCreateDeliveryBill.UseVisualStyleBackColor = true;
            this.btnCreateDeliveryBill.Click += new System.EventHandler(this.btnCreateDeliveryBill_Click);
            // 
            // orderGridView
            // 
            this.orderGridView.AutoGenerateColumns = false;
            this.orderGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOrderDataGridViewTextBoxColumn,
            this.idCustomerDataGridViewTextBoxColumn,
            this.paymentMethodDataGridViewTextBoxColumn,
            this.creationDateDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.orderGridView.DataSource = this.ordersBindingSource;
            this.orderGridView.Location = new System.Drawing.Point(382, 22);
            this.orderGridView.Name = "orderGridView";
            this.orderGridView.RowHeadersWidth = 51;
            this.orderGridView.RowTemplate.Height = 24;
            this.orderGridView.Size = new System.Drawing.Size(747, 416);
            this.orderGridView.TabIndex = 15;
            this.orderGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderGridView_CellClick);
            // 
            // idOrderDataGridViewTextBoxColumn
            // 
            this.idOrderDataGridViewTextBoxColumn.DataPropertyName = "idOrder";
            this.idOrderDataGridViewTextBoxColumn.HeaderText = "idOrder";
            this.idOrderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idOrderDataGridViewTextBoxColumn.Name = "idOrderDataGridViewTextBoxColumn";
            // 
            // idCustomerDataGridViewTextBoxColumn
            // 
            this.idCustomerDataGridViewTextBoxColumn.DataPropertyName = "idCustomer";
            this.idCustomerDataGridViewTextBoxColumn.HeaderText = "idCustomer";
            this.idCustomerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idCustomerDataGridViewTextBoxColumn.Name = "idCustomerDataGridViewTextBoxColumn";
            // 
            // paymentMethodDataGridViewTextBoxColumn
            // 
            this.paymentMethodDataGridViewTextBoxColumn.DataPropertyName = "paymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn.HeaderText = "paymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentMethodDataGridViewTextBoxColumn.Name = "paymentMethodDataGridViewTextBoxColumn";
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
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.saleManagementDataSet;
            // 
            // saleManagementDataSet
            // 
            this.saleManagementDataSet.DataSetName = "saleManagementDataSet";
            this.saleManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbBeingTransported);
            this.panel1.Controls.Add(this.rbDelivered);
            this.panel1.Location = new System.Drawing.Point(158, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 75);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbPaid);
            this.panel2.Controls.Add(this.rbUnpaid);
            this.panel2.Location = new System.Drawing.Point(158, 280);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 75);
            this.panel2.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDeliveryBillDataGridViewTextBoxColumn,
            this.idOrderDataGridViewTextBoxColumn1,
            this.idAccountantDataGridViewTextBoxColumn,
            this.creationDateDataGridViewTextBoxColumn1,
            this.orderStatusDataGridViewTextBoxColumn,
            this.paymentStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.deliveryBillBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 523);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1097, 243);
            this.dataGridView1.TabIndex = 18;
            // 
            // idDeliveryBillDataGridViewTextBoxColumn
            // 
            this.idDeliveryBillDataGridViewTextBoxColumn.DataPropertyName = "idDeliveryBill";
            this.idDeliveryBillDataGridViewTextBoxColumn.HeaderText = "idDeliveryBill";
            this.idDeliveryBillDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDeliveryBillDataGridViewTextBoxColumn.Name = "idDeliveryBillDataGridViewTextBoxColumn";
            // 
            // idOrderDataGridViewTextBoxColumn1
            // 
            this.idOrderDataGridViewTextBoxColumn1.DataPropertyName = "idOrder";
            this.idOrderDataGridViewTextBoxColumn1.HeaderText = "idOrder";
            this.idOrderDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idOrderDataGridViewTextBoxColumn1.Name = "idOrderDataGridViewTextBoxColumn1";
            // 
            // idAccountantDataGridViewTextBoxColumn
            // 
            this.idAccountantDataGridViewTextBoxColumn.DataPropertyName = "idAccountant";
            this.idAccountantDataGridViewTextBoxColumn.HeaderText = "idAccountant";
            this.idAccountantDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idAccountantDataGridViewTextBoxColumn.Name = "idAccountantDataGridViewTextBoxColumn";
            // 
            // creationDateDataGridViewTextBoxColumn1
            // 
            this.creationDateDataGridViewTextBoxColumn1.DataPropertyName = "creationDate";
            this.creationDateDataGridViewTextBoxColumn1.HeaderText = "creationDate";
            this.creationDateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.creationDateDataGridViewTextBoxColumn1.Name = "creationDateDataGridViewTextBoxColumn1";
            // 
            // orderStatusDataGridViewTextBoxColumn
            // 
            this.orderStatusDataGridViewTextBoxColumn.DataPropertyName = "orderStatus";
            this.orderStatusDataGridViewTextBoxColumn.HeaderText = "orderStatus";
            this.orderStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderStatusDataGridViewTextBoxColumn.Name = "orderStatusDataGridViewTextBoxColumn";
            // 
            // paymentStatusDataGridViewTextBoxColumn
            // 
            this.paymentStatusDataGridViewTextBoxColumn.DataPropertyName = "paymentStatus";
            this.paymentStatusDataGridViewTextBoxColumn.HeaderText = "paymentStatus";
            this.paymentStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentStatusDataGridViewTextBoxColumn.Name = "paymentStatusDataGridViewTextBoxColumn";
            // 
            // deliveryBillBindingSource
            // 
            this.deliveryBillBindingSource.DataMember = "deliveryBill";
            this.deliveryBillBindingSource.DataSource = this.saleManagementDataSet;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(421, 470);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(280, 39);
            this.label7.TabIndex = 19;
            this.label7.Text = "DELIVERY BILL";
            // 
            // deliveryBillTableAdapter
            // 
            this.deliveryBillTableAdapter.ClearBeforeFill = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(112, 448);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(131, 42);
            this.btnExport.TabIndex = 20;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // deliveryBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 787);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.orderGridView);
            this.Controls.Add(this.btnCreateDeliveryBill);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.createDate);
            this.Controls.Add(this.tbIdOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbIdAccountant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIdDeliveryBill);
            this.Controls.Add(this.label1);
            this.Name = "deliveryBill";
            this.Text = "Delivery Bill";
            this.Load += new System.EventHandler(this.deliveryBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleManagementDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBillBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIdDeliveryBill;
        private System.Windows.Forms.TextBox tbIdAccountant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIdOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker createDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbBeingTransported;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbDelivered;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbPaid;
        private System.Windows.Forms.RadioButton rbUnpaid;
        private System.Windows.Forms.Button btnCreateDeliveryBill;
        private System.Windows.Forms.DataGridView orderGridView;
        private saleManagementDataSet saleManagementDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private saleManagementDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource deliveryBillBindingSource;
        private saleManagementDataSetTableAdapters.deliveryBillTableAdapter deliveryBillTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDeliveryBillDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrderDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAccountantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnExport;
    }
}