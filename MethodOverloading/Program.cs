namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Add(3, 4));
            Console.WriteLine(Add(3.00m, 3.00m));
            Console.WriteLine(Add(1, 4, true));
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
        public static string Add(int a, int b, bool equals)
        {
            var sum = a + b;
            if (equals == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (equals == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return $"{sum}";
            }
        }
    }
}
