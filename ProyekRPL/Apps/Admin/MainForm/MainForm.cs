using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using ProyekRPL.Module;

namespace ProyekRPL.Apps.Admin
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static Dictionary<string, string> SelectedEditRows;

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            this.TabCon.SelectedTab = UserManagementTab;
            this.RefreshUserData();
            this.RefreshMenuData();
        }

        private void AdminMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginState.Reset();
        }

        private string GetValueDataGrid(MetroGrid grid, int cellRow)
        {
            var data = grid.SelectedRows[0].Cells[cellRow];
            if (data.Value != null) return data.Value.ToString();
            else return null;
        }
    }
}
