namespace Cart_Operations
{
    public class ShoppingCartService
    {
        private readonly ILogger _logger;
        private readonly ICartStorage _cartStorage;
        private readonly ICartPrinter _cartPrinter;

        public ShoppingCartService(ILogger logger, ICartStorage cartStorage, ICartPrinter cartPrinter)
        {
            _logger = logger;
            _cartStorage = cartStorage;
            _cartPrinter = cartPrinter;
        }

        public void AddProductToCart(ShoppingCart cart, Product product)
        {
            cart.AddProduct(product);
            _cartStorage.SaveCart(cart);
            _logger.Log("Product added to the cart.");
        }

        public void RemoveProductFromCart(ShoppingCart cart, Product product)
        {
            cart.RemoveProduct(product);
            _cartStorage.SaveCart(cart);
            _logger.Log("Product removed from the cart.");
        }

        public void PrintCart(ShoppingCart cart)
        {
            _cartPrinter.PrintCart(cart);
        }
    }
}
