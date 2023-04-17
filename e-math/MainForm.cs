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
    public partial class MainForm : Form
    {
        internal static MainForm instance;
        private String username;
        internal int[] scores = new int[6];
        internal int score;
        internal int level;
        private void MainForm_Load(object sender, EventArgs e)
        {
            usernameTextBox.Text = username;
            Score s = new Score();
            s.openConnection();
            s.selectedUser(username);
            scores = s.arrayInitialization();
            level = s.the_level_of_the_user();
            s.closeReader();
            s.closeConnection();
            score = s.totalScore(scores);
            scoreTextBox.Text = score.ToString();
            if (level == 1)
            {
                label3.Visible = true;
                level2Button.Visible = false;
            }
            else
            {
                label3.Visible = false;
                level2Button.Visible = true;
            }
        }

        public MainForm(String username)
        {
            InitializeComponent();
            this.username = username;
            instance = this;
        }

        private void theoryButton_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "..//..//help//theory.chm");
        }

        private void chapter1Button_Click(object sender, EventArgs e)
        {
            new Chapter1TheoryForm(username).Show();
        }

        private void chapter2Button_Click(object sender, EventArgs e)
        {
            new Chapter2TheoryForm(username).Show();
        }

        private void chapter3Button_Click(object sender, EventArgs e)
        {
            new Chapter3TheoryForm(username).Show();
        }

        private void chapter4Button_Click(object sender, EventArgs e)
        {
            new Chapter4TheoryForm(username).Show();
        }

        private void chapter5Button_Click(object sender, EventArgs e)
        {
            new Chapter5TheoryForm(username).Show();
        }

        private void chapter6Button_Click(object sender, EventArgs e)
        {
            new Chapter6TheoryForm(username).Show();
        }

        private void level2Button_Click(object sender, EventArgs e)
        {
            new newTaskForm(username).Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
