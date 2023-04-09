namespace GreaterOfTwoValues
{
    internal class GreaterOfTwoValues
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input type value:");
            string typeValue = Console.ReadLine().ToLower();

            Console.WriteLine("First value:");
            string value1 = Console.ReadLine().ToLower();

            Console.WriteLine("Second value:");
            string value2 = Console.ReadLine().ToLower();

            Console.WriteLine("The greater value is:");
        }

        internal static string GetMax(string typeValue, string value1, string value2)
        {
            string result = string.Empty;
            if (typeValue == "int")
            {
                int firstValue = int.Parse(value1);
                int secondValue = int.Parse(value2);
                result = (Math.Max(firstValue, secondValue)).ToString();
            }
            else if (typeValue == "char")
            {
               
                char firstChar = char.Parse(value1);
                char secondChar = char.Parse(value2);
                if ( firstChar > secondChar ) { result = firstChar.ToString(); }
                else { result = secondChar.ToString(); }
            }
            return result;
        }
    }
}