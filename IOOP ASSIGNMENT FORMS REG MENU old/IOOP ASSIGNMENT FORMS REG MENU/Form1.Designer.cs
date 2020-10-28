namespace IOOP_ASSIGNMENT_FORMS_REG_MENU
{
    partial class Registeration
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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Backbutton = new System.Windows.Forms.Button();
            this.RegisterBTN = new System.Windows.Forms.Button();
            this.RegisterationForm = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.FullName = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.tologinbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(237, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(505, 167);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(310, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(564, 280);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(233, 22);
            this.textBox3.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(215, 165);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(166, 22);
            this.textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(546, 98);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(251, 22);
            this.textBox6.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(366, 375);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // Backbutton
            // 
            this.Backbutton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbutton.Location = new System.Drawing.Point(670, 447);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(108, 47);
            this.Backbutton.TabIndex = 7;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = false;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // RegisterBTN
            // 
            this.RegisterBTN.BackColor = System.Drawing.Color.Lime;
            this.RegisterBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBTN.Location = new System.Drawing.Point(358, 447);
            this.RegisterBTN.Name = "RegisterBTN";
            this.RegisterBTN.Size = new System.Drawing.Size(116, 56);
            this.RegisterBTN.TabIndex = 8;
            this.RegisterBTN.Text = "Submit";
            this.RegisterBTN.UseVisualStyleBackColor = false;
            this.RegisterBTN.Click += new System.EventHandler(this.RegisterBTN_Click);
            // 
            // RegisterationForm
            // 
            this.RegisterationForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterationForm.Location = new System.Drawing.Point(310, 13);
            this.RegisterationForm.Name = "RegisterationForm";
            this.RegisterationForm.Size = new System.Drawing.Size(265, 39);
            this.RegisterationForm.TabIndex = 10;
            this.RegisterationForm.Text = "Registeration Form";
            this.RegisterationForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RegisterationForm.Click += new System.EventHandler(this.label1_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(184, 98);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(25, 17);
            this.ID.TabIndex = 11;
            this.ID.Text = "ID:";
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.Location = new System.Drawing.Point(445, 98);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(75, 17);
            this.FullName.TabIndex = 12;
            this.FullName.Text = "Full Name:";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Location = new System.Drawing.Point(102, 170);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(107, 17);
            this.PhoneNumber.TabIndex = 13;
            this.PhoneNumber.Text = "Phone Number:";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(423, 173);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(64, 17);
            this.Address.TabIndex = 15;
            this.Address.Text = "Address:";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(288, 381);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(60, 17);
            this.Gender.TabIndex = 16;
            this.Gender.Text = "Gender:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(258, 281);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 17;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(172, 286);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(77, 17);
            this.Username.TabIndex = 18;
            this.Username.Text = "Username:";
            this.Username.Click += new System.EventHandler(this.label2_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(475, 285);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(73, 17);
            this.Password.TabIndex = 19;
            this.Password.Text = "Password:";
            // 
            // tologinbtn
            // 
            this.tologinbtn.BackColor = System.Drawing.Color.OrangeRed;
            this.tologinbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tologinbtn.Location = new System.Drawing.Point(44, 428);
            this.tologinbtn.Name = "tologinbtn";
            this.tologinbtn.Size = new System.Drawing.Size(114, 52);
            this.tologinbtn.TabIndex = 20;
            this.tologinbtn.Text = "Login";
            this.tologinbtn.UseVisualStyleBackColor = false;
            this.tologinbtn.Click += new System.EventHandler(this.tologinbtn_Click);
            // 
            // Registeration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(843, 525);
            this.Controls.Add(this.tologinbtn);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.RegisterationForm);
            this.Controls.Add(this.RegisterBTN);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Registeration";
            this.Text = "Registeration Form";
            this.Load += new System.EventHandler(this.Registeration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Button RegisterBTN;
        private System.Windows.Forms.Label RegisterationForm;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button tologinbtn;
    }
}

