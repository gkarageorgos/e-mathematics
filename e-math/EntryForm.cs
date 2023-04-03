using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_math
{
    public partial class EntryForm : Form
    {
        private String connectionString = "Data source=..\\..\\e-math.db;Version=3";
        private SQLiteConnection conn;
        private String username, password;
        public EntryForm()
        {
            InitializeComponent();
        }

        private void EntryForm_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString);
            pictureBox1.ImageLocation = "..//..//pictures/book.jpg";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            username = usernameTextBox.Text;
            password = passwordTextBox.Text;
            //Parameterized query
            String selectSQL = "Select * from User where " +
                "username=@username and password=@password";
            SQLiteCommand cmd = new SQLiteCommand(selectSQL, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                this.Hide();
                MessageBox.Show("Επιτυχία σύνδεσης!");
                String role = reader.GetString(2);
                if (role == "student")
                {
                    new MainForm(username).Show();
                }
                if (role == "teacher")
                {
                    new TeacherForm().Show();
                }
            }
            else
            {
                passwordTextBox.Clear();
                MessageBox.Show("Λάθος στοιχεία...");
            }
            reader.Close();
            conn.Close();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            new RegisterForm().Show();
        }

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "όνομα χρήστη")
            {
                usernameTextBox.Text = "";
                usernameTextBox.ForeColor = Color.Black;
            }

        }

        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "")
            {
                usernameTextBox.Text = "όνομα χρήστη";
                usernameTextBox.ForeColor = Color.Silver;
            }
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "κωδικός πρόσβασης")
            {
                passwordTextBox.Text = "";
                passwordTextBox.UseSystemPasswordChar = true;
                passwordTextBox.ForeColor = Color.Black;
;            }
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.UseSystemPasswordChar = false;
                passwordTextBox.Text = "κωδικός πρόσβασης";
                passwordTextBox.ForeColor = Color.Silver;
            }
        }
    }
}
