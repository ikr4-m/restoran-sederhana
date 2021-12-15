﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MetroFramework.Forms;
using ProyekRPL.Module;

namespace ProyekRPL.Apps.Tracing
{
    public partial class Tracer : MetroForm
    {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        public Tracer()
        {
            InitializeComponent();

            RegisterHotKey(this.Handle, 1, 0x0000, (int)Keys.F1);
        }

        protected override void WndProc(ref Message m)
        {
            // Kode ini untuk override WndProc untuk membaca hotkey yang
            // diregister saat initialisasi komponen
            if (m.Msg == 0x0312)
            {
                switch (m.WParam.ToInt32())
                {
                    case 1: ProcessBtn.PerformClick(); break;
                }
            }

            base.WndProc(ref m);
        }

        public class PeekID
        {
            public static uint ID = 0;
            public static string Name = "";
            public static string Timestamp = "";
            public static bool Processed = false;
        }

        private GlobalState.UserRole Role = GlobalState.UserRole.None;

        private void OrderInsertDatagrid(string[][] data)
        {
            List<string> arr = new List<string>();
            foreach (string[] s in data)
            {
                // Karena ini ticking tiap detik, maka tidak ada yang namanya clearing data
                if (DataGridHelper.IsIncludeCell(OrderDataGrid, 0, s[0]) < 0)
                {
                    foreach (string s2 in s) arr.Add(s2);
                    OrderDataGrid.Rows.Add(arr.ToArray());
                    arr = new List<string>();
                }
            }
        }

        private void RefreshOrderData()
        {
            string query = string.Format("SELECT id, tanggal_pemesan, nama_pemesan, nomor_meja, status_pesanan FROM pesanan WHERE status_pesanan='{0}' ORDER BY id ASC",
                Role == GlobalState.UserRole.Koki ? "Masak' OR status_pesanan='Menunggu" : "Dikirim");
            this.OrderInsertDatagrid(SQL.GetDataQuery(query));
        }

        private void Tracer_Load(object sender, EventArgs e)
        {
            // Ambil rolenya
            if (GlobalState.ThatUserLogin.Role == GlobalState.UserRole.Admin)
            {
                DialogResult dialogResult = MessageBox.Show("Pilih \"Yes\" untuk menjadi Koki, dan \"No\" untuk menjadi Waiter.", "Prompt", MessageBoxButtons.YesNo);
                Role = dialogResult == DialogResult.Yes ? GlobalState.UserRole.Koki : GlobalState.UserRole.Waiter;
            }
            else Role = GlobalState.ThatUserLogin.Role;

            // Set title
            switch (Role)
            {
                case GlobalState.UserRole.Koki: this.Text += "Koki"; break;
                case GlobalState.UserRole.Waiter: this.Text += "Waiter"; break;
                default: this.Close(); break;
            }

            // Ambil data
            this.RefreshOrderData();
            this.OrderDataGrid.Focus();
            this.CallingQuery.Enabled = true;
        }

        private void OrderDataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            PeekOrderBtn.PerformClick();
        }

        private void CallingQuery_Tick(object sender, EventArgs e)
        {
            this.RefreshOrderData();
        }

        private void PeekOrderBtn_Click(object sender, EventArgs e)
        {
            PeekID.ID = uint.Parse(DataGridHelper.GetValueSelectedRow(OrderDataGrid, 0));
            PeekID.Name = DataGridHelper.GetValueSelectedRow(OrderDataGrid, 2);
            PeekID.Timestamp = DataGridHelper.GetValueSelectedRow(OrderDataGrid, 1);

            using (var form = new TracerPeeker()) form.ShowDialog();

            PeekID.ID = 0;
            PeekID.Name = "";
            PeekID.Timestamp = "";
            PeekID.Processed = false;
        }

        private void OrderDataGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SendKeys.SendWait("{ENTER}");
        }

        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            string status = DataGridHelper.GetValueSelectedRow(OrderDataGrid, 4);
            uint id = uint.Parse(DataGridHelper.GetValueSelectedRow(OrderDataGrid, 0));

            // Ganti status
            switch (status)
            {
                case "Menunggu": status = "Masak"; break;
                case "Masak": status = "Dikirim"; break;
                case "Dikirim": status = "Selesai"; break;
            }

            DialogResult di = MessageBox.Show("Apakah anda yakin ingin memproses pesanan ini?", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (di != DialogResult.Yes) return;

            // Query
            string query = string.Format("UPDATE pesanan SET status_pesanan='{0}' WHERE id='{1}'",
                status, id);
            SQL.NonReturnQuery(query);

            MessageBox.Show(string.Format("Status pesanan diubah menjadi \"{0}\"", status), "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OrderDataGrid.Rows.Clear();
        }
    }
}
