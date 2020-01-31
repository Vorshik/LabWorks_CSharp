using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_p2_
{
	class Expensive : Stones
	{
		private double costExp;		
		private double prozrach;

		//Поля и определение
		
		public double CostExp
		{
			get { return costExp; }
			set { costExp = value; }
		}
		
		public double Prozrach
		{
			get { return prozrach; }
			set { prozrach = value; }
		}

		//Конструкторы
		public Expensive(string nameExpens, double costExp, double mass, double prozrach) : base(nameExpens, mass)
		{
			this.nameExpens = nameExpens;
			this.costExp = costExp;
			this.mass = mass;
			this.prozrach = prozrach;
		}

		//Методы
		public double Count()
		{
			double count = costExp;
			return count;

		}
		public override string ToString()
		{
			return "Стоимость камня " + costExp + "\nКоэффициент прозрачности " + prozrach;
		}
	}
}
