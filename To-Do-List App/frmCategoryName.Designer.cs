namespace To_Do_List_App
{
    partial class frmCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategories));
            this.gbCategories = new System.Windows.Forms.GroupBox();
            this.btnAddCategory = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnOk = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // gbCategories
            // 
            this.gbCategories.AutoSize = true;
            this.gbCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCategories.Location = new System.Drawing.Point(101, 12);
            this.gbCategories.Name = "gbCategories";
            this.gbCategories.Size = new System.Drawing.Size(633, 407);
            this.gbCategories.TabIndex = 0;
            this.gbCategories.TabStop = false;
            this.gbCategories.Text = "Select Category";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.CheckedState.Parent = this.btnAddCategory;
            this.btnAddCategory.CustomImages.Parent = this.btnAddCategory;
            this.btnAddCategory.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.HoverState.Parent = this.btnAddCategory;
            this.btnAddCategory.Location = new System.Drawing.Point(804, 74);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.PressedColor = System.Drawing.Color.IndianRed;
            this.btnAddCategory.ShadowDecoration.Parent = this.btnAddCategory;
            this.btnAddCategory.Size = new System.Drawing.Size(190, 45);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(804, 140);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PressedColor = System.Drawing.Color.IndianRed;
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(190, 45);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Category";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOk
            // 
            this.btnOk.CheckedState.Parent = this.btnOk;
            this.btnOk.CustomImages.Parent = this.btnOk;
            this.btnOk.FillColor = System.Drawing.Color.White;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.Black;
            this.btnOk.HoverState.Parent = this.btnOk;
            this.btnOk.Location = new System.Drawing.Point(804, 374);
            this.btnOk.Name = "btnOk";
            this.btnOk.PressedColor = System.Drawing.Color.IndianRed;
            this.btnOk.ShadowDecoration.Parent = this.btnOk;
            this.btnOk.Size = new System.Drawing.Size(190, 45);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(804, 446);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PressedColor = System.Drawing.Color.IndianRed;
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(190, 45);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Canel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1080, 518);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.gbCategories);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Category";
            this.Load += new System.EventHandler(this.frmCategories_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCategories;
        private Guna.UI2.WinForms.Guna2Button btnAddCategory;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnOk;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}