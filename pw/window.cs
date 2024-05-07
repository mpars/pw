using System;
using System.Globalization;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.IO;

namespace pw
{
    public partial class window : Form

    {
        List<string> wordList = new List<string>();
        List<string> myWordList = new List<string>();
        //String[] wordList = new String[7776];
        Boolean useMyWord = false;
      

        public window()
        {
            InitializeComponent();
            
            String wordLine = "";
            
            if(Properties.Settings.Default.wordsFile)
            {
                try
                {
                    wordLine = File.ReadAllText(Properties.Settings.Default.wordsFilePath);
                }catch
                { 
                
                }
                
            }
            else
            {
                wordLine = Properties.Resources.words2;
            }
           
            wordList = wordLine.Split('\n').ToList();
            String myWordLine = Properties.Resources.myWords;
            myWordList = myWordLine.Split('\n').ToList();
            wordList.AddRange(myWordList);
            //wordList = wordLine.Split('\n');
      

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
                generateWords(3, myWordsCheckBox.Checked);
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
       private void generateWords(int numWords, Boolean useMyWord)
        {
            
            int when = getRandom(numWords);

            Console.WriteLine(when);

            for (int i = 0; i < numWords; i++)
            {
                String singleWord = "";
                if (useMyWord && (when == i) && (myWordList.Count > 0))
                {
                    singleWord = myWordList[getRandom(myWordList.Count)];
                    useMyWord = false;
                    if (singleWord.Length == 0) { singleWord = wordList[getRandom(wordList.Count)]; }
                    Console.WriteLine(when + " " + i);
                }
                else 
                {
                    singleWord = wordList[getRandom(wordList.Count)];

                }
                if (capitaliseCheckBox.Checked) {

                    if(randomCB.Checked) { 

                    int wordPos = getRandom(singleWord.Length-1);
                    char[] array = singleWord.ToCharArray();
                    for (int j=0; j<singleWord.Length-1; j++)
                    {
                        if(j== wordPos) {
                            array[j] = char.ToUpper(array[j]);
                            
                        }
                    }

                    singleWord = new string(array);
                    }
                    else 
                    { singleWord = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(singleWord.Trim()); }
                    //
                }
                

                if (addSpecialCheckBox.Checked)
                {
                    string pw = "1234567890!£$%*()_-}";
                    char c = pw[getRandom(pw.Length)];
                    singleWord = singleWord.Trim() + c;
                }
                passwordTB.Text += singleWord.Trim();
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
            { generateWords(1, false); 
            }
            
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            passwordTB.Text = "(c) Mark Parsons v0.0.3 BSD Licence";
            addButton.Enabled = false;
        }

        private void myWordsCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void capitaliseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (capitaliseCheckBox.Checked)
            {
                randomCB.Enabled = true;
            }
            else
            {
                randomCB.Enabled = false;
            }
        }

        private void wordsRadio_CheckedChanged(object sender, EventArgs e)
        {
            if(wordsRadio.Checked)
            {
                wordsPanel.Enabled = true;
                randomPanel.Enabled = false;
            }
           
        }

        private void randomRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (randomRadio.Checked)
            {
                randomPanel.Enabled = true;
                wordsPanel.Enabled = false;
            }
        }

        private void editWordsBtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }
    }

}