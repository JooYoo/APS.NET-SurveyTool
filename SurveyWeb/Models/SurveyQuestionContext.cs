using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveyWeb.Models
{
    public class SurveyQuestionContext
    {
        public string ConnectionString { get; set; }

        public SurveyQuestionContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<SurveyQuestion> GetAllSurveyQuestion()
        {
            var list = new List<SurveyQuestion>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("select * from surveyquestion", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new SurveyQuestion()
                        {
                            Id = Convert.ToInt32(reader["ID"]),
                            SurveyId = Convert.ToInt32(reader["Survey_Id"]),
                            Question =  reader["Question"].ToString(),
                            Description = reader["Description"].ToString(),
                            Type = reader["Type"].ToString()
                        });
                    }
                }
            }

            return list;
        }
    }
}
