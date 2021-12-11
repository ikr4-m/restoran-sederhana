using System;
using System.Threading;
using System.Windows.Forms;

namespace ProyekRPL.Module
{
    public partial class LoadingScreen : Form
    {
        public string ScreenLoadingText
        {
            get { return this.ScreenLoading.Text; }
            set { this.ScreenLoading.Text = value;}
        }

        public LoadingScreen()
        {
            InitializeComponent();
        }
    }
}
