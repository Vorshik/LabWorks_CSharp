using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_p1_
{
	class Planet
	{
		private string namePlanet;
		private double mPlanet;
		private double rPlanet;
		private int count;
		public Moon[] Moons;
		public string NamePlanet
		{
			get { return namePlanet; }
			set { namePlanet = value; }
		}

		public int Count
		{
			get { return count; }
			set { count = value; }
		}

		public double RPlanet
		{
			get { return rPlanet; }
			set { rPlanet = value; }
		}

		public double MPlanet
		{
			get { return mPlanet; }
			set { mPlanet = value; }
		}

		//Конструктор
		public Planet(string namePlanet, Moon[] Moons)
		{
			this.namePlanet = namePlanet;
			this.Moons = Moons;
		}

		public Planet(string namePlanet, double mPlanet, double rPlanet)
		{
			
			string nameMoon;
			double mass;
			string shape;
			Console.WriteLine("Введите количество спутников планеты ");
			count = Convert.ToInt32(Console.ReadLine());
			this.namePlanet = namePlanet;
			this.mPlanet = mPlanet;
			this.rPlanet = rPlanet;
			Moons = new Moon[count];
			if (count != 0)
			{
				for (int i = 0; i< count; i++)
				{
					Console.WriteLine("Введите название спутника ");
					nameMoon = Convert.ToString(Console.ReadLine());
					Console.WriteLine("Введите массу спутника ");
					mass = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Введите форму спутника ");
					shape = Convert.ToString(Console.ReadLine());

					Moons[i] = new Moon(nameMoon, mass, shape);
					
				}
			}
			else if(count == 0)
			{
				Console.WriteLine("У данной планеты нет спутников");
			}
		}

		//Методы
		public void View()
		{
			if (count != 0)
			{
				for (int i = 0; i < Moons.Length; i++)
				{
					Console.WriteLine(Moons[i]);
				}
			}
			else if (count == 0)
			{
				Console.WriteLine();
			}
		}
		public override string ToString()
		{
			return "Имя планеты " + namePlanet + "\nМасса планеты " + mPlanet + "\nРадиус планеты " + rPlanet ;
		}
	}
	
}
