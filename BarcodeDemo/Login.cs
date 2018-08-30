using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCodeGenerator
{
    public partial class Login : Form
    {
        DataTable dt = new DataTable();
        LoginProvider l = new LoginProvider();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BTN_LOGIN_Click(object sender, EventArgs e)
        {
            
         dt=l.CheckLogin(Txt_user.Text, Txt_pass.Text);
         if (dt.Rows.Count > 0)
         {
             MessageBox.Show("ok");
         }

         else
         {
             MessageBox.Show("Invalid user or password");
         }
        }
    }
}
