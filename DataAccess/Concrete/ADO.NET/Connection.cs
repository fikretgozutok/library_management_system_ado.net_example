using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DataAccess.Concrete.ADO.NET
{
    public class Connection : IDisposable
    {
        private static Connection? _instance = null;
        private SqlConnection _connection;
        private static readonly object _lock = new object();
        private string _connectionString;

        private Connection()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            _connection = new SqlConnection(_connectionString);
        }

        public static Connection Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Connection();
                    }

                    return _instance;
                }
            }
        }

        public SqlConnection GetConnection()
        {
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }

            return _connection;
        }

        public void CloseConnection()
        {
            if (_connection.State != ConnectionState.Closed)
            {
                _connection.Close();
            }
        }

        public void Dispose()
        {
            if (_instance != null)
            {
                if (_connection.State != ConnectionState.Closed)
                {
                    _connection.Close();
                }

                _connection.Dispose();
            }
        }
    }
}
