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
    public partial class ModifyMenu : MetroForm
    {
        public ModifyMenu()
        {
            InitializeComponent();
        }

        private uint _id = 0;

        private void CallEditedData()
        {
            MenuNameTxt.Text = MenuManager.SelectedEditRows["NamaMenu"];
            MenuCategoryCmb.Text = MenuManager.SelectedEditRows["JenisMenu"];
            PriceTxt.Text = MenuManager.SelectedEditRows["Harga"];
            MenuStatusCmb.Text = MenuManager.SelectedEditRows["StatusMenu"];
            this._id = uint.Parse(MenuManager.SelectedEditRows["IDMenu"]);
        }

        private void ModifyMenu_Load(object sender, EventArgs e)
        {
            switch (MenuManager.ModifyMenuMode)
            {
                case MenuManager.EModifyMenuMode.Insert:
                    this.Text = "Tambah Menu";
                    this.ExecuteButton.Text = "Tambah";
                    break;
                case MenuManager.EModifyMenuMode.Edit:
                    this.Text = "Ubah Menu";
                    this.ExecuteButton.Text = "Ubah";
                    this.CallEditedData();
                    break;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsEmpty()
        {
            if (string.IsNullOrEmpty(MenuNameTxt.Text) || string.IsNullOrEmpty(MenuCategoryCmb.Text) ||
                string.IsNullOrEmpty(PriceTxt.Text) || string.IsNullOrEmpty(MenuStatusCmb.Text))
            {
                return true;
            }
            return false;
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            if (this.IsEmpty())
            {
                MessageBox.Show("Isian masih ada yang kosong!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MenuManager.ModifyMenuMode == MenuManager.EModifyMenuMode.Insert)
            {
                string query = string.Format("INSERT INTO menu (nama_menu, jenis_menu, harga, status_menu) " +
                    "VALUES ('{0}','{1}','{2}','{3}')",
                    MenuNameTxt.Text,
                    MenuCategoryCmb.Text,
                    PriceTxt.Text,
                    MenuStatusCmb.Text == "Tersedia" ? 1 : 0);
                
                Module.SQL.NonReturnQuery(query);
                MessageBox.Show("Menu berhasil ditambah!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (MenuManager.ModifyMenuMode == MenuManager.EModifyMenuMode.Edit)
            {
                string query = string.Format("UPDATE menu SET nama_menu='{0}', jenis_menu='{1}', harga='{2}', status_menu='{3}' WHERE id='{4}'",
                    MenuNameTxt.Text,
                    MenuCategoryCmb.Text,
                    PriceTxt.Text,
                    MenuStatusCmb.Text == "Tersedia" ? 1 : 0,
                    this._id.ToString());

                Module.SQL.NonReturnQuery(query);
                MessageBox.Show("Menu berhasil diubah!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }
    }
}
