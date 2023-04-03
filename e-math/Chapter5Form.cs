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
            usernameTextBox.Text = username;
            scoreTextBox.Text = MainForm.instance.scores[4].ToString();
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            int score5 = 0;
            //
            scoreTextBox.Text = score5.ToString();
            Score s = new Score();
            s.openConnection();
            s.update(username, score5, 5);
            s.closeConnection();
        }
    }
}
