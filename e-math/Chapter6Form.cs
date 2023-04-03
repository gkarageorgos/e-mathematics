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
    public partial class Chapter6Form : Form
    {
        private String username;
        public Chapter6Form(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Chapter6Form_Load(object sender, EventArgs e)
        {
            usernameTextBox.Text = username;
            scoreTextBox.Text = MainForm.instance.scores[5].ToString();
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            int score6 = 0;
            //
            scoreTextBox.Text = score6.ToString();
            Score s = new Score();
            s.openConnection();
            s.update(username, score6, 6);
            s.closeConnection();
        }
    }
}
