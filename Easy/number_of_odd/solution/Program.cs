using static System.Console;
using System;

namespace solution
{
    class MainClass
    {
        static int number_of_odd(int number)
        {
            int counter = 0;
          
            while (number != 0)
            {
                if ((number % 10) % 2 != 0)
                {
                    counter += 1;
                }
                number /= 10;
            }
            return counter;
        }

        public static void Main(string[] args)
        {

            int int_number = int.Parse(ReadLine());

            Write(number_of_odd(int_number));

            ReadKey();
        }
    }
}
