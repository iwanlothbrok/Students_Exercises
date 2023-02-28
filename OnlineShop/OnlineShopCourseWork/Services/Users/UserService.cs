using Microsoft.AspNetCore.Connections.Features;
using MySql.Data.MySqlClient;
using OnlineShopCourseWork.Data.Models;
using System.Data;

namespace OnlineShopCourseWork.Services.Users
{
    public sealed class UserService : IUserService
    {
        private readonly MySqlConnection con;

        public UserService(MySqlConnection con)
        {
            this.con = con;
        }

        public void Create(User user)
        {
            try
            {
                string sql = $"insert into users (user_password, first_name, last_name, phone_number, email, username)values('{user.PasswordHash}', '{user.FirstName}', '{user.LastName}', '{user.PhoneNumber}', '{user.Email}', '{user.UserName}'); select LAST_INSERT_ID();";

                MySqlCommand com = new MySqlCommand(sql, con);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                int id = int.Parse(com.ExecuteScalar().ToString());
                user.Id = id;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public User GetByUserName(string userName)
        {
            User user = null;

            string sql = $"select * from users as us where upper(username) = '{userName}'";

            MySqlCommand command = new MySqlCommand(sql, con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string userId = reader["user_id"].ToString();
                        string password = reader["user_password"].ToString();
                        string firstName = reader["first_name"].ToString();
                        string lastName = reader["last_name"].ToString();
                        string phoneNumber = reader["phone_number"].ToString();
                        string email = reader["email"].ToString();
                        string username = reader["username"].ToString();

                        user = new User
                        {
                            Id = int.Parse(userId),
                            Email = email,
                            FirstName = firstName,
                            LastName = lastName,
                            PasswordHash = password,
                            UserName = username,
                            PhoneNumber = phoneNumber
                        };
                    }
                }

            }
            catch (Exception)
            {

            }
            finally
            {
                con.Close();
            }

            return user;
        }

        public string GetUserPasswordHash(int userId)
        {
            try
            {
                string sql = "select us.User_Password from users as us where us.User_id = " + userId;
                MySqlCommand com = new MySqlCommand(sql, con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string res = com.ExecuteScalar().ToString();

                return res;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public bool HasUser(string username)
        {
            try
            {
                string sql = $"select count(username) from users where username = '{username}'";
                MySqlCommand com = new MySqlCommand(sql, con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                int res = int.Parse(com.ExecuteScalar().ToString());
                if (res < 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
