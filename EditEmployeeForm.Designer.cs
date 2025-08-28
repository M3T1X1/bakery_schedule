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

        private System.Windows.Forms.TextBox tbImie;
        private System.Windows.Forms.TextBox tbNazwisko;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.ComboBox cbRodzajUmowy;
        private System.Windows.Forms.TextBox tbLataDoswiadczenia;
        private System.Windows.Forms.ComboBox cbStanowisko;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.ComboBox cbAdres;

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

            tbImie = new System.Windows.Forms.TextBox();
            tbNazwisko = new System.Windows.Forms.TextBox();
            tbTelefon = new System.Windows.Forms.TextBox();
            cbRodzajUmowy = new System.Windows.Forms.ComboBox();
            tbLataDoswiadczenia = new System.Windows.Forms.TextBox();
            cbStanowisko = new System.Windows.Forms.ComboBox();
            cbProduct = new System.Windows.Forms.ComboBox();
            cbAdres = new System.Windows.Forms.ComboBox();

            btnSave = new System.Windows.Forms.Button();

            table = new System.Windows.Forms.TableLayoutPanel();
            buttonPanel = new System.Windows.Forms.FlowLayoutPanel();

            table.SuspendLayout();
            buttonPanel.SuspendLayout();
            SuspendLayout();

            // --- Labelki ---
            Label[] labels = { lblFirstName, lblLastName, lblPhoneNumber, lblContractType,
                       lblYearsOfExperience, lblPosition, lblProduct, lblAddress };
            string[] labelTexts = { "Imię", "Nazwisko", "Telefon", "Rodzaj umowy",
                            "Lata doświadczenia", "Stanowisko", "Produkt", "Adres" };
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].Text = labelTexts[i];
                labels[i].TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                labels[i].Dock = System.Windows.Forms.DockStyle.Fill;
                labels[i].Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            }

            // --- Pola tekstowe / ComboBox ---
            TextBox[] textBoxes = { tbImie, tbNazwisko, tbTelefon, tbLataDoswiadczenia };
            foreach (var tb in textBoxes)
            {
                tb.Dock = System.Windows.Forms.DockStyle.Fill;
                tb.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
                tb.Height = 25;
            }

            ComboBox[] combos = { cbRodzajUmowy, cbStanowisko, cbProduct, cbAdres };
            foreach (var cb in combos)
            {
                cb.Dock = System.Windows.Forms.DockStyle.Fill;
                cb.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
                cb.Height = 25;
            }
            cbRodzajUmowy.Items.AddRange(new object[] { "Umowa o pracę", "Umowa zlecenie", "Umowa o dzieło" });

            // --- Button ---
            btnSave.Text = "Zapisz";
            btnSave.AutoSize = true;
            btnSave.Click += btnSave_Click;

            buttonPanel.AutoSize = true;
            buttonPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            buttonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonPanel.Controls.Add(btnSave);

            // --- TableLayoutPanel ---
            table.ColumnCount = 2;
            table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            table.RowCount = 9;
            for (int i = 0; i < 8; i++)
                table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));

            table.Dock = System.Windows.Forms.DockStyle.Fill;
            table.Padding = new System.Windows.Forms.Padding(10);

            table.Controls.Add(lblFirstName, 0, 0); table.Controls.Add(tbImie, 1, 0);
            table.Controls.Add(lblLastName, 0, 1); table.Controls.Add(tbNazwisko, 1, 1);
            table.Controls.Add(lblPhoneNumber, 0, 2); table.Controls.Add(tbTelefon, 1, 2);
            table.Controls.Add(lblContractType, 0, 3); table.Controls.Add(cbRodzajUmowy, 1, 3);
            table.Controls.Add(lblYearsOfExperience, 0, 4); table.Controls.Add(tbLataDoswiadczenia, 1, 4);
            table.Controls.Add(lblPosition, 0, 5); table.Controls.Add(cbStanowisko, 1, 5);
            table.Controls.Add(lblProduct, 0, 6); table.Controls.Add(cbProduct, 1, 6);
            table.Controls.Add(lblAddress, 0, 7); table.Controls.Add(cbAdres, 1, 7);
            table.Controls.Add(buttonPanel, 1, 8);

            // --- Form ---
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(450, 400);
            Controls.Add(table);
            Name = "EditEmployeeForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Edytuj pracownika";

            table.ResumeLayout(false);
            table.PerformLayout();
            buttonPanel.ResumeLayout(false);
            buttonPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
