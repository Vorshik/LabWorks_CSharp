using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_p1_
{
	class StarSystem
	{
		private string name;
		private int schet = 0;
		public Stars[] Stary { get; set; }

		public string Name {
			get { return name; }
			set { name = value; }
		}

		public int Schet
		{
			get { return schet; }
			set { schet = value; }
		}
		//Конструкторы
		public StarSystem(string name, Stars[] Stary)
		{
			this.name = name;
			this.Stary = Stary;
			
		}

		public StarSystem(string name, int count)
		{
			string nameStar;
			double mStar;
			double rStar;
			int count1;
			this.name = name;
			Stary = new Stars[count];
			for(int i=0; i<count; i++)
			{
				Console.WriteLine("Введите имя звезды");
				nameStar = Convert.ToString(Console.ReadLine());
				Console.WriteLine("Введите массу звезды");
				mStar = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Введите радиус звезды");
				rStar = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Введите количество планет");
				count1 = Convert.ToInt32(Console.ReadLine());

				Stary[i] = new Stars(nameStar, mStar, rStar, count1);

				Stary[i].GravEner();
				Stary[i].SvetStar();
				Stary[i].TimeOut();
				Console.WriteLine("Ваши планеты ");
				Stary[i].ShowPlanet();
				schet += Stary[i].Count();
				Console.WriteLine();
				
			}
		}

		public void VivodStar()
		{
			for(int i =0; i<Stary.Length; i++)
			{
				Console.WriteLine(Stary[i]);
			}
		}

		public override string ToString()
		{
			return "Название вашей звёздной системы: " + name + " \nКоличество планет в звёздной системе " + schet;
			
		}
	}
}
