//гр.761401; Варламов Дмитрий; Пусть n-натуральное число и пусть n!! озночает 1*3*...*n для нечетного и 2*4*...n для чётного n. Для заданного натурального n вычислите n!!.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, pc = 1;
            Console.WriteLine("Введите n ");
            n = Convert.ToInt32(Console.ReadLine());

			for (int i = n; i > 0 ; i -= 2)
			{
				pc = pc * i;
			}
			Console.WriteLine("Произведение n!! равно {0}", pc);

			Console.ReadKey();
        }
    }
}
