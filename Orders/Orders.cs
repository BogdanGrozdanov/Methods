namespace Orders
{
    internal class Orders
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input : coffe,water,coke or snacks");
            string order = Console.ReadLine().ToLower();
            Console.WriteLine("Quantity :");
            double quantity = int.Parse(Console.ReadLine());

            if (order == "coffee") { Console.WriteLine(Coffee(quantity)); ; }



        }
       static private double Coffee(double quantity)
        {
            double totalPrice = quantity * 1.5;
            return totalPrice;
        }
        static void Water(int quantity)
        {
            double totalPrice = quantity * 1.00;
            Console.WriteLine(quantity);
        }
        static void Coke(int quantity)
        {
            double totalPrice = quantity * 1.40;
            Console.WriteLine(quantity);
        }
        static void Snacks(int quantity)
        {
            double totalPrice = quantity * 2.00;
            Console.WriteLine(quantity);
        }
    }
}