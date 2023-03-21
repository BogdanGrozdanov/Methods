namespace Calculations
{
    internal class Calculations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input operation(add,multiplay,substract or divide)");
            string operation = Console.ReadLine().ToLower();
            Console.WriteLine("First number");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Second number");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Result:");

            if (operation == "add") { Add(firstNumber, secondNumber); }
            else if (operation == "multiplay") { Multiply(firstNumber, secondNumber); }
            else if (operation == "substract") { Substract(firstNumber, secondNumber); }
            else if (operation == "divide") { Divide(firstNumber, secondNumber); }
        }
        static void Add(double firstNumber, double secondNumber)
        {
            double result = firstNumber + secondNumber;
            Console.WriteLine(result);
        }
        static void Multiply(double firstNumber, double secondNumber)
        {
            double result = firstNumber * secondNumber;
            Console.WriteLine(result);
        }
        static void Substract(double firstNumber, double secondNumber)
        {
            double result = firstNumber - secondNumber;
            Console.WriteLine(result);
        }
        static void Divide(double firstNumber, double secondNumber)
        {
            double result = firstNumber / secondNumber;
            Console.WriteLine(result);
        }
    }
}