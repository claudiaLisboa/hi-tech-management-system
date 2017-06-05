namespace Solution_HitechSystem.GUI
{
    partial class SoftwareForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoftwareForm));
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
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.grpSoftwareInformation = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSoftwareName = new System.Windows.Forms.TextBox();
            this.txtSoftwareId = new System.Windows.Forms.TextBox();
            this.lblSoftwareName = new System.Windows.Forms.Label();
            this.lblSoftwareId = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tipSoftwares = new System.Windows.Forms.ToolTip(this.components);
            this.lblSystemName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grdSoftwares = new System.Windows.Forms.DataGridView();
            this.colSoftwareId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoryDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantityOnHand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpSoftwareInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSoftwares)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSupplier
            // 
            this.btnSupplier.AutoSize = true;
            this.btnSupplier.Location = new System.Drawing.Point(488, 183);
            this.btnSupplier.MinimumSize = new System.Drawing.Size(65, 38);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(65, 42);
            this.btnSupplier.TabIndex = 7;
            this.btnSupplier.Text = "...";
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(212, 185);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.ReadOnly = true;
            this.txtSupplier.Size = new System.Drawing.Size(271, 38);
            this.txtSupplier.TabIndex = 5;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(40, 188);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(121, 32);
            this.lblSupplier.TabIndex = 4;
            this.lblSupplier.Text = "Supplier";
            // 
            // txtSupplierId
            // 
            this.txtSupplierId.Enabled = false;
            this.txtSupplierId.Location = new System.Drawing.Point(260, 182);
            this.txtSupplierId.Name = "txtSupplierId";
            this.txtSupplierId.Size = new System.Drawing.Size(59, 38);
            this.txtSupplierId.TabIndex = 6;
            this.txtSupplierId.Visible = false;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(717, 121);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(163, 38);
            this.txtUnitPrice.TabIndex = 15;
            // 
            // txtQuantityOnHand
            // 
            this.txtQuantityOnHand.Location = new System.Drawing.Point(717, 54);
            this.txtQuantityOnHand.Name = "txtQuantityOnHand";
            this.txtQuantityOnHand.Size = new System.Drawing.Size(163, 38);
            this.txtQuantityOnHand.TabIndex = 13;
            this.tipSoftwares.SetToolTip(this.txtQuantityOnHand, "Quantity On Hand");
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(598, 124);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(80, 32);
            this.lblUnitPrice.TabIndex = 14;
            this.lblUnitPrice.Text = "Price";
            // 
            // lblQuantityOnHand
            // 
            this.lblQuantityOnHand.AutoSize = true;
            this.lblQuantityOnHand.Location = new System.Drawing.Point(598, 57);
            this.lblQuantityOnHand.Name = "lblQuantityOnHand";
            this.lblQuantityOnHand.Size = new System.Drawing.Size(79, 32);
            this.lblQuantityOnHand.TabIndex = 12;
            this.lblQuantityOnHand.Text = "QOH";
            this.tipSoftwares.SetToolTip(this.lblQuantityOnHand, "Quantity On Hand");
            // 
            // btnCategory
            // 
            this.btnCategory.AutoSize = true;
            this.btnCategory.Location = new System.Drawing.Point(488, 250);
            this.btnCategory.MinimumSize = new System.Drawing.Size(65, 38);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(65, 42);
            this.btnCategory.TabIndex = 11;
            this.btnCategory.Text = "...";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(212, 252);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.Size = new System.Drawing.Size(271, 38);
            this.txtCategory.TabIndex = 9;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(40, 255);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(130, 32);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Category";
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Enabled = false;
            this.txtCategoryId.Location = new System.Drawing.Point(260, 255);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(59, 38);
            this.txtCategoryId.TabIndex = 10;
            this.txtCategoryId.Visible = false;
            // 
            // grpSoftwareInformation
            // 
            this.grpSoftwareInformation.BackColor = System.Drawing.SystemColors.Control;
            this.grpSoftwareInformation.Controls.Add(this.btnSupplier);
            this.grpSoftwareInformation.Controls.Add(this.txtSupplier);
            this.grpSoftwareInformation.Controls.Add(this.lblSupplier);
            this.grpSoftwareInformation.Controls.Add(this.txtSupplierId);
            this.grpSoftwareInformation.Controls.Add(this.txtUnitPrice);
            this.grpSoftwareInformation.Controls.Add(this.txtQuantityOnHand);
            this.grpSoftwareInformation.Controls.Add(this.lblUnitPrice);
            this.grpSoftwareInformation.Controls.Add(this.lblQuantityOnHand);
            this.grpSoftwareInformation.Controls.Add(this.btnCategory);
            this.grpSoftwareInformation.Controls.Add(this.txtCategory);
            this.grpSoftwareInformation.Controls.Add(this.lblCategory);
            this.grpSoftwareInformation.Controls.Add(this.btnClear);
            this.grpSoftwareInformation.Controls.Add(this.txtSoftwareName);
            this.grpSoftwareInformation.Controls.Add(this.txtSoftwareId);
            this.grpSoftwareInformation.Controls.Add(this.lblSoftwareName);
            this.grpSoftwareInformation.Controls.Add(this.lblSoftwareId);
            this.grpSoftwareInformation.Controls.Add(this.txtCategoryId);
            this.grpSoftwareInformation.Location = new System.Drawing.Point(28, 140);
            this.grpSoftwareInformation.Name = "grpSoftwareInformation";
            this.grpSoftwareInformation.Size = new System.Drawing.Size(1152, 340);
            this.grpSoftwareInformation.TabIndex = 1;
            this.grpSoftwareInformation.TabStop = false;
            this.grpSoftwareInformation.Text = "Software Information";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(989, 40);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 68);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Cl&ear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtSoftwareName
            // 
            this.txtSoftwareName.Location = new System.Drawing.Point(212, 121);
            this.txtSoftwareName.Name = "txtSoftwareName";
            this.txtSoftwareName.Size = new System.Drawing.Size(239, 38);
            this.txtSoftwareName.TabIndex = 3;
            // 
            // txtSoftwareId
            // 
            this.txtSoftwareId.Location = new System.Drawing.Point(212, 54);
            this.txtSoftwareId.Name = "txtSoftwareId";
            this.txtSoftwareId.ReadOnly = true;
            this.txtSoftwareId.Size = new System.Drawing.Size(239, 38);
            this.txtSoftwareId.TabIndex = 1;
            // 
            // lblSoftwareName
            // 
            this.lblSoftwareName.AutoSize = true;
            this.lblSoftwareName.Location = new System.Drawing.Point(40, 124);
            this.lblSoftwareName.Name = "lblSoftwareName";
            this.lblSoftwareName.Size = new System.Drawing.Size(90, 32);
            this.lblSoftwareName.TabIndex = 2;
            this.lblSoftwareName.Text = "Name";
            // 
            // lblSoftwareId
            // 
            this.lblSoftwareId.AutoSize = true;
            this.lblSoftwareId.Location = new System.Drawing.Point(40, 57);
            this.lblSoftwareId.Name = "lblSoftwareId";
            this.lblSoftwareId.Size = new System.Drawing.Size(157, 32);
            this.lblSoftwareId.TabIndex = 0;
            this.lblSoftwareId.Text = "Software Id";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(480, 508);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(183, 68);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1031, 1048);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(149, 68);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(855, 1048);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 68);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "&Save";
            this.tipSoftwares.SetToolTip(this.btnSave, "Persist data immediately to disk");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tipSoftwares
            // 
            this.tipSoftwares.IsBalloon = true;
            // 
            // lblSystemName
            // 
            this.lblSystemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSystemName.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSystemName.Font = new System.Drawing.Font("Bauhaus 93", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemName.Location = new System.Drawing.Point(0, 0);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(1229, 124);
            this.lblSystemName.TabIndex = 0;
            this.lblSystemName.Text = "Hi-Tech Management System";
            this.lblSystemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(254, 508);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(183, 68);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(28, 508);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(183, 68);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.colProductName,
            this.colSupplierId,
            this.colSupplierName,
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
            this.grdSoftwares.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdSoftwares.Location = new System.Drawing.Point(28, 602);
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
            this.grdSoftwares.Size = new System.Drawing.Size(1152, 407);
            this.grdSoftwares.TabIndex = 5;
            this.grdSoftwares.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdSoftwares_CellMouseDoubleClick);
            // 
            // colSoftwareId
            // 
            this.colSoftwareId.HeaderText = "Software Id";
            this.colSoftwareId.Name = "colSoftwareId";
            this.colSoftwareId.ReadOnly = true;
            // 
            // colProductName
            // 
            this.colProductName.HeaderText = "Name";
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
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
            // SoftwareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1213, 1150);
            this.Controls.Add(this.grpSoftwareInformation);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSystemName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grdSoftwares);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1245, 1232);
            this.Name = "SoftwareForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hi-Tech Management System - Softwares";
            this.Load += new System.EventHandler(this.SoftwareForm_Load);
            this.grpSoftwareInformation.ResumeLayout(false);
            this.grpSoftwareInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSoftwares)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.TextBox txtSupplierId;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtQuantityOnHand;
        private System.Windows.Forms.ToolTip tipSoftwares;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblQuantityOnHand;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.GroupBox grpSoftwareInformation;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSoftwareName;
        private System.Windows.Forms.TextBox txtSoftwareId;
        private System.Windows.Forms.Label lblSoftwareName;
        private System.Windows.Forms.Label lblSoftwareId;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView grdSoftwares;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoftwareId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantityOnHand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
    }
}