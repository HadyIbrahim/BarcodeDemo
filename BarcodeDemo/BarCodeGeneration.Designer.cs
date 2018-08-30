namespace BarcodeDemo
{
    partial class BarCodeGeneration
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_month = new System.Windows.Forms.TextBox();
            this.txt_day = new System.Windows.Forms.TextBox();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.txt_serial = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_generate = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.combo_MaterialCat = new System.Windows.Forms.ComboBox();
            this.combo_target = new System.Windows.Forms.ComboBox();
            this.combo_shiftCode = new System.Windows.Forms.ComboBox();
            this.combo_PRD_Line = new System.Windows.Forms.ComboBox();
            this.combo_FcatoryCode = new System.Windows.Forms.ComboBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(54, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(54, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(54, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Factory Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(54, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(54, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Material Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(54, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Shift Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(54, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Production Line";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(54, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Serial";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(54, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Target";
            // 
            // txt_month
            // 
            this.txt_month.Enabled = false;
            this.txt_month.Location = new System.Drawing.Point(326, 49);
            this.txt_month.Name = "txt_month";
            this.txt_month.Size = new System.Drawing.Size(100, 20);
            this.txt_month.TabIndex = 9;
            // 
            // txt_day
            // 
            this.txt_day.Enabled = false;
            this.txt_day.Location = new System.Drawing.Point(326, 13);
            this.txt_day.Name = "txt_day";
            this.txt_day.Size = new System.Drawing.Size(100, 20);
            this.txt_day.TabIndex = 10;
            // 
            // txt_year
            // 
            this.txt_year.Enabled = false;
            this.txt_year.Location = new System.Drawing.Point(326, 93);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(100, 20);
            this.txt_year.TabIndex = 11;
            // 
            // txt_serial
            // 
            this.txt_serial.Enabled = false;
            this.txt_serial.Location = new System.Drawing.Point(326, 248);
            this.txt_serial.Name = "txt_serial";
            this.txt_serial.Size = new System.Drawing.Size(121, 20);
            this.txt_serial.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 448);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(511, 74);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_generate
            // 
            this.Btn_generate.Location = new System.Drawing.Point(119, 386);
            this.Btn_generate.Name = "Btn_generate";
            this.Btn_generate.Size = new System.Drawing.Size(231, 23);
            this.Btn_generate.TabIndex = 19;
            this.Btn_generate.Text = "Generate";
            this.Btn_generate.UseVisualStyleBackColor = true;
            this.Btn_generate.Click += new System.EventHandler(this.Btn_generate_Click);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(592, 448);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(105, 58);
            this.btn_print.TabIndex = 20;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // combo_MaterialCat
            // 
            this.combo_MaterialCat.FormattingEnabled = true;
            this.combo_MaterialCat.Location = new System.Drawing.Point(326, 354);
            this.combo_MaterialCat.Name = "combo_MaterialCat";
            this.combo_MaterialCat.Size = new System.Drawing.Size(121, 21);
            this.combo_MaterialCat.TabIndex = 21;
            // 
            // combo_target
            // 
            this.combo_target.FormattingEnabled = true;
            this.combo_target.Items.AddRange(new object[] {
            "Sales",
            "Maintenance",
            "Export"});
            this.combo_target.Location = new System.Drawing.Point(326, 305);
            this.combo_target.Name = "combo_target";
            this.combo_target.Size = new System.Drawing.Size(121, 21);
            this.combo_target.TabIndex = 22;
            // 
            // combo_shiftCode
            // 
            this.combo_shiftCode.FormattingEnabled = true;
            this.combo_shiftCode.Location = new System.Drawing.Point(326, 204);
            this.combo_shiftCode.Name = "combo_shiftCode";
            this.combo_shiftCode.Size = new System.Drawing.Size(121, 21);
            this.combo_shiftCode.TabIndex = 23;
            // 
            // combo_PRD_Line
            // 
            this.combo_PRD_Line.FormattingEnabled = true;
            this.combo_PRD_Line.Location = new System.Drawing.Point(326, 163);
            this.combo_PRD_Line.Name = "combo_PRD_Line";
            this.combo_PRD_Line.Size = new System.Drawing.Size(121, 21);
            this.combo_PRD_Line.TabIndex = 24;
            // 
            // combo_FcatoryCode
            // 
            this.combo_FcatoryCode.FormattingEnabled = true;
            this.combo_FcatoryCode.Location = new System.Drawing.Point(326, 119);
            this.combo_FcatoryCode.Name = "combo_FcatoryCode";
            this.combo_FcatoryCode.Size = new System.Drawing.Size(121, 21);
            this.combo_FcatoryCode.TabIndex = 25;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // BarCodeGeneration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 615);
            this.Controls.Add(this.combo_FcatoryCode);
            this.Controls.Add(this.combo_PRD_Line);
            this.Controls.Add(this.combo_shiftCode);
            this.Controls.Add(this.combo_target);
            this.Controls.Add(this.combo_MaterialCat);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.Btn_generate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_serial);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.txt_day);
            this.Controls.Add(this.txt_month);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BarCodeGeneration";
            this.Text = "BarCodeGeneration";
            this.Load += new System.EventHandler(this.BarCodeGeneration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_month;
        private System.Windows.Forms.TextBox txt_day;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.TextBox txt_serial;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_generate;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.ComboBox combo_MaterialCat;
        private System.Windows.Forms.ComboBox combo_target;
        private System.Windows.Forms.ComboBox combo_shiftCode;
        private System.Windows.Forms.ComboBox combo_PRD_Line;
        private System.Windows.Forms.ComboBox combo_FcatoryCode;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}