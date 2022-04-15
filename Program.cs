using System;

namespace Lab4Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            bool lessThan100(int num1, int num2)
            {
                int result = num1 + num2;
                if (result < 100)
                {
                    return true;
                }
                return false;
            }

            bool result1 = lessThan100(12,134); //You can change these parameters to check numbers whose sum are less than 100
            Console.WriteLine(result1);

            bool result2 = lessThan100(12,14); //You can change these parameters to check numbers whose sum are less than 100
            Console.WriteLine(result2);
        }
    }
}
