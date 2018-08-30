namespace BarcodeDemo
{
    partial class LoginForm
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
            this.BTN_LOGIN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(339, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "كلمة المرور";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(329, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "اسم المستخدم";
            // 
            // Txt_user
            // 
            this.Txt_user.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Txt_user.Location = new System.Drawing.Point(135, 88);
            this.Txt_user.Name = "Txt_user";
            this.Txt_user.Size = new System.Drawing.Size(150, 27);
            this.Txt_user.TabIndex = 26;
            // 
            // Txt_pass
            // 
            this.Txt_pass.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Txt_pass.Location = new System.Drawing.Point(135, 136);
            this.Txt_pass.Name = "Txt_pass";
            this.Txt_pass.PasswordChar = '*';
            this.Txt_pass.Size = new System.Drawing.Size(153, 27);
            this.Txt_pass.TabIndex = 27;
            // 
            // BTN_LOGIN
            // 
            this.BTN_LOGIN.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.BTN_LOGIN.ForeColor = System.Drawing.Color.Green;
            this.BTN_LOGIN.Location = new System.Drawing.Point(135, 223);
            this.BTN_LOGIN.Name = "BTN_LOGIN";
            this.BTN_LOGIN.Size = new System.Drawing.Size(159, 30);
            this.BTN_LOGIN.TabIndex = 28;
            this.BTN_LOGIN.Text = "تسجيل دخول";
            this.BTN_LOGIN.Click += new System.EventHandler(this.BTN_LOGIN_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 375);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_user);
            this.Controls.Add(this.Txt_pass);
            this.Controls.Add(this.BTN_LOGIN);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_user;
        private System.Windows.Forms.TextBox Txt_pass;
        private System.Windows.Forms.Button BTN_LOGIN;
    }
}