using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeDemo.Classes;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;

namespace BarcodeDemo
{
    public partial class Form1 : Form
    {
        Classes.BrcodeProvider P;
        DataTable ResultsTable = new DataTable();
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
           
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {



            DataSet1 dsCustomers = GetData();
            ReportDataSource datasource = new ReportDataSource("DataSet1", dsCustomers.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();













            //BarcodeELARABYDataSet1 ds = new BarcodeDemo.BarcodeELARABYDataSet1();
            // ds.Tables.Add("Sp_Get_BarcodeTableAdapter");
            //  Fill(this.DataSet1.sp_GetRent1, "@RentNo1", "@AppPath");
            //this.GetSPResult();






            //            reportViewer1.LocalReport.ReportPath = @"D:\SAP\Barcode project\Barcode2018\BarcodeDemo\BarcodeDemo\Report1.rdlc";
            //reportViewer1.RefreshReport();
            // this.reportViewer1.RefreshReport();
            //   this.reportViewer1.RefreshReport();
        }

        private DataSet1 GetData()
        {
            string constr = @"Data Source=.;Initial Catalog=BarcodeELARABY;Integrated Security = true";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Login"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataSet1 dsCustomers = new DataSet1())
                        {
                            sda.Fill(dsCustomers, "DataTable1");
                            return dsCustomers;
                        }
                    }
                }
            }
        }


        private DataTable ShoWdata()
        {
          //  DataTable dt = new DataTable();
            P = new BrcodeProvider();
            dt = P.GetByID(Convert.ToInt32(textBox1.Text));
            return ResultsTable;
        }

        private void Btn_getdata_Click(object sender, EventArgs e)
        {
            //RESET
            reportViewer1.Refresh();


            //DATA SOURCE
            reportViewer1.LocalReport.ReportPath = @"D:\SAP\Barcode project\Barcode2018\BarcodeDemo\BarcodeDemo\Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Add(rds);
            
            //PATH
            //PARAMTER
           // DataTable dt = ShoWdata();


            //ReportParameter[] reptparam = new ReportParameter[] {
            //new ReportParameter("",textBox1.Text)
            //};
           // reportViewer1.LocalReport.SetParameters(reptparam);

            //REFRESH

          //  reportViewer1.LocalReport.Refresh();
          ShoWdata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         //   Sp_Get_Barcode1TableAdapter ta = new Sp_Get_Barcode1TableAdapter();
         //   BarcodeELARABYDataSet1.Sp_Get_Barcode1DataTable ds = new BarcodeELARABYDataSet1.Sp_Get_Barcode1DataTable();
            
         //   //            ta.Fill(ds, Convert.ToInt32(textBox1.Text));
         // //  ta.Fill(ds);
         //   ReportDataSource rds = new ReportDataSource();
         //   rds.Name = "DataSet1";
         //   rds.Value = ds;

         ////   ReportParameter rp = new ReportParameter("ID", textBox1.Text.ToString());

         //   reportViewer1.LocalReport.DataSources.Clear();
         //   reportViewer1.LocalReport.ReportPath = @"D:\SAP\Barcode project\Barcode2018\BarcodeDemo\BarcodeDemo\Report1.rdlc";
         //  // reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp });
         //   reportViewer1.LocalReport.DataSources.Add(rds);
           // reportViewer1.LocalReport.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox1.Image = barcode.Draw(textBox1.Text, 50);
        }
    }
}

