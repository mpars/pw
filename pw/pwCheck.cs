using HaveIBeenPwned;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pw
{
    
    public partial class pwCheck : Form
    {
        public bool showingHelp = false;
        public string previousOutput = string.Empty;

        HaveIBeenPwned.Password.HaveIBeenPwned pwned;
        public pwCheck()
        {
            InitializeComponent();
        }

        private void pwCheck_Load(object sender, EventArgs e)
        {

        }

        private bool checkPwned(HaveIBeenPwned.Password.HaveIBeenPwned pwned, string passwordToCheck)
        {
            bool isPasswordPwned = pwned.IsPasswordPwned(passwordToCheck);
            return isPasswordPwned;
        }

        private void checkBTN_Click(object sender, EventArgs e)
        {
            if (pwToCheckTB.TextLength > 0)
            {
                pwned = new HaveIBeenPwned.Password.HaveIBeenPwned();
                bool isPasswordPwned = checkPwned(pwned, pwToCheckTB.Text);
                if (isPasswordPwned)
                {
                    if (showingHelp)
                    {
                        showingHelp = false;
                        outputTB.Text = previousOutput;
                        outputTB.SelectionStart = outputTB.Text.Length;
                        outputTB.ScrollToCaret();

                    }

                    int numberOfTimesPwned = pwned.GetNumberOfTimesPasswordPwned(pwToCheckTB.Text);
                    if (outputTB.Text.Length > 0)
                    {
                        outputTB.Text += "\r\n";
                    }

                    outputTB.Text += pwToCheckTB.Text + " : Seen " + numberOfTimesPwned.ToString() + " times in breaches";
                    //addPwnedToLV(pwned, pwToCheckTB.Text);
                    outputTB.SelectionStart = outputTB.Text.Length;
                    outputTB.ScrollToCaret();
                    pwToCheckTB.BackColor = Color.Red;
                    pwToCheckTB.ForeColor = Color.White;
                    pwnedPanel.BackColor = Color.Red;

                }
                else
                {
                    pwToCheckTB.BackColor = Color.LightGreen;
                    pwnedPanel.BackColor = Color.LightGreen;
                }
            }
        }

        private void pwToCheckTB_MouseDown(object sender, MouseEventArgs e)
        {
            pwToCheckTB.Text = "";
            pwToCheckTB.BackColor = Color.White;
            pwToCheckTB.ForeColor = Color.Black;
            pwnedPanel.BackColor = System.Drawing.SystemColors.Control;
        }

     

        private void infoBTN_Click(object sender, EventArgs e)
        {
            previousOutput = outputTB.Text;
            showingHelp = true;
            outputTB.Text = "Checks if a password has appeared in known data breaches. If a password doesn't appear in a breach this doesn't mean it's a good password!";
        }
    }
}
