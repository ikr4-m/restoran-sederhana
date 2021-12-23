using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace ProyekRPL.Apps.Cashier
{
    public partial class Transaction : MetroForm
    {
        public Transaction()
        {
            InitializeComponent();
        }

        public static int PayPrice = 0;
        public static uint InvoiceID = 0;

        private void UpdatePrice()
        {
            if (PayTxt.Text == "") PayTxt.Text = "0";
            PayPrice = int.Parse(Regex.Match(PayTxt.Text, @"\d+").Value);

            // Ganti Kembalian
            ChangeTxt.Text = (PayPrice - MainForm.GrandTotalPrice).ToString();
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            // Set Total
            GrandTotalTxt.Text = string.Format(GlobalState.CultureInfo, "{0:C0}", MainForm.GrandTotalPrice);

            this.UpdatePrice();
            this.PayTxt.Focus();
        }

        private void PayTxt_TextChanged(object sender, EventArgs e)
        {
            this.UpdatePrice();
        }

        private void ExecuteBtn_Click(object sender, EventArgs e)
        {
            if (int.Parse(ChangeTxt.Text) < 0)
            {
                MessageBox.Show("Kembalian tidak boleh minus!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            PayPrice = 0;
            this.Close();
        }

        private void PayTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) ExecuteBtn.PerformClick();
            if (e.KeyCode == Keys.Escape) CancelBtn.PerformClick();
        }
    }
}
