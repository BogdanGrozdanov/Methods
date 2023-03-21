using System.Text;

namespace RepeatString
{
    internal class RepeatString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input text");
            string text = Console.ReadLine();
            Console.WriteLine("Input number repeat");
            int num = int.Parse(Console.ReadLine());

            PrintString(text, num);
        }

        private static string PrintString(string text, int num)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < num; i++)
            {
                result.Append(text);
            }

            return result.ToString(); 
        }
    }
}