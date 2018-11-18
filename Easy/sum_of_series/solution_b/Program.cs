using System;
using static System.Console;
using static System.Math;

namespace solution_b
{
    class MainClass
    {
        static void summ(double sum, double epsilon)
        {
            int pow_of_one = -1;
            int n = 1;
            double dem = 8;//Pow(2, (2 * n + 1))
           
            while (Abs(sum - Atan(0.5)) > epsilon)
            {
                
                sum += pow_of_one / ((2 * n + 1) * dem);
                n ++;
                dem *= 4;
                pow_of_one *= -1;
           
            }
            WriteLine("Сумма равна {0}", sum);
            WriteLine("Количество интераций с точностью eps={0} равно {1}", Pow(10, -2), n -1);
            //WriteLine(Atan(0.5));
        }

        static void Main()
        {

            double initial_sum = 0.5;
            double eps = Pow(10, -2);
            //double eps = Pow(10, -4);

            summ(initial_sum, eps);

                        
            ReadKey();
        }
    }
}
