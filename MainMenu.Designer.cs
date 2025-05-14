namespace Bakery_Schedule
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonSchedule;
        private System.Windows.Forms.Button buttonEmployees;
        private System.Windows.Forms.Label labelClock;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.TableLayoutPanel layoutPanel;
        private System.Windows.Forms.Label labelHeader;  // Dodajemy nową etykietę na nagłówek

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            buttonSchedule = new Button();
            buttonEmployees = new Button();
            SuspendLayout();

            // Dodajemy labelHeader i ustawiamy jej właściwości
            labelHeader = new Label();  // Tworzymy kontrolkę
            labelHeader.Text = "Grafik piekarzy";  // Ustawiamy tekst
            labelHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold);  // Ustawiamy czcionkę
            labelHeader.TextAlign = ContentAlignment.MiddleCenter;  // Wyrównanie do środka
            labelHeader.Dock = DockStyle.Fill;  // Sprawia, że etykieta wypełnia cały wiersz

            // 
            // buttonSchedule
            // 

            buttonSchedule.Margin = new Padding(3, 4, 3, 4);
            buttonSchedule.Name = "buttonSchedule";
            buttonSchedule.Size = new Size(200, 50);
            buttonSchedule.TabIndex = 0;
            buttonSchedule.Text = "Grafik";
            buttonSchedule.UseVisualStyleBackColor = true;
            buttonSchedule.Click += buttonSchedule_Click;

            // 
            // buttonEmployees
            // 
            buttonEmployees.Margin = new Padding(3, 4, 3, 4);
            buttonEmployees.Name = "buttonEmployees";
            buttonEmployees.Size = new Size(200, 50);
            buttonEmployees.TabIndex = 1;
            buttonEmployees.Text = "Pracownicy";
            buttonEmployees.UseVisualStyleBackColor = true;
            buttonEmployees.Click += buttonEmployees_Click;

            // MainMenu
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(buttonSchedule);
            Controls.Add(buttonEmployees);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainMenu";
            Text = "Menu Główne";
            ResumeLayout(false);

            this.labelClock = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer();

            // 
            // labelClock
            // 
            this.labelClock.AutoSize = true;
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(100, 23);
            this.labelClock.TabIndex = 2;
            this.labelClock.Text = "00:00:00";

            // 
            // timerClock
            // 
            this.timerClock.Interval = 1000; // 1 sekunda
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);

            this.Controls.Add(this.labelClock);
            this.layoutPanel = new System.Windows.Forms.TableLayoutPanel();

            // 
            // layoutPanel
            // 
            this.layoutPanel.ColumnCount = 1;
            this.layoutPanel.RowCount = 4;  // Zmieniamy liczbę wierszy na 4
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));  // Zmieniamy procent na 25%
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));  // Zmieniamy procent na 25%
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));  // Zmieniamy procent na 25%
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));  // Zmieniamy procent na 25%
            this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel.Controls.Add(this.labelHeader, 0, 0);  // Dodajemy nagłówek w pierwszym wierszu
            this.layoutPanel.Controls.Add(this.buttonSchedule, 0, 1);
            this.layoutPanel.Controls.Add(this.buttonEmployees, 0, 2);
            this.layoutPanel.Controls.Add(this.labelClock, 0, 3);
            this.layoutPanel.Name = "layoutPanel";

            // 
            // buttonSchedule
            // 
            this.buttonSchedule.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSchedule.Size = new System.Drawing.Size(200, 40);
            this.buttonSchedule.Text = "Grafik";

            // 
            // buttonEmployees
            // 
            this.buttonEmployees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEmployees.Size = new System.Drawing.Size(200, 40);
            this.buttonEmployees.Text = "Pracownicy";

            // 
            // labelClock
            // 
            this.labelClock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelClock.AutoSize = true;
            this.labelClock.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelClock.Text = "00:00:00";

            // 
            // MainMenu
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.layoutPanel);
            this.Name = "MainMenu";
            this.Text = "Menu Główne";

            this.BackColor = Color.FromArgb(240, 240, 240);

            this.buttonSchedule.BackColor = Color.SteelBlue;
            this.buttonSchedule.ForeColor = Color.White;
            this.buttonSchedule.FlatStyle = FlatStyle.Flat;
            this.buttonSchedule.Font = new Font("Segoe UI", 12F, FontStyle.Bold);

            this.buttonEmployees.BackColor = Color.SeaGreen;
            this.buttonEmployees.ForeColor = Color.White;
            this.buttonEmployees.FlatStyle = FlatStyle.Flat;
            this.buttonEmployees.Font = new Font("Segoe UI", 12F, FontStyle.Bold);

            this.labelClock.Font = new Font("Segoe UI", 14F, FontStyle.Regular);
            this.labelClock.ForeColor = Color.DimGray;

            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(this.buttonSchedule, "Przejdź do grafiku piekarzy");
            tooltip.SetToolTip(this.buttonEmployees, "Zarządzaj pracownikami");
        }


        #endregion
    }
}
