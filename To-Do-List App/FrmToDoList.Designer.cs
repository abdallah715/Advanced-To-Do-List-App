namespace To_Do_List_App
{
    partial class FrmMainToDoListScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainToDoListScreen));
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.dgvtodolist = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAddTask = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteTask = new Guna.UI2.WinForms.Guna2Button();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChangeCategory = new Guna.UI2.WinForms.Guna2Button();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.lblNoTasks = new System.Windows.Forms.Label();
            this.rgProgress = new Guna.UI2.WinForms.Guna2RadialGauge();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPomodoroTimer = new Guna.UI2.WinForms.Guna2Button();
            this.btnComplete = new Guna.UI2.WinForms.Guna2Button();
            this.btnPending = new Guna.UI2.WinForms.Guna2Button();
            this.btnAll = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtodolist)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(381, -3);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(23, 834);
            this.guna2VSeparator1.TabIndex = 1;
            // 
            // dgvtodolist
            // 
            this.dgvtodolist.AllowUserToAddRows = false;
            this.dgvtodolist.AllowUserToDeleteRows = false;
            this.dgvtodolist.AllowUserToResizeColumns = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvtodolist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvtodolist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtodolist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvtodolist.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvtodolist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvtodolist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvtodolist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtodolist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvtodolist.ColumnHeadersHeight = 29;
            this.dgvtodolist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtodolist.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvtodolist.EnableHeadersVisualStyles = false;
            this.dgvtodolist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dgvtodolist.Location = new System.Drawing.Point(395, 238);
            this.dgvtodolist.Name = "dgvtodolist";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtodolist.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvtodolist.RowHeadersVisible = false;
            this.dgvtodolist.RowHeadersWidth = 51;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.dgvtodolist.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvtodolist.RowTemplate.Height = 24;
            this.dgvtodolist.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvtodolist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtodolist.ShowEditingIcon = false;
            this.dgvtodolist.Size = new System.Drawing.Size(990, 593);
            this.dgvtodolist.TabIndex = 8;
            this.dgvtodolist.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvtodolist.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvtodolist.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvtodolist.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvtodolist.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvtodolist.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvtodolist.ThemeStyle.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvtodolist.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dgvtodolist.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvtodolist.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvtodolist.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvtodolist.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvtodolist.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvtodolist.ThemeStyle.HeaderStyle.Height = 29;
            this.dgvtodolist.ThemeStyle.ReadOnly = false;
            this.dgvtodolist.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvtodolist.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvtodolist.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvtodolist.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvtodolist.ThemeStyle.RowsStyle.Height = 24;
            this.dgvtodolist.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvtodolist.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvtodolist.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtodolist_CellValueChanged);
            // 
            // btnAddTask
            // 
            this.btnAddTask.AutoRoundedCorners = true;
            this.btnAddTask.BorderRadius = 33;
            this.btnAddTask.CheckedState.Parent = this.btnAddTask;
            this.btnAddTask.CustomImages.Parent = this.btnAddTask;
            this.btnAddTask.FillColor = System.Drawing.Color.DimGray;
            this.btnAddTask.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.HoverState.Parent = this.btnAddTask;
            this.btnAddTask.Location = new System.Drawing.Point(901, 153);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.ShadowDecoration.Parent = this.btnAddTask;
            this.btnAddTask.Size = new System.Drawing.Size(208, 68);
            this.btnAddTask.TabIndex = 9;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.AutoRoundedCorners = true;
            this.btnDeleteTask.BorderRadius = 33;
            this.btnDeleteTask.CheckedState.Parent = this.btnDeleteTask;
            this.btnDeleteTask.CustomImages.Parent = this.btnDeleteTask;
            this.btnDeleteTask.FillColor = System.Drawing.Color.DimGray;
            this.btnDeleteTask.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTask.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTask.HoverState.Parent = this.btnDeleteTask;
            this.btnDeleteTask.Location = new System.Drawing.Point(1143, 153);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.ShadowDecoration.Parent = this.btnDeleteTask;
            this.btnDeleteTask.Size = new System.Drawing.Size(208, 68);
            this.btnDeleteTask.TabIndex = 10;
            this.btnDeleteTask.Text = "Delete Task";
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.BackColor = System.Drawing.Color.Green;
            this.lblCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryName.ForeColor = System.Drawing.Color.Snow;
            this.lblCategoryName.Location = new System.Drawing.Point(469, 55);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(186, 46);
            this.lblCategoryName.TabIndex = 12;
            this.lblCategoryName.Tag = "1";
            this.lblCategoryName.Text = "Personal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(410, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 46);
            this.label2.TabIndex = 13;
            this.label2.Text = "Current Category";
            // 
            // btnChangeCategory
            // 
            this.btnChangeCategory.AutoRoundedCorners = true;
            this.btnChangeCategory.BorderRadius = 33;
            this.btnChangeCategory.CheckedState.Parent = this.btnChangeCategory;
            this.btnChangeCategory.CustomImages.Parent = this.btnChangeCategory;
            this.btnChangeCategory.FillColor = System.Drawing.Color.DimGray;
            this.btnChangeCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnChangeCategory.ForeColor = System.Drawing.Color.White;
            this.btnChangeCategory.HoverState.Parent = this.btnChangeCategory;
            this.btnChangeCategory.Location = new System.Drawing.Point(459, 137);
            this.btnChangeCategory.Name = "btnChangeCategory";
            this.btnChangeCategory.ShadowDecoration.Parent = this.btnChangeCategory;
            this.btnChangeCategory.Size = new System.Drawing.Size(208, 68);
            this.btnChangeCategory.TabIndex = 14;
            this.btnChangeCategory.Text = "Change Category";
            this.btnChangeCategory.Click += new System.EventHandler(this.btnChangeCategory_Click);
            // 
            // dtPicker
            // 
            this.dtPicker.CalendarMonthBackground = System.Drawing.SystemColors.Highlight;
            this.dtPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPicker.Location = new System.Drawing.Point(72, 17);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(238, 38);
            this.dtPicker.TabIndex = 15;
            this.dtPicker.Value = new System.DateTime(2024, 10, 31, 8, 40, 20, 0);
            this.dtPicker.ValueChanged += new System.EventHandler(this.dtPicker_ValueChanged);
            // 
            // lblNoTasks
            // 
            this.lblNoTasks.AutoSize = true;
            this.lblNoTasks.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoTasks.Location = new System.Drawing.Point(564, 284);
            this.lblNoTasks.Name = "lblNoTasks";
            this.lblNoTasks.Size = new System.Drawing.Size(605, 71);
            this.lblNoTasks.TabIndex = 16;
            this.lblNoTasks.Text = "No tasks for the selected date.";
            this.lblNoTasks.Visible = false;
            // 
            // rgProgress
            // 
            this.rgProgress.Font = new System.Drawing.Font("Verdana", 8.2F);
            this.rgProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.rgProgress.Location = new System.Drawing.Point(45, 84);
            this.rgProgress.MinimumSize = new System.Drawing.Size(30, 30);
            this.rgProgress.Name = "rgProgress";
            this.rgProgress.ProgressColor = System.Drawing.Color.Red;
            this.rgProgress.Size = new System.Drawing.Size(288, 288);
            this.rgProgress.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Percentage of Achievements";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(131, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 31);
            this.label3.TabIndex = 19;
            this.label3.Text = "Today";
            // 
            // btnPomodoroTimer
            // 
            this.btnPomodoroTimer.BackColor = System.Drawing.Color.Transparent;
            this.btnPomodoroTimer.CheckedState.Parent = this.btnPomodoroTimer;
            this.btnPomodoroTimer.CustomImages.Parent = this.btnPomodoroTimer;
            this.btnPomodoroTimer.FillColor = System.Drawing.Color.Transparent;
            this.btnPomodoroTimer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPomodoroTimer.ForeColor = System.Drawing.Color.White;
            this.btnPomodoroTimer.HoverState.Parent = this.btnPomodoroTimer;
            this.btnPomodoroTimer.Image = global::To_Do_List_App.Properties.Resources.pomodoro_timer;
            this.btnPomodoroTimer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPomodoroTimer.ImageSize = new System.Drawing.Size(35, 35);
            this.btnPomodoroTimer.Location = new System.Drawing.Point(12, 698);
            this.btnPomodoroTimer.Name = "btnPomodoroTimer";
            this.btnPomodoroTimer.ShadowDecoration.Parent = this.btnPomodoroTimer;
            this.btnPomodoroTimer.Size = new System.Drawing.Size(309, 45);
            this.btnPomodoroTimer.TabIndex = 20;
            this.btnPomodoroTimer.Text = "Pomodoro Timer";
            this.btnPomodoroTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPomodoroTimer.Click += new System.EventHandler(this.btnPomodoroTimer_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.Transparent;
            this.btnComplete.CheckedState.Parent = this.btnComplete;
            this.btnComplete.CustomImages.Parent = this.btnComplete;
            this.btnComplete.FillColor = System.Drawing.Color.Transparent;
            this.btnComplete.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.ForeColor = System.Drawing.Color.White;
            this.btnComplete.HoverState.Parent = this.btnComplete;
            this.btnComplete.Image = global::To_Do_List_App.Properties.Resources.done;
            this.btnComplete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnComplete.ImageSize = new System.Drawing.Size(35, 35);
            this.btnComplete.Location = new System.Drawing.Point(12, 626);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.ShadowDecoration.Parent = this.btnComplete;
            this.btnComplete.Size = new System.Drawing.Size(309, 45);
            this.btnComplete.TabIndex = 7;
            this.btnComplete.Text = "Complete";
            this.btnComplete.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnPending
            // 
            this.btnPending.BackColor = System.Drawing.Color.Transparent;
            this.btnPending.CheckedState.Parent = this.btnPending;
            this.btnPending.CustomImages.Parent = this.btnPending;
            this.btnPending.FillColor = System.Drawing.Color.Transparent;
            this.btnPending.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPending.ForeColor = System.Drawing.Color.White;
            this.btnPending.HoverState.Parent = this.btnPending;
            this.btnPending.Image = ((System.Drawing.Image)(resources.GetObject("btnPending.Image")));
            this.btnPending.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPending.ImageSize = new System.Drawing.Size(35, 35);
            this.btnPending.Location = new System.Drawing.Point(12, 557);
            this.btnPending.Name = "btnPending";
            this.btnPending.ShadowDecoration.Parent = this.btnPending;
            this.btnPending.Size = new System.Drawing.Size(309, 45);
            this.btnPending.TabIndex = 6;
            this.btnPending.Text = "Pending";
            this.btnPending.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPending.Click += new System.EventHandler(this.btnPending_Click);
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.Transparent;
            this.btnAll.CheckedState.Parent = this.btnAll;
            this.btnAll.CustomImages.Parent = this.btnAll;
            this.btnAll.FillColor = System.Drawing.Color.Transparent;
            this.btnAll.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.White;
            this.btnAll.HoverState.Parent = this.btnAll;
            this.btnAll.Image = global::To_Do_List_App.Properties.Resources.check_list;
            this.btnAll.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAll.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAll.Location = new System.Drawing.Point(12, 485);
            this.btnAll.Name = "btnAll";
            this.btnAll.ShadowDecoration.Parent = this.btnAll;
            this.btnAll.Size = new System.Drawing.Size(309, 45);
            this.btnAll.TabIndex = 5;
            this.btnAll.Text = "All";
            this.btnAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // FrmMainToDoListScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1385, 833);
            this.Controls.Add(this.btnPomodoroTimer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rgProgress);
            this.Controls.Add(this.lblNoTasks);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.btnChangeCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.dgvtodolist);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnPending);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.guna2VSeparator1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMainToDoListScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To-Do-List";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtodolist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2Button btnComplete;
        private Guna.UI2.WinForms.Guna2Button btnPending;
        private Guna.UI2.WinForms.Guna2Button btnAll;
        private Guna.UI2.WinForms.Guna2DataGridView dgvtodolist;
        private Guna.UI2.WinForms.Guna2Button btnAddTask;
        private Guna.UI2.WinForms.Guna2Button btnDeleteTask;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnChangeCategory;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Label lblNoTasks;
        private Guna.UI2.WinForms.Guna2RadialGauge rgProgress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnPomodoroTimer;
    }
}