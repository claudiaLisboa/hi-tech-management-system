namespace Solution_HitechSystem.GUI
{
    partial class BookForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            this.txtYearPublished = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblYearPublished = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBookId = new System.Windows.Forms.Label();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
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
            this.grpBookInformation = new System.Windows.Forms.GroupBox();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.txtSupplierId = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtQuantityOnHand = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblQuantityOnHand = new System.Windows.Forms.Label();
            this.btnCategory = new System.Windows.Forms.Button();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnAuthor = new System.Windows.Forms.Button();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthorId = new System.Windows.Forms.TextBox();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tipBooks = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdBooks)).BeginInit();
            this.grpBookInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtYearPublished
            // 
            this.txtYearPublished.Location = new System.Drawing.Point(189, 251);
            this.txtYearPublished.MaxLength = 4;
            this.txtYearPublished.Name = "txtYearPublished";
            this.txtYearPublished.Size = new System.Drawing.Size(239, 38);
            this.txtYearPublished.TabIndex = 7;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(189, 184);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(239, 38);
            this.txtISBN.TabIndex = 5;
            // 
            // lblYearPublished
            // 
            this.lblYearPublished.AutoSize = true;
            this.lblYearPublished.Location = new System.Drawing.Point(39, 254);
            this.lblYearPublished.Name = "lblYearPublished";
            this.lblYearPublished.Size = new System.Drawing.Size(75, 32);
            this.lblYearPublished.TabIndex = 6;
            this.lblYearPublished.Text = "Year";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(39, 187);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(80, 32);
            this.lblISBN.TabIndex = 4;
            this.lblISBN.Text = "ISBN";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1153, 39);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 68);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Cl&ear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(189, 120);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(239, 38);
            this.txtTitle.TabIndex = 3;
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(189, 53);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.ReadOnly = true;
            this.txtBookId.Size = new System.Drawing.Size(239, 38);
            this.txtBookId.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(39, 123);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(70, 32);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Location = new System.Drawing.Point(39, 56);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(110, 32);
            this.lblBookId.TabIndex = 0;
            this.lblBookId.Text = "Book Id";
            // 
            // lblSystemName
            // 
            this.lblSystemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSystemName.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSystemName.Font = new System.Drawing.Font("Bauhaus 93", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemName.Location = new System.Drawing.Point(0, 0);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(1385, 124);
            this.lblSystemName.TabIndex = 0;
            this.lblSystemName.Text = "Hi-Tech Management System";
            this.lblSystemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(254, 560);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(183, 68);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grdBooks
            // 
            this.grdBooks.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdBooks.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdBooks.Location = new System.Drawing.Point(28, 654);
            this.grdBooks.MultiSelect = false;
            this.grdBooks.Name = "grdBooks";
            this.grdBooks.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdBooks.RowTemplate.Height = 20;
            this.grdBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdBooks.Size = new System.Drawing.Size(1315, 407);
            this.grdBooks.TabIndex = 5;
            this.grdBooks.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdBooks_CellMouseDoubleClick);
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
            // grpBookInformation
            // 
            this.grpBookInformation.BackColor = System.Drawing.SystemColors.Control;
            this.grpBookInformation.Controls.Add(this.btnSupplier);
            this.grpBookInformation.Controls.Add(this.txtSupplier);
            this.grpBookInformation.Controls.Add(this.lblSupplier);
            this.grpBookInformation.Controls.Add(this.txtSupplierId);
            this.grpBookInformation.Controls.Add(this.txtUnitPrice);
            this.grpBookInformation.Controls.Add(this.txtQuantityOnHand);
            this.grpBookInformation.Controls.Add(this.lblUnitPrice);
            this.grpBookInformation.Controls.Add(this.lblQuantityOnHand);
            this.grpBookInformation.Controls.Add(this.btnCategory);
            this.grpBookInformation.Controls.Add(this.txtCategory);
            this.grpBookInformation.Controls.Add(this.lblCategory);
            this.grpBookInformation.Controls.Add(this.btnAuthor);
            this.grpBookInformation.Controls.Add(this.txtAuthor);
            this.grpBookInformation.Controls.Add(this.lblAuthor);
            this.grpBookInformation.Controls.Add(this.txtYearPublished);
            this.grpBookInformation.Controls.Add(this.txtISBN);
            this.grpBookInformation.Controls.Add(this.lblYearPublished);
            this.grpBookInformation.Controls.Add(this.lblISBN);
            this.grpBookInformation.Controls.Add(this.btnClear);
            this.grpBookInformation.Controls.Add(this.txtTitle);
            this.grpBookInformation.Controls.Add(this.txtBookId);
            this.grpBookInformation.Controls.Add(this.lblTitle);
            this.grpBookInformation.Controls.Add(this.lblBookId);
            this.grpBookInformation.Controls.Add(this.txtAuthorId);
            this.grpBookInformation.Controls.Add(this.txtCategoryId);
            this.grpBookInformation.Location = new System.Drawing.Point(28, 140);
            this.grpBookInformation.Name = "grpBookInformation";
            this.grpBookInformation.Size = new System.Drawing.Size(1315, 393);
            this.grpBookInformation.TabIndex = 1;
            this.grpBookInformation.TabStop = false;
            this.grpBookInformation.Text = "Book Information";
            // 
            // btnSupplier
            // 
            this.btnSupplier.AutoSize = true;
            this.btnSupplier.Location = new System.Drawing.Point(941, 51);
            this.btnSupplier.MinimumSize = new System.Drawing.Size(65, 38);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(65, 42);
            this.btnSupplier.TabIndex = 11;
            this.btnSupplier.Text = "...";
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(665, 53);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.ReadOnly = true;
            this.txtSupplier.Size = new System.Drawing.Size(271, 38);
            this.txtSupplier.TabIndex = 9;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(515, 56);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(121, 32);
            this.lblSupplier.TabIndex = 8;
            this.lblSupplier.Text = "Supplier";
            // 
            // txtSupplierId
            // 
            this.txtSupplierId.Enabled = false;
            this.txtSupplierId.Location = new System.Drawing.Point(692, 47);
            this.txtSupplierId.Name = "txtSupplierId";
            this.txtSupplierId.Size = new System.Drawing.Size(59, 38);
            this.txtSupplierId.TabIndex = 10;
            this.txtSupplierId.Visible = false;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(665, 318);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(163, 38);
            this.txtUnitPrice.TabIndex = 23;
            // 
            // txtQuantityOnHand
            // 
            this.txtQuantityOnHand.Location = new System.Drawing.Point(665, 251);
            this.txtQuantityOnHand.Name = "txtQuantityOnHand";
            this.txtQuantityOnHand.Size = new System.Drawing.Size(163, 38);
            this.txtQuantityOnHand.TabIndex = 21;
            this.tipBooks.SetToolTip(this.txtQuantityOnHand, "Quantity On Hand");
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(515, 321);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(80, 32);
            this.lblUnitPrice.TabIndex = 22;
            this.lblUnitPrice.Text = "Price";
            // 
            // lblQuantityOnHand
            // 
            this.lblQuantityOnHand.AutoSize = true;
            this.lblQuantityOnHand.Location = new System.Drawing.Point(515, 254);
            this.lblQuantityOnHand.Name = "lblQuantityOnHand";
            this.lblQuantityOnHand.Size = new System.Drawing.Size(79, 32);
            this.lblQuantityOnHand.TabIndex = 20;
            this.lblQuantityOnHand.Text = "QOH";
            this.tipBooks.SetToolTip(this.lblQuantityOnHand, "Quantity On Hand");
            // 
            // btnCategory
            // 
            this.btnCategory.AutoSize = true;
            this.btnCategory.Location = new System.Drawing.Point(941, 182);
            this.btnCategory.MinimumSize = new System.Drawing.Size(65, 38);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(65, 42);
            this.btnCategory.TabIndex = 19;
            this.btnCategory.Text = "...";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(665, 184);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.Size = new System.Drawing.Size(271, 38);
            this.txtCategory.TabIndex = 17;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(515, 187);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(130, 32);
            this.lblCategory.TabIndex = 16;
            this.lblCategory.Text = "Category";
            // 
            // btnAuthor
            // 
            this.btnAuthor.AutoSize = true;
            this.btnAuthor.Location = new System.Drawing.Point(941, 118);
            this.btnAuthor.MinimumSize = new System.Drawing.Size(65, 38);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Size = new System.Drawing.Size(65, 42);
            this.btnAuthor.TabIndex = 15;
            this.btnAuthor.Text = "...";
            this.btnAuthor.UseVisualStyleBackColor = true;
            this.btnAuthor.Click += new System.EventHandler(this.btnAuthor_Click);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(665, 120);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(271, 38);
            this.txtAuthor.TabIndex = 13;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(515, 123);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(99, 32);
            this.lblAuthor.TabIndex = 12;
            this.lblAuthor.Text = "Author";
            // 
            // txtAuthorId
            // 
            this.txtAuthorId.Enabled = false;
            this.txtAuthorId.Location = new System.Drawing.Point(692, 117);
            this.txtAuthorId.Name = "txtAuthorId";
            this.txtAuthorId.Size = new System.Drawing.Size(59, 38);
            this.txtAuthorId.TabIndex = 14;
            this.txtAuthorId.Visible = false;
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Enabled = false;
            this.txtCategoryId.Location = new System.Drawing.Point(692, 193);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(59, 38);
            this.txtCategoryId.TabIndex = 18;
            this.txtCategoryId.Visible = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(480, 560);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(183, 68);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1194, 1100);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(149, 68);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1016, 1100);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 68);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "&Save";
            this.tipBooks.SetToolTip(this.btnSave, "Persist data immediately to disk");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(28, 560);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(183, 68);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tipBooks
            // 
            this.tipBooks.IsBalloon = true;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1369, 1201);
            this.Controls.Add(this.lblSystemName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grdBooks);
            this.Controls.Add(this.grpBookInformation);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1401, 1210);
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hi-Tech Management System - Books";
            this.Load += new System.EventHandler(this.BookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBooks)).EndInit();
            this.grpBookInformation.ResumeLayout(false);
            this.grpBookInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtYearPublished;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblYearPublished;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView grdBooks;
        private System.Windows.Forms.GroupBox grpBookInformation;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthorId;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtQuantityOnHand;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblQuantityOnHand;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.TextBox txtSupplierId;
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
        private System.Windows.Forms.ToolTip tipBooks;
    }
}