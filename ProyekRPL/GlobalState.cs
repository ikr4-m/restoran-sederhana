namespace ProyekRPL
{
    class GlobalState
    {
        /// <summary>
        /// Keadaan login dari database, defaultnya adalah false.
        /// </summary>
        public static bool LoginState = false;
        
        public enum UserRole
        {
            Admin, Kasir, Koki, Waiter, None
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
