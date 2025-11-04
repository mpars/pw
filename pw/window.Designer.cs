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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(window));
            this.generateButton = new System.Windows.Forms.Button();
            this.charactersTrackBar = new System.Windows.Forms.TrackBar();
            this.pwCharsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.charactersRadio = new System.Windows.Forms.RadioButton();
            this.wordsRadio = new System.Windows.Forms.RadioButton();
            this.addSpecialCheckBox = new System.Windows.Forms.CheckBox();
            this.capitaliseCheckBox = new System.Windows.Forms.CheckBox();
            this.moreWordsCheckBox = new System.Windows.Forms.CheckBox();
            this.randomCheckBox = new System.Windows.Forms.CheckBox();
            this.wordsPanel = new System.Windows.Forms.Panel();
            this.onlyTheseCheckBox = new System.Windows.Forms.CheckBox();
            this.wordFileDialogBTN = new System.Windows.Forms.Button();
            this.randomPanel = new System.Windows.Forms.Panel();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.passwordsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearPasswordListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGeneratedPasswordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.QuitToTrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.checkPwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.specialCharsOptions = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.charactersTrackBar)).BeginInit();
            this.wordsPanel.SuspendLayout();
            this.randomPanel.SuspendLayout();
            this.passwordPanel.SuspendLayout();
            this.passwordsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateButton.FlatAppearance.BorderSize = 0;
            this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.Image = global::pw.Properties.Resources.lock_add;
            this.generateButton.Location = new System.Drawing.Point(383, 61);
            this.generateButton.Margin = new System.Windows.Forms.Padding(4);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(43, 42);
            this.generateButton.TabIndex = 0;
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // charactersTrackBar
            // 
            this.charactersTrackBar.Location = new System.Drawing.Point(84, -1);
            this.charactersTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.charactersTrackBar.Maximum = 60;
            this.charactersTrackBar.Minimum = 8;
            this.charactersTrackBar.Name = "charactersTrackBar";
            this.charactersTrackBar.Size = new System.Drawing.Size(245, 45);
            this.charactersTrackBar.TabIndex = 2;
            this.charactersTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.charactersTrackBar.Value = 12;
            this.charactersTrackBar.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // pwCharsLabel
            // 
            this.pwCharsLabel.AutoSize = true;
            this.pwCharsLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwCharsLabel.Location = new System.Drawing.Point(55, 3);
            this.pwCharsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pwCharsLabel.Name = "pwCharsLabel";
            this.pwCharsLabel.Size = new System.Drawing.Size(19, 13);
            this.pwCharsLabel.TabIndex = 3;
            this.pwCharsLabel.Text = "12";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Length";
            // 
            // charactersRadio
            // 
            this.charactersRadio.AutoSize = true;
            this.charactersRadio.Checked = true;
            this.charactersRadio.FlatAppearance.BorderSize = 0;
            this.charactersRadio.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.charactersRadio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charactersRadio.Location = new System.Drawing.Point(14, 7);
            this.charactersRadio.Margin = new System.Windows.Forms.Padding(4);
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
            this.wordsRadio.FlatAppearance.BorderSize = 0;
            this.wordsRadio.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.wordsRadio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordsRadio.Location = new System.Drawing.Point(14, 58);
            this.wordsRadio.Margin = new System.Windows.Forms.Padding(4);
            this.wordsRadio.Name = "wordsRadio";
            this.wordsRadio.Size = new System.Drawing.Size(59, 17);
            this.wordsRadio.TabIndex = 7;
            this.wordsRadio.Text = "Words";
            this.wordsRadio.UseVisualStyleBackColor = true;
            this.wordsRadio.CheckedChanged += new System.EventHandler(this.wordsRadio_CheckedChanged);
            // 
            // addSpecialCheckBox
            // 
            this.addSpecialCheckBox.AutoSize = true;
            this.addSpecialCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.addSpecialCheckBox.FlatAppearance.BorderSize = 0;
            this.addSpecialCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addSpecialCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSpecialCheckBox.Location = new System.Drawing.Point(97, 36);
            this.addSpecialCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.addSpecialCheckBox.Name = "addSpecialCheckBox";
            this.addSpecialCheckBox.Size = new System.Drawing.Size(119, 17);
            this.addSpecialCheckBox.TabIndex = 8;
            this.addSpecialCheckBox.Text = "Special Characters";
            this.addSpecialCheckBox.UseVisualStyleBackColor = false;
            this.addSpecialCheckBox.CheckedChanged += new System.EventHandler(this.addSpecialCheckBox_CheckedChanged);
            // 
            // capitaliseCheckBox
            // 
            this.capitaliseCheckBox.AutoSize = true;
            this.capitaliseCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.capitaliseCheckBox.FlatAppearance.BorderSize = 0;
            this.capitaliseCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.capitaliseCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capitaliseCheckBox.Location = new System.Drawing.Point(4, 4);
            this.capitaliseCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.capitaliseCheckBox.Name = "capitaliseCheckBox";
            this.capitaliseCheckBox.Size = new System.Drawing.Size(76, 17);
            this.capitaliseCheckBox.TabIndex = 9;
            this.capitaliseCheckBox.Text = "Capitalise";
            this.capitaliseCheckBox.UseVisualStyleBackColor = false;
            this.capitaliseCheckBox.CheckedChanged += new System.EventHandler(this.capitaliseCheckBox_CheckedChanged);
            // 
            // moreWordsCheckBox
            // 
            this.moreWordsCheckBox.AutoSize = true;
            this.moreWordsCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.moreWordsCheckBox.FlatAppearance.BorderSize = 0;
            this.moreWordsCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.moreWordsCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moreWordsCheckBox.Location = new System.Drawing.Point(4, 24);
            this.moreWordsCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.moreWordsCheckBox.Name = "moreWordsCheckBox";
            this.moreWordsCheckBox.Size = new System.Drawing.Size(112, 17);
            this.moreWordsCheckBox.TabIndex = 12;
            this.moreWordsCheckBox.Text = "Use More Words";
            this.moreWordsCheckBox.UseVisualStyleBackColor = false;
            this.moreWordsCheckBox.CheckedChanged += new System.EventHandler(this.moreWordsCheckBox_CheckedChanged);
            // 
            // randomCheckBox
            // 
            this.randomCheckBox.AutoSize = true;
            this.randomCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.randomCheckBox.Enabled = false;
            this.randomCheckBox.FlatAppearance.BorderSize = 0;
            this.randomCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.randomCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomCheckBox.Location = new System.Drawing.Point(84, 4);
            this.randomCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.randomCheckBox.Name = "randomCheckBox";
            this.randomCheckBox.Size = new System.Drawing.Size(80, 17);
            this.randomCheckBox.TabIndex = 13;
            this.randomCheckBox.Text = "At random";
            this.randomCheckBox.UseVisualStyleBackColor = false;
            // 
            // wordsPanel
            // 
            this.wordsPanel.Controls.Add(this.randomCheckBox);
            this.wordsPanel.Controls.Add(this.capitaliseCheckBox);
            this.wordsPanel.Controls.Add(this.onlyTheseCheckBox);
            this.wordsPanel.Controls.Add(this.wordFileDialogBTN);
            this.wordsPanel.Controls.Add(this.moreWordsCheckBox);
            this.wordsPanel.Enabled = false;
            this.wordsPanel.Location = new System.Drawing.Point(93, 56);
            this.wordsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.wordsPanel.Name = "wordsPanel";
            this.wordsPanel.Size = new System.Drawing.Size(282, 47);
            this.wordsPanel.TabIndex = 14;
            // 
            // onlyTheseCheckBox
            // 
            this.onlyTheseCheckBox.AutoSize = true;
            this.onlyTheseCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.onlyTheseCheckBox.FlatAppearance.BorderSize = 0;
            this.onlyTheseCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.onlyTheseCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlyTheseCheckBox.Location = new System.Drawing.Point(118, 24);
            this.onlyTheseCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.onlyTheseCheckBox.Name = "onlyTheseCheckBox";
            this.onlyTheseCheckBox.Size = new System.Drawing.Size(81, 17);
            this.onlyTheseCheckBox.TabIndex = 15;
            this.onlyTheseCheckBox.Text = "Only these";
            this.onlyTheseCheckBox.UseVisualStyleBackColor = false;
            // 
            // wordFileDialogBTN
            // 
            this.wordFileDialogBTN.FlatAppearance.BorderSize = 0;
            this.wordFileDialogBTN.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.wordFileDialogBTN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.wordFileDialogBTN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordFileDialogBTN.Location = new System.Drawing.Point(202, 23);
            this.wordFileDialogBTN.Margin = new System.Windows.Forms.Padding(4);
            this.wordFileDialogBTN.Name = "wordFileDialogBTN";
            this.wordFileDialogBTN.Size = new System.Drawing.Size(71, 20);
            this.wordFileDialogBTN.TabIndex = 14;
            this.wordFileDialogBTN.Text = "Words...";
            this.wordFileDialogBTN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.wordFileDialogBTN.UseVisualStyleBackColor = true;
            this.wordFileDialogBTN.Click += new System.EventHandler(this.wordFileDialogBTN_Click);
            // 
            // randomPanel
            // 
            this.randomPanel.Controls.Add(this.label1);
            this.randomPanel.Controls.Add(this.charactersTrackBar);
            this.randomPanel.Controls.Add(this.pwCharsLabel);
            this.randomPanel.Location = new System.Drawing.Point(93, 7);
            this.randomPanel.Margin = new System.Windows.Forms.Padding(4);
            this.randomPanel.Name = "randomPanel";
            this.randomPanel.Size = new System.Drawing.Size(333, 26);
            this.randomPanel.TabIndex = 15;
            // 
            // passwordPanel
            // 
            this.passwordPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordPanel.BackColor = System.Drawing.Color.Black;
            this.passwordPanel.ContextMenuStrip = this.passwordsMenu;
            this.passwordPanel.Controls.Add(this.passwordLabel);
            this.passwordPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordPanel.Location = new System.Drawing.Point(0, 107);
            this.passwordPanel.Margin = new System.Windows.Forms.Padding(4);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(439, 39);
            this.passwordPanel.TabIndex = 16;
            this.passwordPanel.Click += new System.EventHandler(this.panel1_Click);
            // 
            // passwordsMenu
            // 
            this.passwordsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem,
            this.addWordToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.checkPwToolStripMenuItem,
            this.quitMenuItem,
            this.toolStripSeparator1});
            this.passwordsMenu.Name = "passwordsMenu";
            this.passwordsMenu.Size = new System.Drawing.Size(238, 142);
            this.passwordsMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.passwordsMenu_ItemClicked);
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(237, 22);
            this.aboutMenuItem.Text = "About";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // addWordToolStripMenuItem
            // 
            this.addWordToolStripMenuItem.Name = "addWordToolStripMenuItem";
            this.addWordToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.addWordToolStripMenuItem.Text = "Add Extra Word";
            this.addWordToolStripMenuItem.Click += new System.EventHandler(this.addWordToolStripMenuItem_Click_1);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearPasswordListToolStripMenuItem,
            this.saveGeneratedPasswordsToolStripMenuItem,
            this.toolStripSeparator2,
            this.QuitToTrayToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // clearPasswordListToolStripMenuItem
            // 
            this.clearPasswordListToolStripMenuItem.Name = "clearPasswordListToolStripMenuItem";
            this.clearPasswordListToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.clearPasswordListToolStripMenuItem.Text = "Clear Password List";
            this.clearPasswordListToolStripMenuItem.Click += new System.EventHandler(this.clearPasswordListToolStripMenuItem_Click);
            // 
            // saveGeneratedPasswordsToolStripMenuItem
            // 
            this.saveGeneratedPasswordsToolStripMenuItem.Name = "saveGeneratedPasswordsToolStripMenuItem";
            this.saveGeneratedPasswordsToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.saveGeneratedPasswordsToolStripMenuItem.Text = "Save Generated Passwords...";
            this.saveGeneratedPasswordsToolStripMenuItem.Click += new System.EventHandler(this.saveGeneratedPasswordsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(219, 6);
            // 
            // QuitToTrayToolStripMenuItem
            // 
            this.QuitToTrayToolStripMenuItem.Name = "QuitToTrayToolStripMenuItem";
            this.QuitToTrayToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.QuitToTrayToolStripMenuItem.Text = "Close to Tray";
            this.QuitToTrayToolStripMenuItem.Click += new System.EventHandler(this.QuitToTrayToolStripMenuItem_Click);
            // 
            // quitMenuItem
            // 
            this.quitMenuItem.Name = "quitMenuItem";
            this.quitMenuItem.Size = new System.Drawing.Size(237, 22);
            this.quitMenuItem.Text = "Quit";
            this.quitMenuItem.Click += new System.EventHandler(this.quitMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(234, 6);
            // 
            // checkPwToolStripMenuItem
            // 
            this.checkPwToolStripMenuItem.Name = "checkPwToolStripMenuItem";
            this.checkPwToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.checkPwToolStripMenuItem.Text = "Check Password for breaches...";
            this.checkPwToolStripMenuItem.Click += new System.EventHandler(this.checkPwToolStripMenuItem_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.Lime;
            this.passwordLabel.Location = new System.Drawing.Point(4, 7);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(20, 22);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "-";
            this.passwordLabel.Click += new System.EventHandler(this.pwLabel_Click);
            // 
            // trayIcon
            // 
            this.trayIcon.BalloonTipText = "pw has been minimised to the system tray\r\nclick pw\'s system tray icon to open.";
            this.trayIcon.ContextMenuStrip = this.passwordsMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "pw";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseClick);
            // 
            // specialCharsOptions
            // 
            this.specialCharsOptions.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialCharsOptions.Location = new System.Drawing.Point(216, 33);
            this.specialCharsOptions.Margin = new System.Windows.Forms.Padding(4);
            this.specialCharsOptions.Name = "specialCharsOptions";
            this.specialCharsOptions.Size = new System.Drawing.Size(63, 22);
            this.specialCharsOptions.TabIndex = 17;
            this.specialCharsOptions.Text = "Choose...";
            this.specialCharsOptions.UseVisualStyleBackColor = true;
            this.specialCharsOptions.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuButton
            // 
            this.menuButton.ContextMenuStrip = this.passwordsMenu;
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Image = global::pw.Properties.Resources.menu_dots;
            this.menuButton.Location = new System.Drawing.Point(383, 33);
            this.menuButton.Margin = new System.Windows.Forms.Padding(4);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(43, 25);
            this.menuButton.TabIndex = 18;
            this.menuButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            this.menuButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuButton_MouseDown);
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(439, 144);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.specialCharsOptions);
            this.Controls.Add(this.passwordPanel);
            this.Controls.Add(this.wordsPanel);
            this.Controls.Add(this.addSpecialCheckBox);
            this.Controls.Add(this.randomPanel);
            this.Controls.Add(this.charactersRadio);
            this.Controls.Add(this.wordsRadio);
            this.Controls.Add(this.generateButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "window";
            this.Opacity = 0.95D;
            this.Text = "pw";
            this.TopMost = true;
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.window_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.window_FormClosing);
            this.Load += new System.EventHandler(this.window_Load);
            this.Resize += new System.EventHandler(this.window_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.charactersTrackBar)).EndInit();
            this.wordsPanel.ResumeLayout(false);
            this.wordsPanel.PerformLayout();
            this.randomPanel.ResumeLayout(false);
            this.randomPanel.PerformLayout();
            this.passwordPanel.ResumeLayout(false);
            this.passwordPanel.PerformLayout();
            this.passwordsMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TrackBar charactersTrackBar;
        private System.Windows.Forms.Label pwCharsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton charactersRadio;
        private System.Windows.Forms.RadioButton wordsRadio;
        private System.Windows.Forms.CheckBox addSpecialCheckBox;
        private System.Windows.Forms.CheckBox capitaliseCheckBox;
        private System.Windows.Forms.CheckBox moreWordsCheckBox;
        private System.Windows.Forms.CheckBox randomCheckBox;
        private System.Windows.Forms.Panel wordsPanel;
        private System.Windows.Forms.Panel randomPanel;
        private System.Windows.Forms.Button wordFileDialogBTN;
        private System.Windows.Forms.CheckBox onlyTheseCheckBox;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.ContextMenuStrip passwordsMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ToolStripMenuItem quitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearPasswordListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGeneratedPasswordsToolStripMenuItem;
        private System.Windows.Forms.Button specialCharsOptions;
        private System.Windows.Forms.ToolStripMenuItem QuitToTrayToolStripMenuItem;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem addWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkPwToolStripMenuItem;
    }
}

