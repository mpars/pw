using System;
using System.Globalization;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using System.Drawing;
using System.Runtime.InteropServices.ComTypes;

namespace pw
{
    public partial class window : Form

    {
        List<string> wordList = new List<string>();
        List<string> myWordList = new List<string>();
        //String[] wordList = new String[7776];
        Boolean useMyWord = false;

        String runningPasswords = "";
        

        public window()
        {
            InitializeComponent();



            String wordLine = "";
            String myWordLine = "";

            if (Properties.Settings.Default.wordsFile)
            {
                try
                {
                    myWordLine = File.ReadAllText(Properties.Settings.Default.wordsFilePath);
                }
                catch
                {

                }

            }
           
                wordLine = Properties.Resources.words2;
            

            //wordList = wordLine.Split('\n').ToList();

            wordList = wordsToList(wordLine);
            myWordList = wordsToList(myWordLine);
            //String myWordLine = Properties.Resources.myWords;
            // myWordList = myWordLine.Split('\n').ToList();

            // add mywordlist to wordlist
            //wordList.AddRange(myWordList);
            //wordList = wordLine.Split('\n');


            // set up check boxes

            if (Properties.Settings.Default.characters)
            {
                charactersRadio.Checked = true;
            }
            else
            {
                wordsRadio.Checked = true;
            }

            addSpecialCheckBox.Checked = Properties.Settings.Default.special;
            capitaliseCheckBox.Checked = Properties.Settings.Default.capitalise;
            randomCB.Checked = Properties.Settings.Default.atRandom;
            moreWordsCheckBox.Checked = Properties.Settings.Default.moreWords;
            onlyTheseCheckBox.Checked = Properties.Settings.Default.onlyThese;
            
           

        }

        private List<string>  wordsToList(string words)
        {
            return words.Split('\n').ToList();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            addButton.Enabled = true;
            passwordTB.Text = "";

            if (charactersRadio.Checked)
            {
                generateChars();
            }
            else
            {
                generateWords(3, moreWordsCheckBox.Checked);
            }

            runningPasswords += "\n"+passwordTB.Text;
            Console.WriteLine(runningPasswords);
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

                if (useMyWord && onlyTheseCheckBox.Checked && (myWordList.Count > 0)) {

                    singleWord = myWordList[getRandom(myWordList.Count)];

                }
                // insert myword in sequence
                else if (useMyWord && (when == i) && (myWordList.Count > 0))
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




                if (capitaliseCheckBox.Checked)
                {

                    if (randomCB.Checked)
                    {

                        int wordPos = getRandom(singleWord.Length - 1);
                        char[] array = singleWord.ToCharArray();
                        for (int j = 0; j < singleWord.Length - 1; j++)
                        {
                            if (j == wordPos)
                            {
                                array[j] = char.ToUpper(array[j]);

                            }
                        }

                        singleWord = new string(array);
                    }
                    else
                    { 
                        singleWord = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(singleWord.Trim()); 
                    }
                    //
                }


                if (addSpecialCheckBox.Checked)
                {
                    string pw = "1234567890!£$%*()_-}{[]#'?";
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
            if (charactersRadio.Checked)
            {
                generateChars();
            }
            else
            {
                generateWords(1, false);
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
                Properties.Settings.Default.capitalise = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                randomCB.Enabled = false;
                Properties.Settings.Default.capitalise = false;
                Properties.Settings.Default.Save();
            }
        }

        private void wordsRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (wordsRadio.Checked)
            {
                wordsPanel.Enabled = true;
                randomPanel.Enabled = false;
                Properties.Settings.Default.characters = false;
                Properties.Settings.Default.Save();
            }

        }

        private void randomRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (charactersRadio.Checked)
            {
                randomPanel.Enabled = true;
                wordsPanel.Enabled = false;
                Properties.Settings.Default.characters = true;
                Properties.Settings.Default.Save();
            }
        }

       

        private void window_Load(object sender, EventArgs e)
        {
            passwordTB.Text = "(c) Mark Parsons v0.0.4 BSD Licence";
        }

        private void wordFileDialogBTN_Click(object sender, EventArgs e)
        {
            string filename = "";

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files|*.txt";
            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                filename = ofd.FileName;
                Properties.Settings.Default.wordsFilePath = filename;
                Properties.Settings.Default.wordsFile = true;
                Properties.Settings.Default.Save();
            }
            Console.WriteLine(filename);

            String myWordLine = "";
            try
            {
                myWordLine = File.ReadAllText(Properties.Settings.Default.wordsFilePath);
                myWordList = wordsToList(myWordLine);
            }
            catch { }
        }

        private void addSpecialCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (addSpecialCheckBox.Checked)
            {
                Properties.Settings.Default.special = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.special = false;
                Properties.Settings.Default.Save();
            }
            
        }
    }

    }

 

