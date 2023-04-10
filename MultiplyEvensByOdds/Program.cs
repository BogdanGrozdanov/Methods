namespace MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number : ");
            int number =int.Parse(Console.ReadLine());
            GetSumOfEvenDigits(number);

        }

        private static int GetSumOfEvenDigits(int number)
        {
            var result = 0;
            int digit;
            while (number > 0) 
            {
            digit = number % 10;
                if (digit == 0) { }
            }

            

            return result;
        }
    }
}