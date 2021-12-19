using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ProyekRPL.Module;

namespace ProyekRPL.Apps.Report.Invoice
{
    public partial class PrintInvoice : Form
    {
        public PrintInvoice()
        {
            InitializeComponent();

            IniFile ini = new IniFile("ApplicationConfig.ini");
            RestaurantIdentity.Name = ini.Read("RestaurantName", "General");
            RestaurantIdentity.Address = ini.Read("Address", "General");
            RestaurantIdentity.PhoneNumber = ini.Read("PhoneNumber", "General");
        }

        private readonly int _widthGraph = 40;
        private class RestaurantIdentity
        {
            public static string Name = "";
            public static string Address = "";
            public static string PhoneNumber = "";
        }

        private int CenterTextPosition(string text)
        {
            return (int)Math.Floor((decimal)(this._widthGraph / 2 - text.Length / 2));
        }

        private string EmptyStringCenter(string text)
        {
            return new string(' ', CenterTextPosition(text)) + text;
        }

        private string[] SplitMaxString(string text)
        {
            int max = this._widthGraph;
            List<string> list = new List<string>();

            // String lebih lebar dari batas maximum
            if (text.Length > max)
            {
                string[] split = text.Split(' ');
                List<string> temp = new List<string>();
                foreach (string s in split)
                {
                    temp.Add(s);
                    string strTemp = string.Join(" ", temp.ToArray());
                    if (strTemp.Length > max)
                    {
                        temp.RemoveAt(temp.Count - 1);
                        list.Add(string.Join(" ", temp.ToArray()));
                        temp = new List<string> { s };
                    }
                }
                list.Add(string.Join(" ", temp.ToArray()));
            }
            else
                list.Add(text);

            return list.ToArray();
        }

        private void PrintInvoice_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int startX = 0;
            int startY = 0;
            int offset = 10;

            void DrawString(string text, bool center = false)
            {
                string[] splitted = SplitMaxString(text);
                foreach (string s in splitted)
                {
                    startY += offset * 2;
                    g.DrawString(center ? EmptyStringCenter(s) : s, new Font("Hack NF", 10),
                        new SolidBrush(Color.Black),
                        startX + offset, startY + offset);
                }
            }

            // Awalan dikurang offset 2x
            startY -= offset * 2;

            // Header
            DrawString(new string('-', this._widthGraph));
            DrawString(RestaurantIdentity.Name, true);
            DrawString(RestaurantIdentity.Address, true);
            DrawString("Telp. " + RestaurantIdentity.PhoneNumber, true);
            DrawString(new string('-', this._widthGraph));
        }
    }
}
