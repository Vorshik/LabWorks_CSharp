using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2_
{
	class Triangle
	{
		private double storona;
		private double cor1;
		private double cor2;

		//Проверка
		public Triangle(double storona, double cor1, double cor2)
		{
			if (Proverka())
			{
				this.storona = storona;
				this.cor1 = cor1;
				this.cor2 = cor2;
			}
			else
			{
				storona = 5;
				cor1 = 46;
				cor2 = 35;
				Console.WriteLine("Ваш треугольник не существует");
				Console.WriteLine("Сторона вашего треугольника " + storona);
				Console.WriteLine("Ваш первый угол {0}\n Ваш второй угол {1}", cor1, cor2);
			}
		
		}
		private bool Proverka()
		{
			double cor3 = 180 - cor1 - cor2;
			if (cor1 > 0 && cor2 > 0 && cor2 > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

					

			//Чтение и ввод
		public double Storona
		{
			get
			{
				return storona;
			}
			set
			{
				storona = value;
			}
		}
		public  double Cor1
		{
			get
			{
				return cor1;
			}
			set
			{
				cor1 = value;
			}
		}
		public double Cor2
		{
			get
			{
				return cor2;
			}
			set
			{
				cor2 = value;
			}
		}
		public override string ToString()
		{
			return "Cторона - "+storona +"\nУгол 1 - "+cor1+"\nУгол2 - "+cor2;
		}
	}
}
