using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveyWeb.Models
{
    public class UserContext
    {
        public string ConnectionString { get; set; }

        public UserContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<User> GetAllAlbums()
        {
            List<User> list = new List<User>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from User", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new User()
                        {
                            Id = Convert.ToInt32(reader["ID"]),
                            Firstname = reader["FirstName"].ToString(),
                            Lastname = reader["LastName"].ToString(),
                            Email = reader["EMail"].ToString(),
                            Password = reader["Password"].ToString(),
                            Status = reader["Status"].ToString(),
                        });
                    }
                }
            }
            return list;
        }
    }
}
