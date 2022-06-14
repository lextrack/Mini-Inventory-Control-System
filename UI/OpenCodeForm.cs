using Mini_Inventory_Control.Properties;
using ZXing;
using Strings = Mini_Inventory_Control.Languages.Strings;

namespace QrBar
{
    public partial class OpenCodeForm : Form
    {
        public OpenCodeForm()
        {
            InitializeComponent();
        }

        private void btnOpenCode_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Imagen png|*.png",
                InitialDirectory = @"C:\Users\ariel\Desktop\code"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbshowfile.Image = Image.FromFile(ofd.FileName);
                BarcodeReader br = new BarcodeReader();
                string texto = br.Decode((Bitmap)pbshowfile.Image).ToString();
                txtShowCode.Text = texto;
            }
        }

        private void OpenCodeForm_Load(object sender, EventArgs e)
        {
            GetTextsMain();
        }

        private void GetTextsMain()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Settings.Default.Lenguajes);
            btnOpenCode.Text = Strings.btnOpenCode;
            this.Text = Strings.OpenCodeForm;
        }

        private void OpenCodeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }
    }
}
