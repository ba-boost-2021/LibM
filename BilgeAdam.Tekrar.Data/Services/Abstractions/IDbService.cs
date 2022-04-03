using BilgeAdam.Tekrar.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Tekrar.Data.Services.Abstractions
{
    public interface IDbService
    {
        List<ProductViewDto> GetAllProducts();
        bool AddNewProduct(string productName, decimal unitPrice);
    }
}
