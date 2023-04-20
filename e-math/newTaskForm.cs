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
        private int score = 0;
        public newTaskForm()
        {
            InitializeComponent();
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            if (answer1TextBox.Text == "64")
            {
                score += 4;
            }
            if (correctRadioButton.Checked)
            {
                score += 4;
            }
            if (answer3TextBox.Text == "1")
            {
                score += 4;
            }
            if (answer4ATextBox.Text == "45/112")
            {
                score += 2;
            }
            if (answer4BTextBox.Text == "445/18")
            {
                score += 2;
            }
            if (answer5ATextBox.Text == "36/5")
            {
                score += 2;
            }
            if (answer5ATextBox.Text == "20")
            {
                score += 2;
            }
            MessageBox.Show("Ο τελικός βαθμός σου στο τεστ είναι: " + score.ToString());
            this.Close();
        }

        private void newTaskForm_Load(object sender, EventArgs e)
        {
            richTextBox4.SelectedRtf = Properties.Resources.exercises_repetitions;
        }
    }
}
