using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProyekRPL.Module;

namespace ProyekRPL.Apps.Report.Transaction
{
    public partial class TransactionList : Form
    {
        public TransactionList()
        {
            InitializeComponent();
            Initial.ConfigDatabase();
        }

        private bool _isStartPeriode = false;

        private void TransactionList_Load(object sender, EventArgs e)
        {
            StartPeriode.Text = DateTime.Now.ToString("yyyy-MM-dd");
            EndPeriode.Text = DateTime.Now.AddMonths(1).ToString("yyyy-MM-dd");
        }

        private void StartPeriode_MouseClick(object sender, MouseEventArgs e)
        {
            MonthCal.SelectionStart = Convert.ToDateTime(StartPeriode.Text);
            MonthCal.SelectionEnd = Convert.ToDateTime(StartPeriode.Text);
            MonthCal.Visible = true;
            this._isStartPeriode = true;
        }

        private void EndPeriode_MouseClick(object sender, MouseEventArgs e)
        {
            MonthCal.SelectionStart = Convert.ToDateTime(EndPeriode.Text);
            MonthCal.SelectionEnd = Convert.ToDateTime(EndPeriode.Text);
            MonthCal.Visible = true;
            this._isStartPeriode = false;
        }

        private void MonthCal_MouseLeave(object sender, EventArgs e)
        {
            MonthCal.Visible = false;
            this._isStartPeriode = false;
        }

        private void MonthCal_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Start Periode
            if (this._isStartPeriode)
                StartPeriode.Text = MonthCal.SelectionStart.ToString("yyyy-MM-dd");
            else
                EndPeriode.Text = MonthCal.SelectionStart.ToString("yyyy-MM-dd");
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string query = string.Format("SELECT * FROM v_report WHERE tanggal_pemesan BETWEEN '{0}' AND '{1}'",
                StartPeriode.Text, EndPeriode.Text);
            string[][] data = SQL.GetDataQuery(query);

            // Masukkan ke Viewer
            ReportDG.Rows.Clear();
            List<string> d = new List<string>();
            foreach (string[] row in data)
            {
                foreach (string s in row) d.Add(s);
                ReportDG.Rows.Add(d.ToArray());
                d = new List<string>();
            }
        }
    }
}
