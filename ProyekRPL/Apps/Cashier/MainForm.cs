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
using ProyekRPL.Module;

namespace ProyekRPL.Apps.Cashier
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Ambil nama toko
            this.Text = (new IniFile("ApplicationConfig.ini")).Read("RestaurantName", "General");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginState.Reset();
        }
    }
}
