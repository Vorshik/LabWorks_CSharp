////гр.761401.Варламов Дмитрий.Составить рекурсивную функцию для вычисления P = 2* 4* 6*…*2*n
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_p2_
{
	class Program
	{
		static void Main(string[] args)
		{
			double n;
			Console.Write("Введите n: ");
			n = Convert.ToDouble(Console.ReadLine());
			SumRec(n);
			Console.WriteLine("Ваша сумма Р= {0}", SumRec(n));
			Console.ReadKey();

		}
		static double SumRec(double n)
		{
			double P;
			if (n < 1)
			{
				return 1;
			}
			else
			{
				return P = SumRec(n - 1) * n * 2;
			}
			
			
		}
	}
}
