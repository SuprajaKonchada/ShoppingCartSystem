using Cart_Operations;
public class Program
{
    public static void Main(string[] args)
    {
        var logger = new ConsoleLogger();
        var cartStorage = new CartStorage(logger);
        var cartPrinter = new CartPrinter(logger);

        var shoppingCartService = new ShoppingCartService(logger, cartStorage, cartPrinter);

        var cart = new ShoppingCart();
        var product1 = new Product { Name = "Pen", Price = 10 };
        var product2 = new Product { Name = "Kit Kat", Price = 20 };
        var specialOfferProduct = new SpecialOfferProduct { Name = "Kurkure (Special Offer)", Price = 30, Discount = new PercentageDiscount(0.1m) };

        shoppingCartService.AddProductToCart(cart, product1);
        shoppingCartService.AddProductToCart(cart, product2);
        shoppingCartService.AddProductToCart(cart, specialOfferProduct);

        shoppingCartService.RemoveProductFromCart(cart, product2);

        shoppingCartService.PrintCart(cart);

        decimal total = cart.CalculateTotal();
        Console.WriteLine("Total: "+total);
    }
}
