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

            Console.Write("The greater value is: ");
            var result = GetMax(typeValue, value1, value2);
            Console.WriteLine(result);
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
                var firstChar = Char.GetNumericValue(char.Parse(value1));
                var secondChar = Char.GetNumericValue(char.Parse(value2));
                if (firstChar > secondChar) { result = value1; }
                else { result = value2; }
            }
            else if (typeValue == "string")
            {
                var firstString = value1.Length;
                var secondString = value2.Length;
                if (firstString > secondString) {  result = value1; } else {  result = value2; }
            }
            return result;
        }
    }
}