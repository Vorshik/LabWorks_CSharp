//гр.761401. Варламов Дмитрий. Дана действительная квадратная матрица порядка n. Найдите сумму элементов, расположенных в заштрихованной части матрицы (рис. 8.4).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_p2_
{
	class Program
	{
		static void Main(string[] args)
		{
			int n;
			Console.Write("Введите n ");
			n = Convert.ToInt32(Console.ReadLine());
			int[,] Temp1 = new int[n, n];
			InPut(Temp1);
			Out(Temp1);
			Func(Temp1);

			Console.ReadKey();
		}
		static void InPut(int[,] Temp)
		{
			for (int i = 0; i < Temp.GetLength(0); i++)
			{
				for (int j = 0; j < Temp.GetLength(1); j++)
				{					
						Console.Write("Введите А[{0}, {1}] ", i, j);
						Temp[i, j] = Convert.ToInt32(Console.ReadLine());


				}
			}
		}
		static void Out(int[,] Temp)
		{
			for (int i = 0; i < Temp.GetLength(0); i++)
			{
				for (int j = 0; j < Temp.GetLength(1); j++)
				{
					Console.Write(Temp[i, j] + " ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}
		static void Func(int[,] Temp1)
		{
			int sum = 0;
			for (int i = 0; i < Temp1.GetLength(0); i++)
			{
				for (int j = Temp1.GetLength(1)-1-i; j < Temp1.GetLength(1); j++)
				{
					
				
						sum += Temp1[i, j];
					
				}
			}
			Console.WriteLine("Ваша сумма равна: {0}", sum);
		}
	}
}
