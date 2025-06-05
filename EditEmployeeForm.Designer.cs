namespace Bakery_Schedule
{
    partial class EditEmployeeForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblContractType;
        private System.Windows.Forms.Label lblYearsOfExperience;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblAddress;

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtContractType;
        private System.Windows.Forms.TextBox txtYearsOfExperience;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.ComboBox cbAddress;

        private System.Windows.Forms.Button btnSave;
     

        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.FlowLayoutPanel buttonPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblFirstName = new System.Windows.Forms.Label();
            lblLastName = new System.Windows.Forms.Label();
            lblPhoneNumber = new System.Windows.Forms.Label();
            lblContractType = new System.Windows.Forms.Label();
            lblYearsOfExperience = new System.Windows.Forms.Label();
            lblPosition = new System.Windows.Forms.Label();
            lblProduct = new System.Windows.Forms.Label();
            lblAddress = new System.Windows.Forms.Label();

            txtFirstName = new System.Windows.Forms.TextBox();
            txtLastName = new System.Windows.Forms.TextBox();
            txtPhoneNumber = new System.Windows.Forms.TextBox();
            txtContractType = new System.Windows.Forms.TextBox();
            txtYearsOfExperience = new System.Windows.Forms.TextBox();

            cbPosition = new System.Windows.Forms.ComboBox();
            cbProduct = new System.Windows.Forms.ComboBox();
            cbAddress = new System.Windows.Forms.ComboBox();

            btnSave = new System.Windows.Forms.Button();
            

            table = new System.Windows.Forms.TableLayoutPanel();
            buttonPanel = new System.Windows.Forms.FlowLayoutPanel();

            table.SuspendLayout();
            buttonPanel.SuspendLayout();
            SuspendLayout();

            // 
            // lblFirstName
            // 
            lblFirstName.Location = new System.Drawing.Point(13, 10);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new System.Drawing.Size(100, 20);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "Imię";
            // 
            // lblLastName
            // 
            lblLastName.Location = new System.Drawing.Point(13, 30);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new System.Drawing.Size(100, 20);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Nazwisko";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.Location = new System.Drawing.Point(13, 50);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new System.Drawing.Size(100, 20);
            lblPhoneNumber.TabIndex = 4;
            lblPhoneNumber.Text = "Telefon";
            // 
            // lblContractType
            // 
            lblContractType.Location = new System.Drawing.Point(13, 70);
            lblContractType.Name = "lblContractType";
            lblContractType.Size = new System.Drawing.Size(100, 20);
            lblContractType.TabIndex = 6;
            lblContractType.Text = "Rodzaj umowy";
            // 
            // lblYearsOfExperience
            // 
            lblYearsOfExperience.Location = new System.Drawing.Point(13, 90);
            lblYearsOfExperience.Name = "lblYearsOfExperience";
            lblYearsOfExperience.Size = new System.Drawing.Size(100, 20);
            lblYearsOfExperience.TabIndex = 8;
            lblYearsOfExperience.Text = "Lata doświadczenia";
            // 
            // lblPosition
            // 
            lblPosition.Location = new System.Drawing.Point(13, 110);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new System.Drawing.Size(100, 20);
            lblPosition.TabIndex = 10;
            lblPosition.Text = "Stanowisko";
            // 
            // lblProduct
            // 
            lblProduct.Location = new System.Drawing.Point(13, 130);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new System.Drawing.Size(100, 20);
            lblProduct.TabIndex = 12;
            lblProduct.Text = "Produkt";
            // 
            // lblAddress
            // 
            lblAddress.Location = new System.Drawing.Point(13, 150);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new System.Drawing.Size(100, 20);
            lblAddress.TabIndex = 14;
            lblAddress.Text = "Adres";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new System.Drawing.Point(119, 13);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new System.Drawing.Size(100, 27);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new System.Drawing.Point(119, 33);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new System.Drawing.Size(100, 27);
            txtLastName.TabIndex = 3;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new System.Drawing.Point(119, 53);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new System.Drawing.Size(100, 27);
            txtPhoneNumber.TabIndex = 5;
            txtPhoneNumber.KeyPress += txtPhoneNumber_KeyPress;
            // 
            // txtContractType
            // 
            txtContractType.Location = new System.Drawing.Point(119, 73);
            txtContractType.Name = "txtContractType";
            txtContractType.Size = new System.Drawing.Size(100, 27);
            txtContractType.TabIndex = 7;
            // 
            // txtYearsOfExperience
            // 
            txtYearsOfExperience.Location = new System.Drawing.Point(119, 93);
            txtYearsOfExperience.Name = "txtYearsOfExperience";
            txtYearsOfExperience.Size = new System.Drawing.Size(100, 27);
            txtYearsOfExperience.TabIndex = 9;
            txtYearsOfExperience.MaxLength = 2;
            // Obsługa tylko cyfr (zalecam dodać w kodzie formularza, nie designerze)
            // 
            // cbPosition
            // 
            cbPosition.Location = new System.Drawing.Point(119, 113);
            cbPosition.Name = "cbPosition";
            cbPosition.Size = new System.Drawing.Size(121, 28);
            cbPosition.TabIndex = 11;
            // 
            // cbProduct
            // 
            cbProduct.Location = new System.Drawing.Point(119, 133);
            cbProduct.Name = "cbProduct";
            cbProduct.Size = new System.Drawing.Size(121, 28);
            cbProduct.TabIndex = 13;
            // 
            // cbAddress
            // 
            cbAddress.Location = new System.Drawing.Point(119, 153);
            cbAddress.Name = "cbAddress";
            cbAddress.Size = new System.Drawing.Size(121, 28);
            cbAddress.TabIndex = 15;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(339, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Zapisz";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
        
            // 
            // table
            // 
            table.AutoSize = true;
            table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            table.ColumnCount = 2;
            table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            table.Controls.Add(lblFirstName, 0, 0);
            table.Controls.Add(txtFirstName, 1, 0);
            table.Controls.Add(lblLastName, 0, 1);
            table.Controls.Add(txtLastName, 1, 1);
            table.Controls.Add(lblPhoneNumber, 0, 2);
            table.Controls.Add(txtPhoneNumber, 1, 2);
            table.Controls.Add(lblContractType, 0, 3);
            table.Controls.Add(txtContractType, 1, 3);
            table.Controls.Add(lblYearsOfExperience, 0, 4);
            table.Controls.Add(txtYearsOfExperience, 1, 4);
            table.Controls.Add(lblPosition, 0, 5);
            table.Controls.Add(cbPosition, 1, 5);
            table.Controls.Add(lblProduct, 0, 6);
            table.Controls.Add(cbProduct, 1, 6);
            table.Controls.Add(lblAddress, 0, 7);
            table.Controls.Add(cbAddress, 1, 7);
            table.Controls.Add(buttonPanel, 1, 8);
            table.Dock = System.Windows.Forms.DockStyle.Fill;
            table.Location = new System.Drawing.Point(0, 0);
            table.Name = "table";
            table.Padding = new System.Windows.Forms.Padding(10);
            table.RowCount = 9;
            table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            table.Size = new System.Drawing.Size(427, 290);
            table.TabIndex = 0;

            // 
            // buttonPanel
            // 
            buttonPanel.AutoSize = true;
            buttonPanel.Controls.Add(btnSave);
           
            buttonPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            buttonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonPanel.Location = new System.Drawing.Point(119, 243);
            buttonPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new System.Drawing.Size(305, 37);
            buttonPanel.TabIndex = 16;

            // 
            // EditEmployeeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(427, 290);
            Controls.Add(table);
            Name = "EditEmployeeForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Edytuj pracownika";

            table.ResumeLayout(false);
            table.PerformLayout();
            buttonPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
