namespace Bakery_Schedule
{
    partial class ScheduleForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnAddShift;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel flowPanelControls;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            cbEmployee = new ComboBox();
            dtpDate = new DateTimePicker();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            btnAddShift = new Button();
            dgvSchedule = new DataGridView();
            tableLayoutPanel = new TableLayoutPanel();
            flowPanelControls = new FlowLayoutPanel();

            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            SuspendLayout();

            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F)); // 20% dla kontrolek
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 80F)); // 80% dla DataGridView
            tableLayoutPanel.Controls.Add(flowPanelControls, 0, 0);
            tableLayoutPanel.Controls.Add(dgvSchedule, 0, 1);

            // 
            // flowPanelControls
            // 
            flowPanelControls.Dock = DockStyle.Fill;
            flowPanelControls.FlowDirection = FlowDirection.LeftToRight;
            flowPanelControls.WrapContents = true;
            flowPanelControls.Controls.Add(cbEmployee);
            flowPanelControls.Controls.Add(dtpDate);
            flowPanelControls.Controls.Add(dtpStart);
            flowPanelControls.Controls.Add(dtpEnd);
            flowPanelControls.Controls.Add(btnAddShift);

            // 
            // cbEmployee
            // 
            cbEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEmployee.FormattingEnabled = true;
            cbEmployee.Size = new Size(200, 28);
            cbEmployee.Name = "cbEmployee";
            cbEmployee.TabIndex = 0;

            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Size = new Size(120, 27);
            dtpDate.Name = "dtpDate";
            dtpDate.TabIndex = 1;

            // 
            // dtpStart
            // 
            dtpStart.Format = DateTimePickerFormat.Time;
            dtpStart.ShowUpDown = true;
            dtpStart.Size = new Size(100, 27);
            dtpStart.Name = "dtpStart";
            dtpStart.TabIndex = 2;

            // 
            // dtpEnd
            // 
            dtpEnd.Format = DateTimePickerFormat.Time;
            dtpEnd.ShowUpDown = true;
            dtpEnd.Size = new Size(100, 27);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.TabIndex = 3;

            // 
            // btnAddShift
            // 
            btnAddShift.Size = new Size(100, 29);
            btnAddShift.Name = "btnAddShift";
            btnAddShift.TabIndex = 4;
            btnAddShift.Text = "Dodaj zmianę";
            btnAddShift.Click += btnAddShift_Click;

            // 
            // dgvSchedule
            // 
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Dock = DockStyle.Fill;
            dgvSchedule.Location = new Point(12, 50);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.Size = new Size(760, 390);
            dgvSchedule.TabIndex = 5;

            // 
            // ScheduleForm
            // 
            ClientSize = new Size(794, 464);
            Controls.Add(tableLayoutPanel);
            Name = "ScheduleForm";
            Text = "Grafik pracy piekarzy";
            Load += ScheduleForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            ResumeLayout(false);
        }
    }
}
