using System.Data.SqlClient;

namespace WindowsFormsAppAdoNetCRUD
{
    internal class CategoryDAL : OrtakDAL
    {
        public int Add(Category category)
        {
            
            int sonuc = 0;
            ConnectionKontrol();
            var command = new SqlCommand("insert into categories (Name, Description, IsActive, CreateDate ) values  (@Name, @Description, @IsActive, @CreateDate )", _connection);
            command.Parameters.AddWithValue("@Name", category.Name); 
            command.Parameters.AddWithValue("@Description", category.Description); 
            command.Parameters.AddWithValue("@CreateDate", category.CreateDate); 
            command.Parameters.AddWithValue("@IsActive", category.IsActive);
            
            sonuc = command.ExecuteNonQuery(); // sonuc değişkenine Sql de etiklenen kayıt sayısını ata 
            command.Dispose();
            _connection.Close();
            return sonuc;
        }
    }
}
