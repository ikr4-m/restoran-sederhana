using System;
using System.Collections;
using System.Windows.Forms;
using MetroFramework.Forms;
using ProyekRPL.Module;

namespace ProyekRPL.Apps.Admin
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public enum EModifyUserMode { Insert, Edit, None }
        public static EModifyUserMode ModifyUserMode = EModifyUserMode.None;

        private string GetValueDataGrid(int cellRow)
        {
            var data = UserDataGrid.SelectedRows[0].Cells[cellRow];
            if (data.Value != null) return data.Value.ToString();
            else return null;
        }

        private void RefreshData()
        {
            Initial.ConfigDatabase();

            string[][] data = SQL.GetDataQuery("SELECT * FROM user");
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
            }
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            this.RefreshData();
        }

        private void AdminMainForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            LoginState.Reset();
        }

        private void UserInsertData_Click(object sender, EventArgs e)
        {
            ModifyUserMode = EModifyUserMode.Insert;
            using (ModifyUser form = new ModifyUser()) form.ShowDialog();
            ModifyUserMode = EModifyUserMode.None;
        }

        private void UserEditData_Click(object sender, EventArgs e)
        {
            ModifyUserMode = EModifyUserMode.Edit;
            using (ModifyUser form = new ModifyUser()) form.ShowDialog();
            ModifyUserMode = EModifyUserMode.None;
        }

        private void UserDeleteData_Click(object sender, EventArgs e)
        {
            uint id = uint.Parse(this.GetValueDataGrid(0));
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
        }

        private void UserRefreshData_Click(object sender, EventArgs e)
        {
            this.RefreshData();
        }
    }
}
