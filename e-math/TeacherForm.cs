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
        private int[] scores = new int[6];
        public TeacherForm()
        {
            InitializeComponent();
        }
        private void TeacherForm_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString);
            conn.Open();
            String selectSQL = "Select username, level from User where " +
                "role=@role";
            SQLiteCommand cmd = new SQLiteCommand(selectSQL, conn);
            cmd.Parameters.AddWithValue("@role", "student");
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetString(0));
                Score s = new Score();
                s.openConnection();
                s.selectedUser(reader.GetString(0));
                scores = s.arrayInitialization();
                s.closeReader();
                s.closeConnection();
                for (int i = 0; i < 6; i++)
                {
                    item.SubItems.Add(scores[i].ToString());
                }
                item.SubItems.Add(s.totalScore(scores).ToString());
                item.SubItems.Add(reader.GetInt32(1).ToString());
                studentListView.Items.Add(item);
            }
            reader.Close();
            conn.Close();
        }
    }
}
