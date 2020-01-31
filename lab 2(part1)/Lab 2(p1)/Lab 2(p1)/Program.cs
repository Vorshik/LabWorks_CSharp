//гр.761401. Варламов Дмитрий. Дано целое число m > 10. Получите наибольшее целое k, при котором 4k < m.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_p1_
{
	class Program
	{
		static void Main(string[] args)
		{
			double m, k=0;
			Console.Write("Введите m>10: ");
			m = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("С помощью цикла while ");
			Srawn(m, k);
			Console.WriteLine("С помощью цикла do while ");
			Srawndo(m, k);
			
			Console.ReadKey();
		}
		static void Srawn(double a, double b)
		{
			int step = 1;
			while(step < a)
			{
				b++;
				step *= 4;
				
			}
			Console.WriteLine("Наибольшее целое k: {0}", b-=1);
		}
		static void Srawndo(double a, double b)
		{
			do
			{
				b++;
			} while (Math.Pow(4, b) < a);
			Console.WriteLine("Наибольшее целое k: {0}", b-=1);
		}
	}
}
