using System;

namespace Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число больше 0: ");
            int n = Convert.ToInt32 (Console.ReadLine());
            int a;
            int sum = 0;
           
            if (n<=0)
                Console.WriteLine("Ошибка!");

            for (int i = 1; i <= n; i++)
            {
                a = 2 * i - 1;
                sum += a;
                Console.WriteLine(sum);
            }
            Console.ReadKey();

        }
    }
}
