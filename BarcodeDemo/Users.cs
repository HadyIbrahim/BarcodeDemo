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
    public partial class Users : Form
    {
        Classes.UsersProvider U = new Classes.UsersProvider();
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            LoadFactories();
            LoadProductionLines();
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
        private void LoadProductionLines()
        {
             Dictionary<string, string> Shifts = new Dictionary<string, string>();
            Shifts.Add("1", "A");
            Shifts.Add("2", "B");
            Shifts.Add("3", "C");
            Shifts.Add("4", "D");
            Shifts.Add("5", "E");
            combo_PRD_Line.DataSource = new BindingSource(Shifts, null);
            combo_PRD_Line.DisplayMember = "Value";
            combo_PRD_Line.ValueMember = "Key";
            combo_PRD_Line.SelectedIndex = 0;
        }

        private void BTN_Craete_user_Click(object sender, EventArgs e)
        {
            bool Flag;
           Flag =  U.Create_User(Txt_user.Text, Txt_pass.Text, txt_fullname.Text, Convert.ToInt32(combo_PRD_Line.SelectedValue));
            if(Flag==true)
            {
                MessageBox.Show("تم الحفظ بنجاح");

                txt_fullname.Text = "";
                Txt_pass.Text = "";
                Txt_pass.Text = "";
            }
            else
            {
                MessageBox.Show("حذث خطأ.برجاء المحاولة مرة أخرى  ");
            }
        }
    }
}
