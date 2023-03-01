
namespace ElectronicShopApp
{
	partial class AddOrUpdateCustomer
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
			this.labelInventory = new System.Windows.Forms.Label();
			this.listBoxCustomer = new System.Windows.Forms.ListBox();
			this.labelName = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelPhone = new System.Windows.Forms.Label();
			this.textBoxPhone = new System.Windows.Forms.TextBox();
			this.labelAddress = new System.Windows.Forms.Label();
			this.textBoxAddress = new System.Windows.Forms.TextBox();
			this.labelEmail = new System.Windows.Forms.Label();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.buttonAddCustomer = new System.Windows.Forms.Button();
			this.buttonUpdateCustomer = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelInventory
			// 
			this.labelInventory.AutoSize = true;
			this.labelInventory.Location = new System.Drawing.Point(35, 30);
			this.labelInventory.Name = "labelInventory";
			this.labelInventory.Size = new System.Drawing.Size(51, 13);
			this.labelInventory.TabIndex = 0;
			this.labelInventory.Text = "Inventory";
			// 
			// listBoxCustomer
			// 
			this.listBoxCustomer.FormattingEnabled = true;
			this.listBoxCustomer.Location = new System.Drawing.Point(92, 30);
			this.listBoxCustomer.Name = "listBoxCustomer";
			this.listBoxCustomer.Size = new System.Drawing.Size(643, 173);
			this.listBoxCustomer.TabIndex = 1;
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(38, 254);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(35, 13);
			this.labelName.TabIndex = 2;
			this.labelName.Text = "Name";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(92, 254);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(100, 20);
			this.textBoxName.TabIndex = 3;
			// 
			// labelPhone
			// 
			this.labelPhone.AutoSize = true;
			this.labelPhone.Location = new System.Drawing.Point(316, 257);
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.Size = new System.Drawing.Size(38, 13);
			this.labelPhone.TabIndex = 4;
			this.labelPhone.Text = "Phone";
			// 
			// textBoxPhone
			// 
			this.textBoxPhone.Location = new System.Drawing.Point(405, 254);
			this.textBoxPhone.Name = "textBoxPhone";
			this.textBoxPhone.Size = new System.Drawing.Size(100, 20);
			this.textBoxPhone.TabIndex = 5;
			// 
			// labelAddress
			// 
			this.labelAddress.AutoSize = true;
			this.labelAddress.Location = new System.Drawing.Point(41, 315);
			this.labelAddress.Name = "labelAddress";
			this.labelAddress.Size = new System.Drawing.Size(45, 13);
			this.labelAddress.TabIndex = 6;
			this.labelAddress.Text = "Address";
			// 
			// textBoxAddress
			// 
			this.textBoxAddress.Location = new System.Drawing.Point(92, 312);
			this.textBoxAddress.Name = "textBoxAddress";
			this.textBoxAddress.Size = new System.Drawing.Size(100, 20);
			this.textBoxAddress.TabIndex = 7;
			// 
			// labelEmail
			// 
			this.labelEmail.AutoSize = true;
			this.labelEmail.Location = new System.Drawing.Point(316, 315);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(32, 13);
			this.labelEmail.TabIndex = 8;
			this.labelEmail.Text = "Email";
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Location = new System.Drawing.Point(405, 309);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
			this.textBoxEmail.TabIndex = 9;
			// 
			// buttonAddCustomer
			// 
			this.buttonAddCustomer.Location = new System.Drawing.Point(116, 380);
			this.buttonAddCustomer.Name = "buttonAddCustomer";
			this.buttonAddCustomer.Size = new System.Drawing.Size(75, 23);
			this.buttonAddCustomer.TabIndex = 10;
			this.buttonAddCustomer.Text = "Add";
			this.buttonAddCustomer.UseVisualStyleBackColor = true;
			// 
			// buttonUpdateCustomer
			// 
			this.buttonUpdateCustomer.Location = new System.Drawing.Point(319, 380);
			this.buttonUpdateCustomer.Name = "buttonUpdateCustomer";
			this.buttonUpdateCustomer.Size = new System.Drawing.Size(75, 23);
			this.buttonUpdateCustomer.TabIndex = 11;
			this.buttonUpdateCustomer.Text = "Update";
			this.buttonUpdateCustomer.UseVisualStyleBackColor = true;
			// 
			// AddOrUpdateCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonUpdateCustomer);
			this.Controls.Add(this.buttonAddCustomer);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.labelEmail);
			this.Controls.Add(this.textBoxAddress);
			this.Controls.Add(this.labelAddress);
			this.Controls.Add(this.textBoxPhone);
			this.Controls.Add(this.labelPhone);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.listBoxCustomer);
			this.Controls.Add(this.labelInventory);
			this.Name = "AddOrUpdateCustomer";
			this.Text = "AddOrUpdateCustomer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelInventory;
		private System.Windows.Forms.ListBox listBoxCustomer;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label labelPhone;
		private System.Windows.Forms.TextBox textBoxPhone;
		private System.Windows.Forms.Label labelAddress;
		private System.Windows.Forms.TextBox textBoxAddress;
		private System.Windows.Forms.Label labelEmail;
		private System.Windows.Forms.TextBox textBoxEmail;
		private System.Windows.Forms.Button buttonAddCustomer;
		private System.Windows.Forms.Button buttonUpdateCustomer;
	}
}