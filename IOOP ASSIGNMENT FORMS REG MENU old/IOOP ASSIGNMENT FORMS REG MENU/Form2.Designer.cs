namespace IOOP_ASSIGNMENT_FORMS_REG_MENU
{
    partial class MenuForm
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
            this.Registering = new System.Windows.Forms.Button();
            this.NewInsurance = new System.Windows.Forms.Button();
            this.RenewInsurance = new System.Windows.Forms.Button();
            this.EditUser = new System.Windows.Forms.Button();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Registering
            // 
            this.Registering.BackColor = System.Drawing.SystemColors.Info;
            this.Registering.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registering.Location = new System.Drawing.Point(106, 82);
            this.Registering.Name = "Registering";
            this.Registering.Size = new System.Drawing.Size(177, 100);
            this.Registering.TabIndex = 1;
            this.Registering.Text = "Register";
            this.Registering.UseVisualStyleBackColor = false;
            this.Registering.Click += new System.EventHandler(this.Registering_Click);
            // 
            // NewInsurance
            // 
            this.NewInsurance.BackColor = System.Drawing.SystemColors.Highlight;
            this.NewInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewInsurance.Location = new System.Drawing.Point(433, 82);
            this.NewInsurance.Name = "NewInsurance";
            this.NewInsurance.Size = new System.Drawing.Size(211, 100);
            this.NewInsurance.TabIndex = 2;
            this.NewInsurance.Text = "New Insurance";
            this.NewInsurance.UseVisualStyleBackColor = false;
            this.NewInsurance.Click += new System.EventHandler(this.NewInsurance_Click);
            // 
            // RenewInsurance
            // 
            this.RenewInsurance.BackColor = System.Drawing.Color.Red;
            this.RenewInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RenewInsurance.Location = new System.Drawing.Point(433, 230);
            this.RenewInsurance.Name = "RenewInsurance";
            this.RenewInsurance.Size = new System.Drawing.Size(222, 103);
            this.RenewInsurance.TabIndex = 3;
            this.RenewInsurance.Text = "Renew Insurance";
            this.RenewInsurance.UseVisualStyleBackColor = false;
            this.RenewInsurance.Click += new System.EventHandler(this.button3_Click);
            // 
            // EditUser
            // 
            this.EditUser.BackColor = System.Drawing.Color.SandyBrown;
            this.EditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditUser.Location = new System.Drawing.Point(106, 230);
            this.EditUser.Name = "EditUser";
            this.EditUser.Size = new System.Drawing.Size(177, 103);
            this.EditUser.TabIndex = 4;
            this.EditUser.Text = "Edit User";
            this.EditUser.UseVisualStyleBackColor = false;
            this.EditUser.Click += new System.EventHandler(this.EditUser_Click);
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.BackColor = System.Drawing.Color.Gold;
            this.Logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logoutbtn.Location = new System.Drawing.Point(630, 440);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(130, 47);
            this.Logoutbtn.TabIndex = 5;
            this.Logoutbtn.Text = "Log Out";
            this.Logoutbtn.UseVisualStyleBackColor = false;
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.Logoutbtn);
            this.Controls.Add(this.EditUser);
            this.Controls.Add(this.RenewInsurance);
            this.Controls.Add(this.NewInsurance);
            this.Controls.Add(this.Registering);
            this.Controls.Add(this.label1);
            this.Name = "MenuForm";
            this.Text = "Main Menu:";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Registering;
        private System.Windows.Forms.Button NewInsurance;
        private System.Windows.Forms.Button RenewInsurance;
        private System.Windows.Forms.Button EditUser;
        private System.Windows.Forms.Button Logoutbtn;
    }
}