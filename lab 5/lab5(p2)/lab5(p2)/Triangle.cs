using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_p2_
{
	class Triangle
	{
		private double storona;
		private double cor1;
		private double cor2;
		private double cor3;
		private double s1;
		private double s2;

		//Проверка
		public Triangle(double storona, double cor1, double cor2)
		{
			this.storona = storona;
			if (Proverka(cor1,cor2))
			{
				
				this.cor1 = cor1;
				this.cor2 = cor2;
				//cor3 = 180 - cor2 - cor1;
			}
			else
			{
				
				this.cor1 = 60;
				this.cor2 = 30;
				
				Console.WriteLine("Ваш треугольник не существует, создаем треугольник с углами 60 и 30");
				
				
			}
			cor3 = 180 - cor2 - cor1;

		}
		private bool Proverka(double cor1, double cor2)
		{
			cor3 = 180 - cor1 - cor2;
			if (cor1 > 0 && cor2 > 0 && cor3 > 0)
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
		public double Cor1
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

		//Метод увеличения/уменьшения
		public void MenUv(double pr)
		{
			if (pr < 0 && pr>-100)
			{
				cor1 = cor1 - ((-1)*pr * cor1) / 100;
				cor2 = cor2 + ((-1)*pr * cor2) / 100;
				cor3 = 180 - cor1 - cor2;
				Console.WriteLine("Ваши углы после уменьшения:\n Первый угол - {0}\n Второй угол - {1}\n Третий угол - {2}", cor1, cor2, cor3);
			}
			else if(pr<=-100 || pr >= 100)
			{
				Console.WriteLine("Некоректный ввод!");
			}
			
			else if (pr > 0 && pr < 100)
			{
				cor1 = cor1 + (pr/100 * cor1);
				cor2 = cor2 - (pr/100 * cor2);
				cor3 = 180 - cor1 - cor2;
				Console.WriteLine("Ваши углы после уменьшения:\n Первый угол - {0}\n Второй угол - {1}\n Третий угол - {2}", cor1, cor2, cor3);
			}
			
		}

		//Метод нахождения стороны
		public void Storony()
		{
			cor3 = 180 - cor2 - cor1;
			s2 = Math.Sin((cor1 / 180D) * Math.PI) * storona / Math.Sin((cor3 / 180D) * Math.PI);
			s1 = Math.Sin((cor2 / 180D) * Math.PI) * storona / Math.Sin((cor3 / 180D) * Math.PI);
			
			Console.WriteLine("Стороны вашего треугольника:\n Первая боковая сторона - " + s1 + "\nВторая боковая сторона - " + s2 + "\nОснование - " + storona + "\n");
			
		}

		//Метод нахождения высоты 
		public void High()
		{
			double hs = 0, h1 = 0, h2 = 0;
			hs = s2 * Math.Sin((cor2 / 180D) * Math.PI);
			h1 = storona * Math.Sin((cor1 / 180D) * Math.PI);
			h2 = storona * Math.Sin((cor2 / 180D) * Math.PI);
			Console.WriteLine("Высоты:\n Высота к основанию - "+hs+"\nВысота к первой боковой стороне - "+h1+"\nВысота ко второй боковой стороне - "+h2+"\n");

		}
		//Вывод
		public override string ToString()
		{
			
			return "Cторона - " + storona + "\nУгол 1 - " + cor1 + "\nУгол2 - " + cor2;
			

		}
		
	}
}
