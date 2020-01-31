using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_p2_
{
	class Stones
	{
		protected string nameExpens;
		protected double mass;

		//определение классов
		public string Name
		{
			get { return nameExpens; }
			set { nameExpens = value; }
		}
		public double Mass
		{
			get { return mass; }
			set { mass = value; }
		}

		public Stones(string nameExpens, double mass)
		{
			this.nameExpens = nameExpens;
			this.mass = mass;
		}

		public double MassCount()
		{
			double m = mass;
			return m;
		}
		
		public void Print()
		{
			Console.WriteLine("Название камня "+nameExpens);
			Console.WriteLine("Масса камня "+mass);
		}

		public override string ToString()
		{
			return "Название камня " + nameExpens + "\nМасса камня в каратах " + mass;
		}
	}
}
