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
    public partial class TheoryForm : Form
    {
        private String username;
        private int[] scores = new int[6];
        private int score;
        private int level;
        public TheoryForm(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void theoryButton_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "..//..//help//theory.chm");
            exercisesΒutton.Enabled = true;
        }

        private void exercisesΒutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ExercisesForm(username, scores, score, level).Show();
        }

        private void Theory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Theory_Load(object sender, EventArgs e)
        {
            int[] user_data = new Score().userData(username);
            for (int i = 0; i < 6; i++)
            {
                scores[i] = user_data[i];
            }
            score = user_data[6];
            level = user_data[7];
            if (score > 0)
            {
                exercisesΒutton.Enabled = true;
            }
        }
    }
}
