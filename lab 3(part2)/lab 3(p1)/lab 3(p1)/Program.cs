//гр.761401. Варламов Дмитрий. Сложите две треугольные матрицы порядка n, у которых только элементы над главной диагональю отличны от нуля.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_p1_
{
	class Program
	{
		static void Main(string[] args)
		{
			int n;
			Console.Write("Введите n ");
			n = Convert.ToInt32(Console.ReadLine());
			int[,] Temp1 = new int[n, n];
			int[,] Temp2 = new int[n, n];
			InPut(Temp1);
			Out(Temp1);
			InPut(Temp2);
			Out(Temp2);
			Func(Temp1, Temp2);
			Console.ReadKey();
		}
		static void InPut(int [,] Temp)
		{
			for(int i=0; i <Temp.GetLength(0); i++)
			{
				for(int j=0; j<Temp.GetLength(1); j++)
				{
					if (i<= j)
					{
						Console.Write("Введите А[{0}, {1}] ", i,j);
						Temp[i, j] = Convert.ToInt32(Console.ReadLine());
					}
					else
					{
						Temp[i, j] = 0;
					}
					
					
				}
			}
		}
		static void Func(int[,] Temp1, int[,] Temp2)
		{
			for (int i = 0; i < Temp1.GetLength(0); i++)
			{
				for(int j=i; j<Temp1.GetLength(1); j++)
				{
					Temp1[i, j] = Temp1[i, j] + Temp2[i, j];
				}
			}
			Out(Temp1);
		}
		static void Out(int [,] Temp)
		{
			for (int i = 0; i < Temp.GetLength(0); i++)
			{
				for (int j = 0; j < Temp.GetLength(1); j++)
				{
					Console.Write(Temp[i, j]+" ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}
	}
}
