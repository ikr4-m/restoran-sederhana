using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Reflection;
using System.Linq;
using TheArtOfDev.HtmlRenderer.PdfSharp;
using ProyekRPL.Module;

namespace ProyekRPL.Apps.Report.Transaction
{
    public partial class TransactionList : Form
    {
        public TransactionList()
        {
            InitializeComponent();
        }

        private bool _isStartPeriode = false;
        private string[][] _data;
        private int _totalQty = 0;
        private int _totalAmount = 0;


        private string GetTemplate()
        {
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("ProyekRPL.Resources.report.html"))
                return new StreamReader(stream).ReadToEnd();
        }

        private string ChangeRowToHTML()
        {
            return string.Join("", _data.Select((x, i) => string.Format(
                @"<tr><td>{0}</td>
                    <td>{1}</td>
                    <td>{2}</td>
                    <td>{3}</td>
                    <td>{4}</td>
                </tr>", i+1, x[0], x[1], x[2], string.Format(GlobalState.CultureInfo, "{0:C0}", int.Parse(x[3])))).ToArray());
        }

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
            this._data = SQL.GetDataQuery(query);

            // Masukkan ke Viewer
            ReportDG.Rows.Clear();
            List<string> d = new List<string>();
            foreach (string[] row in this._data)
            {
                foreach (string s in row) d.Add(s);
                ReportDG.Rows.Add(d.ToArray());
                d = new List<string>();

                this._totalQty += int.Parse(row[2]);
                this._totalAmount += int.Parse(row[3]);
            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            if (ReportDG.Rows.Count < 1)
            {
                MessageBox.Show("Anda belum memunculkan data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string html = string.Format(GetTemplate().ToString(),
                StartPeriode.Text + " - " + EndPeriode.Text,
                ChangeRowToHTML(),
                this._totalQty.ToString(),
                string.Format(GlobalState.CultureInfo, "{0:C0}", this._totalAmount));

            // Convert data
            Byte[] res = null;
            using (MemoryStream ms = new MemoryStream())
            {
                var pdf = PdfGenerator.GeneratePdf(html, PdfSharp.PageSize.A4);
                pdf.Save(ms);
                res = ms.ToArray();
            }

            // Simpan data
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "Simpan laporan";
            dlg.Filter = "PDF Files (*.pdf)|*.pdf";
            dlg.DefaultExt = "pdf";
            dlg.RestoreDirectory = false;
            dlg.FileName = string.Format("Report_{0}.pdf", DateTime.Now.ToString("yyyy-MM-dd"));

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(dlg.FileName, res);
                MessageBox.Show("File berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
