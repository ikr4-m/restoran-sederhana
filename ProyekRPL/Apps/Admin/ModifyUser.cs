using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace ProyekRPL.Apps.Admin
{
    public partial class ModifyUser : MetroForm
    {
        public ModifyUser()
        {
            InitializeComponent();
        }

        private void ModifyUser_Load(object sender, EventArgs e)
        {
            // Ganti title
            switch (MainForm.ModifyUserMode)
            {
                case MainForm.EModifyUserMode.Insert: 
                    this.Text = "Tambah User";
                    this.ExecuteButton.Text = "Tambah";
                    break;
                case MainForm.EModifyUserMode.Edit: this.Text = "Ubah User"; break;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
