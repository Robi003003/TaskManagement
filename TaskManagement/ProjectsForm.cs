using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TaskManagement
{
    public partial class ProjectsForm : Form
    {
        private List<Task> tasks = new List<Task>();
        private List<string> projectNames = new List<string>();
        private List<string> taskDescriptions = new List<string>();

        public class Task
        {
            public string ProjectName { get; set; }
            public string TaskDescription { get; set; }
            public string AssignedTo { get; set; }
        }

        public ProjectsForm()
        {
            InitializeComponent();
        }

        private void ProjectsForm_Load(object sender, EventArgs e)
        {
            cmbAssignTo.Items.AddRange(new string[] { "Manager", "Employee 1", "Employee 2" });
            cmbAssignTo.SelectedIndex = 0;

            dgvTasks.AutoGenerateColumns = true;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string projectName = txtProjectName.Text;
            string taskDescription = txtTaskDescription.Text;
            string assignedTo = cmbAssignTo.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrWhiteSpace(projectName) || string.IsNullOrWhiteSpace(taskDescription))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            Task newTask = new Task
            {
                ProjectName = projectName,
                TaskDescription = taskDescription,
                AssignedTo = assignedTo
            };
            tasks.Add(newTask);


            if (!projectNames.Contains(projectName))
                projectNames.Add(projectName);

            if (!taskDescriptions.Contains(taskDescription))
                taskDescriptions.Add(taskDescription);

            RefreshTaskList();
        }

        private void BtnOpenAddTaskForm_Click(object sender, EventArgs e)
        {
            AddTaskForm addTaskForm = new AddTaskForm(projectNames, tasks);
            addTaskForm.ShowDialog();
        }

        private void RefreshTaskList()
        {
            dgvTasks.DataSource = null;
            dgvTasks.DataSource = tasks;
        }
    }
}
