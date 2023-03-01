using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using OnlineShopCourseWork.InputModels.Products;

namespace OnlineShopCourseWork.Services.Products
{
    public class ProductService : IProductService
    {
        private readonly MySqlConnection con;

        public ProductService(MySqlConnection con)
        {
            this.con = con;
        }
        public int Create(ProductsInputModel model)
        {
            
            string cmd = $"INSERT INTO Products(ImageId,ProductName,Price,CategoryId) VALUES(@ImageId,@ProductName,@Price,{model.CategoryId}))";

            
            MySqlCommand com = new MySqlCommand(cmd, con);
            com.Parameters.AddWithValue("@ImageId", model.ImageId);
            com.Parameters.AddWithValue("@ProductName", model.ProductName);
            com.Parameters.AddWithValue("@Price", model.Price);

            // Creating Image AND Category

            //com.Parameters.AddWithValue("@Price", model);
            // naprawi gi po syshtiqt naching !!!
            try
            {
                con.Open();

                com.ExecuteNonQuery();

            }
            catch(Exception ex)
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
    }
}
//public int CheckName(string name)
//{
//    int result = -1;
//    using (SqlConnection connection = new SqlConnection(connectionString))
//    {
//        connection.Open();
//        string commandText = "SELECT Name FROM Category";
//        using (SqlCommand command = new SqlCommand(commandText, connection))
//        {
//            using (SqlDataReader reader = command.ExecuteReader())
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