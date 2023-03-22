
namespace Orders
{
    internal class Orders
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input : coffe,water,coke or snacks");
            string order = Console.ReadLine().ToLower();
            Console.WriteLine("Quantity :");
            double quantity = double.Parse(Console.ReadLine());

            if (order == "coffee") { Coffee(quantity); }
            else if (order == "water") { Water(quantity); }
            else if (order == "coke") { Coke(quantity); }
            else if (order == "snacks") { Snacks(quantity); }


        }
        static void Coffee(double quantity)
        {
            double totalPrice = quantity * 1.5;
            Console.WriteLine($"{totalPrice:F2}");
        }
        static void Water(double quantity)
        {
            double totalPrice = quantity * 1.00;
            Console.WriteLine($"{totalPrice:F2}");
        }
        static void Coke(double quantity)
        {
            double totalPrice = quantity * 1.40;
            Console.WriteLine($"{totalPrice:F2}");
        }
        static void Snacks(double quantity)
        {
            double totalPrice = quantity * 2.00;
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}