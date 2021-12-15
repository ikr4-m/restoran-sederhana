using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProyekRPL.Module;

namespace ProyekRPL.Apps.Tracing
{
    public partial class TracerPeeker : Form
    {
        public TracerPeeker()
        {
            InitializeComponent();
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

        private void TracerPeeker_Load(object sender, EventArgs e)
        {
            string query = "SELECT list_pesanan.id, menu_id, menu.nama_menu, menu.harga, qty, (menu.harga * qty) AS total" +
                " FROM list_pesanan inner join menu on menu.id = list_pesanan.menu_id WHERE pesanan_id='" +
                Tracer.PeekID.ID + "'";
            this.OrderInsertDatagrid(SQL.GetDataQuery(query));

            this.Text = string.Format("Invoice ID: ({0}) {1} / {2}",
                Tracer.PeekID.ID,
                Tracer.PeekID.Name,
                Tracer.PeekID.Timestamp);

            this.OrderDataGrid.Focus();
        }

        private void OrderDataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
