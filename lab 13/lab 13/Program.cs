using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace lab_13
{
	class Program
	{
		static object locker = new object();
		static void Main(string[] args)
		{
			Console.WriteLine("Запускаем основной поток");
			
			Thread th1 = new Thread(() =>
			{

				Thread.Sleep(100);
				Console.WriteLine("Поток 2");
				Test2();
			});
			Thread th2 = new Thread(() =>
			{
				Thread.Sleep(100);
				Console.WriteLine($"Поток 3");				
				Test3();
				
			});
			Thread th3 = new Thread(() =>
			{
				Thread.Sleep(100);
				Console.WriteLine("Поток 4");
				Test4();
			});
			Thread th4 = new Thread(() =>
			{
				Thread.Sleep(100);
				Console.WriteLine("Поток 5");
				Test5();
			});
			Test1();
			th1.Start();
			Console.WriteLine();
			th2.Start();
			Console.WriteLine();
			th3.Start();
			Console.WriteLine();
			th4.Start();
			Console.WriteLine();

			Console.ReadKey();



		}

		static void Prog(double x)
		{
			for(int i=0; i< 10000; i++)
			{
				for(int j=0; j < 10000; j++)
				{
					x = Math.Sqrt(x);
					x = x + 0.000000001;
					x = Math.Pow(x, 2);
				}
			}
			Console.WriteLine("A: " + x.ToString());
		}

		static void Test1()
		{

			Stopwatch stopWatch1 = new Stopwatch();
			double x1 = 12345.6789;
			stopWatch1.Start();
			Prog(x1);
			stopWatch1.Stop();
			TimeSpan ts1 = stopWatch1.Elapsed;
			string elapsedTime1 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts1.Hours, ts1.Minutes, ts1.Seconds,
				ts1.Milliseconds / 10);
			Console.WriteLine($"Time: {elapsedTime1}\n");

		}
		static void Test2()
		{
			lock (locker)
			{
				Stopwatch stopWatch2 = new Stopwatch();
				double x2 = 12345.6789;
				stopWatch2.Start();
				Prog(x2);
				stopWatch2.Stop();
				TimeSpan ts2 = stopWatch2.Elapsed;
				string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts2.Hours, ts2.Minutes, ts2.Seconds,
					ts2.Milliseconds / 10);
				Console.WriteLine($"Time: {elapsedTime2}");
				Console.WriteLine("Поток 2\n");
			}
			

		}
		static void Test3()
		{
			lock (locker)
			{
				Stopwatch stopWatch3 = new Stopwatch();
				double x3 = 12345.6789;
				stopWatch3.Start();
				Prog(x3);
				stopWatch3.Stop();
				TimeSpan ts3 = stopWatch3.Elapsed;
				string elapsedTime3 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts3.Hours, ts3.Minutes, ts3.Seconds,
					ts3.Milliseconds / 10);
				Console.WriteLine($"Time: {elapsedTime3}");
				Console.WriteLine("Поток 3\n");
			}

		}
		static void Test4()
		{
			lock (locker)
			{
				Stopwatch stopWatch4 = new Stopwatch();
				double x4 = 12345.6789;
				stopWatch4.Start();
				Prog(x4);
				stopWatch4.Stop();
				TimeSpan ts4 = stopWatch4.Elapsed;
				string elapsedTime4 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts4.Hours, ts4.Minutes, ts4.Seconds,
					ts4.Milliseconds / 10);
				Console.WriteLine($"Time: {elapsedTime4}");
				Console.WriteLine("Поток 4\n");
			}

		}
		static void Test5()
		{
			lock (locker)
			{
				Stopwatch stopWatch5 = new Stopwatch();
				double x5 = 12345.6789;
				stopWatch5.Start();
				Prog(x5);
				stopWatch5.Stop();
				TimeSpan ts5 = stopWatch5.Elapsed;
				string elapsedTime5 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts5.Hours, ts5.Minutes, ts5.Seconds,
					ts5.Milliseconds / 10);
				Console.WriteLine($"Time: {elapsedTime5}");
				Console.WriteLine("Поток 5\n");
			}

		}
	}
}
