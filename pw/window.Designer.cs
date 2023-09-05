namespace pw
{
    partial class window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(window));
            this.generateButton = new System.Windows.Forms.Button();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pwCharsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.copyButton = new System.Windows.Forms.Button();
            this.randomRadio = new System.Windows.Forms.RadioButton();
            this.wordsRadio = new System.Windows.Forms.RadioButton();
            this.addSpecialCheckBox = new System.Windows.Forms.CheckBox();
            this.capitaliseCheckBox = new System.Windows.Forms.CheckBox();
            this.addButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.myWordsCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.Location = new System.Drawing.Point(375, 55);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(62, 23);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // passwordTB
            // 
            this.passwordTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTB.BackColor = System.Drawing.SystemColors.InfoText;
            this.passwordTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTB.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTB.ForeColor = System.Drawing.Color.Lime;
            this.passwordTB.Location = new System.Drawing.Point(0, 86);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(444, 30);
            this.passwordTB.TabIndex = 1;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(258, 8);
            this.trackBar1.Maximum = 40;
            this.trackBar1.Minimum = 8;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(143, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 12;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // pwCharsLabel
            // 
            this.pwCharsLabel.AutoSize = true;
            this.pwCharsLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwCharsLabel.Location = new System.Drawing.Point(239, 10);
            this.pwCharsLabel.Name = "pwCharsLabel";
            this.pwCharsLabel.Size = new System.Drawing.Size(19, 13);
            this.pwCharsLabel.TabIndex = 3;
            this.pwCharsLabel.Text = "12";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Random Length";
            // 
            // copyButton
            // 
            this.copyButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyButton.Location = new System.Drawing.Point(289, 55);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(42, 23);
            this.copyButton.TabIndex = 5;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // randomRadio
            // 
            this.randomRadio.AutoSize = true;
            this.randomRadio.Checked = true;
            this.randomRadio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomRadio.Location = new System.Drawing.Point(12, 8);
            this.randomRadio.Name = "randomRadio";
            this.randomRadio.Size = new System.Drawing.Size(125, 17);
            this.randomRadio.TabIndex = 6;
            this.randomRadio.TabStop = true;
            this.randomRadio.Text = "Random Characters";
            this.randomRadio.UseVisualStyleBackColor = true;
            // 
            // wordsRadio
            // 
            this.wordsRadio.AutoSize = true;
            this.wordsRadio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordsRadio.Location = new System.Drawing.Point(13, 32);
            this.wordsRadio.Name = "wordsRadio";
            this.wordsRadio.Size = new System.Drawing.Size(59, 17);
            this.wordsRadio.TabIndex = 7;
            this.wordsRadio.Text = "Words";
            this.wordsRadio.UseVisualStyleBackColor = true;
            // 
            // addSpecialCheckBox
            // 
            this.addSpecialCheckBox.AutoSize = true;
            this.addSpecialCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSpecialCheckBox.Location = new System.Drawing.Point(89, 34);
            this.addSpecialCheckBox.Name = "addSpecialCheckBox";
            this.addSpecialCheckBox.Size = new System.Drawing.Size(119, 17);
            this.addSpecialCheckBox.TabIndex = 8;
            this.addSpecialCheckBox.Text = "Special Characters";
            this.addSpecialCheckBox.UseVisualStyleBackColor = true;
            // 
            // capitaliseCheckBox
            // 
            this.capitaliseCheckBox.AutoSize = true;
            this.capitaliseCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capitaliseCheckBox.Location = new System.Drawing.Point(89, 57);
            this.capitaliseCheckBox.Name = "capitaliseCheckBox";
            this.capitaliseCheckBox.Size = new System.Drawing.Size(76, 17);
            this.capitaliseCheckBox.TabIndex = 9;
            this.capitaliseCheckBox.Text = "Capitalise";
            this.capitaliseCheckBox.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(335, 55);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(36, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.aboutButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.Location = new System.Drawing.Point(408, 4);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(24, 23);
            this.aboutButton.TabIndex = 11;
            this.aboutButton.Text = "?";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // myWordsCheckBox
            // 
            this.myWordsCheckBox.AutoSize = true;
            this.myWordsCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myWordsCheckBox.Location = new System.Drawing.Point(214, 34);
            this.myWordsCheckBox.Name = "myWordsCheckBox";
            this.myWordsCheckBox.Size = new System.Drawing.Size(78, 17);
            this.myWordsCheckBox.TabIndex = 12;
            this.myWordsCheckBox.Text = "My Words";
            this.myWordsCheckBox.UseVisualStyleBackColor = true;
            this.myWordsCheckBox.Visible = false;
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(444, 114);
            this.Controls.Add(this.myWordsCheckBox);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.capitaliseCheckBox);
            this.Controls.Add(this.addSpecialCheckBox);
            this.Controls.Add(this.wordsRadio);
            this.Controls.Add(this.randomRadio);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pwCharsLabel);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.trackBar1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "window";
            this.Opacity = 0.95D;
            this.Text = "pw";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label pwCharsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.RadioButton randomRadio;
        private System.Windows.Forms.RadioButton wordsRadio;
        private System.Windows.Forms.CheckBox addSpecialCheckBox;
        private System.Windows.Forms.CheckBox capitaliseCheckBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.CheckBox myWordsCheckBox;
    }
}

