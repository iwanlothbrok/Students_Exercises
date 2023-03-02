//using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

//namespace OnlineShopCourseWork.Services.Images
//{
//    public class ImagesService
//    {
//        / Set up connection string and SQL query
//        string connectionString = "Data Source=myServerAddress;Initial Catalog=myDatabase;User ID=myUsername;Password=myPassword";
//        string query = "INSERT INTO Images (Bytes, ImageName) VALUES (@Bytes, @ImageName)";

//        // Create connection and command objects
//        using (SqlConnection connection = new SqlConnection(connectionString))
//        using (SqlCommand command = new SqlCommand(query, connection))
//        {
//            // Set parameter values for each image
//            byte[] image1Bytes = GetImageBytes("image1.jpg");
//    byte[] image2Bytes = GetImageBytes("image2.png");
//    byte[] image3Bytes = GetImageBytes("image3.gif");
//    command.Parameters.AddWithValue("@Bytes", image1Bytes);
//            command.Parameters.AddWithValue("@ImageName", "image1.jpg");
//            command.Parameters.AddWithValue("@Bytes", image2Bytes);
//            command.Parameters.AddWithValue("@ImageName", "image2.png");
//            command.Parameters.AddWithValue("@Bytes", image3Bytes);
//            command.Parameters.AddWithValue("@ImageName", "image3.gif");

//            // Open connection and execute command
//            connection.Open();
//            command.ExecuteNonQuery();
//        }

//Console.WriteLine("Images inserted successfully.");
//Console.ReadKey();
//    }

//    static byte[] GetImageBytes(string filename)
//{
//    // Load image file as byte array
//    // This is just an example method and implementation details may vary
//    byte[] bytes = new byte[] { 0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xEF };
//    return bytes;
//}
//    }
//}
