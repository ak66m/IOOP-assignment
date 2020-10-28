namespace IOOP_ASSIGNMENT_FORMS_REG_MENU
{
    partial class logedregester
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.IDlbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.numberlbl = new System.Windows.Forms.Label();
            this.addressLBL = new System.Windows.Forms.Label();
            this.userlbl = new System.Windows.Forms.Label();
            this.Pwordlbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.regiserLBL = new System.Windows.Forms.Label();
            this.submitBTN = new System.Windows.Forms.Button();
            this.bckbtn = new System.Windows.Forms.Button();
            this.ErorrMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(167, 360);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(499, 358);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(245, 22);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(167, 227);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(201, 22);
            this.textBox4.TabIndex = 3;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(511, 217);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(250, 22);
            this.textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(495, 87);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(266, 22);
            this.textBox6.TabIndex = 5;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(311, 448);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // IDlbl
            // 
            this.IDlbl.AutoSize = true;
            this.IDlbl.Location = new System.Drawing.Point(137, 90);
            this.IDlbl.Name = "IDlbl";
            this.IDlbl.Size = new System.Drawing.Size(25, 17);
            this.IDlbl.TabIndex = 7;
            this.IDlbl.Text = "ID:";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(401, 90);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(80, 17);
            this.namelbl.TabIndex = 8;
            this.namelbl.Text = "First Name:";
            this.namelbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // numberlbl
            // 
            this.numberlbl.AutoSize = true;
            this.numberlbl.Location = new System.Drawing.Point(54, 230);
            this.numberlbl.Name = "numberlbl";
            this.numberlbl.Size = new System.Drawing.Size(80, 17);
            this.numberlbl.TabIndex = 9;
            this.numberlbl.Text = "Last Name:";
            // 
            // addressLBL
            // 
            this.addressLBL.AutoSize = true;
            this.addressLBL.Location = new System.Drawing.Point(426, 222);
            this.addressLBL.Name = "addressLBL";
            this.addressLBL.Size = new System.Drawing.Size(64, 17);
            this.addressLBL.TabIndex = 10;
            this.addressLBL.Text = "Address:";
            // 
            // userlbl
            // 
            this.userlbl.AutoSize = true;
            this.userlbl.Location = new System.Drawing.Point(64, 363);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(77, 17);
            this.userlbl.TabIndex = 11;
            this.userlbl.Text = "Username:";
            // 
            // Pwordlbl
            // 
            this.Pwordlbl.AutoSize = true;
            this.Pwordlbl.Location = new System.Drawing.Point(426, 358);
            this.Pwordlbl.Name = "Pwordlbl";
            this.Pwordlbl.Size = new System.Drawing.Size(73, 17);
            this.Pwordlbl.TabIndex = 12;
            this.Pwordlbl.Text = "Password:";
            this.Pwordlbl.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 451);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Gender";
            // 
            // regiserLBL
            // 
            this.regiserLBL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.regiserLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regiserLBL.Location = new System.Drawing.Point(294, 18);
            this.regiserLBL.Name = "regiserLBL";
            this.regiserLBL.Size = new System.Drawing.Size(169, 36);
            this.regiserLBL.TabIndex = 14;
            this.regiserLBL.Text = "Regester";
            // 
            // submitBTN
            // 
            this.submitBTN.BackColor = System.Drawing.Color.Lime;
            this.submitBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBTN.Location = new System.Drawing.Point(311, 525);
            this.submitBTN.Name = "submitBTN";
            this.submitBTN.Size = new System.Drawing.Size(138, 59);
            this.submitBTN.TabIndex = 15;
            this.submitBTN.Text = "Submit";
            this.submitBTN.UseVisualStyleBackColor = false;
            this.submitBTN.Click += new System.EventHandler(this.submitBTN_Click);
            // 
            // bckbtn
            // 
            this.bckbtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bckbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bckbtn.Location = new System.Drawing.Point(596, 501);
            this.bckbtn.Name = "bckbtn";
            this.bckbtn.Size = new System.Drawing.Size(90, 42);
            this.bckbtn.TabIndex = 17;
            this.bckbtn.Text = "Back";
            this.bckbtn.UseVisualStyleBackColor = false;
            this.bckbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // ErorrMessage
            // 
            this.ErorrMessage.AutoSize = true;
            this.ErorrMessage.ForeColor = System.Drawing.Color.Red;
            this.ErorrMessage.Location = new System.Drawing.Point(525, 455);
            this.ErorrMessage.Name = "ErorrMessage";
            this.ErorrMessage.Size = new System.Drawing.Size(0, 17);
            this.ErorrMessage.TabIndex = 18;
            // 
            // logedregester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.ErorrMessage);
            this.Controls.Add(this.bckbtn);
            this.Controls.Add(this.submitBTN);
            this.Controls.Add(this.regiserLBL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Pwordlbl);
            this.Controls.Add(this.userlbl);
            this.Controls.Add(this.addressLBL);
            this.Controls.Add(this.numberlbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.IDlbl);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "logedregester";
            this.Text = "Loged In Regester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label IDlbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label numberlbl;
        private System.Windows.Forms.Label addressLBL;
        private System.Windows.Forms.Label userlbl;
        private System.Windows.Forms.Label Pwordlbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label regiserLBL;
        private System.Windows.Forms.Button submitBTN;
        private System.Windows.Forms.Button bckbtn;
        private System.Windows.Forms.Label ErorrMessage;
    }
}