namespace Solution_HitechSystem.GUI
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.lblSystemName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grdClients = new System.Windows.Forms.DataGridView();
            this.colClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFaxNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBankNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBranchNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBankAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpClientInformation = new System.Windows.Forms.GroupBox();
            this.txtCreditLimit = new System.Windows.Forms.TextBox();
            this.mskBankAccount = new System.Windows.Forms.MaskedTextBox();
            this.mskBranchNumber = new System.Windows.Forms.MaskedTextBox();
            this.mskBankNumber = new System.Windows.Forms.MaskedTextBox();
            this.mskPostalCode = new System.Windows.Forms.MaskedTextBox();
            this.mskFaxNumber = new System.Windows.Forms.MaskedTextBox();
            this.mskPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblBankAccount = new System.Windows.Forms.Label();
            this.lblBranchNumber = new System.Windows.Forms.Label();
            this.lblBankNumber = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCreditLimit = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblClientId = new System.Windows.Forms.Label();
            this.lblFaxNumber = new System.Windows.Forms.Label();
            this.tipClients = new System.Windows.Forms.ToolTip(this.components);
            this.btnSelectClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdClients)).BeginInit();
            this.grpClientInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSystemName
            // 
            this.lblSystemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSystemName.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSystemName.Font = new System.Drawing.Font("Bauhaus 93", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemName.Location = new System.Drawing.Point(0, 0);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(1693, 124);
            this.lblSystemName.TabIndex = 0;
            this.lblSystemName.Text = "Hi-Tech Management System";
            this.lblSystemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(254, 497);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(183, 68);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grdClients
            // 
            this.grdClients.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colClientId,
            this.colClientName,
            this.colPhoneNumber,
            this.colFaxNumber,
            this.colAddress,
            this.colCity,
            this.colPostalCode,
            this.colBankNumber,
            this.colBranchNumber,
            this.colBankAccount,
            this.colCreditLimit});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdClients.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdClients.Location = new System.Drawing.Point(28, 591);
            this.grdClients.MultiSelect = false;
            this.grdClients.Name = "grdClients";
            this.grdClients.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdClients.RowTemplate.Height = 20;
            this.grdClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdClients.Size = new System.Drawing.Size(1633, 407);
            this.grdClients.TabIndex = 5;
            this.grdClients.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdClients_CellMouseDoubleClick);
            // 
            // colClientId
            // 
            this.colClientId.HeaderText = "Client Id";
            this.colClientId.Name = "colClientId";
            this.colClientId.ReadOnly = true;
            // 
            // colClientName
            // 
            this.colClientName.HeaderText = "Name";
            this.colClientName.Name = "colClientName";
            this.colClientName.ReadOnly = true;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.HeaderText = "Phone";
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.ReadOnly = true;
            // 
            // colFaxNumber
            // 
            this.colFaxNumber.HeaderText = "Fax";
            this.colFaxNumber.Name = "colFaxNumber";
            this.colFaxNumber.ReadOnly = true;
            // 
            // colAddress
            // 
            this.colAddress.HeaderText = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            // 
            // colCity
            // 
            this.colCity.HeaderText = "City";
            this.colCity.Name = "colCity";
            this.colCity.ReadOnly = true;
            // 
            // colPostalCode
            // 
            this.colPostalCode.HeaderText = "Postal Code";
            this.colPostalCode.Name = "colPostalCode";
            this.colPostalCode.ReadOnly = true;
            // 
            // colBankNumber
            // 
            this.colBankNumber.HeaderText = "Bank";
            this.colBankNumber.Name = "colBankNumber";
            this.colBankNumber.ReadOnly = true;
            // 
            // colBranchNumber
            // 
            this.colBranchNumber.HeaderText = "Branch";
            this.colBranchNumber.Name = "colBranchNumber";
            this.colBranchNumber.ReadOnly = true;
            // 
            // colBankAccount
            // 
            this.colBankAccount.HeaderText = "Account";
            this.colBankAccount.Name = "colBankAccount";
            this.colBankAccount.ReadOnly = true;
            // 
            // colCreditLimit
            // 
            this.colCreditLimit.HeaderText = "Credit Limit";
            this.colCreditLimit.Name = "colCreditLimit";
            this.colCreditLimit.ReadOnly = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(480, 497);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(183, 68);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1512, 1037);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(149, 68);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1344, 1037);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 68);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "&Save";
            this.tipClients.SetToolTip(this.btnSave, "Persist data immediately to disk");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(28, 497);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(183, 68);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpClientInformation
            // 
            this.grpClientInformation.BackColor = System.Drawing.SystemColors.Control;
            this.grpClientInformation.Controls.Add(this.txtCreditLimit);
            this.grpClientInformation.Controls.Add(this.mskBankAccount);
            this.grpClientInformation.Controls.Add(this.mskBranchNumber);
            this.grpClientInformation.Controls.Add(this.mskBankNumber);
            this.grpClientInformation.Controls.Add(this.mskPostalCode);
            this.grpClientInformation.Controls.Add(this.mskFaxNumber);
            this.grpClientInformation.Controls.Add(this.mskPhoneNumber);
            this.grpClientInformation.Controls.Add(this.lblBankAccount);
            this.grpClientInformation.Controls.Add(this.lblBranchNumber);
            this.grpClientInformation.Controls.Add(this.lblBankNumber);
            this.grpClientInformation.Controls.Add(this.txtCity);
            this.grpClientInformation.Controls.Add(this.txtAddress);
            this.grpClientInformation.Controls.Add(this.lblPostalCode);
            this.grpClientInformation.Controls.Add(this.lblCity);
            this.grpClientInformation.Controls.Add(this.lblAddress);
            this.grpClientInformation.Controls.Add(this.lblCreditLimit);
            this.grpClientInformation.Controls.Add(this.btnClear);
            this.grpClientInformation.Controls.Add(this.txtClientName);
            this.grpClientInformation.Controls.Add(this.txtClientId);
            this.grpClientInformation.Controls.Add(this.lblPhoneNumber);
            this.grpClientInformation.Controls.Add(this.lblClientName);
            this.grpClientInformation.Controls.Add(this.lblClientId);
            this.grpClientInformation.Controls.Add(this.lblFaxNumber);
            this.grpClientInformation.Location = new System.Drawing.Point(28, 140);
            this.grpClientInformation.Name = "grpClientInformation";
            this.grpClientInformation.Size = new System.Drawing.Size(1633, 334);
            this.grpClientInformation.TabIndex = 1;
            this.grpClientInformation.TabStop = false;
            this.grpClientInformation.Text = "Client Information";
            // 
            // txtCreditLimit
            // 
            this.txtCreditLimit.Location = new System.Drawing.Point(1200, 252);
            this.txtCreditLimit.Name = "txtCreditLimit";
            this.txtCreditLimit.Size = new System.Drawing.Size(239, 38);
            this.txtCreditLimit.TabIndex = 21;
            // 
            // mskBankAccount
            // 
            this.mskBankAccount.Location = new System.Drawing.Point(1200, 185);
            this.mskBankAccount.Mask = "99999999";
            this.mskBankAccount.Name = "mskBankAccount";
            this.mskBankAccount.Size = new System.Drawing.Size(239, 38);
            this.mskBankAccount.TabIndex = 19;
            this.mskBankAccount.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mskBranchNumber
            // 
            this.mskBranchNumber.Location = new System.Drawing.Point(1199, 118);
            this.mskBranchNumber.Mask = "00000";
            this.mskBranchNumber.Name = "mskBranchNumber";
            this.mskBranchNumber.Size = new System.Drawing.Size(239, 38);
            this.mskBranchNumber.TabIndex = 17;
            this.mskBranchNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mskBankNumber
            // 
            this.mskBankNumber.Location = new System.Drawing.Point(1199, 51);
            this.mskBankNumber.Mask = "000";
            this.mskBankNumber.Name = "mskBankNumber";
            this.mskBankNumber.Size = new System.Drawing.Size(239, 38);
            this.mskBankNumber.TabIndex = 15;
            this.mskBankNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mskPostalCode
            // 
            this.mskPostalCode.Location = new System.Drawing.Point(704, 185);
            this.mskPostalCode.Mask = ">L0L 0L0";
            this.mskPostalCode.Name = "mskPostalCode";
            this.mskPostalCode.Size = new System.Drawing.Size(239, 38);
            this.mskPostalCode.TabIndex = 13;
            this.mskPostalCode.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mskFaxNumber
            // 
            this.mskFaxNumber.Location = new System.Drawing.Point(193, 252);
            this.mskFaxNumber.Mask = "(000) 000-0000";
            this.mskFaxNumber.Name = "mskFaxNumber";
            this.mskFaxNumber.Size = new System.Drawing.Size(239, 38);
            this.mskFaxNumber.TabIndex = 7;
            this.mskFaxNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mskPhoneNumber
            // 
            this.mskPhoneNumber.Location = new System.Drawing.Point(193, 185);
            this.mskPhoneNumber.Mask = "(000) 000-0000";
            this.mskPhoneNumber.Name = "mskPhoneNumber";
            this.mskPhoneNumber.Size = new System.Drawing.Size(239, 38);
            this.mskPhoneNumber.TabIndex = 5;
            this.mskPhoneNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblBankAccount
            // 
            this.lblBankAccount.AutoSize = true;
            this.lblBankAccount.Location = new System.Drawing.Point(996, 188);
            this.lblBankAccount.Name = "lblBankAccount";
            this.lblBankAccount.Size = new System.Drawing.Size(118, 32);
            this.lblBankAccount.TabIndex = 18;
            this.lblBankAccount.Text = "Account";
            // 
            // lblBranchNumber
            // 
            this.lblBranchNumber.AutoSize = true;
            this.lblBranchNumber.Location = new System.Drawing.Point(995, 121);
            this.lblBranchNumber.Name = "lblBranchNumber";
            this.lblBranchNumber.Size = new System.Drawing.Size(105, 32);
            this.lblBranchNumber.TabIndex = 16;
            this.lblBranchNumber.Text = "Branch";
            // 
            // lblBankNumber
            // 
            this.lblBankNumber.AutoSize = true;
            this.lblBankNumber.Location = new System.Drawing.Point(995, 54);
            this.lblBankNumber.Name = "lblBankNumber";
            this.lblBankNumber.Size = new System.Drawing.Size(155, 32);
            this.lblBankNumber.TabIndex = 14;
            this.lblBankNumber.Text = "Bank Code";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(703, 118);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(239, 38);
            this.txtCity.TabIndex = 11;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(703, 51);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(239, 38);
            this.txtAddress.TabIndex = 9;
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(500, 188);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(170, 32);
            this.lblPostalCode.TabIndex = 12;
            this.lblPostalCode.Text = "Postal Code";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(499, 121);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(64, 32);
            this.lblCity.TabIndex = 10;
            this.lblCity.Text = "City";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(499, 54);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(119, 32);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address";
            // 
            // lblCreditLimit
            // 
            this.lblCreditLimit.AutoSize = true;
            this.lblCreditLimit.Location = new System.Drawing.Point(996, 255);
            this.lblCreditLimit.Name = "lblCreditLimit";
            this.lblCreditLimit.Size = new System.Drawing.Size(159, 32);
            this.lblCreditLimit.TabIndex = 20;
            this.lblCreditLimit.Text = "Credit Limit";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1475, 37);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 68);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Cl&ear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(192, 118);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(239, 38);
            this.txtClientName.TabIndex = 3;
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(192, 51);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.ReadOnly = true;
            this.txtClientId.Size = new System.Drawing.Size(239, 38);
            this.txtClientId.TabIndex = 1;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(43, 188);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(98, 32);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "Phone";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(42, 121);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(90, 32);
            this.lblClientName.TabIndex = 2;
            this.lblClientName.Text = "Name";
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Location = new System.Drawing.Point(42, 54);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(119, 32);
            this.lblClientId.TabIndex = 0;
            this.lblClientId.Text = "Client Id";
            // 
            // lblFaxNumber
            // 
            this.lblFaxNumber.AutoSize = true;
            this.lblFaxNumber.Location = new System.Drawing.Point(43, 255);
            this.lblFaxNumber.Name = "lblFaxNumber";
            this.lblFaxNumber.Size = new System.Drawing.Size(62, 32);
            this.lblFaxNumber.TabIndex = 6;
            this.lblFaxNumber.Text = "Fax";
            // 
            // tipClients
            // 
            this.tipClients.IsBalloon = true;
            // 
            // btnSelectClient
            // 
            this.btnSelectClient.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSelectClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectClient.Location = new System.Drawing.Point(28, 1037);
            this.btnSelectClient.Name = "btnSelectClient";
            this.btnSelectClient.Size = new System.Drawing.Size(302, 68);
            this.btnSelectClient.TabIndex = 10;
            this.btnSelectClient.Text = "Select Client";
            this.btnSelectClient.UseVisualStyleBackColor = true;
            this.btnSelectClient.Visible = false;
            this.btnSelectClient.Click += new System.EventHandler(this.btnSelectClient_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1692, 1128);
            this.Controls.Add(this.btnSelectClient);
            this.Controls.Add(this.grpClientInformation);
            this.Controls.Add(this.lblSystemName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grdClients);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1724, 1210);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hi-Tech Management System - Clients";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdClients)).EndInit();
            this.grpClientInformation.ResumeLayout(false);
            this.grpClientInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView grdClients;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpClientInformation;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.Label lblFaxNumber;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCreditLimit;
        private System.Windows.Forms.Label lblBankAccount;
        private System.Windows.Forms.Label lblBranchNumber;
        private System.Windows.Forms.Label lblBankNumber;
        private System.Windows.Forms.MaskedTextBox mskPostalCode;
        private System.Windows.Forms.MaskedTextBox mskFaxNumber;
        private System.Windows.Forms.MaskedTextBox mskPhoneNumber;
        private System.Windows.Forms.MaskedTextBox mskBankAccount;
        private System.Windows.Forms.MaskedTextBox mskBranchNumber;
        private System.Windows.Forms.MaskedTextBox mskBankNumber;
        private System.Windows.Forms.TextBox txtCreditLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFaxNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBankNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBranchNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBankAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditLimit;
        private System.Windows.Forms.ToolTip tipClients;
        private System.Windows.Forms.Button btnSelectClient;
    }
}