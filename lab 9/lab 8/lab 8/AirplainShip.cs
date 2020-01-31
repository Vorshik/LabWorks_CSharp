using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8
{
	class AirplainShip : IWarShip
	{
		private string Name { get; set; }
		private double coor { get; set; }
		private bool Atack { get; set; }
		private static int num = 01010;
		private int enemy { get; set; }
		private static int uenemy = 10;

		//Свойства
		
		public static int Num
		{
			get { return num; }
		}

		public static int Uenemy
		{
			get { return uenemy; }
			
		}
		//Конструкторы
		public AirplainShip(string Name, double coor, int enemy)
		{
			this.Name = num+" "+Name;
			this.coor = coor;
			this.enemy = enemy;
		}

		//Методы
		public void Move()
		{
			if (Atack == true)
			{
				Console.WriteLine("Двигатели запущены! Полный вперед!");
			}
			else
			{
				Console.WriteLine("Стоп машины!");
			}
		}

		//
		public void Coordinate(double coor)
		{
			Console.WriteLine("Плывём по направлению " + coor);
		}

		//
		public void AirUp()
		{
			if (Atack == true)
			{
				Console.WriteLine("Самолёты на взлёт!");
			}
			else
			{
				Console.WriteLine("Нет необходимости поднимать самолёты!");
			}

		}

		//
		public void AirDown()
		{
			if (Atack == false)
			{
				Console.WriteLine("Самолёты на посадку!");
			}
			else
			{
				Console.WriteLine("Атака продолжается!");
			}

		}

		//
		public void Sravn()
		{
			if (enemy >= uenemy)
			{
				Atack = true;
				Console.WriteLine("Врагов очень много!");
			}
			else
			{
				Atack = false;
				Console.WriteLine("Врагов недостаточно!");
			}
			
		}

		public void Battle()
		{
			int kill;
			Console.WriteLine("В атаку!");
			while (enemy > uenemy)
			{
				Console.WriteLine("Сколько врагов было уничтожено?");
				kill = Convert.ToInt32(Console.ReadLine());
				enemy -= kill;
			}
		}

		public override string ToString()
		{
			return "ваш авиносец " + Name + "\nЕго направление движения " + coor + "\nКоличество врагов вокруг него " + enemy;
		}
	}
}
