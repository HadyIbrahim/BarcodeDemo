using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcodeDemo
{
    public partial class BarcodeImage : Form
    {
        public BarcodeImage()
        {
            InitializeComponent();
        }

        private void BarcodeImage_Load(object sender, EventArgs e)
        {
            textBox1.Text = "HADY";

             reportViewer1.LocalReport.ReportPath = @"D:\SAP\Barcode project\Barcode2018\BarcodeDemo\BarcodeDemo\Report1.rdlc";
            //  // reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp });
            //   reportViewer1.LocalReport.DataSources.Add(rds);
          reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string barCode = textBox1.Text;
            Bitmap bitMap = new Bitmap(barCode.Length * 40, 160);
         

            using (Graphics graphics = Graphics.FromImage(bitMap))
            {
                Font oFont = new Font("IDAutomationHC39M", 20, FontStyle.Regular);
                PointF point = new PointF(2f, 5f);
                
                // point.X = 10;
                SolidBrush blackBrush = new SolidBrush(Color.Black);
                SolidBrush whiteBrush = new SolidBrush(Color.White);
                graphics.FillRectangle(whiteBrush, 0, 0, bitMap.Width, bitMap.Height);
                graphics.DrawString("*" + barCode + "*", oFont, blackBrush, point);
            }
            using (MemoryStream ms = new MemoryStream())
            {
                bitMap.Save(ms, ImageFormat.Gif);
                pictureBox1.Image = bitMap;
                pictureBox1.Height = bitMap.Height;
                pictureBox1.Width = bitMap.Width;
            }
        }
        Bitmap bitmapToPrint;
        private void myPrintDocument2_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            //    e.Graphics.DrawImage(pictureBox1.Image, 0.1f, 1.5f);
            bitmapToPrint = new Bitmap(80, 80);
           // Font font = new Font(FontFamily.GenericSansSerif, 120, FontStyle.Regular);
            Font font = new Font("IDAutomationHC39M", 20, FontStyle.Regular);
            string alphabet = "dddddddddd";
            Graphics graphics = Graphics.FromImage(bitmapToPrint);
            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            graphics.DrawString(alphabet, font, System.Drawing.Brushes.Black, 0, 0);
            graphics.DrawString(alphabet, font, System.Drawing.Brushes.Black, 0, 500);
            graphics.DrawString(alphabet, font, System.Drawing.Brushes.White, 0, 300);
            graphics.DrawString(alphabet, font, System.Drawing.Brushes.Black, 0, 300);

            PrintDocument pd = new PrintDocument();
            pd.PrinterSettings.PrinterName = "TOSHIBA B-EX4T2-G (Copy 1)";
            pd.PrinterSettings.PrintToFile = true;
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
            pd.Print();
           // e.Graphics.DrawImage(bitmapToPrint, new RectangleF(0.0f, 0.0f, 850.0f, 1100.0f));

            //  Bitmap myBitmap1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //  //Bitmap myBitmap1 = new Bitmap(300, 500);


            //  // Bitmap bitMap = new Bitmap(barCode.Length * 40, 80);
            ////  myBitmap1.SetResolution(100 ,600 );
            //  // myBitmap1.SetPixel(5,50,System.Drawing.Color.Black);
            //  pictureBox1.DrawToBitmap(myBitmap1, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            //  e.Graphics.DrawImage(myBitmap1,50, 0);
            //  myBitmap1.Dispose();
        }

        void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmapToPrint, new RectangleF(10.0f, 20.0f, 80.0f, 70.0f));
        }
        // myPrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(myPrintDocument2_PrintPage);
        private void button2_Click(object sender, EventArgs e)
        {
            System.Drawing.Printing.PrintDocument myPrintDocument1 = new System.Drawing.Printing.PrintDocument();
            PrintDialog myPrinDialog1 = new PrintDialog();
            myPrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(myPrintDocument2_PrintPage);
            myPrinDialog1.Document = myPrintDocument1;

            if (myPrinDialog1.ShowDialog() == DialogResult.OK)
            {
                myPrintDocument1.PrinterSettings = printDialog1.PrinterSettings;
                myPrintDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            using (Graphics g = e.Graphics)
            {
                using (Font fnt = new Font("code128", 16))
                {
                    string caption = string.Format("code128", "22");
                    g.DrawString(caption, fnt, System.Drawing.Brushes.Black, 50, 50);
                    caption = string.Format(textBox1.Text);
                    g.DrawString(caption, fnt, System.Drawing.Brushes.Black, 50, 75);
                    g.DrawImage(pictureBox1.Image, 50, 110);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
