﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_math
{
    public partial class Chapter6Form : Form
    {
        private String username;
        public Chapter6Form(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Chapter6Form_Load(object sender, EventArgs e)
        {
            richTextBox2.SelectedRtf = Properties.Resources.chapter6_2;
            richTextBox3.SelectedRtf = Properties.Resources.chapter6_3;
            usernameTextBox.Text = username;
            scoreTextBox.Text = MainForm.instance.scores[5].ToString();
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            int score6 = 0;
            if (answer1TextBox.Text == "20/3")
            {
                score6 += 3;
            }
            if (answer2TextBox.Text == "28/3")
            {
                score6 += 5;
            }
            if (answer3TextBox.Text == "192/945" || answer3TextBox.Text == "64/315")
            {
                score6 += 10;
            }
            scoreTextBox.Text = score6.ToString();
            Score s = new Score();
            s.openConnection();
            s.update(username, score6, 6);
            s.closeConnection();
        }
    }
}
