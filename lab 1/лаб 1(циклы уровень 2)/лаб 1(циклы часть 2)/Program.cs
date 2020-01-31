//гр.761401; Варламов Дмитрий; Покажите, что при всех натуральных n число n^3+2n кратно 3.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаб_1_циклы_часть_2_
{
	class Program
	{
		static void Main(string[] args)
		{
			double ogr,pr;
			Console.WriteLine("Vvedite ogranicheniye ");
			ogr = Convert.ToDouble(Console.ReadLine());
			if(ogr==0)
			{
				Console.WriteLine("0- ne naturalen");
			}
			else
			{
				for(double i=1; i<=ogr; i++)
				{
					pr = (i*i*i) + (2 * i);
					Console.WriteLine("Rezult vichesl virajen {0}^3+2*{0} = {1} ", i, pr);
					if(pr%3==0)
					{
						Console.WriteLine("Dannoe chiclo kratno 3");
					}
					else
					{
						Console.WriteLine("Dannoe chislo ne kratno 3");
					}
					Console.WriteLine();
				}
			}
			Console.ReadKey();
		}
	}
}
