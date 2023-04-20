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
    public partial class Chapter5Form : Form
    {
        private String username;
        public Chapter5Form(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Chapter5Form_Load(object sender, EventArgs e)
        {
            richTextBox1.SelectedRtf = Properties.Resources.chapter5_1;
            richTextBox2.SelectedRtf = Properties.Resources.chapter5_2;
            richTextBox3.SelectedRtf = Properties.Resources.chapter5_3;
            usernameTextBox.Text = username;
            scoreTextBox.Text = MainForm.instance.Scores[4].ToString() + " /20";
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            int score5 = 0;
            if (answer1TextBox.Text == "9/4")
            {
                score5 += 4;
                answer1TextBox.BackColor = Color.FromArgb(143, 180, 143);
            }
            else
            {
                answer1TextBox.BackColor = Color.FromArgb(250, 128, 114);
            }
            if (correctRadioButton.Checked)
            {
                score5 += 6;
                correctRadioButton.BackColor = Color.FromArgb(143, 188, 143);
                falseRadioButton.BackColor = Chapter5Form.DefaultBackColor;
            }
            else if (falseRadioButton.Checked)
            {
                falseRadioButton.BackColor = Color.FromArgb(250, 128, 114);
                correctRadioButton.BackColor = Chapter5Form.DefaultBackColor;
            }
            if (answer3TextBox.Text == "12/29")
            {
                score5 += 10;
                answer3TextBox.BackColor = Color.FromArgb(143, 180, 143);
            }
            else
            {
                answer3TextBox.BackColor = Color.FromArgb(250, 128, 114);
            }
            scoreTextBox.Text = score5.ToString() + " /20";
            MainForm.instance.openConnection();
            MainForm.instance.update_Score(score5, 5);
            MainForm.instance.update_Level();
            MainForm.instance.closeConnection();
        }
    }
}
