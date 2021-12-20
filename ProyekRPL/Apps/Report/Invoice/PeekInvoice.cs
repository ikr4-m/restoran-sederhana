using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyekRPL.Module;

namespace ProyekRPL.Apps.Report.Invoice
{
    public partial class PeekInvoice : Form
    {
        public PeekInvoice()
        {
            InitializeComponent();
        }

        private int GrandTotal = 0;

        private void OrderInsertDatagrid(string[][] data)
        {
            List<string> arr = new List<string>();
            OrderDataGrid.Rows.Clear();
            foreach (string[] s in data)
            {
                foreach (string s2 in s) arr.Add(s2);
                OrderDataGrid.Rows.Add(arr.ToArray());
                arr = new List<string>();
                GrandTotal += int.Parse(s[5]);
            }
        }

        private void PeekInvoice_Load(object sender, EventArgs e)
        {
            string query = "SELECT list_pesanan.id, menu_id, menu.nama_menu, menu.harga, qty, (menu.harga * qty) AS total" +
                " FROM list_pesanan inner join menu on menu.id = list_pesanan.menu_id WHERE pesanan_id='" +
                InvoiceList.PeekID.ID + "'";
            this.OrderInsertDatagrid(SQL.GetDataQuery(query));

            this.Text = string.Format("Invoice ID: ({0}) {1} / {2}",
                InvoiceList.PeekID.InvoiceID,
                InvoiceList.PeekID.Name,
                InvoiceList.PeekID.Timestamp);

            TotalLabel.Text = "Total: " + string.Format(GlobalState.CultureInfo, "{0:C0}", GrandTotal);
        }
    }
}
