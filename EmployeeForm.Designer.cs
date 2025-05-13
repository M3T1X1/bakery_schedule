namespace Bakery_Schedule
{
    partial class EmployeeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

  
            // dataGridView1
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 370);
            this.dataGridView1.TabIndex = 0;

            // btnAdd
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.Location = new System.Drawing.Point(10, 10);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            
            // btnEdit
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.Location = new System.Drawing.Point(100, 10);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);


            // btnDelete
            this.btnDelete.Text = "Usuń";
            this.btnDelete.Location = new System.Drawing.Point(190, 10);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // btnSave
            this.btnSave.Text = "Zapisz";
            this.btnSave.Location = new System.Drawing.Point(280, 10);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // EmployeeForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Name = "EmployeeForm";
            this.Text = "Lista Pracowników";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}