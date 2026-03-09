using System.Data.SqlClient;

namespace WindowsFormsAppAdoNetCRUD
{
    internal class KullanicidAL : OrtakDAL
    {
        public int Add(User user)
        {

            int sonuc = 0;
            ConnectionKontrol();
            var command = new SqlCommand("insert into Users (Name, Email, IsActive, CreateDate, Surname, Password ) values  (@Name, @Email, @IsActive, @CreateDate, @Surname, @Password )", _connection);
            command.Parameters.AddWithValue("@Name", user.Name);
            command.Parameters.AddWithValue("@Email", user.Email);
            command.Parameters.AddWithValue("@CreateDate", user.CreateDate);
            command.Parameters.AddWithValue("@IsActive", user.IsActive);
            command.Parameters.AddWithValue("@Surname", user.Surname);
            command.Parameters.AddWithValue("@Password", user.Password);

            sonuc = command.ExecuteNonQuery(); // sonuc değişkenine Sql de etiklenen kayıt sayısını ata 
            command.Dispose();
            _connection.Close();
            return sonuc;
        }
        public int Update(User user)
        {

            int sonuc = 0;
            ConnectionKontrol();
            var command = new SqlCommand("update users set Name=@Name, Surname=@Surname, IsActive=@IsActive, CreateDate=@CreateDate, Password=@Password, Email=@Email where Id=@Id ", _connection);
            command.Parameters.AddWithValue("@Id", user.Id);
            command.Parameters.AddWithValue("@Name", user.Name);
            command.Parameters.AddWithValue("@Email", user.Email);
            command.Parameters.AddWithValue("@CreateDate", user.CreateDate);
            command.Parameters.AddWithValue("@IsActive", user.IsActive);
            command.Parameters.AddWithValue("@Surname", user.Surname);
            command.Parameters.AddWithValue("@Password", user.Password);

            sonuc = command.ExecuteNonQuery(); // sonuc değişkenine Sql de etiklenen kayıt sayısını ata 
            command.Dispose();
            _connection.Close();
            return sonuc;
        }
        public int Delete(User user)
        {

            int sonuc = 0;
            ConnectionKontrol();
            var command = new SqlCommand("Delete from users where Id=@Id", _connection);
            command.Parameters.AddWithValue("@Id", user.Id);
            sonuc = command.ExecuteNonQuery(); // sonuc değişkenine Sql de etiklenen kayıt sayısını ata 
            command.Dispose();
            _connection.Close();
            return sonuc;
        }
    }
}
