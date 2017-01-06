namespace pl.lodz.p.ftims.edu.pai.admin
{
    partial class EmployeeForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textLastname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboManager = new System.Windows.Forms.ComboBox();
            this.checkUserAccount = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 319);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(284, 30);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(84, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.textId);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.textName);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.textLastname);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.textEmail);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.comboManager);
            this.flowLayoutPanel2.Controls.Add(this.checkUserAccount);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(284, 319);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.flowLayoutPanel2.SetFlowBreak(this.label1, true);
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // textId
            // 
            this.flowLayoutPanel2.SetFlowBreak(this.textId, true);
            this.textId.Location = new System.Drawing.Point(6, 26);
            this.textId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.textId.Name = "textId";
            this.textId.ReadOnly = true;
            this.textId.Size = new System.Drawing.Size(185, 20);
            this.textId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.flowLayoutPanel2.SetFlowBreak(this.label2, true);
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Imię";
            // 
            // textName
            // 
            this.flowLayoutPanel2.SetFlowBreak(this.textName, true);
            this.textName.Location = new System.Drawing.Point(6, 78);
            this.textName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(185, 20);
            this.textName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.flowLayoutPanel2.SetFlowBreak(this.label3, true);
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nazwisko";
            // 
            // textLastname
            // 
            this.flowLayoutPanel2.SetFlowBreak(this.textLastname, true);
            this.textLastname.Location = new System.Drawing.Point(6, 130);
            this.textLastname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.textLastname.Name = "textLastname";
            this.textLastname.Size = new System.Drawing.Size(185, 20);
            this.textLastname.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.flowLayoutPanel2.SetFlowBreak(this.label4, true);
            this.label4.Location = new System.Drawing.Point(6, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "E-mail";
            // 
            // textEmail
            // 
            this.flowLayoutPanel2.SetFlowBreak(this.textEmail, true);
            this.textEmail.Location = new System.Drawing.Point(6, 182);
            this.textEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(185, 20);
            this.textEmail.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.flowLayoutPanel2.SetFlowBreak(this.label5, true);
            this.label5.Location = new System.Drawing.Point(6, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Manager";
            // 
            // comboManager
            // 
            this.flowLayoutPanel2.SetFlowBreak(this.comboManager, true);
            this.comboManager.FormattingEnabled = true;
            this.comboManager.Location = new System.Drawing.Point(6, 232);
            this.comboManager.Margin = new System.Windows.Forms.Padding(6, 0, 6, 3);
            this.comboManager.Name = "comboManager";
            this.comboManager.Size = new System.Drawing.Size(185, 21);
            this.comboManager.TabIndex = 11;
            // 
            // checkUserAccount
            // 
            this.checkUserAccount.AutoSize = true;
            this.checkUserAccount.Location = new System.Drawing.Point(6, 262);
            this.checkUserAccount.Margin = new System.Windows.Forms.Padding(6);
            this.checkUserAccount.Name = "checkUserAccount";
            this.checkUserAccount.Size = new System.Drawing.Size(121, 17);
            this.checkUserAccount.TabIndex = 12;
            this.checkUserAccount.Text = "Utwórz użytkownika";
            this.checkUserAccount.UseVisualStyleBackColor = true;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 349);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EmployeeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pracownik";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textId;
        public System.Windows.Forms.TextBox textName;
        public System.Windows.Forms.TextBox textLastname;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox comboManager;
        public System.Windows.Forms.CheckBox checkUserAccount;
    }
}