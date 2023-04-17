using System;
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
    public partial class newTaskForm : Form
    {
        private String username;
        public newTaskForm(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            int score = new Score().userData(username)[6];
            if (answer1TextBox.Text == "64")
            {
                score += 8;
            }
            if (correctRadioButton.Checked)
            {
                score += 8;
            }
            if (answer3TextBox.Text == "1")
            {
                score += 8;
            }
            if (answer4ATextBox.Text == "45/112")
            {
                score += 6;
            }
            if (answer4BTextBox.Text == "445/18")
            {
                score += 6;
            }
            if (answer5ATextBox.Text == "36/5")
            {
                score += 6;
            }
            if (answer5ATextBox.Text == "20")
            {
                score += 6;
            }
            MainForm.instance.openConnection();
            MainForm.instance.update_Score(score, 0);
            MainForm.instance.update_Level();
            MainForm.instance.closeConnection();
            if (MainForm.instance.Level == 1)
            {
                this.Close();
            }
        }

        private void newTaskForm_Load(object sender, EventArgs e)
        {
            richTextBox4.SelectedRtf = Properties.Resources.exercises_repetitions;
        }
    }
}
