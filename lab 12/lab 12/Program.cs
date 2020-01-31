using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Collections;


namespace lab_12
{
	class Program
	{
		
		static void Main(string[] args)
		{
			
			Console.WriteLine("Для запуска нажмите любую клавишу");
			Console.ReadKey();
			int[] mass = new int[50000];
			Zap(mass);
			Thread th1 = new Thread(MergeSort);
			
			Console.ReadKey();
			Thread th2 = new Thread(RadixSort);
			th1.Start(mass);
			th2.Start(mass);

			Console.ReadKey();

		}

		static void Zap(int[] mass)
		{
			Random rand = new Random();
			for(int i=0; i<mass.Length; i++)
			{
				mass[i] = rand.Next(0, 5000);
			}
			
		}

		//Слияние
		static int[] Merge(int[] mass)
		{
			if (mass.Length == 1)
			{
				return mass;
			}

			int mid = mass.Length / 2;
			return Together(Merge(mass.Take(mid).ToArray()), Merge(mass.Skip(mid).ToArray()));
		}
		
		static int[] Together(int[] mass1, int[] mass2)
		{
			int compmerge = 0;
			int m1 = 0, m2 = 0;
			int[] merged = new int[mass1.Length + mass2.Length];
			for(int i=0; i<merged.Length; i++)
			{
				compmerge++;
				if(m1<mass1.Length && m2 < mass2.Length)
				{
					if(mass1[m1]>mass2[m2] && m2 < mass2.Length)
					{
						merged[i] = mass2[m2++];
					}
					else
					{
						merged[i] = mass1[m1++];
					}
				}
				else if (m2 < mass2.Length)
				{
					merged[i] = mass2[m2++];
				}
				else
				{
					merged[i] = mass1[m1++];
				}
				Console.WriteLine($"Промежуточный результат сравнения 1 потока {merged[i]}");
			}
			Console.WriteLine($"Число сравнений составило {compmerge}");
			return merged;
		}

		//Метод для секундомера метода слияние
		static void MergeSort(Object massive)
		{
			int[] mass = (int[])massive;
			Stopwatch stopwatch1 = new Stopwatch();
			stopwatch1.Start();
			mass = Merge(mass);
			stopwatch1.Stop();
			TimeSpan ts = stopwatch1.Elapsed;

			string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
			ts.Hours, ts.Minutes, ts.Seconds,
			ts.Milliseconds / 10);
			Console.WriteLine($"На сортировку слиянием было затрачено {elapsedTime}");
		}

		//Поразрядная сортировка
		static void Radix(int[] mass, int range, int lenth)
		{
			int compradix = 0;
			ArrayList[] lists = new ArrayList[range];
			for(int i=0; i < range; ++i)
			{
				lists[i] = new ArrayList();
			}
			for (int step = 0; step < lenth; step++)
			{
				for (int i = 0; i < mass.Length; i++)
				{
					compradix++;
					int temp = (mass[i] % (int)Math.Pow(range, step + 1)) / (int)Math.Pow(range, step);
					lists[temp].Add(mass[i]);


				}


				int k = 0;
				for (int i = 0; i < range; i++)
				{
					for (int j = 0; j < lists[i].Count; j++)
					{
						mass[k] = (int)lists[i][j];
						Console.WriteLine($"Промежуточный результат блочной сортировки {mass[k]}");
					}
				}
				for (int i = 0; i < range; i++)
				{
					lists[i].Clear();
				}
			}
			
			Console.WriteLine($"Число сравнений составило {compradix}");
			
		}

		//Метод для секундомера метода поразрядной сортировки
		static void RadixSort(Object massive)
		{
			int[] mass = (int[])massive;
			Stopwatch stopwatch2 = new Stopwatch();
			stopwatch2.Start();
			Radix(mass,100,3);
			stopwatch2.Stop();
			TimeSpan ts2 = stopwatch2.Elapsed;

			string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
			ts2.Hours, ts2.Minutes, ts2.Seconds,
			ts2.Milliseconds / 10);
			Console.WriteLine($"На сортировку слиянием было затрачено {elapsedTime2}");
		}

	}
}
