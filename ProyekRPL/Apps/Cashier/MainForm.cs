using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
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
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        public MainForm()
        {
            InitializeComponent();

            RegisterHotKey(this.Handle, 1, 0x0000, (int)Keys.F1);
            RegisterHotKey(this.Handle, 2, 0x0000, (int)Keys.F2);
            RegisterHotKey(this.Handle, 3, 0x0000, (int)Keys.F3);
            RegisterHotKey(this.Handle, 4, 0x0000, (int)Keys.F4);
        }

        protected override void WndProc(ref Message m)
        {
            // Kode ini untuk override WndProc untuk membaca hotkey yang
            // diregister saat initialisasi komponen
            if (m.Msg == 0x0312)
            {
                switch (m.WParam.ToInt32())
                {
                    case 1: MenuSearchTxt.Focus(); break;
                    case 2: BuyBtn.PerformClick(); break;
                    case 3: PrintBtn.PerformClick(); break;
                    case 4: ResetBtn.PerformClick(); break;
                }
            }

            base.WndProc(ref m);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //
        }

        private void BuyBtn_Click(object sender, EventArgs e)
        {
            //
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            //
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
