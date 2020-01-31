//6.	Создать объект класса Звездная система, используя классы Планета, Звезда, Луна.
//Методы: вывести на консоль количество планет в звездной системе, название звезды, добавление планеты в систему.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_p1_
{
	class Program
	{
		static void Main(string[] args)
		{
			string NameStarSystem;
			int count;

			OtsledClass Vivod = new OtsledClass();
			Console.WriteLine("Введите название вашей звёздной системы ");
			NameStarSystem = Convert.ToString(Console.ReadLine());

			Console.WriteLine("Введите количество звёзд в вашей системе");
			count = Convert.ToInt32(Console.ReadLine());

			StarSystem Mlech = new StarSystem(NameStarSystem, count);
			Mlech.OName += Vivod.Message1;
			Mlech.OSchet += Vivod.Message1;
			Console.WriteLine("------------------------------------------------------------------------");
			Console.WriteLine("Звёзды в вашей системе ");
			Mlech.VivodStar();
			Console.WriteLine();
			Console.WriteLine(Mlech);
			Mlech.Name = "gfhhfh";

			Console.ReadKey();
		}
	}
}
