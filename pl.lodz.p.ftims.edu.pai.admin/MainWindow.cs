using pl.lodz.p.ftims.edu.pai.central.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pl.lodz.p.ftims.edu.pai.admin
{
    public partial class MainWindow : Form
    {
        AdminService.IManagement managementService;
        public MainWindow()
        {
            InitializeComponent();
            managementService = new AdminService.ManagementClient();
        }
        #region Branch
        private void btnAddBranch_Click(object sender, EventArgs e)
        {
            BranchForm form = new BranchForm();
            if (DialogResult.OK == form.ShowDialog(this))
            {
                CreateBranch createBranch = new CreateBranch();
                createBranch.Name = form.textName.Text;
                createBranch.Uri = form.textAdres.Text;
                var branch = managementService.CreateBranch(createBranch);
                UpdateGridBranches();
            }
        }

        private void tabBranches_Enter(object sender, EventArgs e)
        {
            UpdateGridBranches();
        }

        private void UpdateGridBranches()
        {
            gridBranch.Rows.Clear();
            Branch[] branches = managementService.GetBranchess(0, 0);
            foreach (var branch in branches)
            {
                gridBranch.Rows.Add(branch.Id, branch.Name, branch.Uri);
            }
        }

        private void gridBranch_SelectionChanged(object sender, EventArgs e)
        {
            var selected = gridBranch.SelectedRows;
            if (selected.Count == 0)
            {
                btnBranchDelete.Enabled = false;
                btnBranchEdit.Enabled = false;
            }
            else if (selected.Count == 1)
            {
                btnBranchDelete.Enabled = true;
                btnBranchEdit.Enabled = true;
            }
            else
            {
                btnBranchDelete.Enabled = true;
                btnBranchEdit.Enabled = false;
            }
        }

        private void btnBranchEdit_Click(object sender, EventArgs e)
        {
            BranchForm form = new BranchForm();
            var selected = gridBranch.SelectedRows[0];
            int branchId = int.Parse(selected.Cells[0].Value.ToString());
            var toEdit = managementService.GetBranch(branchId.ToString());
            form.textId.Text = toEdit.Id.ToString();
            form.textName.Text = toEdit.Name;
            form.textAdres.Text = toEdit.Uri;
            if (DialogResult.OK == form.ShowDialog(this))
            {
                Branch updateBranch = new Branch();
                updateBranch.Name = form.textName.Text;
                updateBranch.Uri = form.textAdres.Text;
                var branch = managementService.UpdateBranch(form.textId.Text, updateBranch);
                UpdateGridBranches();
            }
        }

        private void btnBranchDelete_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < gridBranch.SelectedRows.Count; i++)
            {
                var selection = gridBranch.SelectedRows[i];
                var id = selection.Cells[0].Value.ToString();
                managementService.DeleteBranch(id);
            }
            UpdateGridBranches();
        }
        #endregion
        #region Project
        private void btnAddProject_Click(object sender, EventArgs e)
        {
            ProjectForm form = new ProjectForm();
            if (DialogResult.OK == form.ShowDialog(this))
            {
                CreateProject createProject = new CreateProject(form.textCode.Text, form.textName.Text, 0, form.comboType.ValueMember == "W" ? 0 : 1);
                var project = managementService.CreateProject(createProject);
                UpdateGridProjects();
            }
        }

        private void tabProject_Enter(object sender, EventArgs e)
        {
            UpdateGridProjects();
        }

        private void UpdateGridProjects()
        {
            gridProject.Rows.Clear();
            Project[] projects = managementService.GetProjects(0, 0);
            foreach (var project in projects)
            {
                gridProject.Rows.Add(project.Id, project.Code, project.Name, project.Type == 0 ? "Wewnętrzny" : "Rozliczany");
            }
        }

        private void gridProject_SelectionChanged(object sender, EventArgs e)
        {
            var selected = gridProject.SelectedRows;
            if (selected.Count == 0)
            {
                btnProjectDelete.Enabled = false;
                btnProjectEdit.Enabled = false;
            }
            else if (selected.Count == 1)
            {
                btnProjectDelete.Enabled = true;
                btnProjectEdit.Enabled = true;
            }
            else
            {
                btnProjectDelete.Enabled = true;
                btnProjectEdit.Enabled = false;
            }
        }

        private void btnProjectEdit_Click(object sender, EventArgs e)
        {
            ProjectForm form = new ProjectForm();
            var selected = gridProject.SelectedRows[0];
            int projectId = int.Parse(selected.Cells[0].Value.ToString());
            var toEdit = managementService.GetProject(projectId.ToString());
            form.textId.Text = toEdit.Id.ToString();
            form.textName.Text = toEdit.Name;
            form.textCode.Text = toEdit.Code;
            form.comboType.Text = toEdit.Type == 0 ? "W" : "B";
            if (DialogResult.OK == form.ShowDialog(this))
            {
                Project updateProject = new Project(int.Parse(form.textId.Text), form.textCode.Text, form.textName.Text, form.comboType.Text == "W" ? 0 : 1);
                var branch = managementService.UpdateProject(form.textId.Text, updateProject);
                UpdateGridProjects();
            }
        }

        private void btnProjectDelete_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < gridProject.SelectedRows.Count; i++)
            {
                var selection = gridProject.SelectedRows[i];
                var id = selection.Cells[0].Value.ToString();
                managementService.DeleteProject(id);
            }
            UpdateGridProjects();
        }
        #endregion
        #region Task
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            TaskForm form = new TaskForm();
            if (DialogResult.OK == form.ShowDialog(this))
            {
                CreateTask createTask = new CreateTask(form.textCode.Text, form.textName.Text);
                var project = managementService.CreateTask(createTask);
                UpdateGridTasks();
            }
        }

        private void tabTask_Enter(object sender, EventArgs e)
        {
            UpdateGridTasks();
        }

        private void UpdateGridTasks()
        {
            gridTask.Rows.Clear();
            central.dto.Task[] projects = managementService.GetTasks(0, 0);
            foreach (var project in projects)
            {
                gridTask.Rows.Add(project.Id, project.Code, project.Name);
            }
        }

        private void gridTask_SelectionChanged(object sender, EventArgs e)
        {
            var selected = gridTask.SelectedRows;
            if (selected.Count == 0)
            {
                btnTaskDelete.Enabled = false;
                btnTaskEdit.Enabled = false;
            }
            else if (selected.Count == 1)
            {
                btnTaskDelete.Enabled = true;
                btnTaskEdit.Enabled = true;
            }
            else
            {
                btnTaskDelete.Enabled = true;
                btnTaskEdit.Enabled = false;
            }
        }

        private void btnTaskEdit_Click(object sender, EventArgs e)
        {
            TaskForm form = new TaskForm();
            var selected = gridTask.SelectedRows[0];
            int projectId = int.Parse(selected.Cells[0].Value.ToString());
            var toEdit = managementService.GetTask(projectId.ToString());
            form.textId.Text = toEdit.Id.ToString();
            form.textName.Text = toEdit.Name;
            form.textCode.Text = toEdit.Code;
            if (DialogResult.OK == form.ShowDialog(this))
            {
                central.dto.Task updateTask = new central.dto.Task(int.Parse(form.textId.Text), form.textCode.Text, form.textName.Text);
                var branch = managementService.UpdateTask(form.textId.Text, updateTask);
                UpdateGridTasks();
            }
        }

        private void btnTaskDelete_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < gridTask.SelectedRows.Count; i++)
            {
                var selection = gridTask.SelectedRows[i];
                var id = selection.Cells[0].Value.ToString();
                managementService.DeleteTask(id);
            }
            UpdateGridTasks();
        }
        #endregion
    }
}
