namespace TaskManagement
{
    partial class ProjectsForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label label1;
        private TextBox txtProjectName;
        private Label label2;
        private TextBox txtTaskDescription;
        private Label label3;
        private ComboBox cmbAssignTo;
        private Button btnAddTask;
        private DataGridView dgvTasks;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            txtProjectName = new TextBox();
            label2 = new Label();
            txtTaskDescription = new TextBox();
            label3 = new Label();
            cmbAssignTo = new ComboBox();
            btnAddTask = new Button();
            dgvTasks = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            SuspendLayout();
             
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 16);
            label1.TabIndex = 0;
            label1.Text = "Project Name";
            
            txtProjectName.BackColor = Color.Silver;
            txtProjectName.BorderStyle = BorderStyle.FixedSingle;
            txtProjectName.Location = new Point(15, 31);
            txtProjectName.Margin = new Padding(2, 2, 2, 2);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.Size = new Size(147, 23);
            txtProjectName.TabIndex = 1;
            
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 68);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 16);
            label2.TabIndex = 2;
            label2.Text = "Task Description";
            
            
            txtTaskDescription.BackColor = Color.Silver;
            txtTaskDescription.BorderStyle = BorderStyle.FixedSingle;
            txtTaskDescription.Location = new Point(15, 85);
            txtTaskDescription.Margin = new Padding(2, 2, 2, 2);
            txtTaskDescription.Multiline = true;
            txtTaskDescription.Name = "txtTaskDescription";
            txtTaskDescription.Size = new Size(252, 53);
            txtTaskDescription.TabIndex = 3;
            
            
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 153);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 16);
            label3.TabIndex = 4;
            label3.Text = "Assign To";
           
            
            cmbAssignTo.BackColor = Color.Silver;
            cmbAssignTo.FormattingEnabled = true;
            cmbAssignTo.Location = new Point(15, 170);
            cmbAssignTo.Margin = new Padding(2, 2, 2, 2);
            cmbAssignTo.Name = "cmbAssignTo";
            cmbAssignTo.Size = new Size(129, 23);
            cmbAssignTo.TabIndex = 5;
            
            
            btnAddTask.BackColor = Color.Silver;
            btnAddTask.BackgroundImageLayout = ImageLayout.None;
            btnAddTask.FlatAppearance.BorderColor = Color.Silver;
            btnAddTask.FlatAppearance.BorderSize = 0;
            btnAddTask.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTask.Location = new Point(493, 22);
            btnAddTask.Margin = new Padding(2, 2, 2, 2);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(78, 25);
            btnAddTask.TabIndex = 6;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Click += btnAddTask_Click;
            

            dgvTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTasks.BackgroundColor = Color.Silver;
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Location = new Point(309, 51);
            dgvTasks.Margin = new Padding(2, 2, 2, 2);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.RowHeadersWidth = 62;
            dgvTasks.Size = new Size(262, 107);
            dgvTasks.TabIndex = 7;
            

            button1.BackColor = Color.Silver;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(493, 201);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(78, 24);
            button1.TabIndex = 8;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = false;
            button1.Click += BtnOpenAddTaskForm_Click;
           

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(589, 236);
            Controls.Add(button1);
            Controls.Add(dgvTasks);
            Controls.Add(btnAddTask);
            Controls.Add(cmbAssignTo);
            Controls.Add(label3);
            Controls.Add(txtTaskDescription);
            Controls.Add(label2);
            Controls.Add(txtProjectName);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ProjectsForm";
            Text = "ProjectsForm";
            Load += ProjectsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
    }
}
