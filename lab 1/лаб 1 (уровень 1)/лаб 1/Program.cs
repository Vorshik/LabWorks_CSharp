//гр. 761401 Варламов Дмитрий. Даны радиус круга и сторона квадрата. Пройдет ли квадрат в круг.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаб_1
{
	class Program
	{
		static void Main(string[] args)
		{
			double a, b;
			Console.WriteLine("Введите радиус круга: ");
			a = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Введите сторону квадрата: ");
			b = Convert.ToDouble(Console.ReadLine());
			if(2*a >= b )
			{
				Console.WriteLine("Квадрат пройдёт в круг");
			}
			else
			{
				Console.WriteLine("Квадрат не пройдёт в круг");
			}

			Console.ReadKey();
		}
	}
}
