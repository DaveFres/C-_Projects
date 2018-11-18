using static System.Console;
using System;

namespace second
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            bool is_num_simple(int number)
            {
                for (int i = 2; i * i < number; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }


            int begin = 10000;

            int four_digit = begin;
            int five_digit = begin;


            while (true)
            {
                if (is_num_simple(four_digit) == false)
                {
                    four_digit -= 1;
                }
               
                if (is_num_simple(five_digit) == false)
                {
                    five_digit += 1;
                }
                if (is_num_simple(five_digit) == true && is_num_simple(four_digit) == true)
                {
                    break;
                }
            }

            WriteLine(four_digit);
            WriteLine(five_digit);
        }
    }
}
