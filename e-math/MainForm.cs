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
        private String connectionString = "Data source=..\\..\\e-math.db;Version=3";
        private SQLiteConnection conn;
        internal static MainForm instance;
        private String username;
        private int[] scores = new int[6];
        private int score;
        private int level;
        internal int[] Scores
        {
            get { return scores; }
        }
        internal int Level
        {
            get { return level; }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            usernameTextBox.Text = username;
            int[] user_data = new Score().userData(username);
            for (int i = 0; i < 6; i++)
            {
                scores[i] = user_data[i];
            }
            score = user_data[6];
            level = user_data[7];
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

        internal void openConnection()
        {
            conn = new SQLiteConnection(connectionString);
            conn.Open();
        }

        internal void closeConnection()
        {
            conn.Close();
        }

        internal void update_Score(int score, int chapter)
        {
            if (chapter == 0)
            {
                this.score = score;
            }
            else
            {
                this.score -= scores[chapter - 1];
                scores[chapter - 1] = score;
                this.score += scores[chapter - 1];
                //Parameterized query
                String updateSQL = "Update User Set score" + chapter + "=@score" + chapter + " where username=@username";
                SQLiteCommand cmd = new SQLiteCommand(updateSQL, conn);
                cmd.Parameters.AddWithValue("@score" + chapter, score);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.ExecuteNonQuery();
            }
            scoreTextBox.Text = this.score.ToString();
        }

        internal void update_Level()
        {
            Boolean changeLevel = false;
            if (score > 90)
            {
                if (level == 1)
                {
                    changeLevel = !changeLevel;
                }
                if (changeLevel)
                {
                    level = 2;
                    label3.Visible = false;
                    level2Button.Visible = true;
                }
            }
            else
            {
                if (level == 2)
                {
                    changeLevel = !changeLevel;
                }
                if (changeLevel)
                {
                    level = 1;
                    label3.Visible = true;
                    level2Button.Visible = false;
                }
            }
            if (changeLevel)
            {
                //Parameterized query
                String updateSQL = "Update User Set level=@level where username=@username";
                SQLiteCommand cmd = new SQLiteCommand(updateSQL, conn);
                cmd.Parameters.AddWithValue("@level", MainForm.instance.level);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
