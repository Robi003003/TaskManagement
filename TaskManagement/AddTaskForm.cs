using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TaskManagement
{
    public partial class AddTaskForm : Form
    {
        private List<ProjectsForm.Task> tasks; 

        public AddTaskForm(List<string> projectNames, List<ProjectsForm.Task> taskList)
        {
            InitializeComponent();

            tasks = taskList; 

            
            cmbProjectName.Items.AddRange(projectNames.ToArray());
            cmbProjectName.SelectedIndexChanged += cmbProjectName_SelectedIndexChanged;
        }

        private void cmbProjectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTaskDescription.Clear(); 

            string selectedProject = cmbProjectName.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedProject))
            {
                
                var relatedTasks = tasks.Where(t => t.ProjectName == selectedProject).ToList();

                if (relatedTasks.Any())
                {
                    
                    cmbTaskDescription.Text = relatedTasks.First().TaskDescription;
                    textBox1.Text = relatedTasks.First().AssignedTo;
                }
                else
                {
                    cmbTaskDescription.Text = "";
                    textBox1.Text = "";
                }
            }
        }

        private void btnSaveTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbProjectName.Text) || string.IsNullOrWhiteSpace(cmbTaskDescription.Text))
            {
                MessageBox.Show("Please select a project and a task.");
                return;
            }

            MessageBox.Show($"Task Details:\nProject: {cmbProjectName.Text}\nTask: {cmbTaskDescription.Text}\nAssigned To: {textBox1.Text}");
        }
    }
}

