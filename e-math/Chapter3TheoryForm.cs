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
    public partial class Chapter3TheoryForm : Form
    {
        private String username;
        public Chapter3TheoryForm(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Chapter3TheoryForm_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "..//..//help//chapter3.png";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Chapter3Form(username).Show();
        }
    }
}
