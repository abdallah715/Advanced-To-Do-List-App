namespace To_Do_List_App
{
    partial class frmPomodoroTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPomodoroTimer));
            this.txtTask = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddTask = new Guna.UI2.WinForms.Guna2Button();
            this.lblAddTask = new System.Windows.Forms.Label();
            this.lblTaskDescription = new System.Windows.Forms.Label();
            this.btnTimer = new Guna.UI2.WinForms.Guna2Button();
            this.lblClarify = new System.Windows.Forms.Label();
            this.pbTimer = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTask
            // 
            this.txtTask.AutoRoundedCorners = true;
            this.txtTask.BorderRadius = 33;
            this.txtTask.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTask.DefaultText = "";
            this.txtTask.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTask.DisabledState.Parent = this.txtTask;
            this.txtTask.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTask.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTask.FocusedState.Parent = this.txtTask;
            this.txtTask.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtTask.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTask.HoverState.Parent = this.txtTask;
            this.txtTask.Location = new System.Drawing.Point(24, 41);
            this.txtTask.Margin = new System.Windows.Forms.Padding(5);
            this.txtTask.Name = "txtTask";
            this.txtTask.PasswordChar = '\0';
            this.txtTask.PlaceholderText = "";
            this.txtTask.SelectedText = "";
            this.txtTask.ShadowDecoration.Parent = this.txtTask;
            this.txtTask.Size = new System.Drawing.Size(379, 68);
            this.txtTask.TabIndex = 1;
            this.txtTask.TextChanged += new System.EventHandler(this.txtTask_TextChanged);
            this.txtTask.Click += new System.EventHandler(this.txtTask_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.AutoRoundedCorners = true;
            this.btnAddTask.BorderRadius = 33;
            this.btnAddTask.CheckedState.Parent = this.btnAddTask;
            this.btnAddTask.CustomImages.Parent = this.btnAddTask;
            this.btnAddTask.Enabled = false;
            this.btnAddTask.FillColor = System.Drawing.Color.DimGray;
            this.btnAddTask.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.HoverState.Parent = this.btnAddTask;
            this.btnAddTask.Location = new System.Drawing.Point(553, 41);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.ShadowDecoration.Parent = this.btnAddTask;
            this.btnAddTask.Size = new System.Drawing.Size(208, 68);
            this.btnAddTask.TabIndex = 10;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // lblAddTask
            // 
            this.lblAddTask.AutoSize = true;
            this.lblAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTask.Location = new System.Drawing.Point(131, 9);
            this.lblAddTask.Name = "lblAddTask";
            this.lblAddTask.Size = new System.Drawing.Size(145, 25);
            this.lblAddTask.TabIndex = 11;
            this.lblAddTask.Text = "Add your task";
            // 
            // lblTaskDescription
            // 
            this.lblTaskDescription.AutoSize = true;
            this.lblTaskDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskDescription.ForeColor = System.Drawing.Color.Red;
            this.lblTaskDescription.Location = new System.Drawing.Point(175, 63);
            this.lblTaskDescription.Name = "lblTaskDescription";
            this.lblTaskDescription.Size = new System.Drawing.Size(427, 46);
            this.lblTaskDescription.TabIndex = 12;
            this.lblTaskDescription.Text = "Here the task detials !";
            this.lblTaskDescription.Visible = false;
            // 
            // btnTimer
            // 
            this.btnTimer.AutoRoundedCorners = true;
            this.btnTimer.BorderRadius = 33;
            this.btnTimer.CheckedState.Parent = this.btnTimer;
            this.btnTimer.CustomImages.Parent = this.btnTimer;
            this.btnTimer.Enabled = false;
            this.btnTimer.FillColor = System.Drawing.Color.DimGray;
            this.btnTimer.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimer.ForeColor = System.Drawing.Color.White;
            this.btnTimer.HoverState.Parent = this.btnTimer;
            this.btnTimer.Location = new System.Drawing.Point(199, 159);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.ShadowDecoration.Parent = this.btnTimer;
            this.btnTimer.Size = new System.Drawing.Size(394, 68);
            this.btnTimer.TabIndex = 13;
            this.btnTimer.Text = "Start Timer";
            this.btnTimer.Visible = false;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // lblClarify
            // 
            this.lblClarify.AutoSize = true;
            this.lblClarify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClarify.Location = new System.Drawing.Point(178, 9);
            this.lblClarify.Name = "lblClarify";
            this.lblClarify.Size = new System.Drawing.Size(430, 25);
            this.lblClarify.TabIndex = 14;
            this.lblClarify.Text = "It is a Timer of 25 mim Work and 5 min Rest";
            this.lblClarify.Visible = false;
            // 
            // pbTimer
            // 
            this.pbTimer.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.pbTimer.Location = new System.Drawing.Point(88, 343);
            this.pbTimer.Name = "pbTimer";
            this.pbTimer.ProgressColor = System.Drawing.Color.Red;
            this.pbTimer.ShadowDecoration.Parent = this.pbTimer;
            this.pbTimer.Size = new System.Drawing.Size(656, 30);
            this.pbTimer.TabIndex = 15;
            this.pbTimer.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(355, 280);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(96, 36);
            this.lblTimer.TabIndex = 16;
            this.lblTimer.Text = "00:00";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(354, 392);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(119, 39);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "Status";
            // 
            // frmPomodoroTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 483);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.pbTimer);
            this.Controls.Add(this.lblClarify);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.lblTaskDescription);
            this.Controls.Add(this.lblAddTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.txtTask);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPomodoroTimer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomodoro Timer";
            this.Load += new System.EventHandler(this.frmPomodoroTimer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtTask;
        private Guna.UI2.WinForms.Guna2Button btnAddTask;
        private System.Windows.Forms.Label lblAddTask;
        private System.Windows.Forms.Label lblTaskDescription;
        private Guna.UI2.WinForms.Guna2Button btnTimer;
        private System.Windows.Forms.Label lblClarify;
        private Guna.UI2.WinForms.Guna2ProgressBar pbTimer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblStatus;
    }
}