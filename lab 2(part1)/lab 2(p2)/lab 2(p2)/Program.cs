//гр.761401.Варламов Дмитрий. Вычислите сумму ряда (-1)^n*1/(2n+1) с заданной степенью точностю а=0.0001.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_p2_
{
	class Program
	{
		static void Main(string[] args)
		{
			double a;
			Console.Write("Введите точность a: ");
			a = Convert.ToDouble(Console.ReadLine());
			Sum(a);
			Console.ReadKey();
		}
		static void Sum(double a)
		{
			int i = 1;
			double res1 = 0, res2 = 0;
			res2 = 1;
			i++;
			int znak = -1;
			while (res2 >= 0.0001)
			{
				

				res2 = 1 / (2 * i + 1);
				res1 += znak * res2;
				znak = -znak;

				
			
			}
			Console.WriteLine("Сумма с точность a равна {0}, i={1}", res1, i);

		}
	}
}
