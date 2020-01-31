using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7_p1_
{
	class Vektor
	{
		private string name { get; set; }
		private double x { get; set; }
		public double[] mass;
		private static int count = 0;
		private static int nextIndex = 1000;
		private int index = 0;
		private double dlina { get; set; }

		//Свойства
		public static int Count
		{
			get { return count; }
			set { count = value; }
		}

		public int Index
		{
			get { return index; }
			set { index = value; }
		}

		//Конструкторы
		public Vektor(string name, double[] mass)
		{
			this.name = name;
			this.mass = mass;
			
		}

		public Vektor(string name, int nmer)
		{
			count++;
			index = nextIndex;
			nextIndex += 10;
			this.name = name+" : "+count;
			mass = new double[nmer];
			for(int i=0; i<nmer; i++)
			{
				Console.WriteLine("Введите значение " + i + " пространства");
				
				mass[i] = Convert.ToDouble(Console.ReadLine());
			}

		}

		//Методы
		public double Schet()
		{
			double sum = 0;
			for(int i=0; i<mass.Length; i++){
				sum += mass[i];
			}
			dlina = Math.Sqrt(sum);
			Console.WriteLine("Длина вашего вектора равна " + dlina);
			return sum;
		}

		public void Show()
		{
			for(int i=0; i<mass.Length; i++)
			{
				Console.WriteLine(mass[i]);
			}
		}

		//Перегруженые операторы отношения
		public static bool operator > (Vektor V1, Vektor V2)
		{

			return V1.Schet() > V2.Schet();
		}

		public static bool operator < (Vektor V1, Vektor V2)
		{
			return V1.Schet() < V2.Schet();
		}

		//Вывод
		public override string ToString()
		{
			return "Идентификационный номер: "+index+"\nНазвание вашего вектора "+name+ "\nКоличество элементов "+count+"\nЭлементы вектора ";
		}
	}
}
