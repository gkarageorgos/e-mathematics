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
        private int[] user_data = new int[8];
        internal int[] userData(String username)
        {
            conn = new SQLiteConnection(connectionString);
            conn.Open();
            //Parameterized query
            String selectSQL = "Select * from User where username=@username";
            SQLiteCommand cmd = new SQLiteCommand(selectSQL, conn);
            cmd.Parameters.AddWithValue("@username", username);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                for (int i = 0; i < 6; i++)
                {
                    user_data[i] = reader.GetInt32(i + 3);
                }
            }
            user_data[6] = totalScore(user_data);
            user_data[7] = reader.GetInt32(9);
            reader.Close();
            conn.Close();
            return user_data;

        }
        private int totalScore(int[] scores)
        {
            int sum = 0;
            for (int i = 0; i < 6; i++)
            {
                sum += scores[i];
            }
            return sum;
        }
    }
}
