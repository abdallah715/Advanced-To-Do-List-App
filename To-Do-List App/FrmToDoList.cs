using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoListBusinessLayer;

namespace To_Do_List_App
{
    public partial class FrmMainToDoListScreen : Form
    {
        DateTime SelectedDate = DateTime.Now.Date;
        int totalTasks = 0;
        int CompleteTasks = 0;

        public FrmMainToDoListScreen()
        {
            InitializeComponent();
            dgvtodolist.CellValueChanged += dgvtodolist_CellValueChanged;
        }
        private void MarkCompleteRowsAsReadOnly()
        {
            foreach (DataGridViewRow row in dgvtodolist.Rows)
            {
                // Check if the Status column (index 6) has the value "Complete"
                if (row.Cells[6].Value != null && row.Cells[6].Value.ToString() == "Complete")
                {
                    // Apply red background and white text color for visibility
                    row.DefaultCellStyle.BackColor = Color.Green;
                    row.DefaultCellStyle.ForeColor = Color.White;
                    row.Frozen = true;

                    // Make the row read-only
                    row.ReadOnly = true;
                }
            }
        }
        private void CalculateProgress()
        {
            if (SelectedDate.Date == DateTime.Now.Date)
            {
                CompleteTasks = clsToDoListRow.GetAllComplete().Rows.Count;
                if (totalTasks == 0)
                {
                    rgProgress.Value = 0;
                    return;
                }
                float CompletePercentage = (float)CompleteTasks / totalTasks * 100;
                rgProgress.Value = (int)CompletePercentage;
                rgProgress.ProgressColor = Color.Red;
                if (CompletePercentage == 100)
                {
                    rgProgress.ProgressColor = Color.Green;
                    rgProgress.Value = 100;
                }
                rgProgress.Visible = true;
            }
            else
            {
                rgProgress.Visible = false;

            }

        }
        private void EditProperites()
        {
            btnAddTask.Enabled = true;
            btnDeleteTask.Enabled = true;
            dgvtodolist.Visible = true;
            lblNoTasks.Visible = false;
            dgvtodolist.Columns[0].Visible = false;
            dgvtodolist.Columns[1].ReadOnly = false;
            dgvtodolist.Columns[2].ReadOnly = false;
            dgvtodolist.Columns[3].ReadOnly = true;
            dgvtodolist.Columns[4].ReadOnly = true;
            dgvtodolist.Columns[5].ReadOnly = true;
            dgvtodolist.Columns[6].ReadOnly = true;
            dgvtodolist.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvtodolist.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            MarkCompleteRowsAsReadOnly();
        }
        private void LoadAlltodolist()
        {
            DataTable LoadedData = clsToDoListRow.GetAllTasks(SelectedDate.Date);
            if (LoadedData != null)
            {
                dgvtodolist.DataSource = clsToDoListRow.GetAllTasks(SelectedDate.Date);
                totalTasks = LoadedData.Rows.Count;
                
                CalculateProgress();
                EditProperites();
            }
            else
            {
                lblNoTasks.Visible = true;
                dgvtodolist.Visible = false;
                btnAddTask.Enabled = false;
                btnDeleteTask.Enabled = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAlltodolist();
            dtPicker.Format = DateTimePickerFormat.Custom;
            dtPicker.CustomFormat = "dd/MM/yyyy";
            dtPicker.Value = DateTime.Now;
            

        }
        private void btnChangeCategory_Click(object sender, EventArgs e)
        {
            frmCategories categories = new frmCategories(lblCategoryName.Text);
            categories.DataBack += categories_DataBack;// Subscribe to the Event 
            categories.ShowDialog();
        }
        private void categories_DataBack(int CategoryID, string CategoryName)
        {
            lblCategoryName.Text = CategoryName;
            lblCategoryName.Tag = CategoryID;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            // Prompt user for the text
            string DescriptionText = PromptForRadioButtonText();

            // Check if the text is not empty
            if (!string.IsNullOrEmpty(DescriptionText))
            {

                clsToDoListRow newRow = new clsToDoListRow();
                newRow.Description = DescriptionText;
                newRow.CategoryName = lblCategoryName.Text.ToString();
                newRow.CategoryID = int.Parse(lblCategoryName.Tag.ToString());
                if (newRow.Save())
                {
                    LoadAlltodolist();
                }

                //newCategory.AddNewCategory(DescriptionText);
                //LoadCategories();

            }
        }
        private string PromptForRadioButtonText()
        {
            // Simple input dialog using InputBox (or a custom form for better UI)
            string promptValue = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter Description Text:", "Add New Task", "");

            return promptValue;
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            dgvtodolist.DataSource = clsToDoListRow.GetAllPending();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadAlltodolist();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            dgvtodolist.DataSource = clsToDoListRow.GetAllComplete();
            dgvtodolist.Columns[0].Visible = false;
            MarkCompleteRowsAsReadOnly();

        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (dgvtodolist.SelectedRows.Count > 0)
            {
                // Get the selected row
                var selectedRow = dgvtodolist.SelectedRows[0];

                // Get the ID from the first column (assuming it's at index 0)
                int taskId = Convert.ToInt32(selectedRow.Cells[0].Value);

                // Confirm deletion (optional)
                var result = MessageBox.Show("Are you sure you want to delete this task?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    clsToDoListRow.DeleteTaskById(taskId);
                    LoadAlltodolist();
                }
            }
        }


        private void dgvtodolist_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the changed cell is in the Description column
            if (e.ColumnIndex == 2) // Assuming the Description column is at index 2
            {
                var selectedRow = dgvtodolist.Rows[e.RowIndex];
                int taskId = Convert.ToInt32(selectedRow.Cells[0].Value); // Get the ID
                string newDescription = selectedRow.Cells[e.ColumnIndex].Value?.ToString(); // Get the new Description

                // Update the Description in the database
                clsToDoListRow.UpdateDescription(taskId, newDescription);
            }
            // Check if the changed cell is in the IsDone checkbox column
            else if (e.ColumnIndex == 1) // Assuming the IsDone column is at index 2
            {
                var selectedRow = dgvtodolist.Rows[e.RowIndex];
                int taskId = Convert.ToInt32(selectedRow.Cells[0].Value); // Get the ID
                bool isDone = Convert.ToBoolean(selectedRow.Cells[e.ColumnIndex].Value); // Get the new IsDone value

                // Update the IsDone status in the database
                clsToDoListRow.UpdateIsDone(taskId, isDone);

            }
            LoadAlltodolist();
        }

        private void dtPicker_ValueChanged(object sender, EventArgs e)
        {
            SelectedDate = dtPicker.Value;
            LoadAlltodolist();
        }

        private void btnPomodoroTimer_Click(object sender, EventArgs e)
        {
            frmPomodoroTimer frmPomodoroTimer = new frmPomodoroTimer();
            frmPomodoroTimer.ShowDialog();

        }
    }
}
