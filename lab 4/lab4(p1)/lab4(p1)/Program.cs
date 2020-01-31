//гр.761401.Варламов Дмитрий. С помощью признака делимости на 11 проверьте, кратно ли данное натуральное число 11. Напишите рекурсивную функцию.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_p1_
{
	class Program
	{
		static void Main(string[] args)
		{
			int n;
			int i = 1;
			Console.Write("Vvtdite n ");
			n = Convert.ToInt32(Console.ReadLine());
			if (Recursch(n, i) == Recursn(n, i))
			{
				Console.WriteLine("Kratno!");
			}
			else
			{
				Console.WriteLine("Ne kratno!");
			}
			

			Console.ReadKey();

		}

		static int Recursch(int x, int i)
		{
			int sum = 0;
			i += 1;
			if (x == 0)
			{
				return 0;
			}
			if (i % 2 == 0)
			{
				sum = x % 10;
				
			}
			return sum = sum + Recursch(x / 10, i);
			

		
		}
		static int Recursn(int x, int i)
		{
			int sum = 0;
			i += 1;
			if (x == 0)
			{
				return 0;
			}
			if (i % 2 != 0)
			{
				sum = x % 10;

			}
			return sum = sum + Recursn(x / 10, i);



		}
	}
}
