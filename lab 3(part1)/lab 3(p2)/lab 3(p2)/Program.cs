//гр.761401. Варламов Дмитрий. Дан числовой массив А, состоящий из n натуральных чисел. Определите количество элементов массива, которые больше заданного числа.
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
			int N, s;
			Console.Write("Введите размер массива ");
			N = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите элемент для сравнения s: ");
			s = Convert.ToInt32(Console.ReadLine());
			int[] Temp = new int[N];
			InPut(Temp);
			Out(Temp);
			Func(Temp, s);
			Console.ReadKey();
		}
		static void InPut(int[] Temp)
		{
			for (int i = 0; i < Temp.Length; i++)
			{
				Console.Write("Введите A[{0}] ", i);
				Temp[i] = Convert.ToInt32(Console.ReadLine());
			}
		}
		static void Func(int[] Temp, int s)
		{
			int sum = 0;
			for (int i = 0; i < Temp.Length; i++)
			{
				if (Temp[i] > s)
				{
					sum += 1;
				}
			}
			Console.WriteLine("Кол-во элементов больше заданного: {0}", sum);
		}
		static void Out(int[] Temp)
		{
			Console.Write("Ваш массив: ");
			for (int i = 0; i < Temp.Length; i++)
			{
				Console.Write(" " + Temp[i]);
			}
			Console.WriteLine();
		}
	}
}
