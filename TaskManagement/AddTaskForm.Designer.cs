
namespace TaskManagement
{
    partial class AddTaskForm
    {
        private System.ComponentModel.IContainer components = null;

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
            btnSaveTask = new Button();
            cmbProjectName = new ComboBox();
            cmbTaskDescription = new TextBox();
            textBox1 = new TextBox();
            lblTD = new Label();
            label2 = new Label();
            SuspendLayout();
            
            
            btnSaveTask.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveTask.Location = new Point(8, 192);
            btnSaveTask.Margin = new Padding(2, 2, 2, 2);
            btnSaveTask.Name = "btnSaveTask";
            btnSaveTask.Size = new Size(175, 33);
            btnSaveTask.TabIndex = 5;
            btnSaveTask.Text = "Show Details";
            btnSaveTask.UseVisualStyleBackColor = true;
            btnSaveTask.Click += btnSaveTask_Click;
            

            cmbProjectName.BackColor = Color.Silver;
            cmbProjectName.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbProjectName.FormattingEnabled = true;
            cmbProjectName.Location = new Point(8, 11);
            cmbProjectName.Margin = new Padding(2, 2, 2, 2);
            cmbProjectName.Name = "cmbProjectName";
            cmbProjectName.Size = new Size(176, 24);
            cmbProjectName.TabIndex = 6;
            cmbProjectName.Text = "Project Name";
           

            cmbTaskDescription.BackColor = Color.Silver;
            cmbTaskDescription.Location = new Point(8, 60);
            cmbTaskDescription.Margin = new Padding(2, 2, 2, 2);
            cmbTaskDescription.Multiline = true;
            cmbTaskDescription.Name = "cmbTaskDescription";
            cmbTaskDescription.Size = new Size(176, 57);
            cmbTaskDescription.TabIndex = 9;
            
             
            textBox1.BackColor = Color.Silver;
            textBox1.Location = new Point(8, 148);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 23);
            textBox1.TabIndex = 10;
            

            lblTD.AutoSize = true;
            lblTD.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTD.Location = new Point(8, 43);
            lblTD.Name = "lblTD";
            lblTD.Size = new Size(108, 16);
            lblTD.TabIndex = 11;
            lblTD.Text = "Project Description";
           

            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 130);
            label2.Name = "label2";
            label2.Size = new Size(76, 16);
            label2.TabIndex = 12;
            label2.Text = "Assigned To:";
           

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(206, 236);
            Controls.Add(label2);
            Controls.Add(lblTD);
            Controls.Add(textBox1);
            Controls.Add(cmbTaskDescription);
            Controls.Add(cmbProjectName);
            Controls.Add(btnSaveTask);
            Margin = new Padding(2, 2, 2, 2);
            Name = "AddTaskForm";
            Text = "Add Task";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnSaveTask;
        private ComboBox cmbProjectName;
        private TextBox cmbTaskDescription;
        private TextBox textBox1;
        private EventHandler cmbTaskDescription_TextChanged;
        private Label lblTD;
        private Label label2;
    }
}
