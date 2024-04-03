namespace api_front_csharp.Users
{
    partial class UserContent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.emailLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emailLbl
            // 
            this.emailLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.emailLbl.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.ForeColor = System.Drawing.Color.DarkGray;
            this.emailLbl.Location = new System.Drawing.Point(257, 0);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(303, 25);
            this.emailLbl.TabIndex = 9;
            this.emailLbl.Text = "ariniaina@luda.com";
            this.emailLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(256, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 25);
            this.panel2.TabIndex = 8;
            // 
            // usernameLbl
            // 
            this.usernameLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.usernameLbl.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.ForeColor = System.Drawing.Color.DarkGray;
            this.usernameLbl.Location = new System.Drawing.Point(61, 0);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(195, 25);
            this.usernameLbl.TabIndex = 7;
            this.usernameLbl.Text = "Ariniaina11";
            this.usernameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(60, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 25);
            this.panel1.TabIndex = 6;
            // 
            // idLbl
            // 
            this.idLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.idLbl.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLbl.ForeColor = System.Drawing.Color.DarkGray;
            this.idLbl.Location = new System.Drawing.Point(0, 0);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(60, 25);
            this.idLbl.TabIndex = 5;
            this.idLbl.Text = "1";
            this.idLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.idLbl);
            this.Name = "UserContent";
            this.Size = new System.Drawing.Size(577, 25);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label idLbl;
    }
}
