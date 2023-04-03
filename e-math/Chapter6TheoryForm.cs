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
    public partial class Chapter6TheoryForm : Form
    {
        private String username;
        public Chapter6TheoryForm(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Chapter6TheoryForm_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "..//..//help//chapter6.png";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Chapter6Form(username).Show();
        }
    }
}
