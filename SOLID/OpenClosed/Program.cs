public class Program
{
    public static void Main(string[] args)
    {
        /*
         * Bir nesne gelişime AÇIK, değişime KAPALI olmalıdır.
         * 
         * Varolan bir nesneye yeni bir özellik eklemek istiyorsunuz. 
         */
        Customer customer = new Customer() { Name = "Türkay", Cart = new Premium() };
        OrderManager orderManager = new OrderManager { Customer = customer };
        Console.WriteLine(orderManager.GetTotalPrice(100));
    }

}

public abstract class CartType
{
    public abstract decimal DiscountedPrice(decimal price);
    
}

public class Standard : CartType
{
    public override decimal DiscountedPrice(decimal price)
    {
        return price * 0.95M; 
    }
}

public class Silver : CartType
{
    public override decimal DiscountedPrice(decimal price)
    {
        return price * 0.90M;

    }
}

public class Gold : CartType
{
    public override decimal DiscountedPrice(decimal price)
    {
        return price * 0.85M;

    }
}

public class Premium : CartType
{
    public override decimal DiscountedPrice(decimal price)
    {
        return price * .80M;
    }
}

public class Customer
{
    public string Name { get; set; }
    public CartType Cart { get; set; }
}

public class OrderManager
{
    public Customer Customer { get; set; }
    public decimal GetTotalPrice(decimal price)
    {
        //decimal result = 0;
        //switch (Customer.Cart)
        //{
        //    case CartType.Silver:
        //        result = price * 0.9m;
        //        break;
        //    case CartType.Gold:
        //        result = price * 0.85m;
        //        break;
        //    case CartType.Standard:
        //        result = price * 0.95m;
        //        break;
        //    case CartType.Premium:
        //        result = price * .80M;
        //        break;
        //    default:
        //        result = price;
        //        break;
        //}
        return Customer.Cart.DiscountedPrice(price);

    }

}



