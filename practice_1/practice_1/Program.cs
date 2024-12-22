using System;

namespace practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is my practice program!");

            //I am going to add variables and do basic mathematical operations with them
            int number1 = 10;
            int number2 = 20;
            int sum = number1 + number2;
            int difference = number1 - number2;


            Console.WriteLine($"The sum of number 1 and number 2 is {sum}");
            Console.WriteLine($"The difference between {number1} and {number2} is {difference}");



            Console.WriteLine("######################################");


            Console.WriteLine("Now we will do some other types of calculations");

            double radius = 5.5;
            double areaOfCircle = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"The area of a circle with radius of {radius} is equal to {areaOfCircle}");

            //now with a few if-else conditions
            if(radius > 5.6)
            {
                Console.WriteLine("The radius of the circle is quite too large, please make it small");
            }
            else
            {
                Console.WriteLine("The radius of the circle is within the acceptable range!, Good Job!");
            }
        }
    }
}