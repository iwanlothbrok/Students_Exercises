using MySql.Data.MySqlClient;
using System.Drawing;

namespace OnlineShopCourseWork.Services.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly MySqlConnection con;

        public CategoryService(MySqlConnection con)
        {
            this.con = con;
        }
        public int Create(string name)
        {
            if (name == null || name.Length < 3)
            {
                return -1;
            }

            string cmd = $"INSERT INTO Categories(CategoryName) VALUES(@CategoryName))";


            MySqlCommand com = new MySqlCommand(cmd, con);
            com.Parameters.AddWithValue("@CategoryName", name);
            //naprawi gi po syshtiqt naching!!!
            try
            {
                con.Open();

                //because its not returni any value and is UPDATE METHOD 
                com.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return 0;
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return 1;
        }
        public int IsAvailable(string name)
        {
            //CHECK IF CATEGORY EXIST 
            // command for getting if there is something like this 
            string checkCmd = $"SELECT * FROM Categories WHERE Name = {name == null : return -1 ? name}";

            //creating my sql command 
            MySqlCommand comForCheck = new MySqlCommand(checkCmd, con);

            // if there is result create it 
            //else return -1; and do not 
            int res;
            try
            {
                con.Open();
                //RETRUNING VALUE
                var obj = comForCheck.ExecuteScalar();


                if (obj is null)
                {
                    return -1;
                }

                res = Convert.ToInt32(obj);

            }
            catch (Exception ex)
            {
                return -1;
                throw ex;
            }
            finally
            {
                con.Close();
            }


            return res;
        }
    }
}

