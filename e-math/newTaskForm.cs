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
            Score s = new Score();
            int score = s.totalScore(MainForm.instance.scores);
            //
            MainForm.instance.score = score;
            MainForm.instance.scoreTextBox.Text = MainForm.instance.score.ToString();
        }
    }
}
