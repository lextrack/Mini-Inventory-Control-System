using c_sahrp;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Mini_Inventory_Control.Properties;
using Mini_Inventory_Control.UI;
using System.Data;
using System.Diagnostics;
using System.IO;
using Strings = Mini_Inventory_Control.Languages.Strings;

namespace Mini_Inventory_Control
{
    public partial class InventoryControlMainWindow
    {
        public InventoryControlMainWindow()
        {
            InitializeComponent();
        }

        public Microsoft.Office.Interop.Excel.Application xlibro;

        private void MainForm_Load(object sender, EventArgs e)
        {
            Connection.OpenConnection();
            CheckDGV();
            GetTextsMain();
        }

        private void CheckDGV()
        {
            try
            {
                if (Connection.Conexion.State == ConnectionState.Closed)
                {
                    Connection.Conexion.Open();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Strings.message1, "Error");
            }

            var da = new System.Data.OleDb.OleDbDataAdapter("select * from [datos$] where collaborator like'%" + txtBuscar.Text + "%'", Connection.Conexion);
            var ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                DataGridView1.DataSource = null;
            }

            Connection.Conexion.Close();
        }

        //save button
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "0")
            {
                if ((int)MessageBox.Show(Strings.message2, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (int)Constants.vbYes)
                {
                    KillExcelProcess();
                    ExcelWoorkshetF("datos");
                    xlibro.Run("InsertarRegistro", "datos", txtDescripcion.Text, txtCantidad_entradas.Text, txtCantidad_salidas.Text, txtPrecio_compra.Text, txtColaborador.Text, txtUbicacion.Text, txtSupplier.Text, txtPoNumber.Text, txtReport.Text, (object)DateTimePicker1.Value.Date);
                    xlibro.DisplayAlerts = false;
                    xlibro.ActiveWorkbook.Save();
                    KillExcelProcess();
                    CheckDGV();
                    ClearData();
                }
            }
            else if ((int)MessageBox.Show(Strings.message3, "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (int)Constants.vbYes)
            {
                KillExcelProcess();
                ExcelWoorkshetF("datos");
                xlibro.Run("ActualizarDatos", "datos", txtID.Text, txtDescripcion.Text, txtCantidad_entradas.Text, txtCantidad_salidas.Text, txtPrecio_compra.Text, txtColaborador.Text, txtUbicacion.Text, txtSupplier.Text, txtPoNumber.Text, txtReport.Text, (object)DateTimePicker1.Value.Date);
                xlibro.DisplayAlerts = false;
                xlibro.ActiveWorkbook.Save();
                KillExcelProcess();
                CheckDGV();
                ClearData();
            }
        }

        //update button
        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "0")
            {
                if ((int)MessageBox.Show(Strings.message4, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (int)Constants.vbYes)
                {
                    KillExcelProcess();
                    ExcelWoorkshetF("datos");
                    xlibro.Run("InsertarRegistro", "datos", txtDescripcion.Text, txtCantidad_entradas.Text, txtCantidad_salidas.Text, txtPrecio_compra.Text, txtColaborador.Text, txtUbicacion.Text, txtSupplier.Text, txtPoNumber.Text, txtReport.Text, (object)DateTimePicker1.Value.Date);
                    xlibro.DisplayAlerts = false;
                    xlibro.ActiveWorkbook.Save();
                    KillExcelProcess();
                    CheckDGV();
                    ClearData();
                }
            }
            else if ((int)MessageBox.Show(Strings.message5, "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (int)Constants.vbYes)
            {
                KillExcelProcess();
                ExcelWoorkshetF("datos");
                xlibro.Run("ActualizarDatos", "datos", txtID.Text, txtDescripcion.Text, txtCantidad_entradas.Text, txtCantidad_salidas.Text, txtPrecio_compra.Text, txtColaborador.Text, txtUbicacion.Text, txtSupplier.Text, txtPoNumber.Text, txtReport.Text, (object)DateTimePicker1.Value.Date);
                xlibro.DisplayAlerts = false;
                xlibro.ActiveWorkbook.Save();
                KillExcelProcess();
                CheckDGV();
                ClearData();
            }
        }

        public static void KillExcelProcess()
        {
            try
            {
                var Xcel = Process.GetProcessesByName("EXCEL");
                foreach (Process Process in Xcel)
                    Process.Kill();
            }
            catch (Exception)
            {

            }
        }

        public void ExcelWoorkshetF(string NombreTabla)
        {
            string dbPath = Path.Combine(Directory.GetCurrentDirectory(), "database.xlsm");
            xlibro = (Microsoft.Office.Interop.Excel.Application)Interaction.CreateObject("Excel.Application");
            xlibro.Workbooks.Open(dbPath);
            xlibro.Visible = false;
            xlibro.Sheets[NombreTabla].Select();
        }

        private void ClearData()
        {
            txtID.Text = "0";
            txtDescripcion.Clear();
            txtCantidad_entradas.Clear();
            txtCantidad_salidas.Clear();
            txtPrecio_compra.Clear();
            txtColaborador.Clear();
            txtUbicacion.Clear();
            txtSupplier.Clear();
            txtPoNumber.Clear();
            txtReport.Clear();
            DateTimePicker1.Value = DateTime.Today;
            txtDescripcion.Focus();
        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView1.RowCount > 0)
            {
                txtID.Text = Conversions.ToString(DataGridView1.CurrentRow.Cells["ID"].Value);
                txtDescripcion.Text = DataGridView1.CurrentRow.Cells["PRODUCT"].Value.ToString();
                txtCantidad_entradas.Text = DataGridView1.CurrentRow.Cells["INCOMINGS"].Value.ToString();
                txtCantidad_salidas.Text = DataGridView1.CurrentRow.Cells["OUTGOINGS"].Value.ToString();
                txtPrecio_compra.Text = DataGridView1.CurrentRow.Cells["UNIT_PRICE"].Value.ToString();
                txtColaborador.Text = DataGridView1.CurrentRow.Cells["COLLABORATOR"].Value.ToString();
                txtUbicacion.Text = DataGridView1.CurrentRow.Cells["LOCATION"].Value.ToString();
                txtSupplier.Text = DataGridView1.CurrentRow.Cells["SUPPLIER"].Value.ToString();
                txtPoNumber.Text = DataGridView1.CurrentRow.Cells["PO_NUMBER"].Value.ToString();
                txtReport.Text = DataGridView1.CurrentRow.Cells["OBSERVATIONS"].Value.ToString();
                DateTimePicker1.Value = Conversions.ToDate(DataGridView1.CurrentRow.Cells["DATE_ENTRY"].Value);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if ((int)MessageBox.Show(Strings.message6, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (int)Constants.vbYes)
            {
                ExcelWoorkshetF("datos");
                xlibro.Run("EliminaRegistro", txtID.Text);
                xlibro.ActiveWorkbook.Save();
                KillExcelProcess();
                CheckDGV();
                ClearData();
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CheckDGV();
        }

        #region Button search item name
        private void button3_Click(object sender, EventArgs e)
        {
            var de = new System.Data.OleDb.OleDbDataAdapter("select * from [datos$] where description like'%" + txtBuscarD.Text + "%'", Connection.Conexion);
            var df = new DataSet();
            de.Fill(df);
            if (df.Tables[0].Rows.Count > 0)
            {
                DataGridView1.DataSource = df.Tables[0];
            }
            else
            {
                DataGridView1.DataSource = null;
            }

            Connection.Conexion.Close();

        }
        #endregion


        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutForm NewAbout = new AboutForm();
            NewAbout.ShowDialog();
        }

        private void generateBarcodeAndQRCodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarQrMainWindow NewMainWindowBarQr = new BarQrMainWindow();
            NewMainWindowBarQr.ShowDialog();
        }

        private void btnNuevo_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Clear everything from the TextBoxs", btnNuevoC);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        /*private void purchaseOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            POForm POForm = new();
            POForm.ShowDialog();
        }*/

        #region PrintCode
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Stock";
                printer.SubTitle = "Company Name";
                printer.SubTitleAlignment = StringAlignment.Near;
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = true;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.KeepRowsTogether = true;
                printer.Footer = string.Format("Date: {0}", DateTime.Now.Date);
                printer.FooterSpacing = 15;
                printer.ColumnWidth = DGVPrinter.ColumnWidthSetting.Porportional;
                printer.printDocument.DefaultPageSettings.Landscape = true;
                printer.PrintPreviewDataGridView(DataGridView1);

            }
            catch (Exception)
            {

                MessageBox.Show(Strings.message7, "Error");
            }

        }
        #endregion

        #region TranslationCode
        public void GetTextsMain()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Settings.Default.Lenguajes);
            Label8.Text = Strings.Label8;
            Label2.Text = Strings.Label2;
            Label6.Text = Strings.Label6;
            Label3.Text = Strings.Label3;
            Label7.Text = Strings.Label7;
            Label10.Text = Strings.Label10;
            Label4.Text = Strings.Label4;
            label13.Text = Strings.label13;
            label14.Text = Strings.label14;
            label15.Text = Strings.label15;
            label11.Text = Strings.label11;
            Label9.Text = Strings.Label9;
            btnGuardarS.Text = Strings.btnGuardarS;
            btnEliminarS.Text = Strings.btnEliminarS;
            btnUpdateData.Text = Strings.btnUpdateData;
            btnNuevoC.Text = Strings.btnNuevoC;
            btnSearchIn.Text = Strings.btnSearchIn;
            btnBuscarIn.Text = Strings.btnBuscarIn;
            Label5.Text = Strings.Label5;
            optionsToolStripMenuItem.Text = Strings.optionsToolStripMenuItem;
            toolStripMenuItem4.Text = Strings.toolStripMenuItem4;
            toolStripMenuItem3.Text = Strings.toolStripMenuItem3;
            toolStripMenuItem2.Text = Strings.toolStripMenuItem2;
            toolStripMenuItem1.Text = Strings.toolStripMenuItem1;
            exitApplicationToolStripMenuItem.Text = Strings.exitApplicationToolStripMenuItem;
            generateBarcodeAndQRCodesToolStripMenuItem.Text = Strings.generateBarcodeAndQRCodesToolStripMenuItem;
            this.Text = Strings.titleinventory;
        }

        public void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default.Lenguajes = "es-ES";
            GetTextsMain();
        }

        public void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default.Lenguajes = "en-US";
            GetTextsMain();
        }

        private void InventoryControlForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }
        #endregion
    }
}