using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_math
{
    internal class Score
    {
        private String connectionString = "Data source=..\\..\\e-math.db;Version=3";
        private SQLiteConnection conn;
        private SQLiteDataReader reader;
        private int[] arr = new int[6];
        private Boolean changeLevel = false;
        internal void selectedUser(String username)
        {
            //Parameterized query
            String selectSQL = "Select * from User where username=@username";
            SQLiteCommand cmd = new SQLiteCommand(selectSQL, conn);
            cmd.Parameters.AddWithValue("@username", username);
            reader = cmd.ExecuteReader();
        }
        internal void update(String username, int chapter_score, int chapter)
        {
            MainForm.instance.score -= MainForm.instance.scores[chapter - 1];
            MainForm.instance.scores[chapter - 1] = chapter_score;
            MainForm.instance.score += MainForm.instance.scores[chapter - 1];
            if (MainForm.instance.score > 90)
            {
                if (MainForm.instance.level == 1)
                {
                    changeLevel = !changeLevel;
                }
                if (changeLevel)
                {
                    MainForm.instance.level = 2;
                    MainForm.instance.label3.Visible = false;
                    MainForm.instance.level2Button.Visible = true;
                }
            }
            else
            {
                if (MainForm.instance.level == 2)
                {
                    changeLevel = !changeLevel;
                }
                if (changeLevel)
                {
                    MainForm.instance.level = 1;
                    MainForm.instance.label3.Visible = true;
                    MainForm.instance.level2Button.Visible = false;
                }
            }
            if (changeLevel)
            {
                //Parameterized query
                String updateSQL1 = "Update User Set level=@level where username=@username";
                SQLiteCommand cmd1 = new SQLiteCommand(updateSQL1, conn);
                cmd1.Parameters.AddWithValue("@level", MainForm.instance.level);
                cmd1.Parameters.AddWithValue("@username", username);
                cmd1.ExecuteNonQuery();
            }
            MainForm.instance.scoreTextBox.Text = MainForm.instance.score.ToString();
            //Parameterized query
            String updateSQL = "Update User Set score" + chapter + "=@score" + chapter +" where username=@username";
            SQLiteCommand cmd = new SQLiteCommand(updateSQL, conn);
            cmd.Parameters.AddWithValue("@score" + chapter, chapter_score);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.ExecuteNonQuery();
        }

        internal int[] arrayInitialization()
        {
            if (reader.Read())
            {
                for (int i = 0; i < 6; i++)
                {
                    arr[i] = reader.GetInt32(i + 3);
                }
            }
            return arr;
        }
        internal int the_level_of_the_user()
        {
            return reader.GetInt32(9);
        }
        internal void openConnection()
        {
            conn = new SQLiteConnection(connectionString);
            conn.Open();
        }
        internal void closeReader()
        {
            reader.Close();
        }
        internal void closeConnection()
        {
            conn.Close();
        }
        internal int totalScore(int[] scores)
        {
            int sum = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }
            return sum;
        }
    }
}
