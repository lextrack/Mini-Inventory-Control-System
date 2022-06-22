namespace c_sahrp
{
    partial class BarQrMainWindow
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms
        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarQrMainWindow));
            this.txtQr = new System.Windows.Forms.TextBox();
            this.lbQr = new System.Windows.Forms.Label();
            this.pbgenerar = new System.Windows.Forms.PictureBox();
            this.generateButton1 = new System.Windows.Forms.Button();
            this.barCodeTextBox = new System.Windows.Forms.TextBox();
            this.lbBar = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.leerUnCódigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leerUnCódigoQRODeBarraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbgenerar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQr
            // 
            this.txtQr.Location = new System.Drawing.Point(382, 67);
            this.txtQr.Name = "txtQr";
            this.txtQr.Size = new System.Drawing.Size(348, 33);
            this.txtQr.TabIndex = 2;
            this.txtQr.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // lbQr
            // 
            this.lbQr.AutoSize = true;
            this.lbQr.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbQr.ForeColor = System.Drawing.SystemColors.Control;
            this.lbQr.Location = new System.Drawing.Point(382, 39);
            this.lbQr.Name = "lbQr";
            this.lbQr.Size = new System.Drawing.Size(36, 21);
            this.lbQr.TabIndex = 0;
            this.lbQr.Text = "QR:";
            // 
            // pbgenerar
            // 
            this.pbgenerar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbgenerar.Location = new System.Drawing.Point(179, 179);
            this.pbgenerar.Name = "pbgenerar";
            this.pbgenerar.Size = new System.Drawing.Size(386, 262);
            this.pbgenerar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbgenerar.TabIndex = 3;
            this.pbgenerar.TabStop = false;
            // 
            // generateButton1
            // 
            this.generateButton1.FlatAppearance.BorderSize = 2;
            this.generateButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.generateButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.generateButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generateButton1.ForeColor = System.Drawing.Color.Transparent;
            this.generateButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generateButton1.Location = new System.Drawing.Point(243, 118);
            this.generateButton1.Name = "generateButton1";
            this.generateButton1.Size = new System.Drawing.Size(269, 45);
            this.generateButton1.TabIndex = 3;
            this.generateButton1.Text = "Save";
            this.generateButton1.UseVisualStyleBackColor = true;
            this.generateButton1.Click += new System.EventHandler(this.generateButton1_Click);
            // 
            // barCodeTextBox
            // 
            this.barCodeTextBox.Location = new System.Drawing.Point(12, 67);
            this.barCodeTextBox.Name = "barCodeTextBox";
            this.barCodeTextBox.Size = new System.Drawing.Size(348, 33);
            this.barCodeTextBox.TabIndex = 1;
            this.barCodeTextBox.TextChanged += new System.EventHandler(this.barCodeTextBox_TextChanged);
            // 
            // lbBar
            // 
            this.lbBar.AutoSize = true;
            this.lbBar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbBar.ForeColor = System.Drawing.SystemColors.Control;
            this.lbBar.Location = new System.Drawing.Point(12, 39);
            this.lbBar.Name = "lbBar";
            this.lbBar.Size = new System.Drawing.Size(75, 21);
            this.lbBar.TabIndex = 11;
            this.lbBar.Text = "Barcode:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leerUnCódigoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 25);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // leerUnCódigoToolStripMenuItem
            // 
            this.leerUnCódigoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leerUnCódigoQRODeBarraToolStripMenuItem});
            this.leerUnCódigoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leerUnCódigoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.leerUnCódigoToolStripMenuItem.Name = "leerUnCódigoToolStripMenuItem";
            this.leerUnCódigoToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            this.leerUnCódigoToolStripMenuItem.Text = "Options";
            // 
            // leerUnCódigoQRODeBarraToolStripMenuItem
            // 
            this.leerUnCódigoQRODeBarraToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.leerUnCódigoQRODeBarraToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.leerUnCódigoQRODeBarraToolStripMenuItem.Name = "leerUnCódigoQRODeBarraToolStripMenuItem";
            this.leerUnCódigoQRODeBarraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.leerUnCódigoQRODeBarraToolStripMenuItem.Text = "Scan QR codes";
            this.leerUnCódigoQRODeBarraToolStripMenuItem.Click += new System.EventHandler(this.leerUnCódigoQRODeBarraToolStripMenuItem_Click);
            // 
            // MainWindowBarQr
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(742, 453);
            this.Controls.Add(this.lbBar);
            this.Controls.Add(this.barCodeTextBox);
            this.Controls.Add(this.generateButton1);
            this.Controls.Add(this.pbgenerar);
            this.Controls.Add(this.lbQr);
            this.Controls.Add(this.txtQr);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindowBarQr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode and QR code generator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindowBarQr_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbgenerar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.TextBox txtQr;
        private System.Windows.Forms.Label lbQr;
        private System.Windows.Forms.PictureBox pbgenerar;
        private Button generateButton1;
        private TextBox barCodeTextBox;
        private Label lbBar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem leerUnCódigoToolStripMenuItem;
        private ToolStripMenuItem leerUnCódigoQRODeBarraToolStripMenuItem;
    }
}