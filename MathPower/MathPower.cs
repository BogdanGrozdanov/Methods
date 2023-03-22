namespace MathPower
{
    internal class MathPower
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number");
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine("Input Power");
            int pow = int.Parse(Console.ReadLine());
            double result = Math.Pow(number, pow);
            Console.WriteLine(result);

        }
        static double RiseToPower(double number, int power)
        {
            return Math.Pow(number, power);
        }
    }
}