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

        public static void PrintString(string text, int num)
        {
            string result = string.Empty;

            for (int i = 0; i < num; i++)
            {
                result += text;
            }

            Console.WriteLine(result);
        }
    }
}