using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyekRPL.Module
{
    class LoginState
    {
        public static void Activate(uint id, string username, string name, string role)
        {
            GlobalState.LoginState = true;
            GlobalState.ThatUserLogin.ID = id;
            GlobalState.ThatUserLogin.UserName = username;
            GlobalState.ThatUserLogin.Name = name;
            Enum.TryParse(role, out GlobalState.ThatUserLogin.Role);
        }

        public static void Reset()
        {
            GlobalState.LoginState = false;
            GlobalState.ThatUserLogin.ID = 0;
            GlobalState.ThatUserLogin.UserName = "";
            GlobalState.ThatUserLogin.Name = "";
            GlobalState.ThatUserLogin.Role = GlobalState.UserRole.None;
        }
    }
}
