namespace Solution_HitechSystem.GUI
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tipOrders = new System.Windows.Forms.ToolTip(this.components);
            this.btnRemoveOrderLine = new System.Windows.Forms.Button();
            this.btnAddOrderLine = new System.Windows.Forms.Button();
            this.btnFirstOrder = new System.Windows.Forms.Button();
            this.btnPreviousOrder = new System.Windows.Forms.Button();
            this.btnNextOrder = new System.Windows.Forms.Button();
            this.btnLastOrder = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.grpOrderTakenBy = new System.Windows.Forms.GroupBox();
            this.radEmail = new System.Windows.Forms.RadioButton();
            this.radPhone = new System.Windows.Forms.RadioButton();
            this.radFax = new System.Windows.Forms.RadioButton();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnClient = new System.Windows.Forms.Button();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.grpOrderLines = new System.Windows.Forms.GroupBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtProductType = new System.Windows.Forms.TextBox();
            this.btnProduct = new System.Windows.Forms.Button();
            this.lblProduct = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.grdOrderLines = new System.Windows.Forms.DataGridView();
            this.colOrderLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpOrder.SuspendLayout();
            this.grpOrderTakenBy.SuspendLayout();
            this.grpOrderLines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrderLines)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1394, 1270);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(149, 68);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1216, 1270);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 68);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&Save";
            this.tipOrders.SetToolTip(this.btnSave, "Persist data immediately to disk");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tipOrders
            // 
            this.tipOrders.AutoPopDelay = 5000;
            this.tipOrders.InitialDelay = 300;
            this.tipOrders.IsBalloon = true;
            this.tipOrders.ReshowDelay = 100;
            // 
            // btnRemoveOrderLine
            // 
            this.btnRemoveOrderLine.Location = new System.Drawing.Point(1218, 151);
            this.btnRemoveOrderLine.Name = "btnRemoveOrderLine";
            this.btnRemoveOrderLine.Size = new System.Drawing.Size(183, 68);
            this.btnRemoveOrderLine.TabIndex = 10;
            this.btnRemoveOrderLine.Text = "&Remove";
            this.tipOrders.SetToolTip(this.btnRemoveOrderLine, "Not implemented yet.");
            this.btnRemoveOrderLine.UseVisualStyleBackColor = true;
            // 
            // btnAddOrderLine
            // 
            this.btnAddOrderLine.Location = new System.Drawing.Point(1218, 40);
            this.btnAddOrderLine.Name = "btnAddOrderLine";
            this.btnAddOrderLine.Size = new System.Drawing.Size(183, 68);
            this.btnAddOrderLine.TabIndex = 9;
            this.btnAddOrderLine.Text = "&Add";
            this.tipOrders.SetToolTip(this.btnAddOrderLine, "Not implemented yet.");
            this.btnAddOrderLine.UseVisualStyleBackColor = true;
            // 
            // btnFirstOrder
            // 
            this.btnFirstOrder.Location = new System.Drawing.Point(22, 1270);
            this.btnFirstOrder.Name = "btnFirstOrder";
            this.btnFirstOrder.Size = new System.Drawing.Size(68, 68);
            this.btnFirstOrder.TabIndex = 4;
            this.btnFirstOrder.Text = "| <";
            this.tipOrders.SetToolTip(this.btnFirstOrder, "Not implemented yet.");
            this.btnFirstOrder.UseVisualStyleBackColor = true;
            // 
            // btnPreviousOrder
            // 
            this.btnPreviousOrder.Location = new System.Drawing.Point(96, 1270);
            this.btnPreviousOrder.Name = "btnPreviousOrder";
            this.btnPreviousOrder.Size = new System.Drawing.Size(68, 68);
            this.btnPreviousOrder.TabIndex = 5;
            this.btnPreviousOrder.Text = "<";
            this.tipOrders.SetToolTip(this.btnPreviousOrder, "Not implemented yet.");
            this.btnPreviousOrder.UseVisualStyleBackColor = true;
            // 
            // btnNextOrder
            // 
            this.btnNextOrder.Location = new System.Drawing.Point(170, 1270);
            this.btnNextOrder.Name = "btnNextOrder";
            this.btnNextOrder.Size = new System.Drawing.Size(68, 68);
            this.btnNextOrder.TabIndex = 6;
            this.btnNextOrder.Text = ">";
            this.tipOrders.SetToolTip(this.btnNextOrder, "Not implemented yet.");
            this.btnNextOrder.UseVisualStyleBackColor = true;
            // 
            // btnLastOrder
            // 
            this.btnLastOrder.Location = new System.Drawing.Point(244, 1270);
            this.btnLastOrder.Name = "btnLastOrder";
            this.btnLastOrder.Size = new System.Drawing.Size(68, 68);
            this.btnLastOrder.TabIndex = 7;
            this.btnLastOrder.Text = "> |";
            this.tipOrders.SetToolTip(this.btnLastOrder, "Not implemented yet.");
            this.btnLastOrder.UseVisualStyleBackColor = true;
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(377, 1270);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(206, 68);
            this.btnNewOrder.TabIndex = 8;
            this.btnNewOrder.Text = "New Order";
            this.tipOrders.SetToolTip(this.btnNewOrder, "Not implemented yet.");
            this.btnNewOrder.UseVisualStyleBackColor = true;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(607, 1270);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(206, 68);
            this.btnPlaceOrder.TabIndex = 9;
            this.btnPlaceOrder.Text = "Place Order";
            this.tipOrders.SetToolTip(this.btnPlaceOrder, "Not implemented yet.");
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(837, 1270);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(206, 68);
            this.btnCancelOrder.TabIndex = 10;
            this.btnCancelOrder.Text = "Cancel Order";
            this.tipOrders.SetToolTip(this.btnCancelOrder, "Not implemented yet.");
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            // 
            // lblSystemName
            // 
            this.lblSystemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSystemName.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSystemName.Font = new System.Drawing.Font("Bauhaus 93", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemName.Location = new System.Drawing.Point(0, 0);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(1583, 124);
            this.lblSystemName.TabIndex = 0;
            this.lblSystemName.Text = "Hi-Tech Management System";
            this.lblSystemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpOrder
            // 
            this.grpOrder.BackColor = System.Drawing.SystemColors.Control;
            this.grpOrder.Controls.Add(this.grpOrderTakenBy);
            this.grpOrder.Controls.Add(this.dtpOrderDate);
            this.grpOrder.Controls.Add(this.lblDate);
            this.grpOrder.Controls.Add(this.btnClient);
            this.grpOrder.Controls.Add(this.txtClient);
            this.grpOrder.Controls.Add(this.lblClient);
            this.grpOrder.Controls.Add(this.txtClientId);
            this.grpOrder.Controls.Add(this.btnClear);
            this.grpOrder.Controls.Add(this.txtComments);
            this.grpOrder.Controls.Add(this.txtOrderId);
            this.grpOrder.Controls.Add(this.lblComments);
            this.grpOrder.Controls.Add(this.lblOrderId);
            this.grpOrder.Controls.Add(this.grpOrderLines);
            this.grpOrder.Location = new System.Drawing.Point(22, 155);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(1521, 1087);
            this.grpOrder.TabIndex = 1;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Order";
            // 
            // grpOrderTakenBy
            // 
            this.grpOrderTakenBy.BackColor = System.Drawing.SystemColors.Control;
            this.grpOrderTakenBy.Controls.Add(this.radEmail);
            this.grpOrderTakenBy.Controls.Add(this.radPhone);
            this.grpOrderTakenBy.Controls.Add(this.radFax);
            this.grpOrderTakenBy.Location = new System.Drawing.Point(977, 47);
            this.grpOrderTakenBy.Name = "grpOrderTakenBy";
            this.grpOrderTakenBy.Size = new System.Drawing.Size(256, 268);
            this.grpOrderTakenBy.TabIndex = 8;
            this.grpOrderTakenBy.TabStop = false;
            this.grpOrderTakenBy.Text = "Taken By";
            // 
            // radEmail
            // 
            this.radEmail.AutoSize = true;
            this.radEmail.Checked = true;
            this.radEmail.Location = new System.Drawing.Point(48, 59);
            this.radEmail.Name = "radEmail";
            this.radEmail.Size = new System.Drawing.Size(124, 36);
            this.radEmail.TabIndex = 0;
            this.radEmail.TabStop = true;
            this.radEmail.Text = "Email";
            this.radEmail.UseVisualStyleBackColor = true;
            // 
            // radPhone
            // 
            this.radPhone.AutoSize = true;
            this.radPhone.Location = new System.Drawing.Point(48, 124);
            this.radPhone.Name = "radPhone";
            this.radPhone.Size = new System.Drawing.Size(135, 36);
            this.radPhone.TabIndex = 1;
            this.radPhone.Text = "Phone";
            this.radPhone.UseVisualStyleBackColor = true;
            // 
            // radFax
            // 
            this.radFax.AutoSize = true;
            this.radFax.Location = new System.Drawing.Point(48, 189);
            this.radFax.Name = "radFax";
            this.radFax.Size = new System.Drawing.Size(99, 36);
            this.radFax.TabIndex = 2;
            this.radFax.Text = "Fax";
            this.radFax.UseVisualStyleBackColor = true;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(729, 60);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(220, 38);
            this.dtpOrderDate.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(636, 63);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(75, 32);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // btnClient
            // 
            this.btnClient.AutoSize = true;
            this.btnClient.Location = new System.Drawing.Point(884, 133);
            this.btnClient.MinimumSize = new System.Drawing.Size(65, 38);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(65, 42);
            this.btnClient.TabIndex = 7;
            this.btnClient.Text = "...";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(206, 135);
            this.txtClient.Name = "txtClient";
            this.txtClient.ReadOnly = true;
            this.txtClient.Size = new System.Drawing.Size(661, 38);
            this.txtClient.TabIndex = 5;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(41, 138);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(89, 32);
            this.lblClient.TabIndex = 4;
            this.lblClient.Text = "Client";
            // 
            // txtClientId
            // 
            this.txtClientId.Enabled = false;
            this.txtClientId.Location = new System.Drawing.Point(233, 129);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(59, 38);
            this.txtClientId.TabIndex = 6;
            this.txtClientId.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1347, 47);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 68);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Cl&ear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(206, 205);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(743, 110);
            this.txtComments.TabIndex = 10;
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(206, 60);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.ReadOnly = true;
            this.txtOrderId.Size = new System.Drawing.Size(239, 38);
            this.txtOrderId.TabIndex = 1;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(41, 208);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(151, 32);
            this.lblComments.TabIndex = 9;
            this.lblComments.Text = "Comments";
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(41, 63);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(117, 32);
            this.lblOrderId.TabIndex = 0;
            this.lblOrderId.Text = "Order Id";
            // 
            // grpOrderLines
            // 
            this.grpOrderLines.BackColor = System.Drawing.SystemColors.Control;
            this.grpOrderLines.Controls.Add(this.txtPrice);
            this.grpOrderLines.Controls.Add(this.lblPrice);
            this.grpOrderLines.Controls.Add(this.numQuantity);
            this.grpOrderLines.Controls.Add(this.lblQuantity);
            this.grpOrderLines.Controls.Add(this.txtProduct);
            this.grpOrderLines.Controls.Add(this.txtProductType);
            this.grpOrderLines.Controls.Add(this.btnProduct);
            this.grpOrderLines.Controls.Add(this.lblProduct);
            this.grpOrderLines.Controls.Add(this.txtProductId);
            this.grpOrderLines.Controls.Add(this.btnRemoveOrderLine);
            this.grpOrderLines.Controls.Add(this.btnAddOrderLine);
            this.grpOrderLines.Controls.Add(this.grdOrderLines);
            this.grpOrderLines.Location = new System.Drawing.Point(47, 349);
            this.grpOrderLines.Name = "grpOrderLines";
            this.grpOrderLines.Size = new System.Drawing.Size(1433, 697);
            this.grpOrderLines.TabIndex = 11;
            this.grpOrderLines.TabStop = false;
            this.grpOrderLines.Text = "Order Lines";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(786, 55);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(161, 38);
            this.txtPrice.TabIndex = 8;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(668, 58);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(80, 32);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(485, 55);
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 38);
            this.numQuantity.TabIndex = 6;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(349, 58);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(122, 32);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(45, 116);
            this.txtProduct.Multiline = true;
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.ReadOnly = true;
            this.txtProduct.Size = new System.Drawing.Size(1113, 103);
            this.txtProduct.TabIndex = 2;
            this.txtProduct.TabStop = false;
            // 
            // txtProductType
            // 
            this.txtProductType.Enabled = false;
            this.txtProductType.Location = new System.Drawing.Point(250, 101);
            this.txtProductType.Name = "txtProductType";
            this.txtProductType.Size = new System.Drawing.Size(59, 38);
            this.txtProductType.TabIndex = 4;
            this.txtProductType.Visible = false;
            // 
            // btnProduct
            // 
            this.btnProduct.AutoSize = true;
            this.btnProduct.Location = new System.Drawing.Point(174, 53);
            this.btnProduct.MinimumSize = new System.Drawing.Size(65, 38);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(65, 42);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Text = "...";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(39, 58);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(113, 32);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Product";
            // 
            // txtProductId
            // 
            this.txtProductId.Enabled = false;
            this.txtProductId.Location = new System.Drawing.Point(180, 101);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(59, 38);
            this.txtProductId.TabIndex = 3;
            this.txtProductId.Visible = false;
            // 
            // grdOrderLines
            // 
            this.grdOrderLines.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdOrderLines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdOrderLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrderLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderLine,
            this.colProductType,
            this.colProductId,
            this.colProductDescription,
            this.colQuantity,
            this.colPrice});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdOrderLines.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdOrderLines.Location = new System.Drawing.Point(45, 244);
            this.grdOrderLines.MultiSelect = false;
            this.grdOrderLines.Name = "grdOrderLines";
            this.grdOrderLines.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdOrderLines.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdOrderLines.RowTemplate.Height = 20;
            this.grdOrderLines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdOrderLines.Size = new System.Drawing.Size(1356, 413);
            this.grdOrderLines.TabIndex = 11;
            // 
            // colOrderLine
            // 
            this.colOrderLine.HeaderText = "Line";
            this.colOrderLine.Name = "colOrderLine";
            this.colOrderLine.ReadOnly = true;
            // 
            // colProductType
            // 
            this.colProductType.HeaderText = "Type";
            this.colProductType.Name = "colProductType";
            this.colProductType.ReadOnly = true;
            // 
            // colProductId
            // 
            this.colProductId.HeaderText = "Product Id";
            this.colProductId.Name = "colProductId";
            this.colProductId.ReadOnly = true;
            this.colProductId.Visible = false;
            // 
            // colProductDescription
            // 
            this.colProductDescription.HeaderText = "Product";
            this.colProductDescription.Name = "colProductDescription";
            this.colProductDescription.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1581, 1368);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.btnLastOrder);
            this.Controls.Add(this.btnNextOrder);
            this.Controls.Add(this.btnPreviousOrder);
            this.Controls.Add(this.btnFirstOrder);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSystemName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1613, 1450);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hi-Tech Management System - Order";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            this.grpOrderTakenBy.ResumeLayout(false);
            this.grpOrderTakenBy.PerformLayout();
            this.grpOrderLines.ResumeLayout(false);
            this.grpOrderLines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrderLines)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip tipOrders;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.GroupBox grpOrderLines;
        private System.Windows.Forms.Button btnRemoveOrderLine;
        private System.Windows.Forms.Button btnAddOrderLine;
        private System.Windows.Forms.DataGridView grdOrderLines;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtProductType;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.GroupBox grpOrderTakenBy;
        private System.Windows.Forms.RadioButton radEmail;
        private System.Windows.Forms.RadioButton radPhone;
        private System.Windows.Forms.RadioButton radFax;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Button btnFirstOrder;
        private System.Windows.Forms.Button btnPreviousOrder;
        private System.Windows.Forms.Button btnNextOrder;
        private System.Windows.Forms.Button btnLastOrder;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
    }
}