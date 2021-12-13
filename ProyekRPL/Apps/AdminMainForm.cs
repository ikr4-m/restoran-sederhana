using System;
using System.Collections;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace ProyekRPL.Apps
{
    public partial class AdminMainForm : MetroForm
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private string GetValueDataGrid(int cellRow)
        {
            var data = UserDataGrid.SelectedRows[0].Cells[cellRow];
            if (data.Value != null) return data.Value.ToString();
            else return null;
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            ArrayList row = new ArrayList();
            row.Add("1");
            row.Add("Admin");
            row.Add("Administrator");
            row.Add("Admin");
            UserDataGrid.Rows.Add(row.ToArray());
        }

        private void AdminMainForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            Module.LoginState.Reset();
        }

        private void UserInsertData_Click(object sender, EventArgs e)
        {

        }

        private void UserEditData_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nama: " + GetValueDataGrid(2));
        }
    }
}
