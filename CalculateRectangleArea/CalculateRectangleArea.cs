namespace CalculateRectangleArea
{
    internal class CalculateRectangleArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("width");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("height");
            double height = double.Parse(Console.ReadLine());
            double area = GetRectangleArea(width, height);
            Console.WriteLine(area);
        }

        static double GetRectangleArea(double width, double height)
        {
            return width * height;
        }
    }
}