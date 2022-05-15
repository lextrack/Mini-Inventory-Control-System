using Microsoft.VisualBasic.CompilerServices;
using System.Diagnostics;
using System.Windows.Forms;
using Mini_Inventory_Control.Properties;

namespace Mini_Inventory_Control
{
    [DesignerGenerated()]
    public partial class InventoryControlForm : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryControlForm));
            this.btnEliminarS = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtColaborador = new System.Windows.Forms.TextBox();
            this.btnGuardarS = new System.Windows.Forms.Button();
            this.btnNuevoC = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtCantidad_entradas = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtCantidad_salidas = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtPrecio_compra = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSearchIn = new System.Windows.Forms.Button();
            this.btnBuscarIn = new System.Windows.Forms.Button();
            this.txtBuscarD = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtReport = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPoNumber = new System.Windows.Forms.TextBox();
            this.btnUpdateData = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.españolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Label5 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminarS
            // 
            this.btnEliminarS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEliminarS.FlatAppearance.BorderSize = 2;
            this.btnEliminarS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarS.Location = new System.Drawing.Point(1007, 60);
            this.btnEliminarS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminarS.Name = "btnEliminarS";
            this.btnEliminarS.Size = new System.Drawing.Size(172, 31);
            this.btnEliminarS.TabIndex = 14;
            this.btnEliminarS.Text = "Delete from the inventory";
            this.btnEliminarS.UseVisualStyleBackColor = true;
            this.btnEliminarS.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label6.ForeColor = System.Drawing.SystemColors.Control;
            this.Label6.Location = new System.Drawing.Point(434, 89);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(102, 17);
            this.Label6.TabIndex = 30;
            this.Label6.Text = "COLLABORATOR";
            // 
            // txtColaborador
            // 
            this.txtColaborador.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtColaborador.Location = new System.Drawing.Point(434, 108);
            this.txtColaborador.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtColaborador.Name = "txtColaborador";
            this.txtColaborador.Size = new System.Drawing.Size(373, 25);
            this.txtColaborador.TabIndex = 7;
            // 
            // btnGuardarS
            // 
            this.btnGuardarS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGuardarS.FlatAppearance.BorderSize = 2;
            this.btnGuardarS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarS.Location = new System.Drawing.Point(825, 60);
            this.btnGuardarS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardarS.Name = "btnGuardarS";
            this.btnGuardarS.Size = new System.Drawing.Size(174, 31);
            this.btnGuardarS.TabIndex = 11;
            this.btnGuardarS.Text = "Save data";
            this.btnGuardarS.UseVisualStyleBackColor = true;
            this.btnGuardarS.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevoC
            // 
            this.btnNuevoC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNuevoC.FlatAppearance.BorderSize = 2;
            this.btnNuevoC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNuevoC.Location = new System.Drawing.Point(1007, 105);
            this.btnNuevoC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNuevoC.Name = "btnNuevoC";
            this.btnNuevoC.Size = new System.Drawing.Size(172, 32);
            this.btnNuevoC.TabIndex = 13;
            this.btnNuevoC.Text = "Clear All";
            this.btnNuevoC.UseVisualStyleBackColor = true;
            this.btnNuevoC.Click += new System.EventHandler(this.btnNuevo_Click);
            this.btnNuevoC.MouseHover += new System.EventHandler(this.btnNuevo_MouseHover);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label4.ForeColor = System.Drawing.SystemColors.Control;
            this.Label4.Location = new System.Drawing.Point(433, 183);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(38, 17);
            this.Label4.TabIndex = 28;
            this.Label4.Text = "DATE";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label3.ForeColor = System.Drawing.SystemColors.Control;
            this.Label3.Location = new System.Drawing.Point(13, 137);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(148, 17);
            this.Label3.TabIndex = 27;
            this.Label3.Text = "INCOMING QUANTITIES";
            // 
            // txtCantidad_entradas
            // 
            this.txtCantidad_entradas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCantidad_entradas.Location = new System.Drawing.Point(13, 155);
            this.txtCantidad_entradas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCantidad_entradas.Name = "txtCantidad_entradas";
            this.txtCantidad_entradas.Size = new System.Drawing.Size(373, 25);
            this.txtCantidad_entradas.TabIndex = 3;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label2.ForeColor = System.Drawing.SystemColors.Control;
            this.Label2.Location = new System.Drawing.Point(13, 88);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(66, 17);
            this.Label2.TabIndex = 25;
            this.Label2.Text = "PRODUCT";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescripcion.Location = new System.Drawing.Point(13, 108);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(373, 25);
            this.txtDescripcion.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label1.ForeColor = System.Drawing.SystemColors.Control;
            this.Label1.Location = new System.Drawing.Point(13, 40);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(20, 17);
            this.Label1.TabIndex = 22;
            this.Label1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtID.Location = new System.Drawing.Point(13, 60);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(373, 25);
            this.txtID.TabIndex = 1;
            this.txtID.Text = "0";
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.Location = new System.Drawing.Point(0, 338);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DataGridView1.MultiSelect = false;
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(1190, 279);
            this.DataGridView1.TabIndex = 33;
            this.DataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEnter);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label7.ForeColor = System.Drawing.SystemColors.Control;
            this.Label7.Location = new System.Drawing.Point(12, 184);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(149, 17);
            this.Label7.TabIndex = 35;
            this.Label7.Text = "OUTGOING QUANTITIES";
            // 
            // txtCantidad_salidas
            // 
            this.txtCantidad_salidas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCantidad_salidas.Location = new System.Drawing.Point(13, 204);
            this.txtCantidad_salidas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCantidad_salidas.Name = "txtCantidad_salidas";
            this.txtCantidad_salidas.Size = new System.Drawing.Size(373, 25);
            this.txtCantidad_salidas.TabIndex = 4;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label8.ForeColor = System.Drawing.SystemColors.Control;
            this.Label8.Location = new System.Drawing.Point(434, 40);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(74, 17);
            this.Label8.TabIndex = 37;
            this.Label8.Text = "UNIT PRICE";
            // 
            // txtPrecio_compra
            // 
            this.txtPrecio_compra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecio_compra.Location = new System.Drawing.Point(434, 60);
            this.txtPrecio_compra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPrecio_compra.Name = "txtPrecio_compra";
            this.txtPrecio_compra.Size = new System.Drawing.Size(373, 25);
            this.txtPrecio_compra.TabIndex = 6;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label10.ForeColor = System.Drawing.SystemColors.Control;
            this.Label10.Location = new System.Drawing.Point(434, 135);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(69, 17);
            this.Label10.TabIndex = 39;
            this.Label10.Text = "LOCATION";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUbicacion.Location = new System.Drawing.Point(434, 155);
            this.txtUbicacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(373, 25);
            this.txtUbicacion.TabIndex = 8;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateTimePicker1.CustomFormat = "MM-dd-yyyy";
            this.DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker1.Location = new System.Drawing.Point(434, 204);
            this.DateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(166, 25);
            this.DateTimePicker1.TabIndex = 9;
            // 
            // btnSearchIn
            // 
            this.btnSearchIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSearchIn.FlatAppearance.BorderSize = 2;
            this.btnSearchIn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchIn.Location = new System.Drawing.Point(825, 300);
            this.btnSearchIn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearchIn.Name = "btnSearchIn";
            this.btnSearchIn.Size = new System.Drawing.Size(176, 32);
            this.btnSearchIn.TabIndex = 18;
            this.btnSearchIn.Text = "Search item in inventory";
            this.btnSearchIn.UseVisualStyleBackColor = true;
            this.btnSearchIn.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBuscarIn
            // 
            this.btnBuscarIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBuscarIn.FlatAppearance.BorderSize = 2;
            this.btnBuscarIn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarIn.Location = new System.Drawing.Point(1009, 300);
            this.btnBuscarIn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscarIn.Name = "btnBuscarIn";
            this.btnBuscarIn.Size = new System.Drawing.Size(170, 32);
            this.btnBuscarIn.TabIndex = 17;
            this.btnBuscarIn.Text = "Search collaborator";
            this.btnBuscarIn.UseVisualStyleBackColor = true;
            this.btnBuscarIn.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarD
            // 
            this.txtBuscarD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBuscarD.Location = new System.Drawing.Point(825, 255);
            this.txtBuscarD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBuscarD.Name = "txtBuscarD";
            this.txtBuscarD.Size = new System.Drawing.Size(176, 25);
            this.txtBuscarD.TabIndex = 12;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBuscar.Location = new System.Drawing.Point(1009, 255);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(170, 25);
            this.txtBuscar.TabIndex = 13;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label9.ForeColor = System.Drawing.SystemColors.Control;
            this.Label9.Location = new System.Drawing.Point(1007, 235);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(165, 17);
            this.Label9.TabIndex = 38;
            this.Label9.Text = "SEARCH A COLLABORATOR";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(847, 235);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 17);
            this.label11.TabIndex = 41;
            this.label11.Text = "SEARCH FOR AN ITEM";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(12, 284);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 17);
            this.label15.TabIndex = 42;
            this.label15.Text = "OBSERVATIONS";
            // 
            // txtReport
            // 
            this.txtReport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtReport.Location = new System.Drawing.Point(12, 304);
            this.txtReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtReport.Name = "txtReport";
            this.txtReport.Size = new System.Drawing.Size(795, 25);
            this.txtReport.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(12, 235);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 17);
            this.label13.TabIndex = 45;
            this.label13.Text = "SUPPLIER";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSupplier.Location = new System.Drawing.Point(12, 255);
            this.txtSupplier.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(373, 25);
            this.txtSupplier.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(434, 235);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 17);
            this.label14.TabIndex = 47;
            this.label14.Text = "P.O NUMBER";
            // 
            // txtPoNumber
            // 
            this.txtPoNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPoNumber.Location = new System.Drawing.Point(433, 255);
            this.txtPoNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPoNumber.Name = "txtPoNumber";
            this.txtPoNumber.Size = new System.Drawing.Size(374, 25);
            this.txtPoNumber.TabIndex = 10;
            // 
            // btnUpdateData
            // 
            this.btnUpdateData.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpdateData.FlatAppearance.BorderSize = 2;
            this.btnUpdateData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateData.Location = new System.Drawing.Point(825, 105);
            this.btnUpdateData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateData.Name = "btnUpdateData";
            this.btnUpdateData.Size = new System.Drawing.Size(174, 31);
            this.btnUpdateData.TabIndex = 48;
            this.btnUpdateData.Text = "Update data";
            this.btnUpdateData.UseVisualStyleBackColor = true;
            this.btnUpdateData.Click += new System.EventHandler(this.btnUpdateData_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Brown;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.purchaseOrdersToolStripMenuItem,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1190, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.exitApplicationToolStripMenuItem});
            this.optionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem3.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(289, 22);
            this.toolStripMenuItem3.Text = "Print";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(289, 22);
            this.toolStripMenuItem2.Text = "Restart app";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(289, 22);
            this.toolStripMenuItem1.Text = "About Mini Inventory Control System";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exitApplicationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitApplicationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.exitApplicationToolStripMenuItem.Text = "Exit application";
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);
            // 
            // purchaseOrdersToolStripMenuItem
            // 
            this.purchaseOrdersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.purchaseOrdersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.purchaseOrdersToolStripMenuItem.Name = "purchaseOrdersToolStripMenuItem";
            this.purchaseOrdersToolStripMenuItem.Size = new System.Drawing.Size(118, 21);
            this.purchaseOrdersToolStripMenuItem.Text = "Purchase orders";
            this.purchaseOrdersToolStripMenuItem.Click += new System.EventHandler(this.purchaseOrdersToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.españolToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem4.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(85, 21);
            this.toolStripMenuItem4.Text = "Languages";
            // 
            // españolToolStripMenuItem
            // 
            this.españolToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.españolToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.españolToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.españolToolStripMenuItem.Name = "españolToolStripMenuItem";
            this.españolToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.españolToolStripMenuItem.Text = "Español";
            this.españolToolStripMenuItem.Click += new System.EventHandler(this.españolToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.englishToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.englishToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // Label5
            // 
            this.Label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label5.AutoSize = true;
            this.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label5.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label5.ForeColor = System.Drawing.SystemColors.Control;
            this.Label5.Location = new System.Drawing.Point(424, 2);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(347, 31);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "INVENTORY CONTROL SYSTEM";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Brown;
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.menuStrip1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1190, 37);
            this.Panel1.TabIndex = 1;
            // 
            // InventoryControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1190, 617);
            this.Controls.Add(this.btnUpdateData);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtPoNumber);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.txtReport);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.txtBuscarD);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.btnSearchIn);
            this.Controls.Add(this.btnBuscarIn);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.txtPrecio_compra);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.txtCantidad_salidas);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.btnEliminarS);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtColaborador);
            this.Controls.Add(this.btnGuardarS);
            this.Controls.Add(this.btnNuevoC);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtCantidad_entradas);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "InventoryControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Inventory Control System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InventoryControlForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal Button btnEliminarS;
        internal Label Label6;
        internal TextBox txtColaborador;
        internal Button btnGuardarS;
        internal Button btnNuevoC;
        internal Label Label4;
        internal Label Label3;
        internal TextBox txtCantidad_entradas;
        internal Label Label2;
        internal TextBox txtDescripcion;
        internal Label Label1;
        internal TextBox txtID;
        internal DataGridView DataGridView1;
        internal Label Label7;
        internal TextBox txtCantidad_salidas;
        internal TextBox txtPrecio_compra;
        internal Label Label10;
        internal TextBox txtUbicacion;
        internal DateTimePicker DateTimePicker1;
        internal Button btnSearchIn;
        internal Button btnBuscarIn;
        internal TextBox txtBuscarD;
        internal TextBox txtBuscar;
        internal Label Label9;
        internal Label label11;
        internal Label label15;
        internal TextBox txtReport;
        internal Label label13;
        internal TextBox txtSupplier;
        internal Label label14;
        internal TextBox txtPoNumber;
        internal Button btnUpdateData;
        private ToolTip toolTip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem exitApplicationToolStripMenuItem;
        private ToolStripMenuItem purchaseOrdersToolStripMenuItem;
        internal Label Label5;
        internal Panel Panel1;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem españolToolStripMenuItem;
        private ToolStripMenuItem englishToolStripMenuItem;
        public Label Label8;
    }
}