﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_math
{
    public partial class Chapter2Form : Form
    {
        private String username;
        public Chapter2Form(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Chapter2Form_Load(object sender, EventArgs e)
        {
            usernameTextBox.Text = username;
            scoreTextBox.Text = ExercisesForm.instance.Scores[1].ToString() + " /20";
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            int score2 = 0;
            if (answer1TextBox.Text == "18/45")
            {
                score2 += 4;
                answer1TextBox.BackColor = Color.FromArgb(143, 180, 143);
            }
            else
            {
                answer1TextBox.BackColor = Color.FromArgb(250, 128, 114);
            }
            if (correctRadioButton.Checked)
            {
                score2 += 6;
                correctRadioButton.BackColor = Color.FromArgb(143, 188, 143);
                falseRadioButton.BackColor = Chapter2Form.DefaultBackColor;
            }
            else if (falseRadioButton.Checked)
            {
                falseRadioButton.BackColor = Color.FromArgb(250, 128, 114);
                correctRadioButton.BackColor = Chapter2Form.DefaultBackColor;
            }
            if (answer3TextBox.Text == "5/7")
            {
                score2 += 10;
                answer3TextBox.BackColor = Color.FromArgb(143, 180, 143);
            }
            else
            {
                answer3TextBox.BackColor = Color.FromArgb(250, 128, 114);
            }
            scoreTextBox.Text = score2.ToString() + " /20";
            ExercisesForm.instance.openConnection();
            ExercisesForm.instance.update_Score(score2, 2);
            ExercisesForm.instance.update_Level();
            ExercisesForm.instance.closeConnection();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Chapter2TheoryForm().Show();
        }
    }
}
