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
    public partial class Chapter4TheoryForm : Form
    {
        private String username;
        public Chapter4TheoryForm(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Chapter4TheoryForm_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "..//..//help//chapter4.png";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Chapter4Form(username).Show();
        }
    }
}
