﻿using System;
using System.Windows.Forms;
using System.IO;

namespace Streammoped
{
    public partial class Form1 : Form
    {

        // Initializing Variables

        Int32 score_player1 = 0;
        Int32 score_player2 = 0;
        string name_player1;
        string name_player2;

        string path = Directory.GetCurrentDirectory();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_refresh_txt_Click(object sender, EventArgs e)
        {
            name_player1 = tbx_player1_name.Text;
            name_player2 = tbx_player2_name.Text;
         try 
{	        
                    score_player1 = Convert.ToInt32(tbx_player1_score.Text);
                    score_player2 = Convert.ToInt32(tbx_player2_score.Text);
}
catch (System.FormatException)
{
            score_player1 = 0;
            score_player2 = 0;
            tbx_player1_score.Text = Convert.ToString(score_player1);
            tbx_player2_score.Text = Convert.ToString(score_player2);
}
 

            File.WriteAllText(path + "/player1_name.txt", name_player1);
            File.WriteAllText(path + "/player2_name.txt", name_player2);
            File.WriteAllText(path + "/player1_score.txt", Convert.ToString(score_player1));
            File.WriteAllText(path + "/player2_score.txt", Convert.ToString(score_player2));

        }

        private void btn_clear_score_Click(object sender, EventArgs e)
        {
            score_player1 = 0;
            score_player2 = 0;
            tbx_player1_score.Text = Convert.ToString(score_player1);
            tbx_player2_score.Text = Convert.ToString(score_player2);

            File.WriteAllText(path + "/player1_score.txt", Convert.ToString(score_player1));
            File.WriteAllText(path + "/player2_score.txt", Convert.ToString(score_player2));


        }

        private void tbx_player1_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void score1_plus_Click(object sender, EventArgs e)
        {
            int tmp_score = score_player1;
            score_player1 = tmp_score + 1;

            tbx_player1_score.Text = Convert.ToString(score_player1);


            name_player1 = tbx_player1_name.Text;
            name_player2 = tbx_player2_name.Text;
            try
            {
                score_player1 = Convert.ToInt32(tbx_player1_score.Text);
                score_player2 = Convert.ToInt32(tbx_player2_score.Text);
            }
            catch (System.FormatException)
            {
                score_player1 = 0;
                score_player2 = 0;
                tbx_player1_score.Text = Convert.ToString(score_player1);
                tbx_player2_score.Text = Convert.ToString(score_player2);
            }


            File.WriteAllText(path + "/player1_name.txt", name_player1);
            File.WriteAllText(path + "/player2_name.txt", name_player2);
            File.WriteAllText(path + "/player1_score.txt", Convert.ToString(score_player1));
            File.WriteAllText(path + "/player2_score.txt", Convert.ToString(score_player2));

        }

        private void score1_minus_Click(object sender, EventArgs e)
        {
            int tmp_score = score_player1;
            score_player1 = tmp_score - 1;

            tbx_player1_score.Text = Convert.ToString(score_player1);

            name_player1 = tbx_player1_name.Text;
            name_player2 = tbx_player2_name.Text;
            try
            {
                score_player1 = Convert.ToInt32(tbx_player1_score.Text);
                score_player2 = Convert.ToInt32(tbx_player2_score.Text);
            }
            catch (System.FormatException)
            {
                score_player1 = 0;
                score_player2 = 0;
                tbx_player1_score.Text = Convert.ToString(score_player1);
                tbx_player2_score.Text = Convert.ToString(score_player2);
            }


            File.WriteAllText(path + "/player1_name.txt", name_player1);
            File.WriteAllText(path + "/player2_name.txt", name_player2);
            File.WriteAllText(path + "/player1_score.txt", Convert.ToString(score_player1));
            File.WriteAllText(path + "/player2_score.txt", Convert.ToString(score_player2));

        }

        private void score2_plus_Click(object sender, EventArgs e)
        {
            int tmp_score = score_player2;
            score_player2 = tmp_score + 1;

            tbx_player2_score.Text = Convert.ToString(score_player2);

            name_player1 = tbx_player1_name.Text;
            name_player2 = tbx_player2_name.Text;
            try
            {
                score_player1 = Convert.ToInt32(tbx_player1_score.Text);
                score_player2 = Convert.ToInt32(tbx_player2_score.Text);
            }
            catch (System.FormatException)
            {
                score_player1 = 0;
                score_player2 = 0;
                tbx_player1_score.Text = Convert.ToString(score_player1);
                tbx_player2_score.Text = Convert.ToString(score_player2);
            }


            File.WriteAllText(path + "/player1_name.txt", name_player1);
            File.WriteAllText(path + "/player2_name.txt", name_player2);
            File.WriteAllText(path + "/player1_score.txt", Convert.ToString(score_player1));
            File.WriteAllText(path + "/player2_score.txt", Convert.ToString(score_player2));
        }

        private void score2_minus_Click(object sender, EventArgs e)
        {
            int tmp_score = score_player2;
            score_player2 = tmp_score - 1;

            tbx_player2_score.Text = Convert.ToString(score_player2);

            name_player1 = tbx_player1_name.Text;
            name_player2 = tbx_player2_name.Text;
            try
            {
                score_player1 = Convert.ToInt32(tbx_player1_score.Text);
                score_player2 = Convert.ToInt32(tbx_player2_score.Text);
            }
            catch (System.FormatException)
            {
                score_player1 = 0;
                score_player2 = 0;
                tbx_player1_score.Text = Convert.ToString(score_player1);
                tbx_player2_score.Text = Convert.ToString(score_player2);
            }


            File.WriteAllText(path + "/player1_name.txt", name_player1);
            File.WriteAllText(path + "/player2_name.txt", name_player2);
            File.WriteAllText(path + "/player1_score.txt", Convert.ToString(score_player1));
            File.WriteAllText(path + "/player2_score.txt", Convert.ToString(score_player2));

        }
    }
}
