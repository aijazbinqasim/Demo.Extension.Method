namespace Demo.Extension.Method.ExtensionMethods
{
    public static class HelperExtensions
    {
        public static double Sum(this int value1, int value2)
        {
            return value1 + value2;
        }


        public static string Concat(this string str1, string str2)
        {
            return $"{str1} - {str2}";
        }


        public static void Print(this Action<int> action, int val)
        {
            action(val);
        }


        public static void ValidateAndExecute(this Action<int> action, int val, Func<int, bool> validator)
        {
            if (validator(val))
            {
                action(val);
            }
            else
            {
                Console.WriteLine($"Validation failed for value: {val}");
            }
        }
    }
}
