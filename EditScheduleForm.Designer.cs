namespace Bakery_Schedule
{
    partial class EditScheduleForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.Load += new System.EventHandler(this.EditScheduleForm_Load);

            cbEmployee = new ComboBox();
            dtpData = new DateTimePicker();
            dtpPoczatek = new DateTimePicker();
            dtpKoniec = new DateTimePicker();
            btnSave = new Button();
            btnCancel = new Button();
            lblEmployee = new Label();
            lblDate = new Label();
            lblStart = new Label();
            lblEnd = new Label();
            SuspendLayout();
            // 
            // cbEmployee
            // 
            cbEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEmployee.FormattingEnabled = true;
            cbEmployee.Location = new Point(163, 15);
            cbEmployee.Name = "cbEmployee";
            cbEmployee.Size = new Size(220, 28);
            cbEmployee.TabIndex = 0;
            // 
            // dtpData
            // 
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(163, 55);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(220, 27);
            dtpData.TabIndex = 1;
            // 
            // dtpPoczatek
            // 
            dtpPoczatek.Format = DateTimePickerFormat.Time;
            dtpPoczatek.Location = new Point(163, 95);
            dtpPoczatek.Name = "dtpPoczatek";
            dtpPoczatek.ShowUpDown = true;
            dtpPoczatek.Size = new Size(220, 27);
            dtpPoczatek.TabIndex = 2;
            // 
            // dtpKoniec
            // 
            dtpKoniec.Format = DateTimePickerFormat.Time;
            dtpKoniec.Location = new Point(163, 133);
            dtpKoniec.Name = "dtpKoniec";
            dtpKoniec.ShowUpDown = true;
            dtpKoniec.Size = new Size(220, 27);
            dtpKoniec.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(130, 180);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 30);
            btnSave.TabIndex = 4;
            btnSave.Text = "Zapisz";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(260, 180);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 30);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.Location = new Point(25, 18);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(79, 20);
            lblEmployee.TabIndex = 6;
            lblEmployee.Text = "Pracownik:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(25, 60);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(44, 20);
            lblDate.TabIndex = 7;
            lblDate.Text = "Data:";
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Location = new Point(25, 100);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(121, 20);
            lblStart.TabIndex = 8;
            lblStart.Text = "Początek zmiany:";
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Location = new Point(25, 140);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(108, 20);
            lblEnd.TabIndex = 9;
            lblEnd.Text = "Koniec zmiany:";
            // 
            // EditScheduleForm
            // 
            AcceptButton = btnSave;
            CancelButton = btnCancel;
            ClientSize = new Size(462, 230);
            Controls.Add(lblEnd);
            Controls.Add(lblStart);
            Controls.Add(lblDate);
            Controls.Add(lblEmployee);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dtpKoniec);
            Controls.Add(dtpPoczatek);
            Controls.Add(dtpData);
            Controls.Add(cbEmployee);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "EditScheduleForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edytuj zmianę";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.DateTimePicker dtpPoczatek;
        private System.Windows.Forms.DateTimePicker dtpKoniec;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
    }
}
