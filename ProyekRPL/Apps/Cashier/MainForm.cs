﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MetroFramework.Forms;
using ProyekRPL.Module;
using System.Collections;

namespace ProyekRPL.Apps.Cashier
{
    public partial class MainForm : MetroForm
    {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        public static int GrandTotalPrice = 0;
        public static int PayPrice = 0;
        private uint _ID = 0;

        public MainForm()
        {
            InitializeComponent();

            RegisterHotKey(this.Handle, 1, 0x0000, (int)Keys.F1);
            RegisterHotKey(this.Handle, 2, 0x0000, (int)Keys.F2);
            RegisterHotKey(this.Handle, 3, 0x0000, (int)Keys.F3);
            RegisterHotKey(this.Handle, 4, 0x0000, (int)Keys.F4);
            RegisterHotKey(this.Handle, 5, 0x0000, (int)Keys.F5);
            RegisterHotKey(this.Handle, 6, 0x0000, (int)Keys.F6);
        }

        protected override void WndProc(ref Message m)
        {
            // Kode ini untuk override WndProc untuk membaca hotkey yang
            // diregister saat initialisasi komponen
            if (m.Msg == 0x0312)
            {
                switch (m.WParam.ToInt32())
                {
                    case 1: MenuSearchTxt.Focus(); break;
                    case 2: BuyBtn.PerformClick(); break;
                    case 3: PrintBtn.PerformClick(); break;
                    case 4: ResetBtn.PerformClick(); break;
                    case 5: CustomerNameTxt.Focus(); break;
                    case 6: TableNumberTxt.Focus(); TableNumberTxt.Select(0, TableNumberTxt.Text.Length); break;
                }
            }

            base.WndProc(ref m);
        }

        private void MenuInsertDatagrid(string[][] data)
        {
            ArrayList arr = new ArrayList();
            MenuDataGrid.Rows.Clear();
            foreach (string[] s in data)
            {
                arr.Add(s[0]);
                arr.Add(s[1]);
                arr.Add(s[2]);
                MenuDataGrid.Rows.Add(arr.ToArray());
                arr = new ArrayList();
            }
        }

        private void OrderInsertDatagrid(string[] data)
        {
            ArrayList arr = new ArrayList();
            arr.Add(data[0]);
            arr.Add(data[1]);
            arr.Add(data[2]);
            arr.Add("1");
            arr.Add(data[2]);
            OrderDataGrid.Rows.Add(arr.ToArray());
        }

        private void RefreshMenuData()
        {
            this.MenuInsertDatagrid(SQL.GetDataQuery("SELECT id, nama_menu, harga FROM menu WHERE status_menu='1'"));
        }

        private void UpdatePrice()
        {
            GrandTotalPrice = 0;

            foreach (DataGridViewRow row in OrderDataGrid.Rows)
            {
                // Step 1: Loop semua data di tabel, cocokkan qty dan total
                int priceTotal = int.Parse(row.Cells[2].Value.ToString()) * int.Parse(row.Cells[3].Value.ToString());
                row.Cells[4].Value = priceTotal;

                // Step 2: Masukin ke grand total
                GrandTotalPrice += priceTotal;
            }

            PriceLabel.Text = string.Format(GlobalState.CultureInfo, "{0:C0}", GrandTotalPrice);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.RefreshMenuData();
            this.CustomerNameTxt.Focus();
            this.ChangeLabel.Visible = false;
        }

        private void MenuSearchTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            string query = MenuSearchTxt.Text;
            query = string.Format("SELECT id, nama_menu, harga FROM menu WHERE id LIKE '%{0}%' OR nama_menu LIKE '%{0}%'", query);
            this.MenuInsertDatagrid(SQL.GetDataQuery(query));

            MenuSearchTxt.Text = "";
            MenuDataGrid.Focus();
        }

        private void MenuDataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            List<string> list = new List<string>();
            for (int i = 0; i < 3; i++) list.Add(DataGridHelper.GetValueSelectedRow(MenuDataGrid, i));
            var data = list.ToArray();
            int rowNum = DataGridHelper.IsIncludeCell(OrderDataGrid, 0, data[0]);

            if (rowNum < 0)
            {
                this.OrderInsertDatagrid(data);
            }
            else
            {
                int qty = int.Parse(OrderDataGrid.Rows[rowNum].Cells[3].Value.ToString()) + 1;
                OrderDataGrid.Rows[rowNum].Cells[3].Value = qty.ToString();
            }

            this.UpdatePrice();
            this.RefreshMenuData();
            OrderDataGrid.Focus();
        }

        private void MenuDataGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SendKeys.SendWait("{ENTER}");
        }

        private void OrderDataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
                OrderDataGrid.Rows.RemoveAt(OrderDataGrid.SelectedCells[0].RowIndex);

            this.UpdatePrice();
        }

        private void SyncBtn_Click(object sender, EventArgs e)
        {
            this.UpdatePrice();
            OrderDataGrid.Focus();
        }

        private void BuyBtn_Click(object sender, EventArgs e)
        {
            if (CustomerNameTxt.Text == "")
            {
                MessageBox.Show("Anda tidak menulis nama pemesan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CustomerNameTxt.Focus();
                return;
            }
            if (OrderDataGrid.Rows.Count == 0)
            {
                MessageBox.Show("Anda belum memesan satupun!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var form = new Transaction()) form.ShowDialog();

            PayPrice = Transaction.PayPrice;
            if (PayPrice > 0)
            {
                // Simpan semua datanya ke database
                string query = string.Format("INSERT INTO pesanan (user_id, nama_pemesan, nomor_meja) VALUES ('{0}','{1}','{2}'); SELECT LAST_INSERT_ID();",
                    GlobalState.ThatUserLogin.ID,
                    CustomerNameTxt.Text,
                    TableNumberTxt.Value);
                var lastID = SQL.NonReturnQuery(query).LastInsertedId;
                this._ID = (uint)lastID;

                // Simpan data di tabel ke database
                query = "INSERT INTO list_pesanan (pesanan_id, menu_id, qty) VALUES ";
                List<string> list = new List<string>();
                foreach (DataGridViewRow row in OrderDataGrid.Rows)
                    list.Add(string.Format("('{0}','{1}','{2}')", lastID, row.Cells[0].Value, row.Cells[3].Value));
                query += string.Join(", ", list.ToArray());
                SQL.NonReturnQuery(query);

                // Ganti UI
                string change = string.Format(GlobalState.CultureInfo, "{0:C0}", (PayPrice - GrandTotalPrice));
                ChangeLabel.Text = "Kembalian:\n" + change;
                ChangeLabel.Visible = true;
                BuyBtn.Enabled = false;
                PrintBtn.Enabled = true;
                InvoiceIDTxt.Text = lastID.ToString().PadLeft(5, '0') + "/KSR/" + DateTime.Now.ToString("yyyy");
            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            var param = new Report.Invoice.PrintInvoice.PrintInvoiceParam
            {
                ID = this._ID,
                PayPrice = PayPrice,
                InvoiceID = InvoiceIDTxt.Text
            };
            using (var form = new Report.Invoice.PrintInvoice(param)) form.ShowDialog();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            this.OrderDataGrid.Rows.Clear();
            PriceLabel.Text = "Rp0";

            ChangeLabel.Text = "Kembalian:\nRp0";
            ChangeLabel.Visible = false;
            BuyBtn.Enabled = true;
            PrintBtn.Enabled = false;
            InvoiceIDTxt.Text = "";

            this.CustomerNameTxt.Clear();
            this.CustomerNameTxt.Focus();
        }
    }
}
