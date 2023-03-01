using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFControllerUtilities;
using ElectronicShopCodeFirstFromDB;

namespace ElectronicShopApp
{
	public partial class AddOrUpdateCustomer : Form
	{
		public AddOrUpdateCustomer()
		{
			InitializeComponent();
			this.Load += AddOrUpdateCustomer_Load;
			buttonAddCustomer.Click += buttonAddCustomer_Click;
			buttonUpdateCustomer.Click += buttonUpdateCustomer_Click;
			listBoxCustomer.SelectedIndexChanged += (s, e) => CustomerSelected();
		}

		private void CustomerSelected()
		{
			if (!(listBoxCustomer.SelectedItem is Customer customer))
				return;
			textBoxName.Text = customer.Name;
			textBoxAddress.Text = customer.Address;
			textBoxEmail.Text = customer.Email;
			textBoxPhone.Text = customer.Phone;
		
		}

		private void buttonUpdateCustomer_Click(object sender, EventArgs e)
		{
			if (!(listBoxCustomer.SelectedItem is Customer customer))
			{
				MessageBox.Show("Select customer to be updated");
				return;
			}

			customer.Name = textBoxName.Text;
			customer.Phone = textBoxPhone.Text;
			customer.Address = textBoxAddress.Text;
			customer.Email = textBoxEmail.Text;

			if (Controller<ElectronicShopEntities, Customer>.UpdateEntity(customer) == false)
			{
				MessageBox.Show("Error updating customer");
				return;
			}

			this.DialogResult = DialogResult.OK;
			Close();
		}

		private void buttonAddCustomer_Click(object sender, EventArgs e)
		{
			Customer customer = new Customer()
			{
				Name = textBoxName.Text,
				Phone = textBoxPhone.Text,
				Email = textBoxEmail.Text,
				Address = textBoxAddress.Text
			};

			// need validation

			if (Controller<ElectronicShopEntities, Customer>.AddEntity(customer) == null)
			{
				MessageBox.Show("Cannot add customer to database");
				return;
			}

			this.DialogResult = DialogResult.OK;
			Close();
		}

		private void AddOrUpdateCustomer_Load(object sender, EventArgs e)
		{
			listBoxCustomer.DataSource = Controller<ElectronicShopEntities, Customer>.SetBindingList();
			listBoxCustomer.SelectedIndex = -1;
			textBoxName.ResetText();
			textBoxPhone.ResetText();
			textBoxEmail.ResetText();
			textBoxAddress.ResetText();
		}
	}
}
