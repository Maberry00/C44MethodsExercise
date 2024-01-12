using System.Reflection.Metadata.Ecma335;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine(); // input

            Console.WriteLine("What is your favorite color?");
            var color = Console.ReadLine(); // input 

            Console.WriteLine("What is your favorite animal?");
            var animal = Console.ReadLine(); // input

            Console.WriteLine("What band do you like listening to?");
            var band = Console.ReadLine(); // input

            Console.WriteLine($"The big guy named {name} is a very interesting person." +
                $" He loves the color {color} and his favorite band is {band} that's a crazy coincidence." +
                $" His favorite animal is a {animal} I guess because they sometimes live in pastors which are also green.");

        }
    }
}
