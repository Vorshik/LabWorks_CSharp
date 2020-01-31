//гр.761401. Варламов Дмитрий. Напишите программу нахождения следующего за данным совершенного числа. Совершенным называется число, сумма делителей которого, не считая самого числа, равна этому числу.Первое совершенное число 6 (6 = 1 + 2 + 3).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_p2_
{
	class Program
	{
		static void Main(string[] args)
		{
			int m, rang;
			Console.Write("Введите совершенное число: ");
			m = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите ограничение: ");
			rang = Convert.ToInt32(Console.ReadLine());
			for(int i=m+1; i<rang; i++)
			{
				if (Sover(i))
				{
					Console.WriteLine("Ваше совершенное число: {0}", i);
					break;
				}
				
			}
			Console.ReadKey();
		}
		static bool Sover(int a)
		{

			int sum = 1;
			for(int i=2; i<=a/2; i++)
			{
				if(a%i==0)
				{
					sum += i;
				}
				
			}
			if (sum == a)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
