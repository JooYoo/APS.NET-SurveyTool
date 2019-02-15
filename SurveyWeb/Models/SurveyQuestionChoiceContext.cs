using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace SurveyWeb.Models
{
    public class SurveyQuestionChoiceContext
    {
        public string ConnectionString { get; set; }

        public SurveyQuestionChoiceContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }


        public List<SurveyQuestionChoice> GetAllSurveyQuestionChoice()
        {
            var list = new List<SurveyQuestionChoice>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("select * from surveyquestionchoice", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new SurveyQuestionChoice()
                        {
                            Id = Convert.ToInt32(reader["ID"]),
                            SurveyQuestionId = Convert.ToInt32(reader["SurveyQuestion_ID"]),
                            Choice = reader["Choice"].ToString()
                        });
                    }
                }
            }

            return list;
        }
    }
}
