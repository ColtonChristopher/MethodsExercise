using Internal;

namespace MethodsExercise
{
    public class Program
    {
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2
        }

        public static int Sub(int num1, int num2)
        {
            return num1 - num2
        }

        public static int Divide(int num1, int num2)
        {
            return num1/num2
        }

        public static int Modulus(int num1, int num2)
        {
            return num1 % num2 
        }

        static void Main(string[] args)
        {

            var amountOfCars = Sum(3, 7);
            var amountOfGroups = Multiply(5, 7)
            var amountOfCakes = Sub(10, 3)
            var amountOfSomething = Divide(9, 3)
            var amountOfSomething = Modulus(100, 9)

            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("Hi {userName}. What is your favorite color?")
                var color = Console.ReadLine();

            Console.WriteLine("{color} is an awsome color! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Great! Now what is your favorite band?");
            var band = Console.ReadLine();

           Console.WriteLine($"Hello my name is {userName}, I always thought it would be funny to see my favorite animal a {animal} as my favorite color {color} walking along on two legs listening to my favorite band {band}.")

        }
    }
}
