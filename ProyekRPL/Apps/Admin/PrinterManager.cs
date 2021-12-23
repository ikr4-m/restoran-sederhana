using ESCPOS_NET;
using ESCPOS_NET.Emitters;
using ESCPOS_NET.Utilities;
using System;
using System.Diagnostics;
using System.Management;
using System.Windows.Forms;


namespace ProyekRPL.Apps.Admin
{
    public partial class PrinterManager : Form
    {
        public PrinterManager()
        {
            InitializeComponent();
        }

        private void PrinterManager_Load(object sender, EventArgs e)
        {
            var printer = new SerialPrinter(portName: "COM3", baudRate: 115200);
            var ep = new EPSON();

            printer.StatusChanged += Printer_StatusChanged;

            printer.Write(
  ByteSplicer.Combine(
    ep.CenterAlign(),
    ep.PrintLine("\n"),
    ep.SetBarWidth(BarWidth.Default),
    ep.SetBarLabelPosition(BarLabelPrintPosition.None),
    ep.PrintBarcode(BarcodeType.ITF, "0123456789"),
    ep.PrintLine("\n"),
    ep.PrintLine("B&H PHOTO & VIDEO"),
    ep.PrintLine("420 NINTH AVE."),
    ep.PrintLine("NEW YORK, NY 10001"),
    ep.PrintLine("(212) 502-6380 - (800)947-9975"),
    ep.SetStyles(PrintStyle.Underline),
    ep.PrintLine("www.bhphotovideo.com"),
    ep.SetStyles(PrintStyle.None),
    ep.PrintLine("\n"),
    ep.LeftAlign(),
    ep.PrintLine("Order: 123456789        Date: 02/01/19"),
    ep.PrintLine("\n"),
    ep.PrintLine("\n"),
    ep.SetStyles(PrintStyle.FontB),
    ep.PrintLine("1   TRITON LOW-NOISE IN-LINE MICROPHONE PREAMP"),
    ep.PrintLine("    TRFETHEAD/FETHEAD                        89.95         89.95"),
    ep.PrintLine("----------------------------------------------------------------"),
    ep.RightAlign(),
    ep.PrintLine("SUBTOTAL         89.95"),
    ep.PrintLine("Total Order:         89.95"),
    ep.PrintLine("Total Payment:         89.95"),
    ep.PrintLine("\n"),
    ep.LeftAlign(),
    ep.SetStyles(PrintStyle.Bold | PrintStyle.FontB),
    ep.PrintLine("SOLD TO:                        SHIP TO:"),
    ep.SetStyles(PrintStyle.FontB),
    ep.PrintLine("  FIRSTN LASTNAME                 FIRSTN LASTNAME"),
    ep.PrintLine("  123 FAKE ST.                    123 FAKE ST."),
    ep.PrintLine("  DECATUR, IL 12345               DECATUR, IL 12345"),
    ep.PrintLine("  (123)456-7890                   (123)456-7890"),
    ep.PrintLine("  CUST: 87654321"),
    ep.PrintLine("\n"),
    ep.PrintLine("\n")
  )
);
        }

        private void Printer_StatusChanged(object sender, EventArgs ps)
        {
            var status = (PrinterStatusEventArgs)ps;
            Debug.WriteLine($"Status: {status.IsPrinterOnline}");
            Debug.WriteLine($"Has Paper? {status.IsPaperOut}");
            Debug.WriteLine($"Paper Running Low? {status.IsPaperLow}");
            Debug.WriteLine($"Cash Drawer Open? {status.IsCashDrawerOpen}");
            Debug.WriteLine($"Cover Open? {status.IsCoverOpen}");
        }
    }
}
