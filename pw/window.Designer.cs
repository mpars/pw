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
            this.charactersRadio = new System.Windows.Forms.RadioButton();
            this.wordsRadio = new System.Windows.Forms.RadioButton();
            this.addSpecialCheckBox = new System.Windows.Forms.CheckBox();
            this.capitaliseCheckBox = new System.Windows.Forms.CheckBox();
            this.addButton = new System.Windows.Forms.Button();
            this.moreWordsCheckBox = new System.Windows.Forms.CheckBox();
            this.randomCB = new System.Windows.Forms.CheckBox();
            this.wordsPanel = new System.Windows.Forms.Panel();
            this.onlyTheseCheckBox = new System.Windows.Forms.CheckBox();
            this.wordFileDialogBTN = new System.Windows.Forms.Button();
            this.randomPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.wordsPanel.SuspendLayout();
            this.randomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateButton.FlatAppearance.BorderSize = 0;
            this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.Image = global::pw.Properties.Resources.arrow_refresh_small;
            this.generateButton.Location = new System.Drawing.Point(376, 53);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(42, 36);
            this.generateButton.TabIndex = 0;
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
            this.passwordTB.Location = new System.Drawing.Point(0, 95);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(424, 30);
            this.passwordTB.TabIndex = 1;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(83, -1);
            this.trackBar1.Maximum = 40;
            this.trackBar1.Minimum = 8;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(156, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 12;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // pwCharsLabel
            // 
            this.pwCharsLabel.AutoSize = true;
            this.pwCharsLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwCharsLabel.Location = new System.Drawing.Point(53, 2);
            this.pwCharsLabel.Name = "pwCharsLabel";
            this.pwCharsLabel.Size = new System.Drawing.Size(19, 13);
            this.pwCharsLabel.TabIndex = 3;
            this.pwCharsLabel.Text = "12";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Length";
            // 
            // copyButton
            // 
            this.copyButton.FlatAppearance.BorderSize = 0;
            this.copyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyButton.Image = global::pw.Properties.Resources.page_white_copy;
            this.copyButton.Location = new System.Drawing.Point(375, 6);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(43, 44);
            this.copyButton.TabIndex = 5;
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // charactersRadio
            // 
            this.charactersRadio.AutoSize = true;
            this.charactersRadio.Checked = true;
            this.charactersRadio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charactersRadio.Location = new System.Drawing.Point(12, 11);
            this.charactersRadio.Name = "charactersRadio";
            this.charactersRadio.Size = new System.Drawing.Size(79, 17);
            this.charactersRadio.TabIndex = 6;
            this.charactersRadio.TabStop = true;
            this.charactersRadio.Text = "Characters";
            this.charactersRadio.UseVisualStyleBackColor = true;
            this.charactersRadio.CheckedChanged += new System.EventHandler(this.randomRadio_CheckedChanged);
            // 
            // wordsRadio
            // 
            this.wordsRadio.AutoSize = true;
            this.wordsRadio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordsRadio.Location = new System.Drawing.Point(12, 42);
            this.wordsRadio.Name = "wordsRadio";
            this.wordsRadio.Size = new System.Drawing.Size(59, 17);
            this.wordsRadio.TabIndex = 7;
            this.wordsRadio.Text = "Words";
            this.wordsRadio.UseVisualStyleBackColor = true;
            this.wordsRadio.CheckedChanged += new System.EventHandler(this.wordsRadio_CheckedChanged);
            // 
            // addSpecialCheckBox
            // 
            this.addSpecialCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.addSpecialCheckBox.AutoSize = true;
            this.addSpecialCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Aqua;
            this.addSpecialCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSpecialCheckBox.Location = new System.Drawing.Point(11, 3);
            this.addSpecialCheckBox.Name = "addSpecialCheckBox";
            this.addSpecialCheckBox.Size = new System.Drawing.Size(110, 23);
            this.addSpecialCheckBox.TabIndex = 8;
            this.addSpecialCheckBox.Text = "Special Characters";
            this.addSpecialCheckBox.UseVisualStyleBackColor = true;
            this.addSpecialCheckBox.CheckedChanged += new System.EventHandler(this.addSpecialCheckBox_CheckedChanged);
            // 
            // capitaliseCheckBox
            // 
            this.capitaliseCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.capitaliseCheckBox.AutoSize = true;
            this.capitaliseCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capitaliseCheckBox.Location = new System.Drawing.Point(123, 3);
            this.capitaliseCheckBox.Name = "capitaliseCheckBox";
            this.capitaliseCheckBox.Size = new System.Drawing.Size(67, 23);
            this.capitaliseCheckBox.TabIndex = 9;
            this.capitaliseCheckBox.Text = "Capitalise";
            this.capitaliseCheckBox.UseVisualStyleBackColor = true;
            this.capitaliseCheckBox.CheckedChanged += new System.EventHandler(this.capitaliseCheckBox_CheckedChanged);
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Image = global::pw.Properties.Resources.key_add;
            this.addButton.Location = new System.Drawing.Point(12, 67);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(12, 17);
            this.addButton.TabIndex = 10;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Visible = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // moreWordsCheckBox
            // 
            this.moreWordsCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.moreWordsCheckBox.AutoSize = true;
            this.moreWordsCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moreWordsCheckBox.Location = new System.Drawing.Point(11, 28);
            this.moreWordsCheckBox.Name = "moreWordsCheckBox";
            this.moreWordsCheckBox.Size = new System.Drawing.Size(81, 23);
            this.moreWordsCheckBox.TabIndex = 12;
            this.moreWordsCheckBox.Text = "More Words";
            this.moreWordsCheckBox.UseVisualStyleBackColor = true;
            this.moreWordsCheckBox.CheckedChanged += new System.EventHandler(this.myWordsCheckBox_CheckedChanged);
            // 
            // randomCB
            // 
            this.randomCB.Appearance = System.Windows.Forms.Appearance.Button;
            this.randomCB.AutoSize = true;
            this.randomCB.Enabled = false;
            this.randomCB.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomCB.Location = new System.Drawing.Point(191, 3);
            this.randomCB.Name = "randomCB";
            this.randomCB.Size = new System.Drawing.Size(71, 23);
            this.randomCB.TabIndex = 13;
            this.randomCB.Text = "At random";
            this.randomCB.UseVisualStyleBackColor = true;
            // 
            // wordsPanel
            // 
            this.wordsPanel.Controls.Add(this.onlyTheseCheckBox);
            this.wordsPanel.Controls.Add(this.wordFileDialogBTN);
            this.wordsPanel.Controls.Add(this.addSpecialCheckBox);
            this.wordsPanel.Controls.Add(this.randomCB);
            this.wordsPanel.Controls.Add(this.capitaliseCheckBox);
            this.wordsPanel.Controls.Add(this.moreWordsCheckBox);
            this.wordsPanel.Enabled = false;
            this.wordsPanel.Location = new System.Drawing.Point(97, 36);
            this.wordsPanel.Name = "wordsPanel";
            this.wordsPanel.Size = new System.Drawing.Size(272, 56);
            this.wordsPanel.TabIndex = 14;
            // 
            // onlyTheseCheckBox
            // 
            this.onlyTheseCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.onlyTheseCheckBox.AutoSize = true;
            this.onlyTheseCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlyTheseCheckBox.Location = new System.Drawing.Point(97, 28);
            this.onlyTheseCheckBox.Name = "onlyTheseCheckBox";
            this.onlyTheseCheckBox.Size = new System.Drawing.Size(72, 23);
            this.onlyTheseCheckBox.TabIndex = 15;
            this.onlyTheseCheckBox.Text = "Only these";
            this.onlyTheseCheckBox.UseVisualStyleBackColor = true;
            // 
            // wordFileDialogBTN
            // 
            this.wordFileDialogBTN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordFileDialogBTN.Location = new System.Drawing.Point(175, 28);
            this.wordFileDialogBTN.Name = "wordFileDialogBTN";
            this.wordFileDialogBTN.Size = new System.Drawing.Size(39, 23);
            this.wordFileDialogBTN.TabIndex = 14;
            this.wordFileDialogBTN.Text = "...";
            this.wordFileDialogBTN.UseVisualStyleBackColor = true;
            this.wordFileDialogBTN.Click += new System.EventHandler(this.wordFileDialogBTN_Click);
            // 
            // randomPanel
            // 
            this.randomPanel.Controls.Add(this.label1);
            this.randomPanel.Controls.Add(this.trackBar1);
            this.randomPanel.Controls.Add(this.pwCharsLabel);
            this.randomPanel.Location = new System.Drawing.Point(97, 11);
            this.randomPanel.Name = "randomPanel";
            this.randomPanel.Size = new System.Drawing.Size(242, 27);
            this.randomPanel.TabIndex = 15;
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(424, 123);
            this.Controls.Add(this.wordsPanel);
            this.Controls.Add(this.randomPanel);
            this.Controls.Add(this.charactersRadio);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.wordsRadio);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.generateButton);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "window";
            this.Opacity = 0.95D;
            this.Text = "pw";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.wordsPanel.ResumeLayout(false);
            this.wordsPanel.PerformLayout();
            this.randomPanel.ResumeLayout(false);
            this.randomPanel.PerformLayout();
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
        private System.Windows.Forms.RadioButton charactersRadio;
        private System.Windows.Forms.RadioButton wordsRadio;
        private System.Windows.Forms.CheckBox addSpecialCheckBox;
        private System.Windows.Forms.CheckBox capitaliseCheckBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.CheckBox moreWordsCheckBox;
        private System.Windows.Forms.CheckBox randomCB;
        private System.Windows.Forms.Panel wordsPanel;
        private System.Windows.Forms.Panel randomPanel;
        private System.Windows.Forms.Button wordFileDialogBTN;
        private System.Windows.Forms.CheckBox onlyTheseCheckBox;
    }
}

