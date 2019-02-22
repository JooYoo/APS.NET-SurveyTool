using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;


namespace SurveyWeb.Models
{
    public class SurveyContext
    {
        public string ConnectionString { get; set; }

        public SurveyContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<Survey> GetAllSurvey()
        {
            var list = new List<Survey>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("select * from Survey", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Survey()
                        {
                            Id = Convert.ToInt32(reader["ID"]),
                            Title = reader["Title"].ToString(),
                            Description = reader["Description"].ToString(),
                            CreationDate = ((DateTime)reader["CreationDate"]).ToString("yyyy-MM-dd")
                        });
                    }
                }
            }

            return list;
        }
    }
}
