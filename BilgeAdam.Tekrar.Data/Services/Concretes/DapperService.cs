using BilgeAdam.Tekrar.Data.Contracts;
using BilgeAdam.Tekrar.Data.Managers;
using BilgeAdam.Tekrar.Data.Services.Abstractions;
using Dapper;
using System.Configuration;
using System.Data.SqlClient;

namespace BilgeAdam.Tekrar.Data.Services.Concretes
{
    public class DapperService : IDbService
    {
        private readonly SqlConnection connection;
        public DapperService()
        {
            connection = ConnectionManager.GetConnection();
        }
        public bool AddNewProduct(string productName, decimal unitPrice)
        {
            var newDto = new AddNewProductDto
            {
                ProductName = productName,
                UnitPrice = unitPrice
            };
            connection.Open();
            var query = "INSERT INTO Products (ProductName, UnitPrice) VALUES (@ProductName, @UnitPrice)";
            //var result = connection.Execute(query, new { ProductName = productName, UnitPrice = unitPrice });
            var result = connection.Execute(query, newDto);
            connection.Close();
            return result > 0;
        }

        public List<CategoryViewDto> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public List<ProductViewDto> GetAllProducts()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString;
            var result = new List<ProductViewDto>();
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                result = connection.Query<ProductViewDto>("SELECT ProductName AS Name, UnitPrice AS Price FROM Products").ToList();
            }
            return result;
        }
    }
}
