namespace Mini_Inventory_Control
{
    partial class POForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POForm));
            this.labelSEARCHS = new System.Windows.Forms.Label();
            this.txtSearchS = new System.Windows.Forms.TextBox();
            this.btnSearchS = new System.Windows.Forms.Button();
            this.labelREQUEST = new System.Windows.Forms.Label();
            this.txtRequest = new System.Windows.Forms.TextBox();
            this.labelDELIVERY = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnPrintDataOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.DataGridView2 = new System.Windows.Forms.DataGridView();
            this.LabelDATE = new System.Windows.Forms.Label();
            this.LabelSU = new System.Windows.Forms.Label();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.LabelQTY = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.LabelUNIT = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.LabelITEM = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.LabelPO = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSEARCHS
            // 
            this.labelSEARCHS.AutoSize = true;
            this.labelSEARCHS.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelSEARCHS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSEARCHS.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSEARCHS.Location = new System.Drawing.Point(13, 261);
            this.labelSEARCHS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSEARCHS.Name = "labelSEARCHS";
            this.labelSEARCHS.Size = new System.Drawing.Size(125, 17);
            this.labelSEARCHS.TabIndex = 91;
            this.labelSEARCHS.Text = "SEARCH A SUPPLIER";
            // 
            // txtSearchS
            // 
            this.txtSearchS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchS.Location = new System.Drawing.Point(13, 281);
            this.txtSearchS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearchS.Name = "txtSearchS";
            this.txtSearchS.Size = new System.Drawing.Size(334, 25);
            this.txtSearchS.TabIndex = 11;
            // 
            // btnSearchS
            // 
            this.btnSearchS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSearchS.FlatAppearance.BorderSize = 2;
            this.btnSearchS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchS.Location = new System.Drawing.Point(368, 277);
            this.btnSearchS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearchS.Name = "btnSearchS";
            this.btnSearchS.Size = new System.Drawing.Size(163, 32);
            this.btnSearchS.TabIndex = 12;
            this.btnSearchS.Text = "Search";
            this.btnSearchS.UseVisualStyleBackColor = true;
            this.btnSearchS.Click += new System.EventHandler(this.btnSearchS_Click);
            // 
            // labelREQUEST
            // 
            this.labelREQUEST.AutoSize = true;
            this.labelREQUEST.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelREQUEST.ForeColor = System.Drawing.SystemColors.Control;
            this.labelREQUEST.Location = new System.Drawing.Point(13, 155);
            this.labelREQUEST.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelREQUEST.Name = "labelREQUEST";
            this.labelREQUEST.Size = new System.Drawing.Size(97, 17);
            this.labelREQUEST.TabIndex = 88;
            this.labelREQUEST.Text = "REQUESTED BY";
            // 
            // txtRequest
            // 
            this.txtRequest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRequest.Location = new System.Drawing.Point(13, 173);
            this.txtRequest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.Size = new System.Drawing.Size(334, 25);
            this.txtRequest.TabIndex = 6;
            // 
            // labelDELIVERY
            // 
            this.labelDELIVERY.AutoSize = true;
            this.labelDELIVERY.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDELIVERY.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDELIVERY.Location = new System.Drawing.Point(368, 106);
            this.labelDELIVERY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDELIVERY.Name = "labelDELIVERY";
            this.labelDELIVERY.Size = new System.Drawing.Size(122, 17);
            this.labelDELIVERY.TabIndex = 86;
            this.labelDELIVERY.Text = "DELIVERY ADDRESS";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress.Location = new System.Drawing.Point(368, 124);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(342, 25);
            this.txtAddress.TabIndex = 5;
            // 
            // DateTimePicker2
            // 
            this.DateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateTimePicker2.CustomFormat = "MM-dd-yyyy";
            this.DateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker2.Location = new System.Drawing.Point(368, 173);
            this.DateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DateTimePicker2.Name = "DateTimePicker2";
            this.DateTimePicker2.Size = new System.Drawing.Size(166, 25);
            this.DateTimePicker2.TabIndex = 84;
            // 
            // btnPrintDataOrder
            // 
            this.btnPrintDataOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPrintDataOrder.FlatAppearance.BorderSize = 2;
            this.btnPrintDataOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrintDataOrder.Location = new System.Drawing.Point(547, 218);
            this.btnPrintDataOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrintDataOrder.Name = "btnPrintDataOrder";
            this.btnPrintDataOrder.Size = new System.Drawing.Size(163, 32);
            this.btnPrintDataOrder.TabIndex = 10;
            this.btnPrintDataOrder.Text = "Print";
            this.btnPrintDataOrder.UseVisualStyleBackColor = true;
            this.btnPrintDataOrder.Click += new System.EventHandler(this.btnPrintData_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDeleteOrder.FlatAppearance.BorderSize = 2;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteOrder.Location = new System.Drawing.Point(184, 217);
            this.btnDeleteOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(163, 31);
            this.btnDeleteOrder.TabIndex = 8;
            this.btnDeleteOrder.Text = "Delete data";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSaveOrder.FlatAppearance.BorderSize = 2;
            this.btnSaveOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveOrder.Location = new System.Drawing.Point(13, 217);
            this.btnSaveOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(163, 31);
            this.btnSaveOrder.TabIndex = 7;
            this.btnSaveOrder.Text = "Save or update data";
            this.btnSaveOrder.UseVisualStyleBackColor = true;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClearOrder.FlatAppearance.BorderSize = 2;
            this.btnClearOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearOrder.Location = new System.Drawing.Point(368, 217);
            this.btnClearOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(163, 32);
            this.btnClearOrder.TabIndex = 9;
            this.btnClearOrder.Text = "Clear All";
            this.btnClearOrder.UseVisualStyleBackColor = true;
            this.btnClearOrder.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // DataGridView2
            // 
            this.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataGridView2.Location = new System.Drawing.Point(0, 318);
            this.DataGridView2.Name = "DataGridView2";
            this.DataGridView2.RowTemplate.Height = 25;
            this.DataGridView2.Size = new System.Drawing.Size(728, 200);
            this.DataGridView2.TabIndex = 79;
            this.DataGridView2.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellEnter);
            // 
            // LabelDATE
            // 
            this.LabelDATE.AutoSize = true;
            this.LabelDATE.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelDATE.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelDATE.Location = new System.Drawing.Point(368, 153);
            this.LabelDATE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDATE.Name = "LabelDATE";
            this.LabelDATE.Size = new System.Drawing.Size(113, 17);
            this.LabelDATE.TabIndex = 78;
            this.LabelDATE.Text = "DATE SCHEDULED";
            // 
            // LabelSU
            // 
            this.LabelSU.AutoSize = true;
            this.LabelSU.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelSU.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelSU.Location = new System.Drawing.Point(368, 9);
            this.LabelSU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSU.Name = "LabelSU";
            this.LabelSU.Size = new System.Drawing.Size(62, 17);
            this.LabelSU.TabIndex = 77;
            this.LabelSU.Text = "SUPPLIER";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSupplier.Location = new System.Drawing.Point(368, 29);
            this.txtSupplier.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(342, 25);
            this.txtSupplier.TabIndex = 1;
            // 
            // LabelQTY
            // 
            this.LabelQTY.AutoSize = true;
            this.LabelQTY.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelQTY.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelQTY.Location = new System.Drawing.Point(368, 58);
            this.LabelQTY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelQTY.Name = "LabelQTY";
            this.LabelQTY.Size = new System.Drawing.Size(31, 17);
            this.LabelQTY.TabIndex = 76;
            this.LabelQTY.Text = "QTY";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantity.Location = new System.Drawing.Point(368, 77);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(342, 25);
            this.txtQuantity.TabIndex = 3;
            // 
            // LabelUNIT
            // 
            this.LabelUNIT.AutoSize = true;
            this.LabelUNIT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelUNIT.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelUNIT.Location = new System.Drawing.Point(13, 106);
            this.LabelUNIT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelUNIT.Name = "LabelUNIT";
            this.LabelUNIT.Size = new System.Drawing.Size(74, 17);
            this.LabelUNIT.TabIndex = 75;
            this.LabelUNIT.Text = "UNIT PRICE";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrice.Location = new System.Drawing.Point(13, 124);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(334, 25);
            this.txtPrice.TabIndex = 4;
            // 
            // LabelITEM
            // 
            this.LabelITEM.AutoSize = true;
            this.LabelITEM.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelITEM.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelITEM.Location = new System.Drawing.Point(13, 57);
            this.LabelITEM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelITEM.Name = "LabelITEM";
            this.LabelITEM.Size = new System.Drawing.Size(37, 17);
            this.LabelITEM.TabIndex = 74;
            this.LabelITEM.Text = "ITEM";
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtItemName.Location = new System.Drawing.Point(13, 77);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(334, 25);
            this.txtItemName.TabIndex = 2;
            // 
            // LabelPO
            // 
            this.LabelPO.AutoSize = true;
            this.LabelPO.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelPO.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelPO.Location = new System.Drawing.Point(13, 9);
            this.LabelPO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPO.Name = "LabelPO";
            this.LabelPO.Size = new System.Drawing.Size(109, 17);
            this.LabelPO.TabIndex = 73;
            this.LabelPO.Text = "P.O NUMBER (ID)";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtID.Location = new System.Drawing.Point(13, 29);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(334, 25);
            this.txtID.TabIndex = 68;
            this.txtID.Text = "0";
            // 
            // POForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(728, 518);
            this.Controls.Add(this.labelSEARCHS);
            this.Controls.Add(this.txtSearchS);
            this.Controls.Add(this.btnSearchS);
            this.Controls.Add(this.labelREQUEST);
            this.Controls.Add(this.txtRequest);
            this.Controls.Add(this.labelDELIVERY);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.DateTimePicker2);
            this.Controls.Add(this.btnPrintDataOrder);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnSaveOrder);
            this.Controls.Add(this.btnClearOrder);
            this.Controls.Add(this.DataGridView2);
            this.Controls.Add(this.LabelDATE);
            this.Controls.Add(this.LabelSU);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.LabelQTY);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.LabelUNIT);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.LabelITEM);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.LabelPO);
            this.Controls.Add(this.txtID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "POForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Orders";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.POForm_FormClosed);
            this.Load += new System.EventHandler(this.POForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Label labelSEARCHS;
        internal TextBox txtSearchS;
        internal Button btnSearchS;
        internal Label labelREQUEST;
        internal TextBox txtRequest;
        internal Label labelDELIVERY;
        internal TextBox txtAddress;
        internal DateTimePicker DateTimePicker2;
        internal Button btnPrintDataOrder;
        internal Button btnDeleteOrder;
        internal Button btnSaveOrder;
        internal Button btnClearOrder;
        private DataGridView DataGridView2;
        internal Label LabelDATE;
        internal Label LabelSU;
        internal TextBox txtSupplier;
        internal Label LabelQTY;
        internal TextBox txtQuantity;
        internal Label LabelUNIT;
        internal TextBox txtPrice;
        internal Label LabelITEM;
        internal TextBox txtItemName;
        internal TextBox txtID;
        public Label LabelPO;
    }
}