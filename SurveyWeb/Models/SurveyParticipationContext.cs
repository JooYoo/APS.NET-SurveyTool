using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace SurveyWeb.Models
{
    public class SurveyParticipationContext
    {
        public string ConnectionString { get; set; }

        public SurveyParticipationContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<SurveyParticipation> GetAllParticipations()
        {
            var list = new List<SurveyParticipation>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("select * from surveyparticipation", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new SurveyParticipation()
                        {
                            User_ID = Convert.ToInt32(reader["User_ID"]),
                            Survey_ID = Convert.ToInt32(reader["Survey_ID"]),
                            ParticipationDate = ((DateTime)reader["ParticipationDate"]).ToString("yyyy-MM-dd"),
                            ID = Convert.ToInt32(reader["ID"])
                        });
                    }
                }
            }

            return list;
        }

        public void InsertParticipation(SurveyParticipation newItem)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var query = "insert into surveyparticipation(User_ID, Survey_ID, ParticipationDate, ID)" +
                    "values('" + newItem.User_ID + "','" + newItem.Survey_ID + "','" + newItem.ParticipationDate + "','" + newItem.ID + "')";


                using (var cmd = new MySqlCommand(query, conn))
                {

                    cmd.ExecuteNonQuery();
                }

            }
        }
    }
}
