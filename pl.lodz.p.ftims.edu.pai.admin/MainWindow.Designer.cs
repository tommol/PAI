namespace pl.lodz.p.ftims.edu.pai.admin
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabEmployees = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabProjects = new System.Windows.Forms.TabPage();
            this.gridProject = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coliumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProjectSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnProjectDelete = new System.Windows.Forms.Button();
            this.btnProjectEdit = new System.Windows.Forms.Button();
            this.btnProjectAdd = new System.Windows.Forms.Button();
            this.tabTasks = new System.Windows.Forms.TabPage();
            this.gridTask = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTaskSearch = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnTaskDelete = new System.Windows.Forms.Button();
            this.btnTaskEdit = new System.Windows.Forms.Button();
            this.btnTaskAdd = new System.Windows.Forms.Button();
            this.tabBranches = new System.Windows.Forms.TabPage();
            this.gridBranch = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uriColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSync = new System.Windows.Forms.Button();
            this.btnBranchDelete = new System.Windows.Forms.Button();
            this.btnBranchEdit = new System.Windows.Forms.Button();
            this.btnAddBranch = new System.Windows.Forms.Button();
            this.dataSet1 = new System.Data.DataSet();
            this.tabEmployees.SuspendLayout();
            this.tabProjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProject)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTask)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabBranches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBranch)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabEmployees
            // 
            this.tabEmployees.Controls.Add(this.tabPage1);
            this.tabEmployees.Controls.Add(this.tabProjects);
            this.tabEmployees.Controls.Add(this.tabTasks);
            this.tabEmployees.Controls.Add(this.tabBranches);
            this.tabEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabEmployees.Location = new System.Drawing.Point(0, 0);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.SelectedIndex = 0;
            this.tabEmployees.Size = new System.Drawing.Size(710, 398);
            this.tabEmployees.TabIndex = 0;
            this.tabEmployees.Enter += new System.EventHandler(this.tabProject_Enter);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(702, 372);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pracownicy";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabProjects
            // 
            this.tabProjects.Controls.Add(this.gridProject);
            this.tabProjects.Controls.Add(this.panel2);
            this.tabProjects.Location = new System.Drawing.Point(4, 22);
            this.tabProjects.Name = "tabProjects";
            this.tabProjects.Padding = new System.Windows.Forms.Padding(3);
            this.tabProjects.Size = new System.Drawing.Size(702, 372);
            this.tabProjects.TabIndex = 1;
            this.tabProjects.Text = "Projekty";
            this.tabProjects.UseVisualStyleBackColor = true;
            // 
            // gridProject
            // 
            this.gridProject.AllowUserToAddRows = false;
            this.gridProject.AllowUserToDeleteRows = false;
            this.gridProject.AllowUserToResizeRows = false;
            this.gridProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.coliumnType});
            this.gridProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProject.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridProject.Location = new System.Drawing.Point(3, 34);
            this.gridProject.Name = "gridProject";
            this.gridProject.RowHeadersVisible = false;
            this.gridProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProject.Size = new System.Drawing.Size(696, 335);
            this.gridProject.TabIndex = 3;
            this.gridProject.SelectionChanged += new System.EventHandler(this.gridProject_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Kod";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nazwa";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // coliumnType
            // 
            this.coliumnType.HeaderText = "Typ";
            this.coliumnType.Name = "coliumnType";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnProjectSearch);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.btnProjectDelete);
            this.panel2.Controls.Add(this.btnProjectEdit);
            this.panel2.Controls.Add(this.btnProjectAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 31);
            this.panel2.TabIndex = 2;
            // 
            // btnProjectSearch
            // 
            this.btnProjectSearch.Location = new System.Drawing.Point(575, 3);
            this.btnProjectSearch.Name = "btnProjectSearch";
            this.btnProjectSearch.Size = new System.Drawing.Size(75, 23);
            this.btnProjectSearch.TabIndex = 4;
            this.btnProjectSearch.Text = "Szukaj";
            this.btnProjectSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(248, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(321, 20);
            this.textBox1.TabIndex = 3;
            // 
            // btnProjectDelete
            // 
            this.btnProjectDelete.Enabled = false;
            this.btnProjectDelete.Location = new System.Drawing.Point(167, 3);
            this.btnProjectDelete.Name = "btnProjectDelete";
            this.btnProjectDelete.Size = new System.Drawing.Size(75, 23);
            this.btnProjectDelete.TabIndex = 2;
            this.btnProjectDelete.Text = "Usuń";
            this.btnProjectDelete.UseVisualStyleBackColor = true;
            this.btnProjectDelete.Click += new System.EventHandler(this.btnProjectDelete_Click);
            // 
            // btnProjectEdit
            // 
            this.btnProjectEdit.Enabled = false;
            this.btnProjectEdit.Location = new System.Drawing.Point(86, 3);
            this.btnProjectEdit.Name = "btnProjectEdit";
            this.btnProjectEdit.Size = new System.Drawing.Size(75, 23);
            this.btnProjectEdit.TabIndex = 1;
            this.btnProjectEdit.Text = "Edytuj";
            this.btnProjectEdit.UseVisualStyleBackColor = true;
            this.btnProjectEdit.Click += new System.EventHandler(this.btnProjectEdit_Click);
            // 
            // btnProjectAdd
            // 
            this.btnProjectAdd.Location = new System.Drawing.Point(5, 3);
            this.btnProjectAdd.Name = "btnProjectAdd";
            this.btnProjectAdd.Size = new System.Drawing.Size(75, 23);
            this.btnProjectAdd.TabIndex = 0;
            this.btnProjectAdd.Text = "Dodaj";
            this.btnProjectAdd.UseVisualStyleBackColor = true;
            this.btnProjectAdd.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // tabTasks
            // 
            this.tabTasks.Controls.Add(this.gridTask);
            this.tabTasks.Controls.Add(this.panel3);
            this.tabTasks.Location = new System.Drawing.Point(4, 22);
            this.tabTasks.Name = "tabTasks";
            this.tabTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tabTasks.Size = new System.Drawing.Size(702, 372);
            this.tabTasks.TabIndex = 2;
            this.tabTasks.Text = "Zadania";
            this.tabTasks.UseVisualStyleBackColor = true;
            this.tabTasks.Enter += new System.EventHandler(this.tabTask_Enter);
            // 
            // gridTask
            // 
            this.gridTask.AllowUserToAddRows = false;
            this.gridTask.AllowUserToDeleteRows = false;
            this.gridTask.AllowUserToResizeRows = false;
            this.gridTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.gridTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTask.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridTask.Location = new System.Drawing.Point(3, 34);
            this.gridTask.Name = "gridTask";
            this.gridTask.RowHeadersVisible = false;
            this.gridTask.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTask.Size = new System.Drawing.Size(696, 335);
            this.gridTask.TabIndex = 4;
            this.gridTask.SelectionChanged += new System.EventHandler(this.gridTask_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "#";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Kod";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Nazwa";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnTaskSearch);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.btnTaskDelete);
            this.panel3.Controls.Add(this.btnTaskEdit);
            this.panel3.Controls.Add(this.btnTaskAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(696, 31);
            this.panel3.TabIndex = 3;
            // 
            // btnTaskSearch
            // 
            this.btnTaskSearch.Location = new System.Drawing.Point(575, 3);
            this.btnTaskSearch.Name = "btnTaskSearch";
            this.btnTaskSearch.Size = new System.Drawing.Size(75, 23);
            this.btnTaskSearch.TabIndex = 4;
            this.btnTaskSearch.Text = "Szukaj";
            this.btnTaskSearch.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(248, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(321, 20);
            this.textBox2.TabIndex = 3;
            // 
            // btnTaskDelete
            // 
            this.btnTaskDelete.Enabled = false;
            this.btnTaskDelete.Location = new System.Drawing.Point(167, 3);
            this.btnTaskDelete.Name = "btnTaskDelete";
            this.btnTaskDelete.Size = new System.Drawing.Size(75, 23);
            this.btnTaskDelete.TabIndex = 2;
            this.btnTaskDelete.Text = "Usuń";
            this.btnTaskDelete.UseVisualStyleBackColor = true;
            this.btnTaskDelete.Click += new System.EventHandler(this.btnTaskDelete_Click);
            // 
            // btnTaskEdit
            // 
            this.btnTaskEdit.Enabled = false;
            this.btnTaskEdit.Location = new System.Drawing.Point(86, 3);
            this.btnTaskEdit.Name = "btnTaskEdit";
            this.btnTaskEdit.Size = new System.Drawing.Size(75, 23);
            this.btnTaskEdit.TabIndex = 1;
            this.btnTaskEdit.Text = "Edytuj";
            this.btnTaskEdit.UseVisualStyleBackColor = true;
            this.btnTaskEdit.Click += new System.EventHandler(this.btnTaskEdit_Click);
            // 
            // btnTaskAdd
            // 
            this.btnTaskAdd.Location = new System.Drawing.Point(5, 3);
            this.btnTaskAdd.Name = "btnTaskAdd";
            this.btnTaskAdd.Size = new System.Drawing.Size(75, 23);
            this.btnTaskAdd.TabIndex = 0;
            this.btnTaskAdd.Text = "Dodaj";
            this.btnTaskAdd.UseVisualStyleBackColor = true;
            this.btnTaskAdd.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // tabBranches
            // 
            this.tabBranches.Controls.Add(this.gridBranch);
            this.tabBranches.Controls.Add(this.panel1);
            this.tabBranches.Location = new System.Drawing.Point(4, 22);
            this.tabBranches.Name = "tabBranches";
            this.tabBranches.Padding = new System.Windows.Forms.Padding(3);
            this.tabBranches.Size = new System.Drawing.Size(702, 372);
            this.tabBranches.TabIndex = 3;
            this.tabBranches.Text = "Oddziały";
            this.tabBranches.UseVisualStyleBackColor = true;
            this.tabBranches.Enter += new System.EventHandler(this.tabBranches_Enter);
            // 
            // gridBranch
            // 
            this.gridBranch.AllowUserToAddRows = false;
            this.gridBranch.AllowUserToDeleteRows = false;
            this.gridBranch.AllowUserToResizeRows = false;
            this.gridBranch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBranch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.branchNameColumn,
            this.uriColumn});
            this.gridBranch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBranch.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridBranch.Location = new System.Drawing.Point(3, 34);
            this.gridBranch.Name = "gridBranch";
            this.gridBranch.RowHeadersVisible = false;
            this.gridBranch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBranch.Size = new System.Drawing.Size(696, 335);
            this.gridBranch.TabIndex = 2;
            this.gridBranch.SelectionChanged += new System.EventHandler(this.gridBranch_SelectionChanged);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "#";
            this.idColumn.Name = "idColumn";
            // 
            // branchNameColumn
            // 
            this.branchNameColumn.HeaderText = "Oddział";
            this.branchNameColumn.Name = "branchNameColumn";
            // 
            // uriColumn
            // 
            this.uriColumn.HeaderText = "Adres";
            this.uriColumn.Name = "uriColumn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSync);
            this.panel1.Controls.Add(this.btnBranchDelete);
            this.panel1.Controls.Add(this.btnBranchEdit);
            this.panel1.Controls.Add(this.btnAddBranch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 31);
            this.panel1.TabIndex = 1;
            // 
            // btnSync
            // 
            this.btnSync.Enabled = false;
            this.btnSync.Location = new System.Drawing.Point(248, 3);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(75, 23);
            this.btnSync.TabIndex = 3;
            this.btnSync.Text = "Synchronizuj";
            this.btnSync.UseVisualStyleBackColor = true;
            // 
            // btnBranchDelete
            // 
            this.btnBranchDelete.Enabled = false;
            this.btnBranchDelete.Location = new System.Drawing.Point(167, 3);
            this.btnBranchDelete.Name = "btnBranchDelete";
            this.btnBranchDelete.Size = new System.Drawing.Size(75, 23);
            this.btnBranchDelete.TabIndex = 2;
            this.btnBranchDelete.Text = "Usuń";
            this.btnBranchDelete.UseVisualStyleBackColor = true;
            this.btnBranchDelete.Click += new System.EventHandler(this.btnBranchDelete_Click);
            // 
            // btnBranchEdit
            // 
            this.btnBranchEdit.Enabled = false;
            this.btnBranchEdit.Location = new System.Drawing.Point(86, 3);
            this.btnBranchEdit.Name = "btnBranchEdit";
            this.btnBranchEdit.Size = new System.Drawing.Size(75, 23);
            this.btnBranchEdit.TabIndex = 1;
            this.btnBranchEdit.Text = "Edytuj";
            this.btnBranchEdit.UseVisualStyleBackColor = true;
            this.btnBranchEdit.Click += new System.EventHandler(this.btnBranchEdit_Click);
            // 
            // btnAddBranch
            // 
            this.btnAddBranch.Location = new System.Drawing.Point(5, 3);
            this.btnAddBranch.Name = "btnAddBranch";
            this.btnAddBranch.Size = new System.Drawing.Size(75, 23);
            this.btnAddBranch.TabIndex = 0;
            this.btnAddBranch.Text = "Dodaj";
            this.btnAddBranch.UseVisualStyleBackColor = true;
            this.btnAddBranch.Click += new System.EventHandler(this.btnAddBranch_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 398);
            this.Controls.Add(this.tabEmployees);
            this.Name = "MainWindow";
            this.Text = "Timesheet Admin";
            this.tabEmployees.ResumeLayout(false);
            this.tabProjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProject)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabTasks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTask)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabBranches.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBranch)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEmployees;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabProjects;
        private System.Windows.Forms.TabPage tabTasks;
        private System.Windows.Forms.TabPage tabBranches;
        private System.Windows.Forms.DataGridView gridBranch;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBranchDelete;
        private System.Windows.Forms.Button btnBranchEdit;
        private System.Windows.Forms.Button btnAddBranch;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uriColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnProjectDelete;
        private System.Windows.Forms.Button btnProjectEdit;
        private System.Windows.Forms.Button btnProjectAdd;
        private System.Windows.Forms.Button btnProjectSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView gridProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn coliumnType;
        private System.Windows.Forms.DataGridView gridTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTaskSearch;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnTaskDelete;
        private System.Windows.Forms.Button btnTaskEdit;
        private System.Windows.Forms.Button btnTaskAdd;
    }
}

