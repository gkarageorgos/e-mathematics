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
    public partial class Chapter1Form : Form
    {
        private String username;
        public Chapter1Form(String username)
        {
            InitializeComponent();
            this.username = username;
        }
        private void Chapter1Form_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "..//..//pictures/kyklos.png";
            usernameTextBox.Text = username;
            scoreTextBox.Text = MainForm.instance.Scores[0].ToString() + " /20";
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            int score1 = 0;
            if (answer1TextBox.Text == "2/4")
            {
                score1 += 4;
                answer1TextBox.BackColor = Color.FromArgb(143, 188, 143);
            }
            else
            {
                answer1TextBox.BackColor = Color.FromArgb(250, 128, 114);
            }
            if (correctRadioButton.Checked)
            {
                score1 += 6;
                correctRadioButton.BackColor = Color.FromArgb(143, 188, 143);
                falseRadioButton.BackColor = Chapter1Form.DefaultBackColor;

            }
            else if(falseRadioButton.Checked)
            {
                falseRadioButton.BackColor = Color.FromArgb(250, 128, 114);
                correctRadioButton.BackColor = Chapter1Form.DefaultBackColor;
            }
            if (answer3TextBox.Text == "153")
            {
                score1 += 10;
                answer3TextBox.BackColor = Color.FromArgb(143, 188, 143);
            }
            else
            {
                answer3TextBox.BackColor = Color.FromArgb(250, 128, 114);
            }

            scoreTextBox.Text = score1.ToString() + " /20";

            MainForm.instance.openConnection();
            MainForm.instance.update_Score(score1, 1);
            MainForm.instance.update_Level();
            MainForm.instance.closeConnection();
        }
    }
}
