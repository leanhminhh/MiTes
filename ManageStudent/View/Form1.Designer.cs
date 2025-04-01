using System.Windows.Forms;

namespace StudentManagement.Views
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSave;
        private Button btnLoad;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new DataGridView();
            this.btnAdd = new Button();
            this.btnEdit = new Button();
            this.btnDelete = new Button();
            this.btnSave = new Button();
            this.btnLoad = new Button();

            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Size = new System.Drawing.Size(500, 250);
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 270);
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(95, 270);
            this.btnEdit.Size = new System.Drawing.Size(75, 30);
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(180, 270);
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(265, 270);
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(350, 270);
            this.btnLoad.Size = new System.Drawing.Size(75, 30);
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);

            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(530, 320);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Text = "Student Management";
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

