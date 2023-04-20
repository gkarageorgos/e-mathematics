using System;
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
    public partial class Chapter4Form : Form
    {
        private String username;
        public Chapter4Form(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Chapter4Form_Load(object sender, EventArgs e)
        {
            usernameTextBox.Text = username;
            scoreTextBox.Text = MainForm.instance.Scores[3].ToString() + " /20";
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            int score4 = 0;
            if (answer1TextBox.Text == "3/2")
            {
                score4 += 4;
                answer1TextBox.BackColor = Color.FromArgb(143, 180, 143);
            }
            else
            {
                answer1TextBox.BackColor = Color.FromArgb(250, 128, 114);
            }
            if (answer2TextBox.Text == "19/15")
            {
                score4 += 6;
                answer2TextBox.BackColor = Color.FromArgb(143, 180, 143);
            }
            else
            {
                answer2TextBox.BackColor = Color.FromArgb(250, 128, 114);
            }
            if (answer3TextBox.Text == "16/15")
            {
                score4 += 10;
                answer3TextBox.BackColor = Color.FromArgb(143, 180, 143);
            }
            else
            {
                answer3TextBox.BackColor = Color.FromArgb(250, 128, 114);
            }

            scoreTextBox.Text = score4.ToString() + " /20";

            MainForm.instance.openConnection();
            MainForm.instance.update_Score(score4, 4);
            MainForm.instance.update_Level();
            MainForm.instance.closeConnection();
        }
    }
}
