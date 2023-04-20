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
    public partial class Chapter1TheoryForm : Form
    {
        public Chapter1TheoryForm()
        {
            InitializeComponent();
        }

        private void Chapter1TheoryForm_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "..//..//help//chapter1.png";
        }
    }
}
