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
            scoreTextBox.Text = MainForm.instance.scores[0].ToString();
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            int score1 = 0;
            if (answer1TextBox.Text == "2/4")
            {
                score1 += 3;
            }
            if (correctRadioButton.Checked)
            {
                score1 += 5;
            }
            if (answer3TextBox.Text == "153")
            {
                score1 += 10;
            }
            scoreTextBox.Text = score1.ToString();
            Score s = new Score();
            s.openConnection();
            s.update(username, score1, 1);
            s.closeConnection();
        }
    }
}
