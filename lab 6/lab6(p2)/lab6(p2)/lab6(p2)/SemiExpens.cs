using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_p2_
{
	class SemiExpens : Stones
	{
		
		private double costSemi;
		
		private double prozrach;

		//Поля и определение
		
		public double CostSemi
		{
			get { return costSemi; }
			set { costSemi = value; }
		}
		
		public double Prozrach
		{
			get { return prozrach; }
			set { prozrach = value; }
		}

		//Конструкторы
		public SemiExpens(string nameExpens, double costSemi, double mass, double prozrach) : base(nameExpens, mass)
		{
			this.nameExpens = nameExpens;
			this.costSemi = costSemi;
			this.mass = mass;
			this.prozrach = prozrach;
		}

		//Методы
		public double Count()
		{
			double count = costSemi;
			return count;

		}
		public override string ToString()
		{
			return "Стоимость камня " + costSemi + "\nКоэффициент прозрачности " + prozrach;
		}
	}
}
