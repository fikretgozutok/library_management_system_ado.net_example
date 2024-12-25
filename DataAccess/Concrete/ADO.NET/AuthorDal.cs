using Core.DataAccess;
using DataAccess.Concrete.ADO.NET;
using Entitites.Concrete;
using Microsoft.Data.SqlClient;

namespace DataAccess.Concrete
{
    public class AuthorDal : IRepository<Author>
    {
        private readonly Connection _connectionContext;

        public AuthorDal()
        {
            _connectionContext = Connection.Instance;
        }
        public void Add(Author entity)
        {
            using (var connection = _connectionContext.GetConnection())
            {
                string query = "INSERT INTO Authors (Name) VALUES (@Name)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", entity.Name);

                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = _connectionContext.GetConnection())
            {
                string query = "DELETE FROM Authors WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);

                command.ExecuteNonQuery();
            }
        }

        public Author? Get(int id)
        {
            using (var connection = _connectionContext.GetConnection())
            {
                string query = "SELECT * FROM Authors WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return new Author
                    {
                        Name = reader["Name"].ToString()!
                    };
                }

                return null;
            }
        }

        public IEnumerable<Author> GetAll()
        {
            using (var connection = _connectionContext.GetConnection())
            {
                string query = "SELECT * FROM Authors";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                List<Author> data = new List<Author>();

                while (reader.Read())
                {
                    data.Add(new Author { Name = reader["Name"].ToString()! });
                }

                return data;
            }
        }

        public void Update(Author entity)
        {
            using (var connection = _connectionContext.GetConnection())
            {
                string query = "UPDATE Authors SET Name = @Name";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", entity.Name);

                command.ExecuteNonQuery();
            }
        }
    }

}

