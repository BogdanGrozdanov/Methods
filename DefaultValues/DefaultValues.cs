namespace DefaultValues
{
    internal class DefaultValues
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Input start number");
            //int start = int.Parse(Console.ReadLine());
            //Console.WriteLine("Input end number");
            //int end = int.Parse(Console.ReadLine());
            PrintNumber(start: 1, end: 10);
            Console.WriteLine();
            PrintNumber(1, 10);
            Console.WriteLine();
            PrintNumber(10);
            Console.WriteLine(  );
            PrintNumber();
        }
        static void PrintNumber(int start = 0, int end = 100)
        {
            int counter = 0;
            for (int i = start; i <= end; i++)
            {
                if (i == end)
                {
                    Console.Write($"{i}");
                }
                else
                { Console.Write($"{i}, "); }

                counter++;
            }
            Console.WriteLine();
            Console.Write($"Count of number is : {counter}");
        }

    }
}