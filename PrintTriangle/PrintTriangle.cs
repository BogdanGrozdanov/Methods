namespace PrintTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Input character");
            string ch = Console.ReadLine();
            Console.WriteLine();
            PrintTriangle(num,ch);
        }

        static void PrintLine(int start, int end, string ch)
        {
            for (int i = 1; i <= end; i++)
            {
                Console.Write($"{ch} ");
            }
            Console.WriteLine();
        }

        static void PrintTriangle(int n, string ch)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintLine(1, i, ch);
            }

            for (int i = n - 1; i >= 1; i--)
            {
                PrintLine(1, i, ch);
            }
        }

    }
}