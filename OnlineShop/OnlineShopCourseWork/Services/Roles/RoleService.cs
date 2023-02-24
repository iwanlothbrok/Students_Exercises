using MySql.Data.MySqlClient;
using OnlineShopCourseWork.Models;
using System.Data;

namespace OnlineShopCourseWork.Services.Roles
{
    public sealed class RoleService : IRoleService
    {
        private readonly MySqlConnection con;

        public RoleService(MySqlConnection con)
        {
            this.con = con;
        }

        public Role GetRoleByName(string name)
        {
            try
            {
                string sql = $"select * from roles where lower(Role_n) = \"{name.ToLower()}\"";

                MySqlCommand com = new MySqlCommand(sql, con);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                Role role = new Role();

                using (var reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int roleId = int.Parse(reader["role_id"].ToString());
                        string roleName = reader["role_n"].ToString();

                        role.Id = roleId;
                        role.Name = roleName;
                    }
                }

                return role;

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

        public IEnumerable<string> GetUserRoles(int userId)
        {
            try
            {
                string sql = "select  rol.role_n from roles as rol join user_roles as urol on urol.role_id = rol.Role_id where urol.user_id = " + userId;
                MySqlCommand com = new MySqlCommand(sql, con);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                List<string> roles = new List<string>();

                using (var reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string roleName = reader["role_n"].ToString();
                        roles.Add(roleName);
                    }
                }

                return roles;
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

        public bool HasRole(string roleName)
        {
            try
            {
                string sql = $"select count(us.Role_id) from roles as us where us.Role_n = '{roleName}'";
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

        public void Insert(Role role)
        {
            try
            {
                string sql = $"insert into roles (Role_n) values (\"{role.RoleName}\")";
                MySqlCommand com = new MySqlCommand(sql, con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                com.ExecuteNonQuery();
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

        public bool IsInRole(string roleName, int userId)
        {
            try
            {
                string sql = $"select count(*) from user_roles as ur join roles as ro on ur.role_id = ro.Role_Id where lower(ro.role_n) = '{roleName.ToLower()}' and ur.user_id = {userId}";
                MySqlCommand com = new MySqlCommand(sql,con);
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                int result = int.Parse(com.ExecuteScalar().ToString());
                bool result_f = true;
                if (result < 1)
                {
                    result_f = false;
                }
                return result_f;
            }
            catch (Exception)
            {

                throw;
            }
            finally { 
                con.Close(); 
            }
        }
        public void AddUserToRole(int userId, int roleId)
        {
            try
            {

                string sql = $"insert into user_roles(user_id, role_id) values ({userId}, {roleId})";

                MySqlCommand com = new MySqlCommand(sql, con);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                com.ExecuteNonQuery();
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
