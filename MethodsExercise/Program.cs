using System.Reflection.Metadata.Ecma335;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int sum = Add(5, 5);
            Console.WriteLine($"Sum is {sum}");

            int cal = Sub(20, 5);
            Console.WriteLine($"cal is {cal}");

            int multiplied = Mul(5, 10);
            Console.WriteLine($"Mul is {multiplied}");

            int divisible = Div(100, 20);
            Console.WriteLine($"div is {divisible}");

            int modulus = Mod(10, 2);
            Console.WriteLine($"mod is {modulus}");
            
        }

        
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Sub(int x, int y)
        {
           return x - y;
        }
    
        public static int Mul(int x, int y)
        {
             return x * y;
        }
        
        public static int Div(int x, int y)
        {
             return x / y;
        }
        
        public static int Mod(int x, int y)
        {
             return x % y;
        
        
        }
    }
}
