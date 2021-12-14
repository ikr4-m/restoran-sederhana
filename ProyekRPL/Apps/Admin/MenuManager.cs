using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using ProyekRPL.Module;

namespace ProyekRPL.Apps.Admin
{
    public partial class MenuManager : MetroForm
    {
        public MenuManager()
        {
            InitializeComponent();
        }

        public enum EModifyMenuMode { Insert, Edit, None }
        public static EModifyMenuMode ModifyMenuMode = EModifyMenuMode.None;
        public static Dictionary<string, string> SelectedEditRows;

        private void MenuInsertDatagrid(string[][] data)
        {
            ArrayList arr = new ArrayList();

            // Bersihkan data dan masukkan data manual
            MenuDataGrid.Rows.Clear();
            foreach (string[] s in data)
            {
                arr.Add(s[0]);
                arr.Add(s[1]);
                arr.Add(s[2]);
                arr.Add(s[3]);
                arr.Add(s[4] == "True" ? "Tersedia" : "Tidak Tersedia");
                MenuDataGrid.Rows.Add(arr.ToArray());
                arr = new ArrayList();
            }
        }

        private void RefreshMenuData()
        {
            this.MenuInsertDatagrid(SQL.GetDataQuery("SELECT * FROM menu"));
        }

        private void MenuManager_Load(object sender, EventArgs e)
        {
            this.RefreshMenuData();
        }

        private void MenuRefreshData_Click(object sender, EventArgs e)
        {
            this.RefreshMenuData();
        }

        private void MenuSearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            string query = MenuSearchTextBox.Text;
            query = string.Format("SELECT * FROM menu WHERE id LIKE '%{0}%' OR nama_menu LIKE '%{0}%' OR jenis_menu LIKE '%{0}%'", query);
            this.MenuInsertDatagrid(SQL.GetDataQuery(query));
        }

        private void MenuInsertData_Click(object sender, EventArgs e)
        {
            ModifyMenuMode = EModifyMenuMode.Insert;
            using (ModifyMenu form = new ModifyMenu()) form.ShowDialog();
            ModifyMenuMode = EModifyMenuMode.None;
            this.RefreshMenuData();
        }

        private void MenuEditData_Click(object sender, EventArgs e)
        {
            ModifyMenuMode = EModifyMenuMode.Edit;

            // Masukkan data ke dalam dictionary
            SelectedEditRows = new Dictionary<string, string>();
            var data = MenuDataGrid.SelectedRows[0].Cells;
            for (int i = 0; i < data.Count; i++)
                SelectedEditRows.Add(MenuDataGrid.Columns[data[i].ColumnIndex].Name, DataGridHelper.GetValueSelectedRow(MenuDataGrid, i));

            using (ModifyMenu form = new ModifyMenu()) form.ShowDialog();
            ModifyMenuMode = EModifyMenuMode.None;
            this.RefreshMenuData();
        }

        private void MenuDeleteData_Click(object sender, EventArgs e)
        {
            uint id = uint.Parse(DataGridHelper.GetValueSelectedRow(MenuDataGrid, 0));

            DialogResult dialog = MessageBox.Show("Apakah anda yakin untuk menghapus data ini?", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No) return;
            SQL.NonReturnQuery(string.Format("DELETE FROM menu WHERE id='{0}'", id.ToString()));

            MessageBox.Show("Menu telah terhapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.RefreshMenuData();
        }
    }
}
