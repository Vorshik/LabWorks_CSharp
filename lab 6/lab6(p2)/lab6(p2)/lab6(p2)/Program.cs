using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_p2_
{
	class Program
	{
		static void Main(string[] args)
		{
			string name;
			double cost;
			double prozrach;
			Console.WriteLine("Введите название ожерелья ");
			name = Convert.ToString(Console.ReadLine());
			Console.WriteLine("Введите стоимость ожерелья ");
			cost = Convert.ToDouble(Console.ReadLine());

			necklet Busina = new necklet(name, cost);
			Console.WriteLine("-------------------------------------");
			Busina.Sort();
			Console.WriteLine("После сортировки кмней в ожерелье ");
			Busina.Vivod();
			Console.WriteLine("-------------------------------------");
			Console.WriteLine("Введите коэффициент прозрачности ");
			prozrach = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Камни соотетствующие заданному параметру прозрачности ");
			Busina.Find(prozrach);
			Console.WriteLine("-------------------------------------");
			Console.WriteLine("Параметры вашего ожерелья ");
			Console.WriteLine(Busina);

			Console.ReadKey();
		}
	}
}
