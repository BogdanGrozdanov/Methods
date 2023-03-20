namespace DayOfWeek
{
    internal class DayOfWeek
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate");
            Console.Write("First num :");
            double firstNum = double.Parse(Console.ReadLine());
            Console.Write("Input second num :");
            double secondNum = double.Parse(Console.ReadLine());
            double result = firstNum + secondNum;
            Console.WriteLine($"Result is :{result}");
            //Console.Write("Input number of week :");
            //int dayOfWeekNum = int.Parse(Console.ReadLine());
            //DayOfWeekk(dayOfWeekNum);
        }

        static void DayOfWeekk(int number)
        {
            switch (number)
            {
                case 1:
                    number = 1;
                    Console.WriteLine("Monday");
                    break;
                    case 2:
                    number = 2;
                    Console.WriteLine("Tuesday");
                    break;

            }
            //if (number == 1) { Console.WriteLine("Monday"); }
            //else if (number == 2) { Console.WriteLine("Tuesday"); }
            //else if (number == 3) { Console.WriteLine( "Wednesday" ); }
        }
    }
}