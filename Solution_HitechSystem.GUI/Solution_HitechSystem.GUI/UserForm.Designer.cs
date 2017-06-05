namespace Solution_HitechSystem.GUI
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.btnClear = new System.Windows.Forms.Button();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grdUsers = new System.Windows.Forms.DataGridView();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployeeFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployeeSaveUpdateDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colEmployeeSearchList = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colUserSaveUpdateDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colUserSearchList = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colClientSaveUpdateDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colClientSearchList = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colProductSaveUpdateDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colProductSearchList = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colClientOrderSaveUpdateCancel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colClientOrderSearchList = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkEmployeeSaveUpdateDelete = new System.Windows.Forms.CheckBox();
            this.lblEmployeePermission = new System.Windows.Forms.Label();
            this.chkEmployeeSearchList = new System.Windows.Forms.CheckBox();
            this.grpPermissions = new System.Windows.Forms.GroupBox();
            this.chkProductSearchList = new System.Windows.Forms.CheckBox();
            this.lblProductPermission = new System.Windows.Forms.Label();
            this.chkProductSaveUpdateDelete = new System.Windows.Forms.CheckBox();
            this.chkUserSearchList = new System.Windows.Forms.CheckBox();
            this.lblUserPermission = new System.Windows.Forms.Label();
            this.chkUserSaveUpdateDelete = new System.Windows.Forms.CheckBox();
            this.chkClientsOrdersSearchList = new System.Windows.Forms.CheckBox();
            this.lblClientsOrdersPermission = new System.Windows.Forms.Label();
            this.chkClientsOrdersSaveUpdateCancel = new System.Windows.Forms.CheckBox();
            this.chkClientSearchList = new System.Windows.Forms.CheckBox();
            this.lblClientPermission = new System.Windows.Forms.Label();
            this.chkClientSaveUpdateDelete = new System.Windows.Forms.CheckBox();
            this.tipUsers = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpPermissions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(530, 173);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 68);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Cl&ear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblSystemName
            // 
            this.lblSystemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSystemName.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSystemName.Font = new System.Drawing.Font("Bauhaus 93", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemName.Location = new System.Drawing.Point(0, 0);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(1665, 124);
            this.lblSystemName.TabIndex = 0;
            this.lblSystemName.Text = "Hi-Tech Management System";
            this.lblSystemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(254, 509);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(183, 68);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grdUsers
            // 
            this.grdUsers.AllowUserToAddRows = false;
            this.grdUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUsername,
            this.colEmployeeId,
            this.colEmployeeFullName,
            this.colEmployeeSaveUpdateDelete,
            this.colEmployeeSearchList,
            this.colUserSaveUpdateDelete,
            this.colUserSearchList,
            this.colClientSaveUpdateDelete,
            this.colClientSearchList,
            this.colProductSaveUpdateDelete,
            this.colProductSearchList,
            this.colClientOrderSaveUpdateCancel,
            this.colClientOrderSearchList});
            this.grdUsers.Location = new System.Drawing.Point(28, 738);
            this.grdUsers.MultiSelect = false;
            this.grdUsers.Name = "grdUsers";
            this.grdUsers.ReadOnly = true;
            this.grdUsers.RowTemplate.Height = 20;
            this.grdUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdUsers.Size = new System.Drawing.Size(1611, 349);
            this.grdUsers.TabIndex = 10;
            this.grdUsers.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdUsers_CellMouseDoubleClick);
            // 
            // colUsername
            // 
            this.colUsername.HeaderText = "Username";
            this.colUsername.Name = "colUsername";
            this.colUsername.ReadOnly = true;
            // 
            // colEmployeeId
            // 
            this.colEmployeeId.HeaderText = "Employee Id";
            this.colEmployeeId.Name = "colEmployeeId";
            this.colEmployeeId.ReadOnly = true;
            this.colEmployeeId.Visible = false;
            // 
            // colEmployeeFullName
            // 
            this.colEmployeeFullName.HeaderText = "Employee";
            this.colEmployeeFullName.Name = "colEmployeeFullName";
            this.colEmployeeFullName.ReadOnly = true;
            // 
            // colEmployeeSaveUpdateDelete
            // 
            this.colEmployeeSaveUpdateDelete.HeaderText = "Employee S/U/D";
            this.colEmployeeSaveUpdateDelete.Name = "colEmployeeSaveUpdateDelete";
            this.colEmployeeSaveUpdateDelete.ReadOnly = true;
            this.colEmployeeSaveUpdateDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEmployeeSaveUpdateDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colEmployeeSearchList
            // 
            this.colEmployeeSearchList.HeaderText = "Employee S/L";
            this.colEmployeeSearchList.Name = "colEmployeeSearchList";
            this.colEmployeeSearchList.ReadOnly = true;
            this.colEmployeeSearchList.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEmployeeSearchList.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colUserSaveUpdateDelete
            // 
            this.colUserSaveUpdateDelete.HeaderText = "User S/U/D";
            this.colUserSaveUpdateDelete.Name = "colUserSaveUpdateDelete";
            this.colUserSaveUpdateDelete.ReadOnly = true;
            this.colUserSaveUpdateDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colUserSaveUpdateDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colUserSearchList
            // 
            this.colUserSearchList.HeaderText = "User S/L";
            this.colUserSearchList.Name = "colUserSearchList";
            this.colUserSearchList.ReadOnly = true;
            this.colUserSearchList.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colUserSearchList.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colClientSaveUpdateDelete
            // 
            this.colClientSaveUpdateDelete.HeaderText = "Client S/U/D";
            this.colClientSaveUpdateDelete.Name = "colClientSaveUpdateDelete";
            this.colClientSaveUpdateDelete.ReadOnly = true;
            this.colClientSaveUpdateDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colClientSaveUpdateDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colClientSearchList
            // 
            this.colClientSearchList.HeaderText = "Client S/L";
            this.colClientSearchList.Name = "colClientSearchList";
            this.colClientSearchList.ReadOnly = true;
            this.colClientSearchList.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colClientSearchList.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colProductSaveUpdateDelete
            // 
            this.colProductSaveUpdateDelete.HeaderText = "Product S/U/D";
            this.colProductSaveUpdateDelete.Name = "colProductSaveUpdateDelete";
            this.colProductSaveUpdateDelete.ReadOnly = true;
            this.colProductSaveUpdateDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colProductSaveUpdateDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colProductSearchList
            // 
            this.colProductSearchList.HeaderText = "Product S/L";
            this.colProductSearchList.Name = "colProductSearchList";
            this.colProductSearchList.ReadOnly = true;
            this.colProductSearchList.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colProductSearchList.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colClientOrderSaveUpdateCancel
            // 
            this.colClientOrderSaveUpdateCancel.HeaderText = "Orders S/U/C";
            this.colClientOrderSaveUpdateCancel.Name = "colClientOrderSaveUpdateCancel";
            this.colClientOrderSaveUpdateCancel.ReadOnly = true;
            this.colClientOrderSaveUpdateCancel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colClientOrderSaveUpdateCancel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colClientOrderSearchList
            // 
            this.colClientOrderSearchList.HeaderText = "Orders S/L";
            this.colClientOrderSearchList.Name = "colClientOrderSearchList";
            this.colClientOrderSearchList.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(712, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(611, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 110;
            this.pictureBox1.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(480, 509);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(183, 68);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1490, 1114);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(149, 68);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1313, 1114);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 68);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "&Save";
            this.tipUsers.SetToolTip(this.btnSave, "Persist data immediately to disk");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(28, 509);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(183, 68);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(193, 173);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(294, 38);
            this.txtUsername.TabIndex = 2;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(21, 245);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(142, 32);
            this.lblEmployee.TabIndex = 3;
            this.lblEmployee.Text = "Employee";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(21, 178);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(145, 32);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(193, 240);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(294, 39);
            this.cmbEmployee.Sorted = true;
            this.cmbEmployee.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(22, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(641, 149);
            this.label1.TabIndex = 5;
            this.label1.Text = "The initial password is equal to the username. The user can change it after loggi" +
    "ng in.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkEmployeeSaveUpdateDelete
            // 
            this.chkEmployeeSaveUpdateDelete.AutoSize = true;
            this.chkEmployeeSaveUpdateDelete.Location = new System.Drawing.Point(56, 93);
            this.chkEmployeeSaveUpdateDelete.Name = "chkEmployeeSaveUpdateDelete";
            this.chkEmployeeSaveUpdateDelete.Size = new System.Drawing.Size(337, 36);
            this.chkEmployeeSaveUpdateDelete.TabIndex = 1;
            this.chkEmployeeSaveUpdateDelete.Text = "Save / Update / Delete";
            this.chkEmployeeSaveUpdateDelete.UseVisualStyleBackColor = true;
            // 
            // lblEmployeePermission
            // 
            this.lblEmployeePermission.AutoSize = true;
            this.lblEmployeePermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeePermission.Location = new System.Drawing.Point(50, 58);
            this.lblEmployeePermission.Name = "lblEmployeePermission";
            this.lblEmployeePermission.Size = new System.Drawing.Size(150, 32);
            this.lblEmployeePermission.TabIndex = 0;
            this.lblEmployeePermission.Text = "Employee";
            // 
            // chkEmployeeSearchList
            // 
            this.chkEmployeeSearchList.AutoSize = true;
            this.chkEmployeeSearchList.Location = new System.Drawing.Point(56, 146);
            this.chkEmployeeSearchList.Name = "chkEmployeeSearchList";
            this.chkEmployeeSearchList.Size = new System.Drawing.Size(210, 36);
            this.chkEmployeeSearchList.TabIndex = 2;
            this.chkEmployeeSearchList.Text = "Search / List";
            this.chkEmployeeSearchList.UseVisualStyleBackColor = true;
            // 
            // grpPermissions
            // 
            this.grpPermissions.BackColor = System.Drawing.SystemColors.Control;
            this.grpPermissions.Controls.Add(this.chkProductSearchList);
            this.grpPermissions.Controls.Add(this.lblProductPermission);
            this.grpPermissions.Controls.Add(this.chkProductSaveUpdateDelete);
            this.grpPermissions.Controls.Add(this.chkUserSearchList);
            this.grpPermissions.Controls.Add(this.lblUserPermission);
            this.grpPermissions.Controls.Add(this.chkUserSaveUpdateDelete);
            this.grpPermissions.Controls.Add(this.chkClientsOrdersSearchList);
            this.grpPermissions.Controls.Add(this.lblClientsOrdersPermission);
            this.grpPermissions.Controls.Add(this.chkClientsOrdersSaveUpdateCancel);
            this.grpPermissions.Controls.Add(this.chkClientSearchList);
            this.grpPermissions.Controls.Add(this.lblClientPermission);
            this.grpPermissions.Controls.Add(this.chkClientSaveUpdateDelete);
            this.grpPermissions.Controls.Add(this.chkEmployeeSearchList);
            this.grpPermissions.Controls.Add(this.lblEmployeePermission);
            this.grpPermissions.Controls.Add(this.chkEmployeeSaveUpdateDelete);
            this.grpPermissions.Location = new System.Drawing.Point(712, 163);
            this.grpPermissions.Name = "grpPermissions";
            this.grpPermissions.Size = new System.Drawing.Size(927, 540);
            this.grpPermissions.TabIndex = 6;
            this.grpPermissions.TabStop = false;
            this.grpPermissions.Text = "Permissions";
            // 
            // chkProductSearchList
            // 
            this.chkProductSearchList.AutoSize = true;
            this.chkProductSearchList.Location = new System.Drawing.Point(521, 305);
            this.chkProductSearchList.Name = "chkProductSearchList";
            this.chkProductSearchList.Size = new System.Drawing.Size(210, 36);
            this.chkProductSearchList.TabIndex = 11;
            this.chkProductSearchList.Text = "Search / List";
            this.chkProductSearchList.UseVisualStyleBackColor = true;
            // 
            // lblProductPermission
            // 
            this.lblProductPermission.AutoSize = true;
            this.lblProductPermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPermission.Location = new System.Drawing.Point(515, 214);
            this.lblProductPermission.Name = "lblProductPermission";
            this.lblProductPermission.Size = new System.Drawing.Size(120, 32);
            this.lblProductPermission.TabIndex = 9;
            this.lblProductPermission.Text = "Product";
            // 
            // chkProductSaveUpdateDelete
            // 
            this.chkProductSaveUpdateDelete.AutoSize = true;
            this.chkProductSaveUpdateDelete.Location = new System.Drawing.Point(521, 252);
            this.chkProductSaveUpdateDelete.Name = "chkProductSaveUpdateDelete";
            this.chkProductSaveUpdateDelete.Size = new System.Drawing.Size(337, 36);
            this.chkProductSaveUpdateDelete.TabIndex = 10;
            this.chkProductSaveUpdateDelete.Text = "Save / Update / Delete";
            this.chkProductSaveUpdateDelete.UseVisualStyleBackColor = true;
            // 
            // chkUserSearchList
            // 
            this.chkUserSearchList.AutoSize = true;
            this.chkUserSearchList.Location = new System.Drawing.Point(521, 146);
            this.chkUserSearchList.Name = "chkUserSearchList";
            this.chkUserSearchList.Size = new System.Drawing.Size(210, 36);
            this.chkUserSearchList.TabIndex = 5;
            this.chkUserSearchList.Text = "Search / List";
            this.chkUserSearchList.UseVisualStyleBackColor = true;
            // 
            // lblUserPermission
            // 
            this.lblUserPermission.AutoSize = true;
            this.lblUserPermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserPermission.Location = new System.Drawing.Point(515, 58);
            this.lblUserPermission.Name = "lblUserPermission";
            this.lblUserPermission.Size = new System.Drawing.Size(78, 32);
            this.lblUserPermission.TabIndex = 3;
            this.lblUserPermission.Text = "User";
            // 
            // chkUserSaveUpdateDelete
            // 
            this.chkUserSaveUpdateDelete.AutoSize = true;
            this.chkUserSaveUpdateDelete.Location = new System.Drawing.Point(521, 93);
            this.chkUserSaveUpdateDelete.Name = "chkUserSaveUpdateDelete";
            this.chkUserSaveUpdateDelete.Size = new System.Drawing.Size(337, 36);
            this.chkUserSaveUpdateDelete.TabIndex = 4;
            this.chkUserSaveUpdateDelete.Text = "Save / Update / Delete";
            this.chkUserSaveUpdateDelete.UseVisualStyleBackColor = true;
            // 
            // chkClientsOrdersSearchList
            // 
            this.chkClientsOrdersSearchList.AutoSize = true;
            this.chkClientsOrdersSearchList.Location = new System.Drawing.Point(56, 463);
            this.chkClientsOrdersSearchList.Name = "chkClientsOrdersSearchList";
            this.chkClientsOrdersSearchList.Size = new System.Drawing.Size(210, 36);
            this.chkClientsOrdersSearchList.TabIndex = 14;
            this.chkClientsOrdersSearchList.Text = "Search / List";
            this.chkClientsOrdersSearchList.UseVisualStyleBackColor = true;
            // 
            // lblClientsOrdersPermission
            // 
            this.lblClientsOrdersPermission.AutoSize = true;
            this.lblClientsOrdersPermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientsOrdersPermission.Location = new System.Drawing.Point(50, 372);
            this.lblClientsOrdersPermission.Name = "lblClientsOrdersPermission";
            this.lblClientsOrdersPermission.Size = new System.Drawing.Size(210, 32);
            this.lblClientsOrdersPermission.TabIndex = 12;
            this.lblClientsOrdersPermission.Text = "Clients\' orders";
            // 
            // chkClientsOrdersSaveUpdateCancel
            // 
            this.chkClientsOrdersSaveUpdateCancel.AutoSize = true;
            this.chkClientsOrdersSaveUpdateCancel.Location = new System.Drawing.Point(56, 410);
            this.chkClientsOrdersSaveUpdateCancel.Name = "chkClientsOrdersSaveUpdateCancel";
            this.chkClientsOrdersSaveUpdateCancel.Size = new System.Drawing.Size(343, 36);
            this.chkClientsOrdersSaveUpdateCancel.TabIndex = 13;
            this.chkClientsOrdersSaveUpdateCancel.Text = "Save / Update / Cancel";
            this.chkClientsOrdersSaveUpdateCancel.UseVisualStyleBackColor = true;
            // 
            // chkClientSearchList
            // 
            this.chkClientSearchList.AutoSize = true;
            this.chkClientSearchList.Location = new System.Drawing.Point(56, 305);
            this.chkClientSearchList.Name = "chkClientSearchList";
            this.chkClientSearchList.Size = new System.Drawing.Size(210, 36);
            this.chkClientSearchList.TabIndex = 8;
            this.chkClientSearchList.Text = "Search / List";
            this.chkClientSearchList.UseVisualStyleBackColor = true;
            // 
            // lblClientPermission
            // 
            this.lblClientPermission.AutoSize = true;
            this.lblClientPermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientPermission.Location = new System.Drawing.Point(50, 214);
            this.lblClientPermission.Name = "lblClientPermission";
            this.lblClientPermission.Size = new System.Drawing.Size(95, 32);
            this.lblClientPermission.TabIndex = 6;
            this.lblClientPermission.Text = "Client";
            // 
            // chkClientSaveUpdateDelete
            // 
            this.chkClientSaveUpdateDelete.AutoSize = true;
            this.chkClientSaveUpdateDelete.Location = new System.Drawing.Point(56, 252);
            this.chkClientSaveUpdateDelete.Name = "chkClientSaveUpdateDelete";
            this.chkClientSaveUpdateDelete.Size = new System.Drawing.Size(337, 36);
            this.chkClientSaveUpdateDelete.TabIndex = 7;
            this.chkClientSaveUpdateDelete.Text = "Save / Update / Delete";
            this.chkClientSaveUpdateDelete.UseVisualStyleBackColor = true;
            // 
            // tipUsers
            // 
            this.tipUsers.IsBalloon = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1666, 1211);
            this.Controls.Add(this.grpPermissions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblSystemName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grdUsers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.lblUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1271, 1075);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hi-Tech Management System - Users";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpPermissions.ResumeLayout(false);
            this.grpPermissions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView grdUsers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkEmployeeSaveUpdateDelete;
        private System.Windows.Forms.Label lblEmployeePermission;
        private System.Windows.Forms.CheckBox chkEmployeeSearchList;
        private System.Windows.Forms.GroupBox grpPermissions;
        private System.Windows.Forms.CheckBox chkProductSearchList;
        private System.Windows.Forms.Label lblProductPermission;
        private System.Windows.Forms.CheckBox chkProductSaveUpdateDelete;
        private System.Windows.Forms.CheckBox chkUserSearchList;
        private System.Windows.Forms.Label lblUserPermission;
        private System.Windows.Forms.CheckBox chkUserSaveUpdateDelete;
        private System.Windows.Forms.CheckBox chkClientsOrdersSearchList;
        private System.Windows.Forms.Label lblClientsOrdersPermission;
        private System.Windows.Forms.CheckBox chkClientsOrdersSaveUpdateCancel;
        private System.Windows.Forms.CheckBox chkClientSearchList;
        private System.Windows.Forms.Label lblClientPermission;
        private System.Windows.Forms.CheckBox chkClientSaveUpdateDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeFullName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colEmployeeSaveUpdateDelete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colEmployeeSearchList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colUserSaveUpdateDelete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colUserSearchList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colClientSaveUpdateDelete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colClientSearchList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colProductSaveUpdateDelete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colProductSearchList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colClientOrderSaveUpdateCancel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colClientOrderSearchList;
        private System.Windows.Forms.ToolTip tipUsers;
    }
}