using static System.Console;
using System;


namespace bit_mask
{
    class Program
    {
        static void Main()

        {
            WriteLine("Введите число");

            ushort number = ushort.Parse(ReadLine());

            string s = Convert.ToString(number, 2);
            WriteLine(s);

            ushort low = (ushort)((number & 0xc000) >> 14);

            ushort high = (ushort)((number & 0x0003) << 14);

            ushort mid = (ushort)(number & 0x3ffc);


            ushort y = (ushort)(low | mid | high);

            s = Convert.ToString(y, 2);

            WriteLine(s);
            double x = (double)2 / 3;
            Write(x);
            ReadKey();
        }
    }
}