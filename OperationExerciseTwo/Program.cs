using System;

namespace OperationExerciseTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            var mul = a * b;
            var div = a / b;
            var mod = a % b;
            var add = a + b;
            var sub = a - b;

            // OperatorExercise #1

            Console.WriteLine($"{a}*{b} is {mul}");
            Console.WriteLine($"{a}/{b} is {div} remainder {mod}");
            Console.WriteLine($"{a}-{b} is {sub}");
            Console.WriteLine($"{a}+{b} is {add}");

        }
    }
}
