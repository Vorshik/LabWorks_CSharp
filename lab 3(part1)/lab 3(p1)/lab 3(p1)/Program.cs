//гр,761401. Варламов Дмитрий. Вычислите А1 + 2А2 + 3А3 + ... + NАN.
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
			int N;
			Console.Write("Введите размер массива ");
			N = Convert.ToInt32(Console.ReadLine());
			int[] Temp = new int[N];
			InPut(Temp);
			Out(Temp);
			Func(Temp);
			Console.ReadKey();
		}
		static void InPut(int[] Temp)
		{
			for(int i=0; i < Temp.Length; i++)
			{
				Console.Write("Введите A[{0}] ",i);
				Temp[i] = Convert.ToInt32(Console.ReadLine());
			}
		}
		static void Func(int[] Temp)
		{
			int sum = 0;
			for(int i=0; i < Temp.Length; i++)
			{
				sum += Temp[i] * i;
			}
			Console.WriteLine("Ваша сумма: {0}", sum);
		}
		static void Out(int[] Temp)
		{
			Console.Write("Ваш массив: ");
			for(int i=0; i<Temp.Length; i++)
			{
				Console.Write(" "+Temp[i]);
			}
			Console.WriteLine();
		}
	}
}
