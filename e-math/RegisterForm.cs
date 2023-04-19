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
    public partial class RegisterForm : Form
    {
        private String connectionString = "Data source=..\\..\\e-math.db;Version=3";
        private SQLiteConnection conn;
        private String username, password;
        private int count = 0;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Για να μπορέσεις να έχεις πρόσβαση στην εφαρμογή είναι απαραίτητο να έχεις ένα username και ένα password." +
                " Συμπλήρωσε τα αντίστοιχα πεδία έτσι ώστε να γίνει η εγγραφή!!!");
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString);
            pictureBox1.ImageLocation = "..//..//pictures/mathimatika.jpg";
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (count == 0)
            {
                new EntryForm().Show();
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            username = usernameTextBox.Text;
            password = passwordTextBox.Text;
            if (username == "" || password == "")
            {
                MessageBox.Show("Πρέπει να συμπληρώσετε και τα δυο πεδία για να είναι επιτυχής η εγγραφή!!!");
            }
            else
            {
                conn.Open();
                //Parameterized query
                String insertSQL = "Insert into User(username,password,role,score1,score2,score3,score4,score5,score6,level) " +
                "values(@username,@password,@role,@score1,@score2,@score3,@score4,@score5,@score6,@level)";
                SQLiteCommand cmd = new SQLiteCommand(insertSQL, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@role", "student");
                cmd.Parameters.AddWithValue("@score1", 0);
                cmd.Parameters.AddWithValue("@score2", 0);
                cmd.Parameters.AddWithValue("@score3", 0);
                cmd.Parameters.AddWithValue("@score4", 0);
                cmd.Parameters.AddWithValue("@score5", 0);
                cmd.Parameters.AddWithValue("@score6", 0);
                cmd.Parameters.AddWithValue("@level", 1);
                count = cmd.ExecuteNonQuery();
                if (count > 0)
                    MessageBox.Show("Συγχαρητήρια!!! Η εγγραφή έγινε με επιτυχία!");
                conn.Close();
                new LoginForm().Show();
                this.Close();
            }

        }
    }
}
