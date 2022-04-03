using BilgeAdam.Tekrar.Data.Contracts;
using BilgeAdam.Tekrar.Data.DataAccess;
using BilgeAdam.Tekrar.Data.DataAccess.Entities;
using BilgeAdam.Tekrar.Data.Services.Abstractions;

namespace BilgeAdam.Tekrar.Data.Services.Concretes
{
    public class EFService : IDbService
    {
        private readonly NorthwindDbContext context;

        public EFService()
        {
            context = new NorthwindDbContext();
        }

        public bool AddNewProduct(string productName, decimal unitPrice)
        {
            context.Products.Add(new Product
            {
                ProductName = productName,
                UnitPrice = unitPrice
            });
            var result = context.SaveChanges();
            return result > 0;
        }

        public List<ProductViewDto> GetAllProducts()
        {
            //var products = new List<Product>();
            //products.Select(x => new ProductViewDto
            //{
            //    Name = x.ProductName,
            //    Price = x.UnitPrice
            //}).ToList();
            return context.Products.Select(x => new ProductViewDto
            {
                Name = x.ProductName,
                Price = x.UnitPrice
            }).AsEnumerable().ToList();
        }
    }
}