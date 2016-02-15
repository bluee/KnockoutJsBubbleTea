namespace BubbleTea.WinForm
{
    partial class FormAddCustomer
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
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.CountryListcomboBox = new System.Windows.Forms.ComboBox();
            this.countryListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersDataSet = new BubbleTea.WinForm.CustomersDataSet();
            this.fKCustomersCount276EDEB3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryListTableAdapter = new BubbleTea.WinForm.CustomersDataSetTableAdapters.CountryListTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.countryListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new BubbleTea.WinForm.CustomersDataSetTableAdapters.CustomersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.countryListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCustomersCount276EDEB3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryListBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "This is a dummy form showing a modal window to add a customer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Firstname";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(96, 53);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(217, 20);
            this.FirstNameTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lastname";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(96, 84);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(217, 20);
            this.LastNameTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Address";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(96, 115);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(217, 20);
            this.AddressTextBox.TabIndex = 6;
            // 
            // CountryListcomboBox
            // 
            this.CountryListcomboBox.FormattingEnabled = true;
            this.CountryListcomboBox.Location = new System.Drawing.Point(96, 142);
            this.CountryListcomboBox.Name = "CountryListcomboBox";
            this.CountryListcomboBox.Size = new System.Drawing.Size(217, 21);
            this.CountryListcomboBox.TabIndex = 7;
            // 
            // countryListBindingSource
            // 
            this.countryListBindingSource.DataMember = "CountryList";
            this.countryListBindingSource.DataSource = this.customersDataSet;
            // 
            // customersDataSet
            // 
            this.customersDataSet.DataSetName = "CustomersDataSet";
            this.customersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fKCustomersCount276EDEB3BindingSource
            // 
            this.fKCustomersCount276EDEB3BindingSource.DataMember = "FK__Customers__Count__276EDEB3";
            this.fKCustomersCount276EDEB3BindingSource.DataSource = this.countryListBindingSource;
            // 
            // countryListTableAdapter
            // 
            this.countryListTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(11, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add customer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Country";
            // 
            // countryListBindingSource1
            // 
            this.countryListBindingSource1.DataMember = "CountryList";
            this.countryListBindingSource1.DataSource = this.customersDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // FormAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(335, 209);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CountryListcomboBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAddCustomer";
            this.Text = "Add customer";
            this.Load += new System.EventHandler(this.FormAddCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countryListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCustomersCount276EDEB3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryListBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.ComboBox CountryListcomboBox;
        private CustomersDataSet customersDataSet;
        private System.Windows.Forms.BindingSource countryListBindingSource;
        private CustomersDataSetTableAdapters.CountryListTableAdapter countryListTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource countryListBindingSource1;
        private System.Windows.Forms.BindingSource fKCustomersCount276EDEB3BindingSource;
        private CustomersDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
    }
}