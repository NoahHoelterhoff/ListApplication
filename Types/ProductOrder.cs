namespace ListApplication.Types
{
    public class ProductOrder(Product product, int quantity)
    {
        public Product Product { get; set; } = product;
        public double Price => Product.Price;
        public int Quantity { get; set; } = quantity;
    }
}
