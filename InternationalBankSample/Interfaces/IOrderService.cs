namespace InternationalBankSample.Interfaces
{
    public interface IOrderService
    {
        public string PlaceOrder(int productId);

        public string GetOrder(int orderId);
    }
}
