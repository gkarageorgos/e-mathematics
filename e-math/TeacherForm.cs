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
    public partial class TeacherForm : Form
    {
        private String connectionString = "Data source=..\\..\\e-math.db;Version=3";
        private SQLiteConnection conn;
        public TeacherForm()
        {
            InitializeComponent();
        }
        private void TeacherForm_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString);
            conn.Open();
            String selectSQL = "Select username from User where " +
                "role=@role";
            SQLiteCommand cmd = new SQLiteCommand(selectSQL, conn);
            cmd.Parameters.AddWithValue("@role", "student");
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String username = reader.GetString(0);
                ListViewItem item = new ListViewItem(username);
                int[] userData = new Score().userData(username);
                for (int i = 0; i < 8; i++)
                {
                    item.SubItems.Add(userData[i].ToString());
                }
                studentListView.Items.Add(item);
            }
            reader.Close();
            conn.Close();
        }

        private void TeacherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
