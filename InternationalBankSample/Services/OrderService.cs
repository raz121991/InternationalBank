using InternationalBankSample.Interfaces;

namespace InternationalBankSample.Services
{
    public class OrderService : IOrderService
    {
        private readonly IProductService _productService;

        
        public OrderService(IProductService productService)
        {
            _productService = productService;
        }

        public string GetOrder(int orderId)
        {

            return "You got order number: " + orderId;
        }

        public string PlaceOrder(int productId)
        {
            
            var productDetails =  _productService.GetProductDetails(productId);

            if(productDetails == null) return string.Empty;

            return productDetails;
            
        }
    }
}
