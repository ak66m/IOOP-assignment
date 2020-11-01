namespace IOOP_ASSIGNMENT_FORMS_REG_MENU
{
    partial class renewfrm
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
            this.Renewbtn = new System.Windows.Forms.Button();
            this.menubtn = new System.Windows.Forms.Button();
            this.Warninglbl = new System.Windows.Forms.Label();
            this.RenewInsurance = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Backbtn = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Renewbtn
            // 
            this.Renewbtn.BackColor = System.Drawing.Color.LimeGreen;
            this.Renewbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Renewbtn.Location = new System.Drawing.Point(257, 378);
            this.Renewbtn.Name = "Renewbtn";
            this.Renewbtn.Size = new System.Drawing.Size(142, 68);
            this.Renewbtn.TabIndex = 0;
            this.Renewbtn.Text = "Proceed";
            this.Renewbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Renewbtn.UseCompatibleTextRendering = true;
            this.Renewbtn.UseVisualStyleBackColor = false;
            this.Renewbtn.Click += new System.EventHandler(this.Renewbtn_Click);
            // 
            // menubtn
            // 
            this.menubtn.BackColor = System.Drawing.Color.Orange;
            this.menubtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menubtn.Location = new System.Drawing.Point(501, 423);
            this.menubtn.Name = "menubtn";
            this.menubtn.Size = new System.Drawing.Size(127, 68);
            this.menubtn.TabIndex = 1;
            this.menubtn.Text = "Main Menu";
            this.menubtn.UseVisualStyleBackColor = false;
            this.menubtn.Click += new System.EventHandler(this.menubtn_Click);
            // 
            // Warninglbl
            // 
            this.Warninglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Warninglbl.Location = new System.Drawing.Point(113, 90);
            this.Warninglbl.Name = "Warninglbl";
            this.Warninglbl.Size = new System.Drawing.Size(532, 89);
            this.Warninglbl.TabIndex = 2;
            this.Warninglbl.Text = "Customers that do not claim any incident within one year get to enjoy no-claim di" +
    "scount and insurance can only be renewed within 60days. \r\n";
            this.Warninglbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Warninglbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // RenewInsurance
            // 
            this.RenewInsurance.AutoSize = true;
            this.RenewInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RenewInsurance.Location = new System.Drawing.Point(242, 18);
            this.RenewInsurance.Name = "RenewInsurance";
            this.RenewInsurance.Size = new System.Drawing.Size(234, 32);
            this.RenewInsurance.TabIndex = 3;
            this.RenewInsurance.Text = "Renew Insurance";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(270, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 22);
            this.textBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Card",
            "Cash"});
            this.comboBox1.Location = new System.Drawing.Point(388, 229);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // Backbtn
            // 
            this.Backbtn.BackColor = System.Drawing.Color.Red;
            this.Backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.Location = new System.Drawing.Point(45, 467);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(139, 56);
            this.Backbtn.TabIndex = 8;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBox2.Location = new System.Drawing.Point(388, 282);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(168, 24);
            this.comboBox2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 50);
            this.label1.TabIndex = 10;
            this.label1.Text = "Any Damages Trougout?\r\n(your car will be physically checked)";
            // 
            // renewfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(730, 596);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RenewInsurance);
            this.Controls.Add(this.Warninglbl);
            this.Controls.Add(this.menubtn);
            this.Controls.Add(this.Renewbtn);
            this.Name = "renewfrm";
            this.Text = "Renew Insurance";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Renewbtn;
        private System.Windows.Forms.Button menubtn;
        private System.Windows.Forms.Label Warninglbl;
        private System.Windows.Forms.Label RenewInsurance;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
    }
}