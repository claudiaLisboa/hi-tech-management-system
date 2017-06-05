namespace Solution_HitechSystem.GUI
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.btnAuthors = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnSoftwares = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAuthors
            // 
            this.btnAuthors.Location = new System.Drawing.Point(74, 319);
            this.btnAuthors.Name = "btnAuthors";
            this.btnAuthors.Size = new System.Drawing.Size(208, 68);
            this.btnAuthors.TabIndex = 2;
            this.btnAuthors.Text = "Authors...";
            this.btnAuthors.UseVisualStyleBackColor = true;
            this.btnAuthors.Click += new System.EventHandler(this.btnAuthors_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.Location = new System.Drawing.Point(314, 319);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(208, 68);
            this.btnCategories.TabIndex = 3;
            this.btnCategories.Text = "Categories...";
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Location = new System.Drawing.Point(550, 319);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(208, 68);
            this.btnSuppliers.TabIndex = 4;
            this.btnSuppliers.Text = "Suppliers...";
            this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.Location = new System.Drawing.Point(74, 55);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(311, 193);
            this.btnBooks.TabIndex = 0;
            this.btnBooks.Text = "Books...";
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnSoftwares
            // 
            this.btnSoftwares.Location = new System.Drawing.Point(447, 55);
            this.btnSoftwares.Name = "btnSoftwares";
            this.btnSoftwares.Size = new System.Drawing.Size(311, 193);
            this.btnSoftwares.TabIndex = 1;
            this.btnSoftwares.Text = "Softwares...";
            this.btnSoftwares.UseVisualStyleBackColor = true;
            this.btnSoftwares.Click += new System.EventHandler(this.btnSoftwares_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 427);
            this.Controls.Add(this.btnSoftwares);
            this.Controls.Add(this.btnBooks);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnCategories);
            this.Controls.Add(this.btnAuthors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hi-Tech Management System - Products";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAuthors;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnSoftwares;
    }
}