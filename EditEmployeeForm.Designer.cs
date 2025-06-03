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
        private System.Windows.Forms.NumericUpDown nudYearsOfExperience;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.ComboBox cbAddress;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            lblFirstName = new Label() { Text = "Imię:", AutoSize = true };
            lblLastName = new Label() { Text = "Nazwisko:", AutoSize = true };
            lblPhoneNumber = new Label() { Text = "Telefon:", AutoSize = true };
            lblContractType = new Label() { Text = "Rodzaj umowy:", AutoSize = true };
            lblYearsOfExperience = new Label() { Text = "Lata doświadczenia:", AutoSize = true };
            lblPosition = new Label() { Text = "Stanowisko:", AutoSize = true };
            lblProduct = new Label() { Text = "Produkt:", AutoSize = true };
            lblAddress = new Label() { Text = "ID Adresu:", AutoSize = true };

            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtPhoneNumber = new TextBox();
            txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            txtContractType = new TextBox();
            nudYearsOfExperience = new NumericUpDown() { Minimum = 0, Maximum = 100 };
            cbPosition = new ComboBox() { DropDownStyle = ComboBoxStyle.DropDownList };
            cbProduct = new ComboBox() { DropDownStyle = ComboBoxStyle.DropDownList };
            cbAddress = new ComboBox() { DropDownStyle = ComboBoxStyle.DropDownList };

            btnSave = new Button() { Text = "Zapisz", AutoSize = true };
            btnCancel = new Button() { Text = "Anuluj", AutoSize = true };

            btnSave.Click += btnSave_Click;
            btnCancel.Click += (s, e) => Close();

            var table = new TableLayoutPanel();
            table.ColumnCount = 2;
            table.RowCount = 9;
            table.Dock = DockStyle.Fill;
            table.Padding = new Padding(10);
            table.AutoSize = true;
            table.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            table.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

            table.Controls.Add(lblFirstName, 0, 0); table.Controls.Add(txtFirstName, 1, 0);
            table.Controls.Add(lblLastName, 0, 1); table.Controls.Add(txtLastName, 1, 1);
            table.Controls.Add(lblPhoneNumber, 0, 2); table.Controls.Add(txtPhoneNumber, 1, 2);
            table.Controls.Add(lblContractType, 0, 3); table.Controls.Add(txtContractType, 1, 3);
            table.Controls.Add(lblYearsOfExperience, 0, 4); table.Controls.Add(nudYearsOfExperience, 1, 4);
            table.Controls.Add(lblPosition, 0, 5); table.Controls.Add(cbPosition, 1, 5);
            table.Controls.Add(lblProduct, 0, 6); table.Controls.Add(cbProduct, 1, 6);
            table.Controls.Add(lblAddress, 0, 7); table.Controls.Add(cbAddress, 1, 7);

            var buttonPanel = new FlowLayoutPanel();
            buttonPanel.FlowDirection = FlowDirection.RightToLeft;
            buttonPanel.Dock = DockStyle.Fill;
            buttonPanel.Controls.Add(btnSave);
            buttonPanel.Controls.Add(btnCancel);
            table.Controls.Add(buttonPanel, 1, 8);

            Controls.Add(table);
            Text = "Edytuj Pracownika";
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            StartPosition = FormStartPosition.CenterParent;
        }
    }
}
