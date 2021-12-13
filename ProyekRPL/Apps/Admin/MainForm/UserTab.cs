using ProyekRPL.Module;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyekRPL.Apps.Admin
{
    public partial class MainForm
    {
        public enum EModifyUserMode { Insert, Edit, None }
        public static EModifyUserMode ModifyUserMode = EModifyUserMode.None;

        private void UserInsertDatagrid(string[][] data)
        {
            ArrayList arr = new ArrayList();

            // Bersihkan data dan masukkan data manual
            UserDataGrid.Rows.Clear();
            foreach (string[] s in data)
            {
                arr.Add(s[0]);
                arr.Add(s[1]);
                arr.Add(s[3]);
                arr.Add(s[4]);
                UserDataGrid.Rows.Add(arr.ToArray());
                arr = new ArrayList();
            }
        }

        private void RefreshUserData()
        {
            Initial.ConfigDatabase();
            this.UserInsertDatagrid(SQL.GetDataQuery("SELECT * FROM user"));
        }

        private void UserInsertData_Click(object sender, EventArgs e)
        {
            ModifyUserMode = EModifyUserMode.Insert;
            using (ModifyUser form = new ModifyUser()) form.ShowDialog();
            ModifyUserMode = EModifyUserMode.None;
            this.RefreshUserData();
        }

        private void UserEditData_Click(object sender, EventArgs e)
        {
            ModifyUserMode = EModifyUserMode.Edit;

            // Masukkan data ke dalam dictionary
            SelectedEditRows = new Dictionary<string, string>();
            var data = UserDataGrid.SelectedRows[0].Cells;
            for (int i = 0; i < data.Count; i++)
                SelectedEditRows.Add(UserDataGrid.Columns[data[i].ColumnIndex].Name, GetValueDataGrid(UserDataGrid, i));

            using (ModifyUser form = new ModifyUser()) form.ShowDialog();
            ModifyUserMode = EModifyUserMode.None;
            this.RefreshUserData();
        }

        private void UserDeleteData_Click(object sender, EventArgs e)
        {
            uint id = uint.Parse(this.GetValueDataGrid(UserDataGrid, 0));
            if (id == 1)
            {
                MessageBox.Show("Anda tidak bisa menghapus akun superadmin!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (GlobalState.ThatUserLogin.ID == id)
            {
                MessageBox.Show("Anda tidak bisa menghapus akun anda sendiri!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialog = MessageBox.Show("Apakah anda yakin untuk menghapus data ini?", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No) return;
            SQL.NonReturnQuery(string.Format("DELETE FROM user WHERE id='{0}'", id.ToString()));

            MessageBox.Show("User telah terhapus!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.RefreshUserData();
        }

        private void UserRefreshData_Click(object sender, EventArgs e)
        {
            this.RefreshUserData();
        }

        private void UserSearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            string query = UserSearchTextBox.Text;
            query = string.Format("SELECT * FROM user WHERE id LIKE '%{0}%' OR username LIKE '%{0}%' OR nama LIKE '%{0}%' OR role LIKE '%{0}%'", query);
            this.UserInsertDatagrid(SQL.GetDataQuery(query));
        }
    }
}
