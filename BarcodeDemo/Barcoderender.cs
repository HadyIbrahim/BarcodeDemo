using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcodeDemo
{
    public partial class Barcoderender : Form
    {
        public Barcoderender()
        {
            InitializeComponent();
        }

        private void Barcoderender_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox1.Image = barcode.Draw(textBox1.Text, 50);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDocument1.Print();



        }
        int NoOfTimesToPrint = 5;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


            Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            for (int i = 1; i <= NoOfTimesToPrint; i++)
            {
                pictureBox1.DrawToBitmap(bm, new Rectangle(50, i * 5, pictureBox1.Width, pictureBox1.Height));
            }
            e.Graphics.DrawImage(bm, 50, 0);
            bm.Dispose();



            //Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            //var image = barcode.Draw(textBox1.Text, 50);

            //using (var graphics = Graphics.FromImage(image))
            //using (var font = new Font("Consolas", 12)) // Any font you want
            //using (var brush = new SolidBrush(Color.White))
            //using (var format = new StringFormat() { LineAlignment = StringAlignment.Far }) // To align text above the specified point
            //{
            //    // Print a string at the left bottom corner of image
            //    graphics.DrawString(textBox1.Text, font, brush, 0, image.Height, format);
            //}

            //pictureBox1.Image = image;
        }
    }
}
