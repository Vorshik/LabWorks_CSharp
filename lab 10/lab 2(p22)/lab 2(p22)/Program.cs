//гр,761401. Варламов Дмитрий. Данное натуральное число N переведите из десятичной системы счисления в двоичную.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_p22_
{
	class Program
	{
		delegate void Perevodit(int n);
		static void Main(string[] args)
		{
			int n;
			Console.Write("Введите N: ");
			n = Convert.ToInt32(Console.ReadLine());
			Perevodit PR = Perevod;
			PR(n);
			Console.ReadKey();
		}
		static void Perevod(int N)
		{
			int res1 = 0, res2 = N;
			string str=" ";
			while(res2 > 0)
			{
				res1 = res2 % 2;
				str = res1.ToString()+str;

				res2 = res2/2;
			}
			Console.Write(str);
			
		}
	}
}
