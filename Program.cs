using System;

namespace IntroToSyntax
{
    class Program
    {
        // X types
        // X varibles
        // X null
        // X loops
        // X if
        // x functions 
        // X math 
        // x naming conventions
        // I/O terminal
        // x basic conversion


        // accessModifier [static] returnType Name(parms...)
        public static int Sum(int x, int y)
        {
            return x + y;
        }
        public static double Sum(double x, double y){
            return x + y;
        }

        public static double Sum(int x, int y, int z)
        {
            return Sum(x, y) + z;
        }

        public static int Subtract(int x, int y) => x - y;

        public static void ReturnNothing(string messsage)
        {
                Sum(2,2.3);
        }

        public static void RunSum()
        {
            Console.WriteLine($"lets add 3 and 5 {Sum(3, 5)}");
        }

        static void Main(string[] args)
        {
            // let x = 7 
            // let name = "Bob"
            // name = 45;

            // Primitives
            // int, decimal, float, double, boolean, char

            int x = 45;
            x = 12;
            //x = "Sally";
            var number = "5";

            number = "try this";

            var countOfStudents = 6;

            // non-primitive types
            // string, classes, enums
            var currentCohort = 8;
            // string interpotlation 
            var className = $".NET Cohort {currentCohort}";
            Console.WriteLine(className);

            // null 
            // undefined, null
            string nextCohort = null;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            while (x < 45)
            {
                x++;
            }

            var cat = "cat";
            var dog = 10; // number of dogs

            if (cat == dog.ToString())
            {
                Console.WriteLine("Yup");
            }

            // type conversion
            // primitives
            var asInt = int.Parse("5");
            var asDouble = double.Parse("3.4");
            var asString = asInt.ToString();

            var a = 5;
            var b = 2.3;
            var div = a / b;

            var input = Console.ReadLine();

            Console.WriteLine($"You inputted: {input}");
        }
    }
}
