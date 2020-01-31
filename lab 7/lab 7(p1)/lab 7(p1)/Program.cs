using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7_p1_
{
	class Program
	{
		static void Main(string[] args)
		{
			string name,name1;
			int nmer,nmer1;
			bool result;
			Console.WriteLine("Введите название первого вектора ");
			name = Convert.ToString(Console.ReadLine());
			Console.WriteLine("Введите н-мерное пространство первого вектора ");
			nmer = Convert.ToInt32(Console.ReadLine());

			Vektor V1 = new Vektor(name, nmer);
			Console.WriteLine();
			Console.WriteLine("Введите название второго вектора ");
			name1 = Convert.ToString(Console.ReadLine());
			Console.WriteLine("Введите н-мерное пространство второго вектора ");
			nmer1 = Convert.ToInt32(Console.ReadLine());

			Vektor V2 = new Vektor(name1, nmer1);

			V1.Schet();
			V2.Schet();

			Console.WriteLine("----------------------------------------------------------------------");
			result = V1 > V2;
			if (result == true)
			{
				Console.WriteLine("Длина вектора " + name + " больше длины вектора " + name1);
			}
			else if (V1.Schet() == V2.Schet())
			{
				Console.WriteLine("Длина векторов равны");
			}
			else if(result == false)
			{
				Console.WriteLine("Длина вектора " + name + " меньше длины вектора " + name1);
			}
			

			Console.WriteLine();
			Console.WriteLine(V1);
			V1.Show();

			Console.WriteLine();
			Console.WriteLine(V2);
			V2.Show();

			Console.ReadKey();
		}
	}
}
