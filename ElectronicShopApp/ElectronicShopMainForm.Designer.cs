
namespace ElectronicShopApp
{
    partial class ElectronicShopMainForm
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
			this.tabControlMain = new System.Windows.Forms.TabControl();
			this.tabPageAdministrator = new System.Windows.Forms.TabPage();
			this.labelVersion = new System.Windows.Forms.Label();
			this.listBoxVersion = new System.Windows.Forms.ListBox();
			this.buttonDeleteItem = new System.Windows.Forms.Button();
			this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
			this.labelTotalPrice = new System.Windows.Forms.Label();
			this.buttonOrder = new System.Windows.Forms.Button();
			this.labelCustomer = new System.Windows.Forms.Label();
			this.buttonAddUpdateCustomer = new System.Windows.Forms.Button();
			this.labelQuantity = new System.Windows.Forms.Label();
			this.textBoxQuantity = new System.Windows.Forms.TextBox();
			this.labelSelectedItems = new System.Windows.Forms.Label();
			this.dataGridViewSelectedItems = new System.Windows.Forms.DataGridView();
			this.buttonAddItem = new System.Windows.Forms.Button();
			this.listBoxCurrent = new System.Windows.Forms.ListBox();
			this.labelCurent = new System.Windows.Forms.Label();
			this.listBoxVoltage = new System.Windows.Forms.ListBox();
			this.labelVoltage = new System.Windows.Forms.Label();
			this.labelType = new System.Windows.Forms.Label();
			this.labelCategory = new System.Windows.Forms.Label();
			this.listBoxType = new System.Windows.Forms.ListBox();
			this.listBoxCategory = new System.Windows.Forms.ListBox();
			this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
			this.tabPageManager = new System.Windows.Forms.TabPage();
			this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
			this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
			this.tabPageSalesOrder = new System.Windows.Forms.TabPage();
			this.buttonClearFilter = new System.Windows.Forms.Button();
			this.buttonDeleteAllOrders = new System.Windows.Forms.Button();
			this.buttonDeleteOrder = new System.Windows.Forms.Button();
			this.buttonOrderFilter = new System.Windows.Forms.Button();
			this.listBoxOrderInventory = new System.Windows.Forms.ListBox();
			this.listBoxOrderCustomer = new System.Windows.Forms.ListBox();
			this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
			this.tabPageDatabaseBackup = new System.Windows.Forms.TabPage();
			this.buttonRestoreXML = new System.Windows.Forms.Button();
			this.buttonBackupXML = new System.Windows.Forms.Button();
			this.tabControlMain.SuspendLayout();
			this.tabPageAdministrator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedItems)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
			this.tabPageManager.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
			this.tabPageSalesOrder.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
			this.tabPageDatabaseBackup.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControlMain
			// 
			this.tabControlMain.Controls.Add(this.tabPageAdministrator);
			this.tabControlMain.Controls.Add(this.tabPageManager);
			this.tabControlMain.Controls.Add(this.tabPageSalesOrder);
			this.tabControlMain.Controls.Add(this.tabPageDatabaseBackup);
			this.tabControlMain.Location = new System.Drawing.Point(22, 11);
			this.tabControlMain.Margin = new System.Windows.Forms.Padding(2);
			this.tabControlMain.Name = "tabControlMain";
			this.tabControlMain.SelectedIndex = 0;
			this.tabControlMain.Size = new System.Drawing.Size(1188, 837);
			this.tabControlMain.TabIndex = 0;
			// 
			// tabPageAdministrator
			// 
			this.tabPageAdministrator.Controls.Add(this.labelVersion);
			this.tabPageAdministrator.Controls.Add(this.listBoxVersion);
			this.tabPageAdministrator.Controls.Add(this.buttonDeleteItem);
			this.tabPageAdministrator.Controls.Add(this.textBoxTotalPrice);
			this.tabPageAdministrator.Controls.Add(this.labelTotalPrice);
			this.tabPageAdministrator.Controls.Add(this.buttonOrder);
			this.tabPageAdministrator.Controls.Add(this.labelCustomer);
			this.tabPageAdministrator.Controls.Add(this.buttonAddUpdateCustomer);
			this.tabPageAdministrator.Controls.Add(this.labelQuantity);
			this.tabPageAdministrator.Controls.Add(this.textBoxQuantity);
			this.tabPageAdministrator.Controls.Add(this.labelSelectedItems);
			this.tabPageAdministrator.Controls.Add(this.dataGridViewSelectedItems);
			this.tabPageAdministrator.Controls.Add(this.buttonAddItem);
			this.tabPageAdministrator.Controls.Add(this.listBoxCurrent);
			this.tabPageAdministrator.Controls.Add(this.labelCurent);
			this.tabPageAdministrator.Controls.Add(this.listBoxVoltage);
			this.tabPageAdministrator.Controls.Add(this.labelVoltage);
			this.tabPageAdministrator.Controls.Add(this.labelType);
			this.tabPageAdministrator.Controls.Add(this.labelCategory);
			this.tabPageAdministrator.Controls.Add(this.listBoxType);
			this.tabPageAdministrator.Controls.Add(this.listBoxCategory);
			this.tabPageAdministrator.Controls.Add(this.dataGridViewCustomers);
			this.tabPageAdministrator.Location = new System.Drawing.Point(4, 22);
			this.tabPageAdministrator.Margin = new System.Windows.Forms.Padding(2);
			this.tabPageAdministrator.Name = "tabPageAdministrator";
			this.tabPageAdministrator.Padding = new System.Windows.Forms.Padding(2);
			this.tabPageAdministrator.Size = new System.Drawing.Size(1180, 811);
			this.tabPageAdministrator.TabIndex = 0;
			this.tabPageAdministrator.Text = "Administrator";
			this.tabPageAdministrator.UseVisualStyleBackColor = true;
			// 
			// labelVersion
			// 
			this.labelVersion.AutoSize = true;
			this.labelVersion.Location = new System.Drawing.Point(669, 268);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new System.Drawing.Size(42, 13);
			this.labelVersion.TabIndex = 23;
			this.labelVersion.Text = "Version";
			// 
			// listBoxVersion
			// 
			this.listBoxVersion.FormattingEnabled = true;
			this.listBoxVersion.Location = new System.Drawing.Point(666, 297);
			this.listBoxVersion.Name = "listBoxVersion";
			this.listBoxVersion.Size = new System.Drawing.Size(120, 95);
			this.listBoxVersion.TabIndex = 22;
			// 
			// buttonDeleteItem
			// 
			this.buttonDeleteItem.Location = new System.Drawing.Point(742, 433);
			this.buttonDeleteItem.Name = "buttonDeleteItem";
			this.buttonDeleteItem.Size = new System.Drawing.Size(75, 23);
			this.buttonDeleteItem.TabIndex = 21;
			this.buttonDeleteItem.Text = "Delelte Item";
			this.buttonDeleteItem.UseVisualStyleBackColor = true;
			// 
			// textBoxTotalPrice
			// 
			this.textBoxTotalPrice.Location = new System.Drawing.Point(124, 689);
			this.textBoxTotalPrice.Name = "textBoxTotalPrice";
			this.textBoxTotalPrice.Size = new System.Drawing.Size(100, 20);
			this.textBoxTotalPrice.TabIndex = 20;
			// 
			// labelTotalPrice
			// 
			this.labelTotalPrice.AutoSize = true;
			this.labelTotalPrice.Location = new System.Drawing.Point(42, 692);
			this.labelTotalPrice.Name = "labelTotalPrice";
			this.labelTotalPrice.Size = new System.Drawing.Size(67, 13);
			this.labelTotalPrice.TabIndex = 19;
			this.labelTotalPrice.Text = "Total Price =";
			// 
			// buttonOrder
			// 
			this.buttonOrder.Location = new System.Drawing.Point(636, 689);
			this.buttonOrder.Name = "buttonOrder";
			this.buttonOrder.Size = new System.Drawing.Size(75, 23);
			this.buttonOrder.TabIndex = 18;
			this.buttonOrder.Text = "Order";
			this.buttonOrder.UseVisualStyleBackColor = true;
			// 
			// labelCustomer
			// 
			this.labelCustomer.AutoSize = true;
			this.labelCustomer.Location = new System.Drawing.Point(42, 13);
			this.labelCustomer.Name = "labelCustomer";
			this.labelCustomer.Size = new System.Drawing.Size(51, 13);
			this.labelCustomer.TabIndex = 17;
			this.labelCustomer.Text = "Customer";
			// 
			// buttonAddUpdateCustomer
			// 
			this.buttonAddUpdateCustomer.Location = new System.Drawing.Point(878, 107);
			this.buttonAddUpdateCustomer.Name = "buttonAddUpdateCustomer";
			this.buttonAddUpdateCustomer.Size = new System.Drawing.Size(81, 62);
			this.buttonAddUpdateCustomer.TabIndex = 16;
			this.buttonAddUpdateCustomer.Text = "Add Or Update Customer";
			this.buttonAddUpdateCustomer.UseVisualStyleBackColor = true;
			// 
			// labelQuantity
			// 
			this.labelQuantity.AutoSize = true;
			this.labelQuantity.Location = new System.Drawing.Point(471, 438);
			this.labelQuantity.Name = "labelQuantity";
			this.labelQuantity.Size = new System.Drawing.Size(46, 13);
			this.labelQuantity.TabIndex = 15;
			this.labelQuantity.Text = "Quantity";
			// 
			// textBoxQuantity
			// 
			this.textBoxQuantity.Location = new System.Drawing.Point(529, 433);
			this.textBoxQuantity.Name = "textBoxQuantity";
			this.textBoxQuantity.Size = new System.Drawing.Size(100, 20);
			this.textBoxQuantity.TabIndex = 14;
			// 
			// labelSelectedItems
			// 
			this.labelSelectedItems.AutoSize = true;
			this.labelSelectedItems.Location = new System.Drawing.Point(42, 443);
			this.labelSelectedItems.Name = "labelSelectedItems";
			this.labelSelectedItems.Size = new System.Drawing.Size(77, 13);
			this.labelSelectedItems.TabIndex = 13;
			this.labelSelectedItems.Text = "Selected Items";
			// 
			// dataGridViewSelectedItems
			// 
			this.dataGridViewSelectedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewSelectedItems.Location = new System.Drawing.Point(42, 470);
			this.dataGridViewSelectedItems.Name = "dataGridViewSelectedItems";
			this.dataGridViewSelectedItems.Size = new System.Drawing.Size(808, 204);
			this.dataGridViewSelectedItems.TabIndex = 12;
			// 
			// buttonAddItem
			// 
			this.buttonAddItem.Location = new System.Drawing.Point(655, 433);
			this.buttonAddItem.Name = "buttonAddItem";
			this.buttonAddItem.Size = new System.Drawing.Size(75, 23);
			this.buttonAddItem.TabIndex = 11;
			this.buttonAddItem.Text = "Add Item";
			this.buttonAddItem.UseVisualStyleBackColor = true;
			// 
			// listBoxCurrent
			// 
			this.listBoxCurrent.FormattingEnabled = true;
			this.listBoxCurrent.Location = new System.Drawing.Point(509, 297);
			this.listBoxCurrent.Name = "listBoxCurrent";
			this.listBoxCurrent.Size = new System.Drawing.Size(120, 95);
			this.listBoxCurrent.TabIndex = 8;
			// 
			// labelCurent
			// 
			this.labelCurent.AutoSize = true;
			this.labelCurent.Location = new System.Drawing.Point(506, 268);
			this.labelCurent.Name = "labelCurent";
			this.labelCurent.Size = new System.Drawing.Size(41, 13);
			this.labelCurent.TabIndex = 7;
			this.labelCurent.Text = "Current";
			// 
			// listBoxVoltage
			// 
			this.listBoxVoltage.FormattingEnabled = true;
			this.listBoxVoltage.Location = new System.Drawing.Point(356, 297);
			this.listBoxVoltage.Name = "listBoxVoltage";
			this.listBoxVoltage.Size = new System.Drawing.Size(120, 95);
			this.listBoxVoltage.TabIndex = 6;
			// 
			// labelVoltage
			// 
			this.labelVoltage.AutoSize = true;
			this.labelVoltage.Location = new System.Drawing.Point(353, 268);
			this.labelVoltage.Name = "labelVoltage";
			this.labelVoltage.Size = new System.Drawing.Size(43, 13);
			this.labelVoltage.TabIndex = 5;
			this.labelVoltage.Text = "Voltage";
			// 
			// labelType
			// 
			this.labelType.AutoSize = true;
			this.labelType.Location = new System.Drawing.Point(198, 268);
			this.labelType.Name = "labelType";
			this.labelType.Size = new System.Drawing.Size(31, 13);
			this.labelType.TabIndex = 4;
			this.labelType.Text = "Type";
			// 
			// labelCategory
			// 
			this.labelCategory.AutoSize = true;
			this.labelCategory.Location = new System.Drawing.Point(39, 268);
			this.labelCategory.Name = "labelCategory";
			this.labelCategory.Size = new System.Drawing.Size(49, 13);
			this.labelCategory.TabIndex = 3;
			this.labelCategory.Text = "Category";
			// 
			// listBoxType
			// 
			this.listBoxType.FormattingEnabled = true;
			this.listBoxType.Location = new System.Drawing.Point(201, 297);
			this.listBoxType.Name = "listBoxType";
			this.listBoxType.Size = new System.Drawing.Size(120, 95);
			this.listBoxType.TabIndex = 2;
			// 
			// listBoxCategory
			// 
			this.listBoxCategory.FormattingEnabled = true;
			this.listBoxCategory.Location = new System.Drawing.Point(42, 297);
			this.listBoxCategory.Name = "listBoxCategory";
			this.listBoxCategory.Size = new System.Drawing.Size(120, 95);
			this.listBoxCategory.TabIndex = 1;
			// 
			// dataGridViewCustomers
			// 
			this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewCustomers.Location = new System.Drawing.Point(42, 39);
			this.dataGridViewCustomers.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridViewCustomers.Name = "dataGridViewCustomers";
			this.dataGridViewCustomers.RowHeadersWidth = 51;
			this.dataGridViewCustomers.RowTemplate.Height = 24;
			this.dataGridViewCustomers.Size = new System.Drawing.Size(808, 212);
			this.dataGridViewCustomers.TabIndex = 0;
			// 
			// tabPageManager
			// 
			this.tabPageManager.Controls.Add(this.dataGridViewCategories);
			this.tabPageManager.Controls.Add(this.dataGridViewInventory);
			this.tabPageManager.Location = new System.Drawing.Point(4, 22);
			this.tabPageManager.Margin = new System.Windows.Forms.Padding(2);
			this.tabPageManager.Name = "tabPageManager";
			this.tabPageManager.Padding = new System.Windows.Forms.Padding(2);
			this.tabPageManager.Size = new System.Drawing.Size(1180, 811);
			this.tabPageManager.TabIndex = 1;
			this.tabPageManager.Text = "Manager";
			this.tabPageManager.UseVisualStyleBackColor = true;
			// 
			// dataGridViewCategories
			// 
			this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewCategories.Location = new System.Drawing.Point(39, 28);
			this.dataGridViewCategories.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridViewCategories.Name = "dataGridViewCategories";
			this.dataGridViewCategories.RowHeadersWidth = 51;
			this.dataGridViewCategories.RowTemplate.Height = 24;
			this.dataGridViewCategories.Size = new System.Drawing.Size(308, 212);
			this.dataGridViewCategories.TabIndex = 1;
			// 
			// dataGridViewInventory
			// 
			this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewInventory.Location = new System.Drawing.Point(39, 254);
			this.dataGridViewInventory.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridViewInventory.Name = "dataGridViewInventory";
			this.dataGridViewInventory.RowHeadersWidth = 51;
			this.dataGridViewInventory.RowTemplate.Height = 24;
			this.dataGridViewInventory.Size = new System.Drawing.Size(1061, 212);
			this.dataGridViewInventory.TabIndex = 0;
			// 
			// tabPageSalesOrder
			// 
			this.tabPageSalesOrder.Controls.Add(this.buttonClearFilter);
			this.tabPageSalesOrder.Controls.Add(this.buttonDeleteAllOrders);
			this.tabPageSalesOrder.Controls.Add(this.buttonDeleteOrder);
			this.tabPageSalesOrder.Controls.Add(this.buttonOrderFilter);
			this.tabPageSalesOrder.Controls.Add(this.listBoxOrderInventory);
			this.tabPageSalesOrder.Controls.Add(this.listBoxOrderCustomer);
			this.tabPageSalesOrder.Controls.Add(this.dataGridViewOrders);
			this.tabPageSalesOrder.Location = new System.Drawing.Point(4, 22);
			this.tabPageSalesOrder.Margin = new System.Windows.Forms.Padding(2);
			this.tabPageSalesOrder.Name = "tabPageSalesOrder";
			this.tabPageSalesOrder.Padding = new System.Windows.Forms.Padding(2);
			this.tabPageSalesOrder.Size = new System.Drawing.Size(1180, 811);
			this.tabPageSalesOrder.TabIndex = 2;
			this.tabPageSalesOrder.Text = "Sales Order";
			this.tabPageSalesOrder.UseVisualStyleBackColor = true;
			// 
			// buttonClearFilter
			// 
			this.buttonClearFilter.Location = new System.Drawing.Point(985, 202);
			this.buttonClearFilter.Margin = new System.Windows.Forms.Padding(2);
			this.buttonClearFilter.Name = "buttonClearFilter";
			this.buttonClearFilter.Size = new System.Drawing.Size(104, 56);
			this.buttonClearFilter.TabIndex = 7;
			this.buttonClearFilter.Text = "Clear Filter";
			this.buttonClearFilter.UseVisualStyleBackColor = true;
			// 
			// buttonDeleteAllOrders
			// 
			this.buttonDeleteAllOrders.Location = new System.Drawing.Point(985, 124);
			this.buttonDeleteAllOrders.Margin = new System.Windows.Forms.Padding(2);
			this.buttonDeleteAllOrders.Name = "buttonDeleteAllOrders";
			this.buttonDeleteAllOrders.Size = new System.Drawing.Size(104, 58);
			this.buttonDeleteAllOrders.TabIndex = 6;
			this.buttonDeleteAllOrders.Text = "Delete All Orders";
			this.buttonDeleteAllOrders.UseVisualStyleBackColor = true;
			// 
			// buttonDeleteOrder
			// 
			this.buttonDeleteOrder.Location = new System.Drawing.Point(985, 44);
			this.buttonDeleteOrder.Margin = new System.Windows.Forms.Padding(2);
			this.buttonDeleteOrder.Name = "buttonDeleteOrder";
			this.buttonDeleteOrder.Size = new System.Drawing.Size(104, 54);
			this.buttonDeleteOrder.TabIndex = 5;
			this.buttonDeleteOrder.Text = "Delete Order";
			this.buttonDeleteOrder.UseVisualStyleBackColor = true;
			// 
			// buttonOrderFilter
			// 
			this.buttonOrderFilter.Location = new System.Drawing.Point(594, 309);
			this.buttonOrderFilter.Margin = new System.Windows.Forms.Padding(2);
			this.buttonOrderFilter.Name = "buttonOrderFilter";
			this.buttonOrderFilter.Size = new System.Drawing.Size(114, 56);
			this.buttonOrderFilter.TabIndex = 4;
			this.buttonOrderFilter.Text = "Filter";
			this.buttonOrderFilter.UseVisualStyleBackColor = true;
			// 
			// listBoxOrderInventory
			// 
			this.listBoxOrderInventory.FormattingEnabled = true;
			this.listBoxOrderInventory.Location = new System.Drawing.Point(254, 309);
			this.listBoxOrderInventory.Margin = new System.Windows.Forms.Padding(2);
			this.listBoxOrderInventory.Name = "listBoxOrderInventory";
			this.listBoxOrderInventory.Size = new System.Drawing.Size(305, 199);
			this.listBoxOrderInventory.TabIndex = 3;
			// 
			// listBoxOrderCustomer
			// 
			this.listBoxOrderCustomer.FormattingEnabled = true;
			this.listBoxOrderCustomer.Location = new System.Drawing.Point(31, 309);
			this.listBoxOrderCustomer.Margin = new System.Windows.Forms.Padding(2);
			this.listBoxOrderCustomer.Name = "listBoxOrderCustomer";
			this.listBoxOrderCustomer.Size = new System.Drawing.Size(179, 199);
			this.listBoxOrderCustomer.TabIndex = 2;
			// 
			// dataGridViewOrders
			// 
			this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewOrders.Location = new System.Drawing.Point(31, 27);
			this.dataGridViewOrders.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridViewOrders.Name = "dataGridViewOrders";
			this.dataGridViewOrders.RowHeadersWidth = 51;
			this.dataGridViewOrders.RowTemplate.Height = 24;
			this.dataGridViewOrders.Size = new System.Drawing.Size(930, 247);
			this.dataGridViewOrders.TabIndex = 0;
			// 
			// tabPageDatabaseBackup
			// 
			this.tabPageDatabaseBackup.Controls.Add(this.buttonRestoreXML);
			this.tabPageDatabaseBackup.Controls.Add(this.buttonBackupXML);
			this.tabPageDatabaseBackup.Location = new System.Drawing.Point(4, 22);
			this.tabPageDatabaseBackup.Margin = new System.Windows.Forms.Padding(2);
			this.tabPageDatabaseBackup.Name = "tabPageDatabaseBackup";
			this.tabPageDatabaseBackup.Padding = new System.Windows.Forms.Padding(2);
			this.tabPageDatabaseBackup.Size = new System.Drawing.Size(1180, 811);
			this.tabPageDatabaseBackup.TabIndex = 3;
			this.tabPageDatabaseBackup.Text = "Database Backup";
			this.tabPageDatabaseBackup.UseVisualStyleBackColor = true;
			// 
			// buttonRestoreXML
			// 
			this.buttonRestoreXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonRestoreXML.Location = new System.Drawing.Point(386, 275);
			this.buttonRestoreXML.Margin = new System.Windows.Forms.Padding(2);
			this.buttonRestoreXML.Name = "buttonRestoreXML";
			this.buttonRestoreXML.Size = new System.Drawing.Size(485, 67);
			this.buttonRestoreXML.TabIndex = 1;
			this.buttonRestoreXML.Text = "Restore Data from XML File";
			this.buttonRestoreXML.UseVisualStyleBackColor = true;
			// 
			// buttonBackupXML
			// 
			this.buttonBackupXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBackupXML.Location = new System.Drawing.Point(386, 124);
			this.buttonBackupXML.Margin = new System.Windows.Forms.Padding(2);
			this.buttonBackupXML.Name = "buttonBackupXML";
			this.buttonBackupXML.Size = new System.Drawing.Size(485, 67);
			this.buttonBackupXML.TabIndex = 0;
			this.buttonBackupXML.Text = "Backup Data to XML File";
			this.buttonBackupXML.UseVisualStyleBackColor = true;
			// 
			// ElectronicShopMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1399, 859);
			this.Controls.Add(this.tabControlMain);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "ElectronicShopMainForm";
			this.Text = "Form1";
			this.tabControlMain.ResumeLayout(false);
			this.tabPageAdministrator.ResumeLayout(false);
			this.tabPageAdministrator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedItems)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
			this.tabPageManager.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
			this.tabPageSalesOrder.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
			this.tabPageDatabaseBackup.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageAdministrator;
        private System.Windows.Forms.TabPage tabPageManager;
        private System.Windows.Forms.TabPage tabPageSalesOrder;
        private System.Windows.Forms.TabPage tabPageDatabaseBackup;
        private System.Windows.Forms.Button buttonRestoreXML;
        private System.Windows.Forms.Button buttonBackupXML;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.DataGridView dataGridViewInventory;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.DataGridView dataGridViewCategories;
        private System.Windows.Forms.Button buttonOrderFilter;
        private System.Windows.Forms.ListBox listBoxOrderInventory;
        private System.Windows.Forms.ListBox listBoxOrderCustomer;
        private System.Windows.Forms.Button buttonDeleteAllOrders;
        private System.Windows.Forms.Button buttonDeleteOrder;
        private System.Windows.Forms.Button buttonClearFilter;
		private System.Windows.Forms.ListBox listBoxCategory;
		private System.Windows.Forms.ListBox listBoxType;
		private System.Windows.Forms.Label labelVoltage;
		private System.Windows.Forms.Label labelType;
		private System.Windows.Forms.Label labelCategory;
		private System.Windows.Forms.Button buttonAddItem;
		private System.Windows.Forms.ListBox listBoxCurrent;
		private System.Windows.Forms.Label labelCurent;
		private System.Windows.Forms.ListBox listBoxVoltage;
		private System.Windows.Forms.Label labelSelectedItems;
		private System.Windows.Forms.DataGridView dataGridViewSelectedItems;
		private System.Windows.Forms.Label labelQuantity;
		private System.Windows.Forms.TextBox textBoxQuantity;
		private System.Windows.Forms.Button buttonAddUpdateCustomer;
		private System.Windows.Forms.Label labelCustomer;
		private System.Windows.Forms.Button buttonOrder;
		private System.Windows.Forms.TextBox textBoxTotalPrice;
		private System.Windows.Forms.Label labelTotalPrice;
		private System.Windows.Forms.Button buttonDeleteItem;
		private System.Windows.Forms.ListBox listBoxVersion;
		private System.Windows.Forms.Label labelVersion;
	}
}

