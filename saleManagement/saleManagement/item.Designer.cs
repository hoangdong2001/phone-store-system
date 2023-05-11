
namespace saleManagement
{
    partial class item
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
            this.tbIdItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNameItem = new System.Windows.Forms.TextBox();
            this.btnCreateItem = new System.Windows.Forms.Button();
            this.saleManagementDataSet = new saleManagement.saleManagementDataSet();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemTableAdapter = new saleManagement.saleManagementDataSetTableAdapters.itemTableAdapter();
            this.inventoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemGridView = new System.Windows.Forms.DataGridView();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnClearItem = new System.Windows.Forms.Button();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.saleManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIdItem
            // 
            this.tbIdItem.Location = new System.Drawing.Point(348, 33);
            this.tbIdItem.Name = "tbIdItem";
            this.tbIdItem.Size = new System.Drawing.Size(158, 22);
            this.tbIdItem.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "View Item";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name Item";
            // 
            // tbNameItem
            // 
            this.tbNameItem.Location = new System.Drawing.Point(348, 78);
            this.tbNameItem.Name = "tbNameItem";
            this.tbNameItem.Size = new System.Drawing.Size(158, 22);
            this.tbNameItem.TabIndex = 6;
            // 
            // btnCreateItem
            // 
            this.btnCreateItem.Location = new System.Drawing.Point(244, 126);
            this.btnCreateItem.Name = "btnCreateItem";
            this.btnCreateItem.Size = new System.Drawing.Size(120, 38);
            this.btnCreateItem.TabIndex = 7;
            this.btnCreateItem.Text = "Create Item";
            this.btnCreateItem.UseVisualStyleBackColor = true;
            this.btnCreateItem.Click += new System.EventHandler(this.btnCreateItem_Click);
            // 
            // saleManagementDataSet
            // 
            this.saleManagementDataSet.DataSetName = "saleManagementDataSet";
            this.saleManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "item";
            this.itemBindingSource.DataSource = this.saleManagementDataSet;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // inventoryDataGridViewTextBoxColumn
            // 
            this.inventoryDataGridViewTextBoxColumn.DataPropertyName = "inventory";
            this.inventoryDataGridViewTextBoxColumn.HeaderText = "inventory";
            this.inventoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inventoryDataGridViewTextBoxColumn.Name = "inventoryDataGridViewTextBoxColumn";
            // 
            // nameItemDataGridViewTextBoxColumn
            // 
            this.nameItemDataGridViewTextBoxColumn.DataPropertyName = "nameItem";
            this.nameItemDataGridViewTextBoxColumn.HeaderText = "nameItem";
            this.nameItemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameItemDataGridViewTextBoxColumn.Name = "nameItemDataGridViewTextBoxColumn";
            // 
            // idItemDataGridViewTextBoxColumn
            // 
            this.idItemDataGridViewTextBoxColumn.DataPropertyName = "idItem";
            this.idItemDataGridViewTextBoxColumn.HeaderText = "idItem";
            this.idItemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idItemDataGridViewTextBoxColumn.Name = "idItemDataGridViewTextBoxColumn";
            // 
            // itemGridView
            // 
            this.itemGridView.AutoGenerateColumns = false;
            this.itemGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idItemDataGridViewTextBoxColumn,
            this.nameItemDataGridViewTextBoxColumn,
            this.inventoryDataGridViewTextBoxColumn});
            this.itemGridView.DataSource = this.itemBindingSource;
            this.itemGridView.Location = new System.Drawing.Point(51, 292);
            this.itemGridView.Name = "itemGridView";
            this.itemGridView.RowHeadersWidth = 51;
            this.itemGridView.RowTemplate.Height = 24;
            this.itemGridView.Size = new System.Drawing.Size(704, 346);
            this.itemGridView.TabIndex = 2;
            this.itemGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(386, 188);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(120, 38);
            this.btnDeleteItem.TabIndex = 9;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnClearItem
            // 
            this.btnClearItem.Location = new System.Drawing.Point(386, 126);
            this.btnClearItem.Name = "btnClearItem";
            this.btnClearItem.Size = new System.Drawing.Size(120, 38);
            this.btnClearItem.TabIndex = 10;
            this.btnClearItem.Text = "Clear Input";
            this.btnClearItem.UseVisualStyleBackColor = true;
            this.btnClearItem.Click += new System.EventHandler(this.btnClearItem_Click);
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.Location = new System.Drawing.Point(244, 188);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(120, 38);
            this.btnUpdateItem.TabIndex = 11;
            this.btnUpdateItem.Text = "Update Item";
            this.btnUpdateItem.UseVisualStyleBackColor = true;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 703);
            this.Controls.Add(this.btnUpdateItem);
            this.Controls.Add(this.btnClearItem);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnCreateItem);
            this.Controls.Add(this.tbNameItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.itemGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIdItem);
            this.Name = "item";
            this.Text = "Item";
            this.Load += new System.EventHandler(this.item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saleManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIdItem;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNameItem;
        private System.Windows.Forms.Button btnCreateItem;
        private saleManagementDataSet saleManagementDataSet;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private saleManagementDataSetTableAdapters.itemTableAdapter itemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView itemGridView;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnClearItem;
        private System.Windows.Forms.Button btnUpdateItem;
    }
}