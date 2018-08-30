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
    public partial class LoginForm : Form
    {
        DataTable dt = new DataTable();
        BarCodeGenerator.LoginProvider l = new BarCodeGenerator.LoginProvider();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BTN_LOGIN_Click(object sender, EventArgs e)
        {
            dt = l.CheckLogin(Txt_user.Text, Txt_pass.Text);
            if (dt.Rows.Count > 0)
            {
                string is_admin = dt.Rows[0]["username"].ToString();
                if(is_admin=="admin")
                {
                    Users u = new Users();
                    Hide();
                    u.Show();
                }
                else
                { 
                //  MessageBox.Show("ok");
                BarCodeGeneration b = new BarCodeGeneration();
                this.Hide();
                b.Show();
                }
            }

            else
            {
                MessageBox.Show("Error user or pass");
            }
        }
    }
}
