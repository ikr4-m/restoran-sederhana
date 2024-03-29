﻿using System.Globalization;

namespace ProyekRPL
{
    class GlobalState
    {
        /// <summary>
        /// Keadaan login dari database, defaultnya adalah false.
        /// </summary>
        public static bool LoginState = false;

        /// <summary>
        /// Globalisasi dari aplikasi
        /// </summary>
        public static CultureInfo CultureInfo = CultureInfo.GetCultureInfo("id-ID");
        
        public enum UserRole
        {
            None, Admin, Kasir, Koki, Waiter
        }

        /// <summary>
        /// Yang login saat itu
        /// </summary>
        public class ThatUserLogin
        {
            public static uint ID = 0;
            public static string UserName = "";
            public static string Name = "";
            public static UserRole Role = UserRole.None;
        }
    }
}
