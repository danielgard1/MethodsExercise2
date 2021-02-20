using System;

namespace MethodsExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}");

            Console.WriteLine("give me a number to multiply");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("give me a number to multiply with the first one");
            int y = int.Parse(Console.ReadLine());

            int multiply = Multiply(x, y);
            Console.WriteLine($"The answer is: {multiply}");

            Console.WriteLine("Give me a number to subtract.");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to subtract to the previous number");
            int b = int.Parse(Console.ReadLine());

            int subtract = Subtract(a, b);
            Console.WriteLine($"The answer is: {subtract}");

            Console.WriteLine("give ma a number");
            int q = int.Parse(Console.ReadLine());

            Console.WriteLine("now give me another to to divide from the previous number");
            int w = int.Parse(Console.ReadLine());

            int divide = Divide(q, w);
            Console.WriteLine($"the answer is: {divide}");
        }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Subtract(int a, int b)
        {
            return a - b; 
        }

        public static int Divide(int q, int w)
        {
            return q / w;
        }
    }
}
