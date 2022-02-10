using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("программа сложенения двух дробных чисел:");
            Console.WriteLine("Введите два дробных числа");
            bool noError = true;
            double x = 0;
            double y = 0;
            while (noError)
            {
                try
                {
                    x = Convert.ToDouble(Console.ReadLine());
                    y = Convert.ToDouble(Console.ReadLine());
                    noError = false;
                }
                catch
                {
                    Console.WriteLine("Ошибка!!!");
                }
            }
            var S = x + y;
            Console.WriteLine("сумма="  + S);
            Console.ReadKey();
        }
    }
    
}
