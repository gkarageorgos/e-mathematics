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
            scoreTextBox.Text = MainForm.instance.Scores[4].ToString();
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            int score5 = 0;
            if (answer1TextBox.Text == "9/4")
            {
                score5 += 3;
            }
            if (correctRadioButton.Checked)
            {
                score5 += 5;
            }
            if (answer3TextBox.Text == "12/29")
            {
                score5 += 10;
            }
            scoreTextBox.Text = score5.ToString();
            MainForm.instance.openConnection();
            MainForm.instance.update_Score(score5, 5);
            MainForm.instance.update_Level();
            MainForm.instance.closeConnection();
        }
    }
}
