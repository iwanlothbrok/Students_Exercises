namespace OnlineShopCourseWork.Services.Categories
{
    using MySql.Data.MySqlClient;
    public class CategoryService : ICategoryService
    {
        private readonly MySqlConnection con;

        public CategoryService(MySqlConnection con)
        {
            this.con = con;
        }

        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        {
        //            connection.Open();

        //            // Insert category 1
        //            string insertQuery1 = "INSERT INTO Category (name) VALUES (@name)";
        //SqlCommand command1 = new SqlCommand(insertQuery1, connection);
        //command1.Parameters.AddWithValue("@name", "Category 1");
        //            command1.ExecuteNonQuery();

        //            // Insert category 2
        //            string insertQuery2 = "INSERT INTO Category (name) VALUES (@name)";
        //SqlCommand command2 = new SqlCommand(insertQuery2, connection);
        //command2.Parameters.AddWithValue("@name", "Category 2");
        //            command2.ExecuteNonQuery();

        //            // Insert category 3
        //            string insertQuery3 = "INSERT INTO Category (name) VALUES (@name)";
        //SqlCommand command3 = new SqlCommand(insertQuery3, connection);
        //command3.Parameters.AddWithValue("@name", "Category 3");
        //            command3.ExecuteNonQuery();
        //        }
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
            string checkCmd = $"SELECT * FROM Categories WHERE Name = {name == null: return -1 ? name}";

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

        //the other type
        //public int CheckName(string name)
        //{
        //    int result = -1;
        //    using (con)
        //    {
        //        con.Open();
        //        string commandText = "SELECT Name FROM Category";

        //        using (MySqlCommand command = new MySqlCommand(commandText, con))
        //        {
        //            using (MySqlDataReader reader = command.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    string categoryName = reader.GetString(0);
        //                    if (categoryName.Equals(name, StringComparison.OrdinalIgnoreCase))
        //                    {
        //                        result = 1;
        //                        break;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    return result;
        //}
    }
}


