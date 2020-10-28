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
            this.SuspendLayout();
            // 
            // Renewbtn
            // 
            this.Renewbtn.BackColor = System.Drawing.Color.LimeGreen;
            this.Renewbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Renewbtn.Location = new System.Drawing.Point(276, 208);
            this.Renewbtn.Name = "Renewbtn";
            this.Renewbtn.Size = new System.Drawing.Size(142, 68);
            this.Renewbtn.TabIndex = 0;
            this.Renewbtn.Text = "Proceed";
            this.Renewbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Renewbtn.UseCompatibleTextRendering = true;
            this.Renewbtn.UseVisualStyleBackColor = false;
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
            this.Warninglbl.Size = new System.Drawing.Size(532, 50);
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
            // renewfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(730, 596);
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
    }
}