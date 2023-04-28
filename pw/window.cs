using System;
using System.Globalization;

using System.Windows.Forms;


namespace pw
{
    public partial class window : Form

    {
        String[] wordsArray = new String[7776];
      

        public window()
        {
            InitializeComponent();
            
            String wordLine = Properties.Resources.words2;
            wordsArray = wordLine.Split('\n');
      

        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            addButton.Enabled = true;
            passwordTB.Text = "";

            if (randomRadio.Checked)
            { 
                generateChars();          
            }
            else
            {
                generateWords(3);
            }


        }
        private void generateChars()
        {
            string pw = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm1234567890!£$%*()_-}";
            for (int i = 0; i < trackBar1.Value; i++)
            {
                char c = pw[getRandom(pw.Length)];
                passwordTB.Text += c;
            }
        }
       private void generateWords(int numWords)
        {
            for (int i = 0; i < numWords; i++)
            {
                String singleWord = wordsArray[getRandom(7776)];
                if (capitaliseCheckBox.Checked) {
                    singleWord = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(singleWord);
                }            
                if (addSpecialCheckBox.Checked)
                {
                    string pw = "1234567890!£$%*()_-}";
                    char c = pw[getRandom(pw.Length)];
                    singleWord += c;
                }
                passwordTB.Text += singleWord;
            }
            if (passwordTB.Text.Length < 12)
            {
                passwordTB.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                passwordTB.ForeColor = System.Drawing.Color.Lime;
            }
        }
            


        public int getRandom(int maxNumber)
        {
            byte[] b = new byte[4];
            System.Security.Cryptography.RNGCryptoServiceProvider.Create().GetBytes(b);
            int seed = (b[0] & 0x7f) << 24 | b[1] << 16 | b[2] << 8 | b[3];
            return seed % maxNumber;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            pwCharsLabel.Text = trackBar1.Value.ToString();
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(passwordTB.Text);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(randomRadio.Checked)
            {
                generateChars();
            }
            else 
            { generateWords(1); 
            }
            
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            passwordTB.Text = "(c) Mark Parsons v0.0.1 BSD Licence";
            addButton.Enabled = false;
        }
    }

}