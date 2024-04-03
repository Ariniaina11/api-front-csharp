namespace api_front_csharp
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.headerPnl = new System.Windows.Forms.Panel();
            this.contenPnl = new System.Windows.Forms.Panel();
            this.loadingLbl = new System.Windows.Forms.Label();
            this.buttonsPnl = new System.Windows.Forms.Panel();
            this.customerBtn = new System.Windows.Forms.Button();
            this.userBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.contenPnl.SuspendLayout();
            this.buttonsPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 3);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 597);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(597, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 597);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 597);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(594, 3);
            this.panel4.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.headerPnl);
            this.panel5.Controls.Add(this.contenPnl);
            this.panel5.Controls.Add(this.buttonsPnl);
            this.panel5.Controls.Add(this.closeBtn);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(594, 594);
            this.panel5.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(0, 571);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(594, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "©  M a m i t i a n a   -   2 0 2 4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headerPnl
            // 
            this.headerPnl.Location = new System.Drawing.Point(8, 161);
            this.headerPnl.Name = "headerPnl";
            this.headerPnl.Size = new System.Drawing.Size(577, 31);
            this.headerPnl.TabIndex = 12;
            // 
            // contenPnl
            // 
            this.contenPnl.AutoScroll = true;
            this.contenPnl.Controls.Add(this.loadingLbl);
            this.contenPnl.Location = new System.Drawing.Point(8, 195);
            this.contenPnl.Name = "contenPnl";
            this.contenPnl.Size = new System.Drawing.Size(577, 364);
            this.contenPnl.TabIndex = 11;
            // 
            // loadingLbl
            // 
            this.loadingLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loadingLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadingLbl.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingLbl.ForeColor = System.Drawing.Color.Gray;
            this.loadingLbl.Location = new System.Drawing.Point(0, 0);
            this.loadingLbl.Name = "loadingLbl";
            this.loadingLbl.Size = new System.Drawing.Size(577, 364);
            this.loadingLbl.TabIndex = 0;
            this.loadingLbl.Text = "<No Data>";
            this.loadingLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonsPnl
            // 
            this.buttonsPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttonsPnl.Controls.Add(this.customerBtn);
            this.buttonsPnl.Controls.Add(this.userBtn);
            this.buttonsPnl.Location = new System.Drawing.Point(183, 98);
            this.buttonsPnl.Name = "buttonsPnl";
            this.buttonsPnl.Size = new System.Drawing.Size(235, 45);
            this.buttonsPnl.TabIndex = 10;
            // 
            // customerBtn
            // 
            this.customerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.customerBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.customerBtn.FlatAppearance.BorderSize = 0;
            this.customerBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerBtn.ForeColor = System.Drawing.Color.Silver;
            this.customerBtn.Location = new System.Drawing.Point(114, 0);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(121, 43);
            this.customerBtn.TabIndex = 9;
            this.customerBtn.Text = "C u s t o m e r s";
            this.customerBtn.UseVisualStyleBackColor = true;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // userBtn
            // 
            this.userBtn.BackColor = System.Drawing.Color.Gray;
            this.userBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.userBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.userBtn.FlatAppearance.BorderSize = 0;
            this.userBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBtn.ForeColor = System.Drawing.Color.Silver;
            this.userBtn.Location = new System.Drawing.Point(0, 0);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(114, 43);
            this.userBtn.TabIndex = 8;
            this.userBtn.Text = "U s e r s";
            this.userBtn.UseVisualStyleBackColor = false;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.closeBtn.Location = new System.Drawing.Point(562, 6);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(23, 19);
            this.closeBtn.TabIndex = 7;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(210, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 5);
            this.label3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(281, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 5);
            this.label2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "#CustomerAPI";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.contenPnl.ResumeLayout(false);
            this.buttonsPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.Button userBtn;
        private System.Windows.Forms.Panel buttonsPnl;
        private System.Windows.Forms.Panel contenPnl;
        private System.Windows.Forms.Label loadingLbl;
        private System.Windows.Forms.Panel headerPnl;
        private System.Windows.Forms.Label label4;
    }
}

