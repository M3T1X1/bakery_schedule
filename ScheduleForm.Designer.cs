namespace Bakery_Schedule
{
    using System.Windows.Forms;

    partial class ScheduleForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvSchedule = new DataGridView();
            flowPanelControls = new FlowLayoutPanel();
            btnAddShift = new Button();
            btnGoEmployee = new Button(); // Dodanie guzika
            dtpEnd = new DateTimePicker();
            dtpStart = new DateTimePicker();
            dtpDate = new DateTimePicker();
            cbEmployee = new ComboBox();
            tableLayoutPanel = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            flowPanelControls.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            //
            // dgvSchedule
            //
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Dock = DockStyle.Fill;
            dgvSchedule.Location = new Point(3, 92);
            dgvSchedule.Margin = new Padding(3, 2, 3, 2);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.Size = new Size(694, 281);
            dgvSchedule.TabIndex = 5;
            //
            // flowPanelControls
            //
            flowPanelControls.Controls.Add(cbEmployee);
            flowPanelControls.Controls.Add(dtpDate);
            flowPanelControls.Controls.Add(dtpStart);
            flowPanelControls.Controls.Add(dtpEnd);
            flowPanelControls.Controls.Add(btnAddShift);
            flowPanelControls.Controls.Add(btnGoEmployee); // Dodanie guzika do flowPanelControls
            flowPanelControls.Dock = DockStyle.Fill;
            flowPanelControls.Location = new Point(3, 30);
            flowPanelControls.Margin = new Padding(3, 2, 3, 2);
            flowPanelControls.Name = "flowPanelControls";
            flowPanelControls.Padding = new Padding(9, 8, 9, 8);
            flowPanelControls.Size = new Size(694, 58);
            flowPanelControls.TabIndex = 0;
            //
            // btnAddShift
            //
            btnAddShift.Location = new Point(494, 10);
            btnAddShift.Margin = new Padding(3, 2, 3, 2);
            btnAddShift.Name = "btnAddShift";
            btnAddShift.Size = new Size(105, 22);
            btnAddShift.TabIndex = 4;
            btnAddShift.Text = "Dodaj zmianę";
            btnAddShift.Click += btnAddShift_Click;
            //
            // btnGoEmployee
            //
            btnGoEmployee.Location = new Point(605, 10);
            btnGoEmployee.Margin = new Padding(3, 2, 3, 2);
            btnGoEmployee.Name = "btnGoEmployee";
            btnGoEmployee.Size = new Size(120, 22);
            btnGoEmployee.TabIndex = 5;
            btnGoEmployee.Text = "Pracownicy";
            btnGoEmployee.Click += btnGoEmployee_Click; // Dodanie obsługi zdarzenia

            btnDeleteShift = new Button();
            btnDeleteShift.Location = new Point(730, 10); // Ustaw według własnego układu
            btnDeleteShift.Size = new Size(100, 23);
            btnDeleteShift.Text = "Usuń zmianę";
            btnDeleteShift.Click += btnDeleteShift_Click;
            flowPanelControls.Controls.Add(btnDeleteShift);

            //btnEdit
            btnEditShift = new Button();
            btnEditShift.Location = new Point(730, 10);
            btnEditShift.Margin = new Padding(3, 2, 3, 2);
            btnEditShift.Name = "btnEditShift";
            btnEditShift.Size = new Size(105, 22);
            btnEditShift.TabIndex = 6;
            btnEditShift.Text = "Edytuj zmianę";
            btnEditShift.Click += btnEditShift_Click;
            flowPanelControls.Controls.Add(btnEditShift);

            //
            // dtpEnd
            //
            dtpEnd.Format = DateTimePickerFormat.Time;
            dtpEnd.Location = new Point(400, 10);
            dtpEnd.Margin = new Padding(3, 2, 3, 2);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.ShowUpDown = true;
            dtpEnd.Size = new Size(88, 23);
            dtpEnd.TabIndex = 3;
            //
            // dtpStart
            //
            dtpStart.Format = DateTimePickerFormat.Time;
            dtpStart.Location = new Point(306, 10);
            dtpStart.Margin = new Padding(3, 2, 3, 2);
            dtpStart.Name = "dtpStart";
            dtpStart.ShowUpDown = true;
            dtpStart.Size = new Size(88, 23);
            dtpStart.TabIndex = 2;
            //
            // dtpDate
            //
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(194, 10);
            dtpDate.Margin = new Padding(3, 2, 3, 2);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(106, 23);
            dtpDate.TabIndex = 1;
            //
            // cbEmployee
            //
            cbEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEmployee.FormattingEnabled = true;
            cbEmployee.Location = new Point(12, 10);
            cbEmployee.Margin = new Padding(3, 2, 3, 2);
            cbEmployee.Name = "cbEmployee";
            cbEmployee.Size = new Size(176, 23);
            cbEmployee.TabIndex = 0;

   
            //
            // tableLayoutPanel
            //
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Controls.Add(flowPanelControls, 0, 1);
            tableLayoutPanel.Controls.Add(dgvSchedule, 0, 2);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(700, 375);
            tableLayoutPanel.TabIndex = 0;
            //
            // ScheduleForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 375);
            Controls.Add(tableLayoutPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ScheduleForm";
            Text = "Grafik pracy piekarzy";
            Load += ScheduleForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            flowPanelControls.ResumeLayout(false);
            tableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DataGridView dgvSchedule;
        private FlowLayoutPanel flowPanelControls;
        private ComboBox cbEmployee;
        private DateTimePicker dtpDate;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private Button btnAddShift;
        private Button btnGoEmployee;
        private TableLayoutPanel tableLayoutPanel;
        private TextBox txtSearchEmployee;
        private Button btnEditShift;
        private Button btnDeleteShift;


    }
}