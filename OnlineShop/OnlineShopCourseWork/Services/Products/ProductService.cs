using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using OnlineShopCourseWork.InputModels.Products;
using OnlineShopCourseWork.Services.Categories;

namespace OnlineShopCourseWork.Services.Products
{
    public class ProductService : IProductService
    {
        private readonly MySqlConnection con;
        private readonly ICategoryService categoryService;

        public ProductService(MySqlConnection con, ICategoryService categoryService)
        {
            this.categoryService = categoryService;
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
            //this.categoryService.IsAvailable(model.)
            //com.Parameters.AddWithValue("@Price", model);
            // naprawi gi po syshtiqt naching !!!
            try
            {
                con.Open();

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
    }
}