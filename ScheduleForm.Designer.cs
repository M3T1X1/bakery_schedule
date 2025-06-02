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
            flowPanelControls = new FlowLayoutPanel();
            cbEmployee = new ComboBox();
            dtpDate = new DateTimePicker();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            btnAddShift = new Button();
            btnDeleteShift = new Button();
            btnEditShift = new Button();
            btnGoEmployee = new Button();
            tableLayoutPanel = new TableLayoutPanel();
            dgvSchedule = new DataGridView();
            flowPanelControls.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            SuspendLayout();

            trackBarScroll = new TrackBar();
            trackBarScroll.Orientation = Orientation.Horizontal;
            trackBarScroll.Minimum = 1;
            trackBarScroll.TickStyle = TickStyle.BottomRight;
            trackBarScroll.Dock = DockStyle.Bottom;
            trackBarScroll.Scroll += TrackBarScroll_Scroll;
            Controls.Add(trackBarScroll);
            // 
            // flowPanelControls
            // 
            flowPanelControls.Controls.Add(cbEmployee);
            flowPanelControls.Controls.Add(dtpDate);
            flowPanelControls.Controls.Add(dtpStart);
            flowPanelControls.Controls.Add(dtpEnd);
            flowPanelControls.Controls.Add(btnAddShift);
            flowPanelControls.Controls.Add(btnDeleteShift);
            flowPanelControls.Controls.Add(btnEditShift);
            flowPanelControls.Controls.Add(btnGoEmployee);
            flowPanelControls.Location = new Point(3, 11);
            flowPanelControls.Name = "flowPanelControls";
            flowPanelControls.Padding = new Padding(10, 11, 10, 11);
            flowPanelControls.Size = new Size(1194, 102);
            flowPanelControls.TabIndex = 0;
            // 
            // cbEmployee
            // 
            cbEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEmployee.FormattingEnabled = true;
            cbEmployee.Location = new Point(13, 14);
            cbEmployee.Name = "cbEmployee";
            cbEmployee.Size = new Size(201, 28);
            cbEmployee.TabIndex = 0;
            // 
            // dtpData
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(220, 14);
            dtpDate.Name = "dtpData";
            dtpDate.Size = new Size(121, 27);
            dtpDate.TabIndex = 1;
            // 
            // dtpPoczatek
            // 
            dtpStart.Format = DateTimePickerFormat.Time;
            dtpStart.Location = new Point(347, 14);
            dtpStart.Name = "dtpPoczatek";
            dtpStart.ShowUpDown = true;
            dtpStart.Size = new Size(100, 27);
            dtpStart.TabIndex = 2;
            // 
            // dtpKoniec
            // 
            dtpEnd.Format = DateTimePickerFormat.Time;
            dtpEnd.Location = new Point(453, 14);
            dtpEnd.Name = "dtpKoniec";
            dtpEnd.ShowUpDown = true;
            dtpEnd.Size = new Size(100, 27);
            dtpEnd.TabIndex = 3;
            // 
            // btnAddShift
            // 
            btnAddShift.Location = new Point(559, 14);
            btnAddShift.Name = "btnAddShift";
            btnAddShift.Size = new Size(120, 29);
            btnAddShift.TabIndex = 4;
            btnAddShift.Text = "Dodaj zmianę";
            btnAddShift.Click += btnAddShift_Click;
            // 
            // btnDeleteShift
            // 
            btnDeleteShift.Location = new Point(685, 15);
            btnDeleteShift.Margin = new Padding(3, 4, 3, 4);
            btnDeleteShift.Name = "btnDeleteShift";
            btnDeleteShift.Size = new Size(114, 31);
            btnDeleteShift.TabIndex = 6;
            btnDeleteShift.Text = "Usuń zmianę";
            btnDeleteShift.Click += btnDeleteShift_Click;
            // 
            // btnEditShift
            // 
            btnEditShift.Location = new Point(805, 14);
            btnEditShift.Name = "btnEditShift";
            btnEditShift.Size = new Size(120, 29);
            btnEditShift.TabIndex = 6;
            btnEditShift.Text = "Edytuj zmianę";
            btnEditShift.Click += btnEditShift_Click;
            // 
            // btnGoEmployee
            // 
            btnGoEmployee.Location = new Point(931, 14);
            btnGoEmployee.Name = "btnGoEmployee";
            btnGoEmployee.Size = new Size(137, 29);
            btnGoEmployee.TabIndex = 5;
            btnGoEmployee.Text = "Pracownicy";
            btnGoEmployee.Click += btnGoEmployee_Click;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tableLayoutPanel.Controls.Add(flowPanelControls, 0, 1);
            tableLayoutPanel.Controls.Add(dgvSchedule, 0, 2);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 112F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(1200, 749);
            tableLayoutPanel.TabIndex = 0;
            // 
            // dgvSchedule
            // 
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Dock = DockStyle.Fill;
            dgvSchedule.Location = new Point(3, 123);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.RowHeadersWidth = 51;
            dgvSchedule.Size = new Size(1194, 623);
            dgvSchedule.TabIndex = 5;
            // 
            // ScheduleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 749);
            Controls.Add(tableLayoutPanel);
            Name = "ScheduleForm";
            Text = "Grafik pracy piekarzy";
            Load += ScheduleForm_Load;
            flowPanelControls.ResumeLayout(false);
            tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            ResumeLayout(false);
        }
        private FlowLayoutPanel flowPanelControls;
        private ComboBox cbEmployee;
        private DateTimePicker dtpDate;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private Button btnAddShift;
        private Button btnGoEmployee;
        private TableLayoutPanel tableLayoutPanel;
        
        private Button btnEditShift;
        private Button btnDeleteShift;
        private DataGridView dgvSchedule;
        private System.Windows.Forms.TrackBar trackBarScroll;
    }
}