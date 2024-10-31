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
    public partial class frmCategories : Form
    {
        private string _CurrentCategory;
        public delegate void DataBackEventHandler(int CategoryID, string CategoryName);
        //Declare an Event using the Delegate 
        public event DataBackEventHandler DataBack;
        public frmCategories(string CurrentCategory)
        {
            InitializeComponent();
            _CurrentCategory = CurrentCategory;
        }
        private void LoadCategories()
        {
            DataTable Categories = clsCategories.GetAllCategories();

            gbCategories.Controls.Clear();

            // Starting vertical position for the first RadioButton
            int topPosition = 40;
            int verticalSpacing = 50; // Space between each radio button

            foreach (DataRow row in Categories.Rows)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.Text = row["CategoryName"].ToString();
                radioButton.Tag = int.Parse(row["ID"].ToString());
                radioButton.Top = topPosition;
                radioButton.Left = 10; // Set a fixed horizontal position
                radioButton.AutoSize = true;

                // Add the RadioButton to the GroupBox
                gbCategories.Controls.Add(radioButton);

                // Increase the top position for the next RadioButton
                topPosition += verticalSpacing;
            }
            }
        private void frmCategories_Load(object sender, EventArgs e)
        {
            
            LoadCategories();

        }
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            // Prompt user for the text
            string radioText = PromptForRadioButtonText();

            // Check if the text is not empty
            if (!string.IsNullOrEmpty(radioText))
            {
                
                clsCategories newCategory = new clsCategories();
                newCategory.Categoryname = radioText;
                newCategory.AddNewCategory(radioText);
                LoadCategories();
               
            }
            
        }
        private string PromptForRadioButtonText()
        {
            // Simple input dialog using InputBox (or a custom form for better UI)
            string promptValue = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter text for the new category:", "Add New Category", "");

            return promptValue;
        }
        private RadioButton GetSelectedRadioButtonText()
        {
            // Loop through all controls in the GroupBox
            foreach (Control control in gbCategories.Controls)
            {
                // Check if the control is a RadioButton and if it is checked
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    // Return the text of the selected RadioButton
                    return radioButton;
                }
            }
            // Return empty if no RadioButton is selected
            return null;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string SelectedRatio = Convert.ToString( GetSelectedRadioButtonText().Text);
            if(SelectedRatio == _CurrentCategory)
            {
                MessageBox.Show("You Can't Delete the Current Category", "ToDoList");
            }
            else 
            {
                DialogResult YesOrNo = MessageBox.Show("Are you Sure you want to Delete !", "ToDoList", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
                if (YesOrNo == DialogResult.OK)
                {
                    clsCategories.DeleteCategory(SelectedRatio);
                    LoadCategories();
                }
               
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            RadioButton CurrentSelected = GetSelectedRadioButtonText();
            if (CurrentSelected != null)
            {
                DataBack?.Invoke((int)CurrentSelected.Tag, (string)CurrentSelected.Text);
                this.Close();
            }
        }
    }
}
