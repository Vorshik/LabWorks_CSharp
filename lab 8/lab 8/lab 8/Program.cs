// interface Корабль<- interface Военный Корабль<- class Авианосец.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8
{
	class Program
	{
		static void Main(string[] args)
		{
			string Name;
			double coor;
			int enemy;

			Console.WriteLine("Введите название авианосца ");
			Name = Convert.ToString(Console.ReadLine());

			
			try
			{
				Console.WriteLine("Введите направление движения ");
				coor = Convert.ToDouble(Console.ReadLine());
			}
			catch(FormatException ex)
			{
				Console.WriteLine("Ошибка: {0}", ex.Message);
				Console.WriteLine("Установим направление движения 152");
				coor = 152;
			}
			catch(Exception ex)
			{
				Console.WriteLine("Ошибка: {0}", ex.Message);
				Console.WriteLine("Установим направление движения 10");
				coor = 10;
			}
			
			try
			{
				Console.WriteLine("Введите количество врагов в окрге ");
				enemy = Convert.ToInt32(Console.ReadLine());
			}
			catch (FormatException ex)
			{
				Console.WriteLine("Ошибка: {0}", ex.Message);
				Console.WriteLine("Количество врагов в округе 20");
				enemy = 152;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Ошибка: {0}", ex.Message);
				Console.WriteLine("Количество врагов в округе 25");
				enemy = 10;
			}
			AirplainShip Bagration = new AirplainShip(Name, coor, enemy);

			Bagration.Coordinate(coor);
			Console.WriteLine();

			Bagration.Sravn();
			Console.WriteLine();

			Bagration.Move();
			Console.WriteLine();

			Bagration.AirUp();
			Console.WriteLine();

			Bagration.Battle();
			Console.WriteLine();

			Console.WriteLine("После боя ");
			Console.WriteLine("---------------------------------------------");
			Console.WriteLine();
			Bagration.Sravn();
			Bagration.AirDown();
			Console.WriteLine();
			Console.WriteLine(Bagration);


			Console.ReadKey();
		}
	}
}
