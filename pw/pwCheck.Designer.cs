namespace pw
{
    partial class pwCheck
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
            this.outputTB = new System.Windows.Forms.TextBox();
            this.checkBTN = new System.Windows.Forms.Button();
            this.pwToCheckTB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pwnedPanel = new System.Windows.Forms.Panel();
            this.infoBTN = new System.Windows.Forms.Button();
            this.pwnedPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputTB
            // 
            this.outputTB.BackColor = System.Drawing.Color.Black;
            this.outputTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputTB.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTB.ForeColor = System.Drawing.Color.Lime;
            this.outputTB.Location = new System.Drawing.Point(7, 48);
            this.outputTB.Multiline = true;
            this.outputTB.Name = "outputTB";
            this.outputTB.ReadOnly = true;
            this.outputTB.Size = new System.Drawing.Size(449, 85);
            this.outputTB.TabIndex = 0;
            // 
            // checkBTN
            // 
            this.checkBTN.Location = new System.Drawing.Point(404, 8);
            this.checkBTN.Name = "checkBTN";
            this.checkBTN.Size = new System.Drawing.Size(47, 23);
            this.checkBTN.TabIndex = 1;
            this.checkBTN.Text = "Check";
            this.checkBTN.UseVisualStyleBackColor = true;
            this.checkBTN.Click += new System.EventHandler(this.checkBTN_Click);
            // 
            // pwToCheckTB
            // 
            this.pwToCheckTB.BackColor = System.Drawing.Color.White;
            this.pwToCheckTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pwToCheckTB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwToCheckTB.ForeColor = System.Drawing.Color.Black;
            this.pwToCheckTB.Location = new System.Drawing.Point(14, 10);
            this.pwToCheckTB.Name = "pwToCheckTB";
            this.pwToCheckTB.Size = new System.Drawing.Size(320, 19);
            this.pwToCheckTB.TabIndex = 2;
            this.pwToCheckTB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pwToCheckTB_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 102);
            this.panel1.TabIndex = 3;
            // 
            // pwnedPanel
            // 
            this.pwnedPanel.Controls.Add(this.checkBTN);
            this.pwnedPanel.Controls.Add(this.infoBTN);
            this.pwnedPanel.Location = new System.Drawing.Point(0, 1);
            this.pwnedPanel.Name = "pwnedPanel";
            this.pwnedPanel.Size = new System.Drawing.Size(459, 37);
            this.pwnedPanel.TabIndex = 4;
            // 
            // infoBTN
            // 
            this.infoBTN.Location = new System.Drawing.Point(369, 8);
            this.infoBTN.Name = "infoBTN";
            this.infoBTN.Size = new System.Drawing.Size(29, 23);
            this.infoBTN.TabIndex = 0;
            this.infoBTN.Text = "?";
            this.infoBTN.UseVisualStyleBackColor = true;
            this.infoBTN.Click += new System.EventHandler(this.infoBTN_Click);
            // 
            // pwCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 140);
            this.Controls.Add(this.pwToCheckTB);
            this.Controls.Add(this.outputTB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pwnedPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pwCheck";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Have i been pwned";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.pwCheck_Load);
            this.pwnedPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputTB;
        private System.Windows.Forms.Button checkBTN;
        private System.Windows.Forms.TextBox pwToCheckTB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pwnedPanel;
        private System.Windows.Forms.Button infoBTN;
    }
}