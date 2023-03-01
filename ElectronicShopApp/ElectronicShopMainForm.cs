using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElectronicShopCodeFirstFromDB;
using System.Diagnostics;
using EFControllerUtilities;
using System.IO;
using System.Xml.Serialization;

namespace ElectronicShopApp
{
    public partial class ElectronicShopMainForm : Form
    {
        List<Inventory> inventories = Controller<ElectronicShopEntities, Inventory>.GetEntities().ToList();
        List<Category> categories = Controller<ElectronicShopEntities, Category>.GetEntities().ToList();

        public ElectronicShopMainForm()
        {
            InitializeComponent();

            this.Text = "Electronic Shop Form";

            this.Load += (s,e) => ElectronicShopMainForm_Load();


        }
        /// <summary>
        /// This method is used to setup the control setting for datagridview, listbox, button in different tabs.
        /// Tabs: Administration, Manager, SalesOrder, Database
        /// </summary>
        private void ElectronicShopMainForm_Load()
        {
            using (ElectronicShopEntities context = new ElectronicShopEntities()) 
            {
                context.SeedDatabase();
            }

            // Administration Tab Part
            InitializeDataGridView<Customer>(dataGridViewCustomers);
            InitializeListBoxCategory();
            InitializeListBoxType(inventories);
            InitializeListBoxVoltage(inventories);
            InitializeListBoxCurrent(inventories);
            InitializeListBoxVersion(inventories);
            DisplaySelectedItems();
            buttonAddItem.Click += buttonAddItem_Click;
            buttonDeleteItem.Click += buttonDeleteItem_Click;
            buttonOrder.Click += (s, e) => AddOrder(dataGridViewCustomers, dataGridViewSelectedItems);

            AddOrUpdateCustomer addOrUpdateCustomer = new AddOrUpdateCustomer();
            buttonAddUpdateCustomer.Click += (s, e) => AddUpdateForm<Customer>(dataGridViewCustomers, addOrUpdateCustomer);
            

            // Manager Tab Part
            InitializeDataGridView<Category>(dataGridViewCategories);
            InitializeDataGridView<Inventory>(dataGridViewInventory, "Category");



            // Sales Order Tab Part
            InitializeOrdersListBoxItems();
            InitializeOrdersDataGridView();
            buttonOrderFilter.Click += ButtonOrderFilter_Click;
            buttonClearFilter.Click += ButtonClearFilter_Click;
            buttonDeleteOrder.Click += ButtonDeleteOrder_Click;
            buttonDeleteAllOrders.Click += ButtonDeleteAllOrders_Click;

            // Database backup Tab Part
            buttonBackupXML.Click += (s, e) => BackupDataSetToXML();
            buttonRestoreXML.Click += (s, e) => RestoreDataSetFromXML();

        }

        private void AddUpdateForm<T> (DataGridView dataGridView, Form form) where T : class
		{
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                dataGridView.DataSource = Controller<ElectronicShopEntities, T>.SetBindingList();
                dataGridView.Refresh();
            }
            form.Hide();
        }

        private void buttonDeleteItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridViewSelectedItems.SelectedCells)
            {
                if (oneCell.Selected)
                    dataGridViewSelectedItems.Rows.RemoveAt(oneCell.RowIndex);
            }
            int sum = 0;
            for (int i = 0; i < dataGridViewSelectedItems.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridViewSelectedItems.Rows[i].Cells[4].Value);
            }

            textBoxTotalPrice.Text = sum.ToString("c2");

        }

		private void AddOrder(DataGridView customers, DataGridView selectedItems)
		{
			if (customers.SelectedRows.Count == 0)
			{
				MessageBox.Show("Select a customer who get an order");
			}
			else
			{
				using (ElectronicShopEntities context = new ElectronicShopEntities())
				{
					foreach (DataGridViewRow row in customers.SelectedRows)
					{
						if (row.DataBoundItem is Customer customer)
						{
							foreach (DataGridViewRow rowItem in selectedItems.Rows)
							{
                                string inventoryName = rowItem.Cells[1].Value.ToString();
                                Inventory inventory = context.Inventories.SingleOrDefault(x => x.Name == inventoryName);
                                if (inventory != null)
                                {
                                    selectedItems.SelectAll();
                                    var inventoryFromContext = context.Inventories.Find(inventory.InventoryId);
                                    var customerFromContext = context.Customers.Find(customer.CustomerId);

                                    Order newOrder = new Order();
                                    newOrder.Customer = customerFromContext;
                                    newOrder.CustomerId = customerFromContext.CustomerId;
                                    newOrder.OrderDate = DateTime.Today;

                                    OrderDetail newOrderDetail = new OrderDetail();
                                    newOrderDetail.Inventory = inventoryFromContext;
                                    newOrderDetail.Order = newOrder;
                                    newOrderDetail.InventoryId = inventoryFromContext.InventoryId;
                                    newOrderDetail.OrderId = newOrder.OrderId;
                                    int quantity = (int)rowItem.Cells[3].Value;
                                    newOrderDetail.OrderQuantity = quantity;
                                    double totalAmount = (double)rowItem.Cells[4].Value;
                                    newOrderDetail.TotalAmount = totalAmount;

                                    newOrder.OrderDetails.Add(newOrderDetail);
                                    context.Orders.Add(newOrder);
                                    			
									context.SaveChanges();
                                }
                            }
						}
					}
				}
                MessageBox.Show("Order completed");

				// Clear the datagridview after added order
				for (int i = 0; i < selectedItems.Rows.Count; i++)
				{
					selectedItems.Rows.Clear();
				}
                // Set those fields to empty after added order
                textBoxQuantity.Text = "";
                textBoxTotalPrice.Text = "";
			}
            InitializeOrdersListBoxItems();
            FilterOrders();
            dataGridViewOrders.Refresh();
        }

        

		private void buttonAddItem_Click(object sender, EventArgs e)
		{
            List<string> selectedCategory = (from object selected in listBoxCategory.SelectedItems
                                             select selected.ToString()).ToList();

            List<string> selectedType = (from object selected in listBoxType.SelectedItems
                                         select selected.ToString()).ToList();

            List<string> selectedVoltage = (from object selected in listBoxVoltage.SelectedItems
                                            select selected.ToString()).ToList();

            List<string> selectedCurrent = (from object selected in listBoxCurrent.SelectedItems
                                            select selected.ToString()).ToList();

            List<string> selectedVersion = (from object selected in listBoxVersion.SelectedItems
                                            select selected.ToString()).ToList();

            var selectedAllItems =
                                   from inventory in inventories
                                   from type in selectedType
                                   where type == inventory.Type
                                   from voltage in selectedVoltage
                                   where voltage == inventory.Voltage
                                   from current in selectedCurrent
                                   where current == inventory.Current
                                   from version in selectedVersion
                                   where version == inventory.Version
                                   select inventory;


            //dataGridViewSelectedItems.Rows.Clear();

            if (selectedAllItems.ToList().Count == 0)
                MessageBox.Show("Item is unavailable!");
            else
			{
                foreach (var selected in selectedAllItems)
                {
                    int number;
                    if (!int.TryParse(textBoxQuantity.Text, out number) || textBoxQuantity.Text == "")
                        
                    {
                        MessageBox.Show("Please fill out quantity");
                    }
                    else
                    {
                        int quantity = int.Parse(textBoxQuantity.Text);
                        var subTotal = (selected.UnitPrice * quantity);
                        dataGridViewSelectedItems.Rows.Add("", selected.Name, selected.UnitPrice, quantity, subTotal);

                        // Sum for total price of selected items

                        int sum = 0;
                        for (int i = 0; i < dataGridViewSelectedItems.Rows.Count; ++i)
                        {
                            sum += Convert.ToInt32(dataGridViewSelectedItems.Rows[i].Cells[4].Value);
                        }

                        textBoxTotalPrice.Text = sum.ToString("c2");
                        dataGridViewSelectedItems.Columns[2].DefaultCellStyle.Format = "c2";
                        dataGridViewSelectedItems.Columns[4].DefaultCellStyle.Format = "c2";

                        // Auto increment number for the Item# column 
                        foreach (DataGridViewRow row in dataGridViewSelectedItems.Rows)
                            row.Cells[0].Value = (row.Index + 1).ToString();
                    }
                }
            }         
        }


		private void DisplaySelectedItems()
		{
            dataGridViewSelectedItems.AllowUserToAddRows = false;
            dataGridViewSelectedItems.AllowUserToDeleteRows = false;
            dataGridViewSelectedItems.ReadOnly = true;
            dataGridViewSelectedItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewSelectedItems.ColumnCount = 5;
			dataGridViewSelectedItems.Columns[0].Name = "Item#";
			dataGridViewSelectedItems.Columns[1].Name = "Item Name";
			dataGridViewSelectedItems.Columns[2].Name = "Unit Price";
			dataGridViewSelectedItems.Columns[3].Name = "Quantity";
			dataGridViewSelectedItems.Columns[4].Name = "Sub. Total";

        }

        private void InitializeListBoxVersion(List<Inventory> inventories)
		{
            var versions = from item in inventories
                           select item.Version;
            listBoxVersion.Items.AddRange(versions.Distinct().ToArray());
		}

        private void InitializeListBoxCurrent(List<Inventory> inventories)
		{
            var currents = from item in inventories
                           select item.Current;
            listBoxCurrent.Items.AddRange(currents.Distinct().ToArray());
		}

		private void InitializeListBoxVoltage(List<Inventory> inventories)
		{
            var voltages = from item in inventories
                           select item.Voltage;
            listBoxVoltage.Items.AddRange(voltages.Distinct().ToArray());
		}

		private void InitializeListBoxType(List<Inventory> inventories)
		{
            var types = from item in inventories
                       select item.Type;

            listBoxType.Items.AddRange(types.Distinct().ToArray());
                
        }

		private void InitializeListBoxCategory()
		{
            listBoxCategory.DataSource = Controller<ElectronicShopEntities, Category>.GetEntities();
            listBoxCategory.SelectedIndex = -1;
            listBoxCategory.SelectionMode = SelectionMode.MultiExtended;
        }




		/// <summary>
		/// SelectionMode for listbox is single selection only.
		/// </summary>
		private void InitializeOrdersListBoxItems() 
        {

            listBoxOrderCustomer.DataSource = Controller<ElectronicShopEntities, Customer>.GetEntities();
            listBoxOrderCustomer.SelectedIndex = -1;
            listBoxOrderCustomer.SelectionMode = SelectionMode.MultiExtended;
            for (int i = 0; i < listBoxOrderCustomer.Items.Count; i++)
            {
                listBoxOrderCustomer.SetSelected(i, true);
            }

            listBoxOrderInventory.DataSource = Controller<ElectronicShopEntities, Inventory>.GetEntitiesWithIncluded("Category");
            listBoxOrderInventory.SelectedIndex = -1;
            listBoxOrderInventory.SelectionMode = SelectionMode.MultiExtended;
            for (int i = 0; i < listBoxOrderInventory.Items.Count; i++)
            {
                listBoxOrderInventory.SetSelected(i, true);
            }
        }

		/// <summary>
		/// This method is used to set up the datagridviews for all the entities
		/// Using generics
		/// </summary>
		/// <typeparam name="T"> generics </typeparam>
		/// <param name="dataGridView"> datagridview to be seeded </param>
		/// <param name="hiddenColumns"> which columns should not be displayed </param>
		private void InitializeDataGridView<T>(DataGridView gridView, params string[] columnsToHide) where T : class
        {
            // Allow users to add/delete rows, and fill out columns to the entire width of the control

            gridView.AllowUserToAddRows = false;

            gridView.AllowUserToDeleteRows = true;
            gridView.ReadOnly = true;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // set the handler used to delete an item. Note use of generics.

            gridView.UserDeletingRow += (s, e) => DeletingRow<T>(s as DataGridView, e);

            // probably not needed, but just in case we have some issues

            gridView.DataError += (s, e) => HandleDataError<T>(s as DataGridView, e);

            gridView.DataSource = Controller<ElectronicShopEntities, T>.SetBindingList();


            foreach (string column in columnsToHide)
                gridView.Columns[column].Visible = false;
        }

        /// <summary>
        /// This method ise used to delete a row from datagridview
        /// Using generics
        /// </summary>
        /// <typeparam name="T"> generic</typeparam>
        /// <param name="dataGridView"> datagridview in which delete has occurred </param>
        /// <param name="e"> event arguments </param>
        private void DeletingRow<T>(DataGridView dataGridView, DataGridViewRowCancelEventArgs e) where T : class
        {
            // get the item

            T item = e.Row.DataBoundItem as T;

            Debug.WriteLine("DeletingRow " + e.Row.Index + " entity " + typeof(T) + " " + item);

            // Delete the item in the DB. No need to worry about dependencies, as there is no context!
            // Just let cascade delete take care of it.

            Controller<ElectronicShopEntities, T>.DeleteEntity(item);
            dataGridView.Refresh();

            // update the orders report, and the bind the orders listbox items again
            FilterOrders();
            InitializeOrdersListBoxItems();

        }

        /// <summary>
        /// This method is used to display all orders in datagridview
        /// </summary>
        private void InitializeOrdersDataGridView()
        {

            dataGridViewOrders.AllowUserToAddRows = false;
            dataGridViewOrders.AllowUserToDeleteRows = false;
            dataGridViewOrders.ReadOnly = true;
            dataGridViewOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewOrders.ColumnCount = 10;
            dataGridViewOrders.Columns[0].Name = "Customer Name";
            dataGridViewOrders.Columns[1].Name = "Inventory Name";
            dataGridViewOrders.Columns[1].Width = 200;
            dataGridViewOrders.Columns[2].Name = "Order Quantity";
            dataGridViewOrders.Columns[3].Name = "Total Amount";
            dataGridViewOrders.Columns[4].Name = "Order Date";
            dataGridViewOrders.Columns[5].Name = "Customer Phone";
            dataGridViewOrders.Columns[6].Name = "Customer Address";
            dataGridViewOrders.Columns[7].Name = "CustomerId";
            dataGridViewOrders.Columns[8].Name = "InventoryId";
            dataGridViewOrders.Columns[9].Name = "OrderId";
            dataGridViewOrders.Columns[7].Visible = false;
            dataGridViewOrders.Columns[8].Visible = false;
            dataGridViewOrders.Columns[9].Visible = false;

            FilterOrders();

        }

        /// <summary>
        /// This method is used to drop all orders
        /// </summary>
        private void ButtonDeleteAllOrders_Click(object sender, EventArgs e)
        {
            using (ElectronicShopEntities context = new ElectronicShopEntities())
            {
                context.Orders.RemoveRange(context.Orders);
                context.OrderDetails.RemoveRange(context.OrderDetails);
                context.SaveChanges();
            }
            FilterOrders();
        }


        /// <summary>
        /// This method is used to drop orders
        /// </summary>
        private void ButtonDeleteOrder_Click(object sender, EventArgs e)
        {
            using (ElectronicShopEntities context = new ElectronicShopEntities()) 
            {

                foreach (DataGridViewRow row in dataGridViewOrders.SelectedRows)
                {
                    int customerId = int.Parse(row.Cells[7].Value.ToString());
                    int inventoryId = int.Parse(row.Cells[8].Value.ToString());
                    int orderId = int.Parse(row.Cells[9].Value.ToString());



                    OrderDetail orderDetailDeleted = context.OrderDetails.Find(inventoryId, orderId);
                    context.OrderDetails.Remove(orderDetailDeleted);

                }

               context.SaveChanges();

            }
            FilterOrders();
        }


        /// <summary>
        /// This method is used to show all orders
        /// </summary>
        private void ButtonClearFilter_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxOrderInventory.Items.Count; i++)
            {
                listBoxOrderInventory.SetSelected(i, true);
            }
            for (int i = 0; i < listBoxOrderCustomer.Items.Count; i++)
            {
                listBoxOrderCustomer.SetSelected(i, true);
            }
            FilterOrders();
        }


        /// <summary>
        /// This method is used to trigger the filter orders method
        /// </summary>
        private void ButtonOrderFilter_Click(object sender, EventArgs e)
        {
            FilterOrders();
        }


        /// <summary>
        /// This method is used to filter orders by selecting customer(s) and/or inventory(s).
        /// </summary>
        private void FilterOrders() 
        {

            using (ElectronicShopEntities context = new ElectronicShopEntities())
            {
                List<Customer> filterCustomers = new List<Customer>();
                foreach (int i in listBoxOrderCustomer.SelectedIndices)
                {
                    Customer cust = context.Customers.Find(i + 1);
                    filterCustomers.Add(cust);
                }

                List<Inventory> filterInventories = new List<Inventory>();
                foreach (int i in listBoxOrderInventory.SelectedIndices)
                {
                    Inventory invent = context.Inventories.Find(i + 1);
                    filterInventories.Add(invent);
                }

                dataGridViewOrders.Rows.Clear();
                dataGridViewOrders.Refresh();

                if (filterCustomers.Count == 0)
                {
                    MessageBox.Show("You must select at least one customer to filter");
                    return;
                }

                if (filterInventories.Count == 0)
                {
                    MessageBox.Show("You must select at least one inventory to filter");
                    return;
                }

                foreach (Customer customer in filterCustomers)
                {
                    foreach (Order order in customer.Orders)
                    {
                        DateTime orderDate = (DateTime)order.OrderDate;

                        foreach (OrderDetail orderDetail in order.OrderDetails)
                        {
                            foreach (Inventory inventory in filterInventories)
                            {
                                if (orderDetail.InventoryId == inventory.InventoryId)
                                {
                                    string[] rowAdd = {
                                        order.Customer.Name,
                                        orderDetail.Inventory.Name,
                                        orderDetail.OrderQuantity.ToString(),
                                        orderDetail.TotalAmount.ToString(),
                                        orderDate.ToString("MMM dd, yyyy"),
                                        order.Customer.Phone,
                                        order.Customer.Address,
                                        order.CustomerId.ToString(),
                                        orderDetail.InventoryId.ToString(),
                                        order.OrderId.ToString()
                                        };
                                    dataGridViewOrders.Rows.Add(rowAdd);
                                }
                            }
                        }
                    }
                }



            }
        }



        /// <summary>
        /// This method is used to back up the entities data to XML files
        /// </summary>
        public void BackupDataSetToXML()
        {
            using (ElectronicShopEntities context = new ElectronicShopEntities())
            {
                context.SaveEntitiesToXMLFiles();
            }
        }


        /// <summary>
        /// This method is used to restore the data from XML files to the entities
        /// </summary>
        public void RestoreDataSetFromXML() 
        {
            using (ElectronicShopEntities context = new ElectronicShopEntities())
            {
                context.Database.Delete();
                context.Database.Create();
                context.SaveChanges();
                context.ReadEntitiesFromXMLFiles();
            }
            InitializeDataGridView<Customer>(dataGridViewCustomers);
            InitializeDataGridView<Category>(dataGridViewCategories);
            InitializeDataGridView<Inventory>(dataGridViewInventory, "Category");
            InitializeOrdersDataGridView();

        }



        /// <summary>
        /// Catch any gridview data error, log to debug and cancel any event.
        /// Should not happen, as all of our gridviews are readonly. Might show up when items
        /// are deleted.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="gridView"></param>
        /// <param name="e"></param>
        private void HandleDataError<T>(DataGridView gridView, DataGridViewDataErrorEventArgs e)
        {
            Debug.WriteLine("DataError " + typeof(T) + " " + gridView.Name + " row " + e.RowIndex + " col " + e.ColumnIndex + " Context: " + e.Context.ToString());
            e.Cancel = true;
        }

    }
}
