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
    public partial class Chapter3Form : Form
    {
        private String username;
        public Chapter3Form(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Chapter3Form_Load(object sender, EventArgs e)
        {
            usernameTextBox.Text = username;
            scoreTextBox.Text = MainForm.instance.Scores[2].ToString() + " /20";
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            int score3 = 0;
            if (answer1TextBox.Text == "5/7")
            {
                score3 += 4;
                answer1TextBox.BackColor = Color.FromArgb(143, 180, 143);
            }
            else
            {
                answer1TextBox.BackColor = Color.FromArgb(250, 128, 114);
            }
            if (correctRadioButton.Checked)
            {
                score3 += 6;
                correctRadioButton.BackColor = Color.FromArgb(143, 188, 143);
                falseRadioButton.BackColor = Chapter3Form.DefaultBackColor;
            }
            else if (falseRadioButton.Checked)
            {
                falseRadioButton.BackColor = Color.FromArgb(250, 128, 114);
                correctRadioButton.BackColor = Chapter3Form.DefaultBackColor;
            }
            if (answer3TextBox.Text == "5")
            {
                score3 += 10;
                answer3TextBox.BackColor = Color.FromArgb(143, 180, 143);
            }
            else
            {
                answer3TextBox.BackColor = Color.FromArgb(250, 128, 114);
            }
            scoreTextBox.Text = score3.ToString() + " /20";
            MainForm.instance.openConnection();
            MainForm.instance.update_Score(score3, 3);
            MainForm.instance.update_Level();
            MainForm.instance.closeConnection();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Chapter3TheoryForm().Show();
        }
    }
}
