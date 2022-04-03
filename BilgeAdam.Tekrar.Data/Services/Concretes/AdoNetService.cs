using BilgeAdam.Tekrar.Data.Contracts;
using BilgeAdam.Tekrar.Data.Managers;
using BilgeAdam.Tekrar.Data.Services.Abstractions;
using System.Data.SqlClient;

namespace BilgeAdam.Tekrar.Data.Services.Concretes
{
    public class AdoNetService : IDbService
    {
        private SqlConnection connection;
        public AdoNetService()
        {
            connection = ConnectionManager.GetConnection();
        }
        public bool AddNewProduct(string productName, decimal unitPrice)
        {
            //connection.Open();
            //var query = $@"INSERT INTO Products (ProductName, UnitPrice) 
            //                        VALUES ('{productName}',{unitPrice})";
            //var command = new SqlCommand(query, connection);
            //var result = command.ExecuteNonQuery();
            //connection.Close();

            connection.Open();
            var query = $@"INSERT INTO Products (ProductName, UnitPrice) 
                                    VALUES (@ProductName,@UnitPrice)";
            var command = new SqlCommand(query, connection);
            command.Parameters.AddRange(new SqlParameter[]
            {
                new SqlParameter("ProductName", productName),
                new SqlParameter("UnitPrice", unitPrice)
            });
            var result = command.ExecuteNonQuery();
            connection.Close();
            return result > 0;
        }

        public List<ProductViewDto> GetAllProducts()
        {
            var products = new List<ProductViewDto>();
            var connectionString = "Server=.;Database=Northwind;User Id=sa;Password=123";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var query = "SELECT ProductName, UnitPrice FROM Products";
                var command = new SqlCommand(query, connection);

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    products.Add(new ProductViewDto
                    {
                        Name = reader["ProductName"].ToString(),
                        Price = reader.GetDecimal(1)
                    });
                    //reader.GetString(0)
                    //reader.GetDecimal(1)
                    //reader[0].ToString();
                    //var a = (decimal)reader[1];
                }
            }
            return products;

        }
    }
}