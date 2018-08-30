using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcodeDemo
{
    public partial class Form128 : Form
    {
        public Form128()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            using (Graphics g = e.Graphics)
            {
                using (Font fnt = new Font("Arial", 16))
                {
                    string caption = string.Format("Code128 barcode weight={0}", txtWeight.Text);
                    g.DrawString(caption, fnt, System.Drawing.Brushes.Black, 50, 50);
                    caption = string.Format("message='{0}'", txtInput.Text);
                    g.DrawString(caption, fnt, System.Drawing.Brushes.Black, 50, 75);
                    g.DrawImage(pictBarcode.Image, 50, 110);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string barCode = txtInput.Text;
            Bitmap bitMap = new Bitmap(barCode.Length * 40, 80);


            using (Graphics graphics = Graphics.FromImage(bitMap))
            {
                Font oFont = new Font("IDAutomationHC39M", 20);
                PointF point = new PointF(2f, 50f);

                // point.X = 10;
                SolidBrush blackBrush = new SolidBrush(Color.Black);
                SolidBrush whiteBrush = new SolidBrush(Color.White);
                graphics.FillRectangle(whiteBrush, 0, 0, bitMap.Width, bitMap.Height);
                graphics.DrawString("*" + barCode + "*", oFont, blackBrush, point);
            }
            using (MemoryStream ms = new MemoryStream())
            {
                bitMap.Save(ms, ImageFormat.Png);
                pictBarcode.Image = bitMap;
                pictBarcode.Height = bitMap.Height;
                pictBarcode.Width = bitMap.Width;
            }


            //try
            //{
            //    Image myimg = Code128Rendering.MakeBarcodeImage(txtInput.Text, int.Parse(txtWeight.Text), true);
            //    pictBarcode.Image = myimg;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(this, ex.Message, this.Text);
            //}
        }

        private void Form128_Load(object sender, EventArgs e)
        {

        }

        private void cmdPrint_Click(object sender, System.EventArgs e)
        {
           
        }

        private void cmdPrint_Click_1(object sender, EventArgs e)
        {
 printDocument1.Print();
        }
    }
}
