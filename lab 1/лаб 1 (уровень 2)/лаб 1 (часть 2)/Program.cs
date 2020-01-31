//гр, 761401; Варламов Дмитрий; Треугольник задан координатами своих верши. Определить меньшую из сторон треугольника.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаб_1__часть_2_
{
	class Program
	{
		static void Main(string[] args)
		{
			double x1, x2, x3, y1, y2, y3, a=0, b=0, c=0;
			Console.WriteLine("Введите значения координат: ");
			x1 = Convert.ToDouble(Console.ReadLine());
			x2 = Convert.ToDouble(Console.ReadLine());
			x3 = Convert.ToDouble(Console.ReadLine());
			y1 = Convert.ToDouble(Console.ReadLine());
			y2 = Convert.ToDouble(Console.ReadLine());
			y3 = Convert.ToDouble(Console.ReadLine());

			if (x1 == x2 && y1 == y2 || x2 == x3 && y2 == y3 || x3==x1 && y3 == y1 )
			{
				Console.WriteLine("Треугольник не существует");
                return;
			}
			
			
				a = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
				b = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
				c = Math.Sqrt((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1));

				Console.WriteLine("Стороны треугольника имеют длинны: {0}; {1}; {2}", a, b, c);
			

			if (a < b && a < c)
			{
				Console.WriteLine("Наименьшая сторона имеет длину равную {0}", a);
			}
			else if (b < a && b < c)
			{
				Console.WriteLine("Наибольшая сторона имеет длину равную {0}", b);
			}
			else
			{
				Console.WriteLine("Наибольшая сторона имеет длину равную {0}", c);
			}
			Console.ReadKey();
		}
	}
}
