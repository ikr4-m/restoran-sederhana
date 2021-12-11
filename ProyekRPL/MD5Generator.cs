using System;
using System.Windows.Forms;

namespace ProyekRPL
{
    public partial class MD5Generator : Form
    {
        public MD5Generator()
        {
            InitializeComponent();
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            string md5 = Module.MD5Factory.Generate(PlainTextbox.Text);
            Clipboard.SetText(md5);
            PlainTextbox.Text = "";
            MessageBox.Show(
                "Kode MD5 telah disalin ke clipboard.",
                "Berhasil",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
