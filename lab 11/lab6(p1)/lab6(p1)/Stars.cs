using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_p1_
{
	
	class Stars
	{
		private string nameStar;
		private double mStar;
		private double rStar;
		private double L;

		public Planet[] Planets { get; set; }

		public string NameStar
		{
			get { return nameStar; }
			set
			{
				
				nameStar = value;
			}
		}

		public double RStar
		{
			get { return rStar; }
			set {rStar = value; }
		}

		public double MStar
		{
			get { return mStar; }
			set
			{				
				mStar = value;
			}
		}

		public double l
		{
			get { return L; }
			set { L = value; }
		}

		//конструктор
		public Stars(string nameStar, Planet[] Planets)
		{
			this.nameStar = nameStar;
			this.Planets = Planets;
		}
		public Stars(string nameStar, double mStar, double rStar, int count)
		{
			string namePlanet;
			double mPlanet;
			double rPlanet;
			this.nameStar = nameStar;
			this.mStar = mStar;
			this.rStar = rStar;
			Planets = new Planet[count];
			for(int i=0; i<count; i++)
			{
				Console.WriteLine("Введите параметры " + i + " планеты");
				Console.WriteLine("Введите название планеты ");
				namePlanet = Convert.ToString(Console.ReadLine());
				Console.WriteLine("Введите массу планеты ");
				mPlanet = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Введите радиус планеты ");
				rPlanet = Convert.ToDouble(Console.ReadLine());

				Planets[i] = new Planet(namePlanet, mPlanet, rPlanet);

				Console.WriteLine("Ваши луны: ");
				Planets[i].View();
			}

		}

		//Методы
		public void GravEner()
		{
			double En;
			En = (3 * 6.67 * Math.Pow(10, -11) * mStar * mStar) / (5 * rStar);
			Console.WriteLine("Значение гравитационной энергии данной звезды {0} эрг",En);
		}

		public void TimeOut()
		{
			double T;
			T=(3 * 6.67 * Math.Pow(10, -11) * mStar * mStar) / (5 * rStar*L);
			Console.WriteLine("Излучение звезды составит {0} c.",T);
		}

		public void SvetStar()
		{
			
			if(mStar <= 1.9 * Math.Pow(10, 30))
			{
				Console.WriteLine("Масса звезды составляет {0} массы солнца", mStar / 1.9 * Math.Pow(10, 30));
				L = Math.Pow(mStar, 1.6);
				Console.WriteLine("Светимость звезды составляет"+L+" эрг/с");
			}
			else if(mStar>= 1.9 * Math.Pow(10, 30))
			{
				Console.WriteLine("Масса звезды составляет {0} массы солнца", mStar / 1.9 * Math.Pow(10, 30));
				L = Math.Pow(mStar, 5.4);
				Console.WriteLine("Светимость звезды составляет" + L+ " эрг/с");
			}
		}
		 public int Count()
		{
			int count = Planets.Length;
			return count;
		}

		public void ShowPlanet()
		{
			
			for(int i=0; i<Planets.Length; i++)
			{
				Console.WriteLine(Planets[i]);
			}
		}

		public override string ToString()
		{
			return "Имя звезды "+nameStar+"\nМасса звезды " + mStar+"\nРадиус звезды " + rStar;
		}
	}
}
