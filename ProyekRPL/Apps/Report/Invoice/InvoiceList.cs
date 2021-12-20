using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework.Forms;
using ProyekRPL.Module;

namespace ProyekRPL.Apps.Report.Invoice
{
    public partial class InvoiceList : MetroForm
    {
        public InvoiceList()
        {
            InitializeComponent();
        }

        public class PeekID
        {
            public static uint ID = 0;
            public static string Name = "";
            public static string Timestamp = "";
            public static string InvoiceID = "";
        }

        private void OrderInsertDatagrid(string[][] data)
        {
            List<string> arr = new List<string>();
            OrderDataGrid.Rows.Clear();
            foreach (string[] s in data)
            {
                foreach (string s2 in s) arr.Add(s2);
                OrderDataGrid.Rows.Add(arr.ToArray());
                arr = new List<string>();
            }
        }

        private void RefreshOrderData()
        {
            this.OrderInsertDatagrid(
                SQL.GetDataQuery("SELECT id, CONCAT(LPAD(id, 5, '0'), '/KSR/', YEAR(tanggal_pemesan)) as invoiceID, tanggal_pemesan, nama_pemesan FROM pesanan ORDER BY id DESC"));
        }

        private void InvoiceList_Load(object sender, EventArgs e)
        {
            this.RefreshOrderData();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.RefreshOrderData();
        }

        private void OrderDataGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ViewOrderBtn.PerformClick();
        }

        private void ViewOrderBtn_Click(object sender, EventArgs e)
        {
            PeekID.ID = uint.Parse(DataGridHelper.GetValueSelectedRow(OrderDataGrid, 0));
            PeekID.Name = DataGridHelper.GetValueSelectedRow(OrderDataGrid, 3);
            PeekID.Timestamp = DataGridHelper.GetValueSelectedRow(OrderDataGrid, 2);
            PeekID.InvoiceID = DataGridHelper.GetValueSelectedRow(OrderDataGrid, 1);

            using (var form = new PeekInvoice()) form.ShowDialog();

            PeekID.ID = 0;
            PeekID.Name = "";
            PeekID.Timestamp = "";
            PeekID.InvoiceID = "";
        }
    }
}
