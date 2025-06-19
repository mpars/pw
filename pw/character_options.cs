using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pw.Properties
{
    public partial class character_options : Form
    {
        public character_options()
        {
            InitializeComponent();
        }

        private void character_options_Load(object sender, EventArgs e)
        {
            numbers_chk.Checked = Properties.Settings.Default.special_numbers;
            excla_chk.Checked= Properties.Settings.Default.special_excla;
            pound_chk.Checked= Properties.Settings.Default.special_pound;
            dollar_chk.Checked= Properties.Settings.Default.special_dollar;
            percent_chk.Checked = Properties.Settings.Default.special_percent;
            star_chk.Checked = Properties.Settings.Default.special_star;
            brackets_chk.Checked = Properties.Settings.Default.special_brackets;
            under_chk.Checked = Properties.Settings.Default.special_under;
            dash_chk.Checked = Properties.Settings.Default.special_dash;
            curly_chk.Checked =Properties.Settings .Default.special_curly;
            square_chk.Checked = Properties.Settings.Default.special_square;
            hash_chk.Checked = Properties.Settings.Default.special_hash;
            quote_chk.Checked = Properties.Settings.Default.special_quote;
            question_chk.Checked = Properties.Settings.Default.special_question;
            user_defined.Checked = Properties.Settings.Default.special_user;
            user_tb.Text = Properties.Settings.Default.special_user_string;
        }

        private void numbers_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (numbers_chk.Checked)
            {
                Properties.Settings.Default.special_numbers = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.special_numbers = false;
                Properties.Settings.Default.Save();
            }
        }

        private void excla_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (excla_chk.Checked)
            {
                Properties.Settings.Default.special_excla = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.special_excla = false;
                Properties.Settings.Default.Save();
            }
        }

        private void pound_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (pound_chk.Checked)
            {
                Properties.Settings.Default.special_pound = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.special_pound = false;
                Properties.Settings.Default.Save();
            }
        }

        private void user_defined_CheckedChanged(object sender, EventArgs e)
        {

            if (user_defined.Checked)
            {
                Properties.Settings.Default.special_user = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.special_user = false;
                Properties.Settings.Default.Save();
            }
        }

        private void user_tb_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.special_user_string=user_tb.Text;
            Properties.Settings.Default.Save();
        }

        private void dollar_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (dollar_chk.Checked)
            {
                Properties.Settings.Default.special_dollar = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.special_dollar = false;
                Properties.Settings.Default.Save();
            }
        }

        private void percent_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (percent_chk.Checked)
            {
                Properties.Settings.Default.special_percent = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.special_percent = false;
                Properties.Settings.Default.Save();
            }
        }

        private void star_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (star_chk.Checked)
            {
                Properties.Settings.Default.special_star = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.special_star = false;
                Properties.Settings.Default.Save();
            }
        }

        private void brackets_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (brackets_chk.Checked)
            {
                Properties.Settings.Default.special_brackets = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.special_brackets = false;
                Properties.Settings.Default.Save();
            }
        }

        private void under_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (under_chk.Checked)
            {
                Properties.Settings.Default.special_under = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.special_under = false;
                Properties.Settings.Default.Save();
            }
        }

        private void quote_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (quote_chk.Checked)
            {
                Properties.Settings.Default.special_quote = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.special_quote = false;
                Properties.Settings.Default.Save();
            }
        }

        private void dash_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (dash_chk.Checked)
            {
                Properties.Settings.Default.special_dash = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.special_dash = false;
                Properties.Settings.Default.Save();
            }
        }

        private void square_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (square_chk.Checked)
            {
                Properties.Settings.Default.special_square = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.special_square = false;
                Properties.Settings.Default.Save();
            }
        }

        private void curly_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (curly_chk.Checked)
            {
                Properties.Settings.Default.special_curly = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.special_curly = false;
                Properties.Settings.Default.Save();
            }
        }

        private void hash_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (hash_chk.Checked)
            {
                Properties.Settings.Default.special_hash = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.special_hash = false;
                Properties.Settings.Default.Save();
            }
        }

        private void question_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (question_chk.Checked)
            {
                Properties.Settings.Default.special_question = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.special_question = false;
                Properties.Settings.Default.Save();
            }
        }
    }
    }
    

