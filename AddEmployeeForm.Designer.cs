namespace Bakery_Schedule
{
    partial class AddEmployeeForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox tbImie;
        private System.Windows.Forms.TextBox tbNazwisko;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.TextBox tbLataDoswiadczenia;
        private System.Windows.Forms.ComboBox cbRodzajUmowy;
        private System.Windows.Forms.ComboBox cbStanowisko;
        private System.Windows.Forms.ComboBox cbAdres;  
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbProdukt;
        

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.tbImie = new System.Windows.Forms.TextBox();
            this.tbNazwisko = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.tbLataDoswiadczenia = new System.Windows.Forms.TextBox();

            this.cbRodzajUmowy = new System.Windows.Forms.ComboBox();
            this.cbStanowisko = new System.Windows.Forms.ComboBox();
            this.cbAdres = new System.Windows.Forms.ComboBox();

            this.btnSave = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // tbImie
            // 
            this.tbImie.Location = new System.Drawing.Point(160, 20);
            this.tbImie.Name = "tbImie";
            this.tbImie.Size = new System.Drawing.Size(200, 27);
            this.tbImie.TabIndex = 0;

            // 
            // tbNazwisko
            // 
            this.tbNazwisko.Location = new System.Drawing.Point(160, 60);
            this.tbNazwisko.Name = "tbNazwisko";
            this.tbNazwisko.Size = new System.Drawing.Size(200, 27);
            this.tbNazwisko.TabIndex = 1;

            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(160, 100);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(200, 27);
            this.tbTelefon.TabIndex = 2;

            // 
            // cbRodzajUmowy
            // 
            this.cbRodzajUmowy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRodzajUmowy.FormattingEnabled = true;
            this.cbRodzajUmowy.Items.AddRange(new object[] {
                "Umowa o pracê",
                "Umowa zlecenie",
                "Umowa o dzie³o"});
            this.cbRodzajUmowy.Location = new System.Drawing.Point(160, 140);
            this.cbRodzajUmowy.Name = "cbRodzajUmowy";
            this.cbRodzajUmowy.Size = new System.Drawing.Size(200, 28);
            this.cbRodzajUmowy.TabIndex = 3;

            // 
            // tbLataDoswiadczenia
            // 
            this.tbLataDoswiadczenia.Location = new System.Drawing.Point(160, 180);
            this.tbLataDoswiadczenia.Name = "tbLataDoswiadczenia";
            this.tbLataDoswiadczenia.Size = new System.Drawing.Size(200, 27);
            this.tbLataDoswiadczenia.TabIndex = 4;

            // 
            // cbStanowisko
            // 
            this.cbStanowisko.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStanowisko.FormattingEnabled = true;
            this.cbStanowisko.Location = new System.Drawing.Point(160, 220);
            this.cbStanowisko.Name = "cbStanowisko";
            this.cbStanowisko.Size = new System.Drawing.Size(200, 28);
            this.cbStanowisko.TabIndex = 5;

            // 
            // cbAdres
            // 
            this.cbAdres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAdres.FormattingEnabled = true;
            this.cbAdres.Location = new System.Drawing.Point(160, 260);
            this.cbAdres.Name = "cbAdres";
            this.cbAdres.Size = new System.Drawing.Size(200, 28);
            this.cbAdres.TabIndex = 6;

            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(160, 340);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 29);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);

            // 
            // Etykiety (Labels)
            // 
            var lblImie = new System.Windows.Forms.Label() { Text = "Imiê:", Location = new System.Drawing.Point(20, 20), Size = new System.Drawing.Size(120, 20) };
            var lblNazwisko = new System.Windows.Forms.Label() { Text = "Nazwisko:", Location = new System.Drawing.Point(20, 60), Size = new System.Drawing.Size(120, 20) };
            var lblTelefon = new System.Windows.Forms.Label() { Text = "Telefon:", Location = new System.Drawing.Point(20, 100), Size = new System.Drawing.Size(120, 20) };
            var lblRodzajUmowy = new System.Windows.Forms.Label() { Text = "Rodzaj umowy:", Location = new System.Drawing.Point(20, 140), Size = new System.Drawing.Size(120, 20) };
            var lblLata = new System.Windows.Forms.Label() { Text = "Lata doœwiadczenia:", Location = new System.Drawing.Point(20, 180), Size = new System.Drawing.Size(130, 20) };
            var lblStanowisko = new System.Windows.Forms.Label() { Text = "Stanowisko:", Location = new System.Drawing.Point(20, 220), Size = new System.Drawing.Size(120, 20) };
            var lblAdres = new System.Windows.Forms.Label() { Text = "Adres:", Location = new System.Drawing.Point(20, 260), Size = new System.Drawing.Size(120, 20) };

            // 
            // lblProdukt
            // 
            var lblProdukt = new System.Windows.Forms.Label();
            lblProdukt.Text = "Produkt:";
            lblProdukt.Location = new System.Drawing.Point(20, 300);
            lblProdukt.Size = new System.Drawing.Size(120, 20);
            this.Controls.Add(lblProdukt);

            // ComboBox dla produktów
            this.cbProdukt = new System.Windows.Forms.ComboBox();
            this.cbProdukt.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbProdukt.Location = new System.Drawing.Point(160, 300);
            this.cbProdukt.Size = new System.Drawing.Size(200, 28);
            this.cbProdukt.Name = "cbProdukt";

            this.Controls.Add(this.cbProdukt);

            // Dodajemy kontrolki do formularza
            this.Controls.Add(lblImie);
            this.Controls.Add(this.tbImie);

            this.Controls.Add(lblNazwisko);
            this.Controls.Add(this.tbNazwisko);

            this.Controls.Add(lblTelefon);
            this.Controls.Add(this.tbTelefon);

            this.Controls.Add(lblRodzajUmowy);
            this.Controls.Add(this.cbRodzajUmowy);

            this.Controls.Add(lblLata);
            this.Controls.Add(this.tbLataDoswiadczenia);

            this.Controls.Add(lblStanowisko);
            this.Controls.Add(this.cbStanowisko);

            this.Controls.Add(lblAdres);
            this.Controls.Add(this.cbAdres);

            this.Controls.Add(this.btnSave);

            this.Controls.Add(lblProdukt);
            this.Controls.Add(cbProdukt);

            // 
            // AddEmployeeForm
            // 
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Name = "AddEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj nowego pracownika";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
