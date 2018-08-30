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
    public partial class BarCodeGeneration : Form
    {
        public static int MAXID;
        public static int MAX_Serial_ID;
        Classes.BrcodeProvider b = new Classes.BrcodeProvider();
        public BarCodeGeneration()
        {
            InitializeComponent();
        }

        private void BarCodeGeneration_Load(object sender, EventArgs e)
        {
            //get max ID
            //  GetMaxBarcodeID();
            GetMaxSerialID();

            txt_day.Text = DateTime.Today.Day.ToString();
            txt_month.Text = DateTime.Now.Month.ToString();
            txt_year.Text = DateTime.Now.Year.ToString();

            LoadShiftCodes();
            LoadProductionLines();
            LoadTarget();
            LoadFactories();
            LoadMaterialCategory();
            BarCodeGenerate();
            

        }
        private void BarCodeGenerate()
        {
            ///////////BARCODE GENERATION/////////
            string barCode = txt_day.Text + txt_month.Text + txt_year.Text + combo_FcatoryCode.SelectedValue.ToString() + combo_PRD_Line.SelectedValue.ToString() + combo_shiftCode.SelectedValue.ToString() + txt_serial.Text + combo_target.SelectedValue.ToString() + combo_MaterialCat.SelectedValue.ToString() + 1;
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

            ///////////END OF BARCODE GENERATION/////////
        }
        private void GetMaxBarcodeID()
        {
            DataTable dt_max = new DataTable();
            dt_max=  b.GetMaxID();
            string ID = dt_max.Rows[0]["MAX_ID"].ToString();

            if (ID=="")
            {
                MAXID = 1;
                txt_serial.Text = MAXID.ToString();
            }
            else
            {
                MAXID = Convert.ToInt32( dt_max.Rows[0]["MAX_ID"].ToString());
            }

            
        }


        private void GetMaxSerialID()
        {
            DataTable dt_max = new DataTable();
            dt_max = b.GetMax_Serial();
            string ID = dt_max.Rows[0]["MAX_serial"].ToString();

            if (ID == "")
            {
                MAX_Serial_ID = 1;
                txt_serial.Text = MAX_Serial_ID.ToString();
            }
            else
            {
                MAX_Serial_ID = Convert.ToInt32(dt_max.Rows[0]["MAX_serial"].ToString());
                MAX_Serial_ID = MAX_Serial_ID + 1;
                txt_serial.Text = MAX_Serial_ID.ToString();

            }


        }


        private void LoadMaterialCategory()
        {
            Dictionary<string, string> MaterialCat = new Dictionary<string, string>();
            MaterialCat.Add("S", " غسالة");
            MaterialCat.Add("E", " ثلاجة");
            MaterialCat.Add("M", "مروحة");
            combo_MaterialCat.DataSource = new BindingSource(MaterialCat, null);
            combo_MaterialCat.DisplayMember = "Value";
            combo_MaterialCat.ValueMember = "Key";
            combo_MaterialCat.SelectedIndex = 0;
        }

        private void LoadFactories()
        {
            Dictionary<string, string> Factory = new Dictionary<string, string>();
            Factory.Add("S", "مصنع الغسالة");
            Factory.Add("E", "مصنه الثلاجة");
            Factory.Add("M", "مصنع اللوحات");
             combo_FcatoryCode.DataSource = new BindingSource(Factory, null);
            combo_FcatoryCode.DisplayMember = "Value";
            combo_FcatoryCode.ValueMember = "Key";
            combo_FcatoryCode.SelectedIndex = 0;

        }
        private void LoadTarget()
        {
            Dictionary<string, string> Target = new Dictionary<string, string>();
            Target.Add("S", "Sales");
            Target.Add("E", "Export");
            Target.Add("M", "Maintenance");
          
            combo_target.DataSource = new BindingSource(Target, null);
            combo_target.DisplayMember = "Value";
            combo_target.ValueMember = "Key";

            combo_target.SelectedIndex = 0;

        }
        private void LoadProductionLines()
        {

            
            Dictionary<string, string> Shifts = new Dictionary<string, string>();
            Shifts.Add("A", "A");
            Shifts.Add("B", "B");
            Shifts.Add("C", "C");
            Shifts.Add("D", "D");
            Shifts.Add("E", "E");
            combo_PRD_Line.DataSource = new BindingSource(Shifts, null);
            combo_PRD_Line.DisplayMember = "Value";
            combo_PRD_Line.ValueMember = "Key";

            combo_PRD_Line.SelectedIndex = 0;
        }


        private void LoadShiftCodes()
        {
                   
// Bind combobox to dictionary
            Dictionary<string, string> Shifts = new Dictionary<string, string>();
            Shifts.Add("A", "A");
            Shifts.Add("B", "B");
            Shifts.Add("C", "C");
            combo_shiftCode.DataSource = new BindingSource(Shifts, null);
            combo_shiftCode.DisplayMember = "Value";
            combo_shiftCode.ValueMember = "Key";

            combo_shiftCode.SelectedIndex = 0;
        }

        private void Btn_generate_Click(object sender, EventArgs e)
        {

            //get maxid
            // GetMaxBarcodeID();
            GetMaxSerialID();

             //  MAXID = 0;
             MAXID = b.GenerateBarcode(txt_day.Text, txt_month.Text, txt_year.Text, combo_FcatoryCode.SelectedValue.ToString(), combo_PRD_Line.SelectedValue.ToString(), combo_shiftCode.SelectedValue.ToString(), txt_serial.Text, combo_target.SelectedValue.ToString(), combo_MaterialCat.SelectedValue.ToString(), 1);


            // txt_serial.Text = MAXID.ToString();
           


            MAX_Serial_ID = MAX_Serial_ID + 1;
            txt_serial.Text = MAX_Serial_ID.ToString();
            BarCodeGenerate();

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            using (Graphics g = e.Graphics)
            {
                using (Font fnt = new Font("Arial", 16))
                {
                    string caption = string.Format("Code128 barcode weight={0}", 10);
                    g.DrawString(caption, fnt, System.Drawing.Brushes.Black, 50, 50);
                    caption = string.Format("message='{0}'", 10);
                    g.DrawString(caption, fnt, System.Drawing.Brushes.Black, 50, 75);
                    g.DrawImage(pictureBox1.Image, 50, 110);
                }
            }
        }
    }

   
   
}
