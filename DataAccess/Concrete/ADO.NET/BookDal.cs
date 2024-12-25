using DataAccess.Abstract;
using DataAccess.Concrete.ADO.NET;
using Entitites.Concrete;
using Microsoft.Data.SqlClient;
using System.Data;

public partial class BookDal : IRepository<Book>
{
    private Connection _connectionContext;

    public BookDal()
    {
        _connectionContext = Connection.Instance;
    }

    public void Add(Book entity)
    {
        using (var connection = _connectionContext.GetConnection())
        {
            string query = "INSERT INTO Books (AuthorID, Title, PublishedDate) VALUES (@AuthorID, @Title, @PublishedDate)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AuthorID", entity.AuthorID);
            command.Parameters.AddWithValue("@Title", entity.Title);
            command.Parameters.Add("@PublishedDate", SqlDbType.DateTime).Value = entity.PublishedDate;

            command.ExecuteNonQuery();
        }
    }

    public void Delete(int id)
    {
        using (var connection = _connectionContext.GetConnection())
        {
            string query = "DELETE FROM Books WHERE ID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", id);

            command.ExecuteNonQuery();
        }
    }

    public Book? Get(int id)
    {
        using (var connection = _connectionContext.GetConnection())
        {
            string query = "SELECT * FROM Books WHERE ID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", id);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                return new Book
                {
                    Id = Convert.ToInt32(reader["ID"]),
                    AuthorID = Convert.ToInt32(reader["AuthorID"]),
                    Title = reader["Title"].ToString()!,
                    PublishedDate = reader.GetDateTime(reader.GetOrdinal("PublishedDate"))
                };
            }
            return null; // Kayıt bulunamazsa null döndürülür
        }
    }

    public IEnumerable<Book> GetAll()
    {
        using (var connection = _connectionContext.GetConnection())
        {
            string query = "SELECT * FROM Books";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Book> data = new List<Book>();

            while (reader.Read())
            {
                data.Add(new Book
                {
                    Id = Convert.ToInt32(reader["ID"]),
                    AuthorID = Convert.ToInt32(reader["AuthorID"]),
                    Title = reader["Title"].ToString()!,
                    PublishedDate = reader.GetDateTime(reader.GetOrdinal("PublishedDate"))
                });
            }

            return data;
        }
    }

    public void Update(Book entity)
    {
        using (var connection = _connectionContext.GetConnection())
        {
            string query = "UPDATE Books SET AuthorID = @AuthorID, Title = @Title, PublishedDate = @PublishedDate WHERE ID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", entity.Id);
            command.Parameters.AddWithValue("@AuthorID", entity.AuthorID);
            command.Parameters.AddWithValue("@Title", entity.Title);
            command.Parameters.Add("@PublishedDate", SqlDbType.DateTime).Value = entity.PublishedDate;

            command.ExecuteNonQuery();
        }
    }
}
