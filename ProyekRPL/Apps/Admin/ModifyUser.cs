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

        private uint _id = 0;

        private void CallEditedData()
        {
            UsernameTxt.Text = MainForm.SelectedEditRows["Username"];
            NameTxt.Text = MainForm.SelectedEditRows["Fullname"];
            RoleCmb.Text = MainForm.SelectedEditRows["Role"];
            this._id = uint.Parse(MainForm.SelectedEditRows["ID"]);
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
                case MainForm.EModifyUserMode.Edit:
                    this.Text = "Ubah User";
                    this.ExecuteButton.Text = "Ubah";
                    this.CallEditedData();
                    break;
            }
        }

        private bool IsEmpty(bool editMode = false)
        {
            if (string.IsNullOrEmpty(UsernameTxt.Text) || (string.IsNullOrEmpty(PasswordTxt.Text) && !editMode) ||
                string.IsNullOrEmpty(NameTxt.Text) || string.IsNullOrEmpty(RoleCmb.Text))
            {
                return true; 
            }
            return false;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            if (MainForm.ModifyUserMode == MainForm.EModifyUserMode.Insert)
            {
                if (this.IsEmpty())
                {
                    MessageBox.Show("Isian masih ada yang kosong!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = string.Format("INSERT INTO user (username, password, nama, role) VALUES ('{0}','{1}','{2}','{3}')",
                    UsernameTxt.Text, Module.MD5Factory.Generate(PasswordTxt.Text), NameTxt.Text, RoleCmb.Text);
                Module.SQL.NonReturnQuery(query);

                MessageBox.Show("User berhasil ditambah!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            if (MainForm.ModifyUserMode == MainForm.EModifyUserMode.Edit)
            {
                if (this.IsEmpty(true))
                {
                    MessageBox.Show("Isian masih ada yang kosong!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bool chgPass = !string.IsNullOrEmpty(PasswordTxt.Text);

                string query = string.Format("UPDATE user SET username='{0}', nama='{1}', role='{2}' {3}" +
                    " WHERE id='{4}'",
                    UsernameTxt.Text,
                    NameTxt.Text,
                    RoleCmb.Text,
                    chgPass ? string.Format(", password='{0}'", Module.MD5Factory.Generate(PasswordTxt.Text)) : "",
                    this._id.ToString());
                Module.SQL.NonReturnQuery(query);

                MessageBox.Show("User berhasil diubah!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
