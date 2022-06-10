using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Mini_Inventory_Control.Forms;
using Mini_Inventory_Control.Properties;
using System.Data;
using System.Diagnostics;
using System.IO;
using Strings = Mini_Inventory_Control.Languages.Strings;

namespace Mini_Inventory_Control
{
    public partial class POForm : Form
    {
        public POForm()
        {
            InitializeComponent();
        }

        public Microsoft.Office.Interop.Excel.Application xlibro;
        private void POForm_Load(object sender, EventArgs e)
        {

            Connections.OpenConnection();
            CheckDGV2();
            GetTextsMain();
        }

        private void CheckDGV2()
        {
            try
            {
                if (Connections.Conexion.State == ConnectionState.Closed)
                {
                    Connections.Conexion.Open();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occurred. The Workbook file is not found, or Microsoft Office is not installed.", "Error");
                MessageBox.Show("You will not be able to save data in the inventory.", "Error");
            }

            var ca = new System.Data.OleDb.OleDbDataAdapter("select * from [orders$] where supplier like'%" + txtSearchS.Text + "%'", Connections.Conexion);
            var cb = new DataSet();
            ca.Fill(cb);
            if (cb.Tables[0].Rows.Count > 0)
            {
                DataGridView2.DataSource = cb.Tables[0];
            }
            else
            {
                DataGridView2.DataSource = null;
            }

            Connections.Conexion.Close();
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

        public void ExcelWoorkshetFF(string NombreTabla)
        {
            string Ruta = Path.Combine(Directory.GetCurrentDirectory(), "database.xlsm");
            xlibro = (Microsoft.Office.Interop.Excel.Application)Interaction.CreateObject("Excel.Application");
            xlibro.Workbooks.Open(Ruta);
            xlibro.Visible = false;
            xlibro.Sheets[NombreTabla].Select();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "0")
            {
                if ((int)MessageBox.Show("Would you like to save this data?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (int)Constants.vbYes)
                {
                    KillExcelProcess();
                    ExcelWoorkshetFF("orders");
                    xlibro.Run("InsertOrder", "orders", txtSupplier.Text, txtItemName.Text, txtQuantity.Text, txtPrice.Text, txtAddress.Text, txtRequest.Text, (object)DateTimePicker2.Value.Date);
                    xlibro.DisplayAlerts = false;
                    xlibro.ActiveWorkbook.Save();
                    KillExcelProcess();
                    CheckDGV2();
                    ClearData2();
                }
            }
            else if ((int)MessageBox.Show("Would you like to update this data?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (int)Constants.vbYes)
            {
                KillExcelProcess();
                ExcelWoorkshetFF("orders");
                xlibro.Run("UpdateOrders", "orders", txtID.Text, txtSupplier.Text, txtItemName.Text, txtQuantity.Text, txtPrice.Text, txtAddress.Text, txtRequest.Text, (object)DateTimePicker2.Value.Date);
                xlibro.DisplayAlerts = false;
                xlibro.ActiveWorkbook.Save();
                KillExcelProcess();
                CheckDGV2();
                ClearData2();
            }
        }

        private void DataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView2.RowCount > 0)
            {
                txtID.Text = Conversions.ToString(DataGridView2.CurrentRow.Cells["ID"].Value);
                txtSupplier.Text = DataGridView2.CurrentRow.Cells["SUPPLIER"].Value.ToString();
                txtItemName.Text = DataGridView2.CurrentRow.Cells["PRODUCT"].Value.ToString();
                txtQuantity.Text = DataGridView2.CurrentRow.Cells["QTY"].Value.ToString();
                txtPrice.Text = DataGridView2.CurrentRow.Cells["UNIT_PRICE"].Value.ToString();
                txtAddress.Text = DataGridView2.CurrentRow.Cells["DELIVERY_ADDRESS"].Value.ToString();
                txtRequest.Text = DataGridView2.CurrentRow.Cells["REQUESTED_BY"].Value.ToString();
                DateTimePicker2.Value = Conversions.ToDate(DataGridView2.CurrentRow.Cells["DATE_SCHEDULED"].Value);
            }
        }

        private void ClearData2()
        {
            txtID.Text = "0";
            txtSupplier.Clear();
            txtItemName.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
            txtAddress.Clear();
            txtRequest.Clear();
            DateTimePicker2.Value = DateTime.Today;
            txtSupplier.Focus();
        }

        private void btnPrintData_Click(object sender, EventArgs e)
        {
            try
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Purchase Order Request";
                printer.SubTitle = "Company Name";
                printer.SubTitleAlignment = StringAlignment.Far;
                printer.SubTitleFormatFlags = StringFormatFlags.DirectionRightToLeft;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = true;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Center;
                printer.KeepRowsTogether = true;
                printer.Footer = string.Format("Date: {0}. Sign here:   ", DateTime.Now.Date);
                printer.FooterSpacing = 15;
                printer.ColumnWidth = DGVPrinter.ColumnWidthSetting.CellWidth;
                printer.PrintPreviewDataGridView(DataGridView2);

            }
            catch (Exception)
            {

                MessageBox.Show("No data for printing", "Error");
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ClearData2();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if ((int)MessageBox.Show("Would you like to delete this data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (int)Constants.vbYes)
            {
                ExcelWoorkshetFF("orders");
                xlibro.Run("DeleteOrder", txtID.Text);
                xlibro.ActiveWorkbook.Save();
                KillExcelProcess();
                CheckDGV2();
                ClearData2();
            }
        }

        public void GetTextsMain()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Settings.Default.Lenguajes);
            LabelPO.Text = Strings.LabelPO;
            LabelSU.Text = Strings.LabelSU;
            LabelDATE.Text = Strings.LabelDATE;
            LabelITEM.Text = Strings.LabelITEM;
            LabelQTY.Text = Strings.LabelQTY;
            LabelUNIT.Text = Strings.LabelUNIT;
            labelDELIVERY.Text = Strings.labelDELIVERY;
            labelREQUEST.Text = Strings.labelREQUEST;
            btnSaveOrder.Text = Strings.btnSaveOrder;
            btnDeleteOrder.Text = Strings.btnDeleteOrder;
            btnClearOrder.Text = Strings.btnClearOrder;
            btnPrintDataOrder.Text = Strings.btnPrintDataOrder;
            btnSearchS.Text = Strings.btnSearchS;
            labelSEARCHS.Text = Strings.labelSEARCHS;
            this.Text = Strings.titleorder;
        }


        private void btnSearchS_Click(object sender, EventArgs e)
        {
            CheckDGV2();
        }

        private void POForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }
    }
}
