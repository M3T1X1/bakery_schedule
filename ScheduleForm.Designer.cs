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
            menuStrip = new MenuStrip();
            fileMenu = new ToolStripMenuItem();
            extraMenu = new ToolStripMenuItem();
            dgvSchedule = new DataGridView();
            txtSearch = new TextBox();
            flowPanelControls.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            SuspendLayout();
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
            flowPanelControls.Controls.Add(txtSearch);
            flowPanelControls.Location = new Point(3, 30);
            flowPanelControls.Margin = new Padding(3, 2, 3, 2);
            flowPanelControls.Name = "flowPanelControls";
            flowPanelControls.Padding = new Padding(9, 8, 9, 8);
            flowPanelControls.Size = new Size(1044, 76);
            flowPanelControls.TabIndex = 0;
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
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(194, 10);
            dtpDate.Margin = new Padding(3, 2, 3, 2);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(106, 23);
            dtpDate.TabIndex = 1;
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
            // btnDeleteShift
            // 
            btnDeleteShift.Location = new Point(605, 11);
            btnDeleteShift.Name = "btnDeleteShift";
            btnDeleteShift.Size = new Size(100, 23);
            btnDeleteShift.TabIndex = 6;
            btnDeleteShift.Text = "Usuń zmianę";
            btnDeleteShift.Click += btnDeleteShift_Click;
            // 
            // btnEditShift
            // 
            btnEditShift.Location = new Point(711, 10);
            btnEditShift.Margin = new Padding(3, 2, 3, 2);
            btnEditShift.Name = "btnEditShift";
            btnEditShift.Size = new Size(105, 22);
            btnEditShift.TabIndex = 6;
            btnEditShift.Text = "Edytuj zmianę";
            btnEditShift.Click += btnEditShift_Click;
            // 
            // btnGoEmployee
            // 
            btnGoEmployee.Location = new Point(822, 10);
            btnGoEmployee.Margin = new Padding(3, 2, 3, 2);
            btnGoEmployee.Name = "btnGoEmployee";
            btnGoEmployee.Size = new Size(120, 22);
            btnGoEmployee.TabIndex = 5;
            btnGoEmployee.Text = "Pracownicy";
            btnGoEmployee.Click += btnGoEmployee_Click;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(flowPanelControls, 0, 2);
            tableLayoutPanel.Controls.Add(dgvSchedule, 0, 3);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 4;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(1050, 562);
            tableLayoutPanel.TabIndex = 0;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fileMenu, extraMenu });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(5, 2, 0, 2);
            menuStrip.Size = new Size(1050, 24);
            menuStrip.TabIndex = 0;
            // 
            // fileMenu
            // 
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new Size(38, 20);
            fileMenu.Text = "Plik";
            // 
            // extraMenu
            // 
            extraMenu.Name = "extraMenu";
            extraMenu.Size = new Size(79, 20);
            extraMenu.Text = "Dodatkowe";
            // 
            // dgvSchedule
            // 
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Dock = DockStyle.Fill;
            dgvSchedule.Location = new Point(3, 114);
            dgvSchedule.Margin = new Padding(3, 2, 3, 2);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.RowHeadersWidth = 51;
            dgvSchedule.Size = new Size(1044, 446);
            dgvSchedule.TabIndex = 5;
            dgvSchedule.AutoGenerateColumns = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 40);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(288, 23);
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // ScheduleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 562);
            Controls.Add(menuStrip);
            Controls.Add(tableLayoutPanel);
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ScheduleForm";
            Text = "Grafik pracy piekarzy";
            Load += ScheduleForm_Load;
            flowPanelControls.ResumeLayout(false);
            flowPanelControls.PerformLayout();
            tableLayoutPanel.ResumeLayout(false);
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private MenuStrip menuStrip;
        private TextBox textBox1;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem extraMenu;
        private TextBox txtSearch;
    }
}