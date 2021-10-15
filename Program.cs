using System;

namespace MethodExerciseConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hi, What is your name?");
            //string userName = Console.ReadLine();

            //Console.WriteLine($"Hi, nice to meet you, {userName}! I am going to write you a story based off of your favorite things. To get started, what is your favorite color?");
            //string favoriteColor = Console.ReadLine();

            //Console.WriteLine($"Awesome! {favoriteColor} is lovely. Now, what is your favorite animal? ");
            //string favoriteAnimal = Console.ReadLine();

            //Console.WriteLine($"Oh, wow! {favoriteAnimal} are really cool. Lastly, what is your favorite band?");
            //string favoriteBand = Console.ReadLine();


            //Console.WriteLine($"Thaks {userName}. Here is your story!");

            //Console.WriteLine($"I heard that {userName} has plans to go see their favorite cover band this weekend They are called the");
            //Console.WriteLine($"{favoriteColor}");
            //Console.WriteLine($"{favoriteAnimal}");
            //Console.WriteLine($"and they do {favoriteBand} covers!");


            //exercise 2----

            // ------------add------------
            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());


            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}");

            // -----------multiply----------------
            Console.WriteLine("Give me a number to multiply");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply to the first one");
            num2 = int.Parse(Console.ReadLine());


            int product = Multiply(num1, num2);
            Console.WriteLine($"The product is: {product}");

            // -----------subtract----------------
            Console.WriteLine("Give me a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to subtract from the first one");
            num2 = int.Parse(Console.ReadLine());


            int subtract = Subtract(num1, num2);
            Console.WriteLine($"The difference is: {subtract}");

            // -----------Divide----------------
            Console.WriteLine("Give me a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to divide from the first one");
            num2 = int.Parse(Console.ReadLine());


            int divide = Divide(num1, num2);
            Console.WriteLine($"The quotient is: {divide}");

            // -----------Modulus----------------
            Console.WriteLine("Give me a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to divide from the first one");
            num2 = int.Parse(Console.ReadLine());


            int modulus = Modulus(num1, num2);
            Console.WriteLine($"The remainder is: {modulus}");



        }
        //add
        public static int Sum(int num1, int num2)
        {

            return num1 + num2;

        }

        // multiply
        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        // subtract
        public static int Subtract(int num3, int num4)
        {
            return num3 - num4;
        }

        // divide
        public static int Divide(int num5, int num6)
        {
            return num5 / num6;
        }

        // modulus
        public static int Modulus(int num7, int num8)
        {
            return num7 % num8;
        }

    }
}
