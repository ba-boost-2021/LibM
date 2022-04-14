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

        public List<CategoryViewDto> GetAllCategories()
        {
            var categories = new List<CategoryViewDto>();
            var connectionString = "Server=.;Database=Northwind;User Id=sa;Password=123";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var query = "SELECT CategoryName, Description FROM Categories";
                var command = new SqlCommand(query, connection);

                var reader = command.ExecuteReader();
                categories = GetData<CategoryViewDto>(reader, reader => new CategoryViewDto
                {
                    Name = reader["CategoryName"].ToString(),
                    Description = reader.GetString(1)
                }).ToList();
            }
            return categories;
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
                products = GetData<ProductViewDto>(reader, reader => new ProductViewDto
                {
                    Name = reader["CategoryName"].ToString(),
                    Price = reader.GetDecimal(1)
                }).ToList();
            }
            return products;
        }
        private IEnumerable<TResult> GetData<TResult>(SqlDataReader reader, Func<SqlDataReader, TResult> mapFunc)
        {
            while (reader.Read())
            {
                yield return mapFunc(reader);
            }
        }


        /*
        public ProductViewDto mapFunc(SqlDataReader reader){
            return new ProductViewDto
                {
                    Name = reader["CategoryName"].ToString(),
                    Price = reader.GetDecimal(1)
                }

        }
         
         
         */
    }
}