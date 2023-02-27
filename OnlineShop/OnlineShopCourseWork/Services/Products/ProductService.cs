using MySql.Data.MySqlClient;
using OnlineShopCourseWork.InputModels;

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
            string cmd = $"INSERT INTO Products(ImageId,ProductName,Price,CategoryId) VALUES({model.ImageId},'{model.ProductName}',{model.Price},{model.CategoryId}))";

           
            MySqlCommand com = new MySqlCommand(cmd, con);
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
