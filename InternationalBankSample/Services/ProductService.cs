
using InternationalBankSample.Interfaces;

namespace InternationalBankSample.Services
{
    public class ProductService : IProductService
    {
        public string GetProductDetails(int productId)
        {
           
              return $"Product details for product ID {productId}.";
          
        }
    }
}
