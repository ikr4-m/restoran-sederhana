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

namespace ProyekRPL
{
    public partial class LoginForm : MetroForm
    {
        private int _countMD5 = 1;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            UserLevel.SelectedIndex = 0;
        }

        private void UsernameClearBtn_Click(object sender, EventArgs e)
        {
            UsernameTxt.Text = "";
            UsernameTxt.Focus();
        }

        private void PasswordClearBtn_Click(object sender, EventArgs e)
        {
            PasswordTxt.Text = "";
            PasswordTxt.Focus();
        }

        private void PasswordLogo_Click(object sender, EventArgs e)
        {
            if (_countMD5 == 10)
            {
                (new MD5Generator()).Show();
                _countMD5 = 1;
            }
            else
                _countMD5++;
        }
    }
}
