using week3homework;

public class Program
{
    public static void Main()
    {
        ShoppingCart cart = new ShoppingCart();

        cart.Add(new CartItem()
        {
            CartId = 1,
            Product = new Product()
            {
                ProductId = 0,
                ProductName = "Pro01",
                Price = 50
            },
            Quantity = 5
        });

        cart.Add(new CartItem()
        {
            CartId = 2,
            Product = new Product()
            {
                ProductId = 1,
                ProductName = "Pro02",
                Price = 70
            },
            Quantity = 14
        });

        cart.Add(new CartItem()
        {
            CartId = 3,
            Product = new Product()
            {
                ProductId = 2,
                ProductName = "Pro03",
                Price = 100
            },
            Quantity = 19
        });

        var list = cart.GetList();
        foreach (var item in list)
            Console.WriteLine($"{item.CartId} " +
                $"{item.Product.ProductName} " +
                $"{item.Product.Price} " +
                $"{item.Quantity}");

        Console.WriteLine(cart.GetBalance(0));

        Console.WriteLine(cart.Remove(1).Product.ProductName + " " + "removed");

        list = cart.GetList();

        foreach (var item in list)
            Console.WriteLine($"{item.CartId} " +
                $"{item.Product.ProductName} " +
                $"{item.Product.Price} " +
                $"{item.Quantity}");
    }
}