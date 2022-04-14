namespace BilgeAdam.Tekrar.Data.Contracts
{
    public class ProductViewDto
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }
    }
    public class CategoryViewDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public class AddNewProductDto
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }
}