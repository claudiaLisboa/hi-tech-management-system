namespace Solution_HitechSystem.GUI
{
    partial class SelectProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectProductForm));
            this.grpBooks = new System.Windows.Forms.GroupBox();
            this.btnSelectBook = new System.Windows.Forms.Button();
            this.grdBooks = new System.Windows.Forms.DataGridView();
            this.colBookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYearPublished = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthorFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoryDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantityOnHand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpSoftwares = new System.Windows.Forms.GroupBox();
            this.btnSelectSoftware = new System.Windows.Forms.Button();
            this.grdSoftwares = new System.Windows.Forms.DataGridView();
            this.colSoftwareId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBooks)).BeginInit();
            this.grpSoftwares.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSoftwares)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBooks
            // 
            this.grpBooks.BackColor = System.Drawing.SystemColors.Control;
            this.grpBooks.Controls.Add(this.btnSelectBook);
            this.grpBooks.Controls.Add(this.grdBooks);
            this.grpBooks.Location = new System.Drawing.Point(25, 28);
            this.grpBooks.Name = "grpBooks";
            this.grpBooks.Size = new System.Drawing.Size(1400, 585);
            this.grpBooks.TabIndex = 0;
            this.grpBooks.TabStop = false;
            this.grpBooks.Text = "[  Books  ]";
            // 
            // btnSelectBook
            // 
            this.btnSelectBook.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSelectBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectBook.Location = new System.Drawing.Point(37, 479);
            this.btnSelectBook.Name = "btnSelectBook";
            this.btnSelectBook.Size = new System.Drawing.Size(302, 68);
            this.btnSelectBook.TabIndex = 1;
            this.btnSelectBook.Text = "Select &Book";
            this.btnSelectBook.UseVisualStyleBackColor = true;
            this.btnSelectBook.Click += new System.EventHandler(this.btnSelectBook_Click);
            // 
            // grdBooks
            // 
            this.grdBooks.AllowUserToAddRows = false;
            this.grdBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBookId,
            this.colProductName,
            this.colISBN,
            this.colYearPublished,
            this.colSupplierId,
            this.colSupplierName,
            this.colAuthorId,
            this.colAuthorFullName,
            this.colCategoryId,
            this.colCategoryDescription,
            this.colQuantityOnHand,
            this.colUnitPrice});
            this.grdBooks.Location = new System.Drawing.Point(37, 53);
            this.grdBooks.MultiSelect = false;
            this.grdBooks.Name = "grdBooks";
            this.grdBooks.ReadOnly = true;
            this.grdBooks.RowTemplate.Height = 20;
            this.grdBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdBooks.Size = new System.Drawing.Size(1315, 407);
            this.grdBooks.TabIndex = 0;
            // 
            // colBookId
            // 
            this.colBookId.HeaderText = "Book Id";
            this.colBookId.Name = "colBookId";
            this.colBookId.ReadOnly = true;
            // 
            // colProductName
            // 
            this.colProductName.HeaderText = "Title";
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            // 
            // colISBN
            // 
            this.colISBN.HeaderText = "ISBN";
            this.colISBN.Name = "colISBN";
            this.colISBN.ReadOnly = true;
            // 
            // colYearPublished
            // 
            this.colYearPublished.HeaderText = "Year Published";
            this.colYearPublished.Name = "colYearPublished";
            this.colYearPublished.ReadOnly = true;
            // 
            // colSupplierId
            // 
            this.colSupplierId.HeaderText = "Supplier Id";
            this.colSupplierId.Name = "colSupplierId";
            this.colSupplierId.ReadOnly = true;
            this.colSupplierId.Visible = false;
            // 
            // colSupplierName
            // 
            this.colSupplierName.HeaderText = "Supplier";
            this.colSupplierName.Name = "colSupplierName";
            this.colSupplierName.ReadOnly = true;
            // 
            // colAuthorId
            // 
            this.colAuthorId.HeaderText = "Author Id";
            this.colAuthorId.Name = "colAuthorId";
            this.colAuthorId.ReadOnly = true;
            this.colAuthorId.Visible = false;
            // 
            // colAuthorFullName
            // 
            this.colAuthorFullName.HeaderText = "Author";
            this.colAuthorFullName.Name = "colAuthorFullName";
            this.colAuthorFullName.ReadOnly = true;
            // 
            // colCategoryId
            // 
            this.colCategoryId.HeaderText = "Category Id";
            this.colCategoryId.Name = "colCategoryId";
            this.colCategoryId.ReadOnly = true;
            this.colCategoryId.Visible = false;
            // 
            // colCategoryDescription
            // 
            this.colCategoryDescription.HeaderText = "Category";
            this.colCategoryDescription.Name = "colCategoryDescription";
            this.colCategoryDescription.ReadOnly = true;
            // 
            // colQuantityOnHand
            // 
            this.colQuantityOnHand.HeaderText = "QOH";
            this.colQuantityOnHand.Name = "colQuantityOnHand";
            this.colQuantityOnHand.ReadOnly = true;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.HeaderText = "Unit Price";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.ReadOnly = true;
            // 
            // grpSoftwares
            // 
            this.grpSoftwares.BackColor = System.Drawing.SystemColors.Control;
            this.grpSoftwares.Controls.Add(this.btnSelectSoftware);
            this.grpSoftwares.Controls.Add(this.grdSoftwares);
            this.grpSoftwares.Location = new System.Drawing.Point(25, 653);
            this.grpSoftwares.Name = "grpSoftwares";
            this.grpSoftwares.Size = new System.Drawing.Size(1400, 595);
            this.grpSoftwares.TabIndex = 1;
            this.grpSoftwares.TabStop = false;
            this.grpSoftwares.Text = "[  Softwares  ]";
            // 
            // btnSelectSoftware
            // 
            this.btnSelectSoftware.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSelectSoftware.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectSoftware.Location = new System.Drawing.Point(37, 498);
            this.btnSelectSoftware.Name = "btnSelectSoftware";
            this.btnSelectSoftware.Size = new System.Drawing.Size(302, 68);
            this.btnSelectSoftware.TabIndex = 1;
            this.btnSelectSoftware.Text = "Select &Software";
            this.btnSelectSoftware.UseVisualStyleBackColor = true;
            this.btnSelectSoftware.Click += new System.EventHandler(this.btnSelectSoftware_Click);
            // 
            // grdSoftwares
            // 
            this.grdSoftwares.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSoftwares.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdSoftwares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSoftwares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSoftwareId,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdSoftwares.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdSoftwares.Location = new System.Drawing.Point(37, 64);
            this.grdSoftwares.MultiSelect = false;
            this.grdSoftwares.Name = "grdSoftwares";
            this.grdSoftwares.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSoftwares.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdSoftwares.RowTemplate.Height = 20;
            this.grdSoftwares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSoftwares.Size = new System.Drawing.Size(1315, 407);
            this.grdSoftwares.TabIndex = 0;
            // 
            // colSoftwareId
            // 
            this.colSoftwareId.HeaderText = "Software Id";
            this.colSoftwareId.Name = "colSoftwareId";
            this.colSoftwareId.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Supplier Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Supplier";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Category Id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Category";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "QOH";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Unit Price";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(1276, 1272);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(149, 68);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SelectProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1457, 1368);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpSoftwares);
            this.Controls.Add(this.grpBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hi-Tech Management System - Select Product";
            this.Load += new System.EventHandler(this.SelectProductForm_Load);
            this.grpBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBooks)).EndInit();
            this.grpSoftwares.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSoftwares)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBooks;
        private System.Windows.Forms.Button btnSelectBook;
        private System.Windows.Forms.DataGridView grdBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYearPublished;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthorFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantityOnHand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.GroupBox grpSoftwares;
        private System.Windows.Forms.Button btnSelectSoftware;
        private System.Windows.Forms.DataGridView grdSoftwares;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoftwareId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btnClose;
    }
}