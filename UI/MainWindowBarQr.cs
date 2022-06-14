using Mini_Inventory_Control.Properties;
using QrBar;
using ZXing;
using Strings = Mini_Inventory_Control.Languages.Strings;

namespace c_sahrp
{
    public partial class MainWindowBarQr : Form
    {
        public MainWindowBarQr()
        {
            InitializeComponent();
        }

        public void SaveCode()
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Save code|*.png",
                InitialDirectory = @"C:\Users\ariel\Desktop\Codes"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pbgenerar.Image.Save(sfd.FileName);
            }
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            if (txtQr.Text != "")
            {
                BarcodeWriter br = new BarcodeWriter();
                br.Format = BarcodeFormat.QR_CODE;
                Bitmap bm = new Bitmap(br.Write(txtQr.Text), 300, 300);
                pbgenerar.Image = bm;
            }
        }

        private void barCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (barCodeTextBox.Text != "")
            {
                BarcodeWriter br = new BarcodeWriter();
                br.Format = BarcodeFormat.CODE_128;
                Bitmap bm = new Bitmap(br.Write(barCodeTextBox.Text), 380, 260);
                pbgenerar.Image = bm;
            }
        }

        private void generateButton1_Click(object sender, EventArgs e)
        {
            SaveCode();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            GetTextsMain();
        }

        public void GetTextsMain()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Settings.Default.Lenguajes);
            generateButton1.Text = Strings.generateButton1;
            this.Text = Strings.MainWindowBarQr;
            leerUnCódigoQRODeBarraToolStripMenuItem.Text = Strings.leerUnCódigoQRODeBarraToolStripMenuItem;
            leerUnCódigoToolStripMenuItem.Text = Strings.leerUnCódigoToolStripMenuItem;
            lbBar.Text = Strings.lbBar;
        }

        private void leerUnCódigoQRODeBarraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenCodeForm newOpenCodeForm = new();
            newOpenCodeForm.ShowDialog();
        }

        private void salirDeLaAplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainWindowBarQr_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }
    }
}