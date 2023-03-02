using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int step;
            int n;
            int sum = 0;
            int subSum;
            Console.WriteLine("Введите первый элемент");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель прогрессии");
            step = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число элементов");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                subSum = 0;
                for (int j = 0; j <= i; j++)
                    subSum += a;
                sum += subSum;
            }
            Console.WriteLine("Сумма членов прогрессии равна " + Convert.ToString(sum));
            Console.ReadKey();
        }
    }
}
