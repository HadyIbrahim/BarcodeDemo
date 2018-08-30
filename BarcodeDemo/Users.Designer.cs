namespace BarcodeDemo
{
    partial class Users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_user = new System.Windows.Forms.TextBox();
            this.Txt_pass = new System.Windows.Forms.TextBox();
            this.BTN_Craete_user = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_FcatoryCode = new System.Windows.Forms.ComboBox();
            this.combo_PRD_Line = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(431, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "كلمة المرور";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(406, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "اسم المستخدم";
            // 
            // Txt_user
            // 
            this.Txt_user.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Txt_user.Location = new System.Drawing.Point(212, 40);
            this.Txt_user.Name = "Txt_user";
            this.Txt_user.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_user.Size = new System.Drawing.Size(150, 27);
            this.Txt_user.TabIndex = 1;
            // 
            // Txt_pass
            // 
            this.Txt_pass.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Txt_pass.Location = new System.Drawing.Point(209, 145);
            this.Txt_pass.Name = "Txt_pass";
            this.Txt_pass.PasswordChar = '*';
            this.Txt_pass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_pass.Size = new System.Drawing.Size(153, 27);
            this.Txt_pass.TabIndex = 3;
            // 
            // BTN_Craete_user
            // 
            this.BTN_Craete_user.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.BTN_Craete_user.ForeColor = System.Drawing.Color.Green;
            this.BTN_Craete_user.Location = new System.Drawing.Point(209, 305);
            this.BTN_Craete_user.Name = "BTN_Craete_user";
            this.BTN_Craete_user.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BTN_Craete_user.Size = new System.Drawing.Size(159, 30);
            this.BTN_Craete_user.TabIndex = 6;
            this.BTN_Craete_user.Text = "حفظ";
            this.BTN_Craete_user.Click += new System.EventHandler(this.BTN_Craete_user_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(464, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "المصنع";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(453, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "خط الانتاج";
            // 
            // combo_FcatoryCode
            // 
            this.combo_FcatoryCode.FormattingEnabled = true;
            this.combo_FcatoryCode.Location = new System.Drawing.Point(238, 201);
            this.combo_FcatoryCode.Name = "combo_FcatoryCode";
            this.combo_FcatoryCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_FcatoryCode.Size = new System.Drawing.Size(121, 21);
            this.combo_FcatoryCode.TabIndex = 4;
            // 
            // combo_PRD_Line
            // 
            this.combo_PRD_Line.FormattingEnabled = true;
            this.combo_PRD_Line.Location = new System.Drawing.Point(238, 252);
            this.combo_PRD_Line.Name = "combo_PRD_Line";
            this.combo_PRD_Line.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_PRD_Line.Size = new System.Drawing.Size(121, 21);
            this.combo_PRD_Line.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(431, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "الاسم كاملا";
            // 
            // txt_fullname
            // 
            this.txt_fullname.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_fullname.Location = new System.Drawing.Point(212, 95);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_fullname.Size = new System.Drawing.Size(150, 27);
            this.txt_fullname.TabIndex = 2;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 427);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_fullname);
            this.Controls.Add(this.combo_PRD_Line);
            this.Controls.Add(this.combo_FcatoryCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_user);
            this.Controls.Add(this.Txt_pass);
            this.Controls.Add(this.BTN_Craete_user);
            this.Name = "Users";
            this.Text = "إنشاء مستخدم جديد";
            this.Load += new System.EventHandler(this.Users_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_user;
        private System.Windows.Forms.TextBox Txt_pass;
        private System.Windows.Forms.Button BTN_Craete_user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_FcatoryCode;
        private System.Windows.Forms.ComboBox combo_PRD_Line;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_fullname;
    }
}