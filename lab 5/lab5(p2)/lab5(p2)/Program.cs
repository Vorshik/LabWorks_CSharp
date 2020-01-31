/*Класс Треугольник 
Поля: сторона и два прилежащих к ней угла
Операции: 
 увеличение/уменьшение значения любого угла(из полей) на заданное количество процентов;
 вычисление длины высот, принадлежащей любой стороне;
*/// определение значений сторон.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_p2_
{
	class Program
	{
		static void Main(string[] args)
		{
			double pr,s,cor1,cor2;

			Console.Write("Введите ваше основание ");
			s = Convert.ToDouble(Console.ReadLine());

			Console.Write("Введите ваш первый угол ");
			cor1 = Convert.ToDouble(Console.ReadLine());

			Console.Write("Введите ваш второй угол ");
			cor2 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine();

			Console.WriteLine("Ваш треугольник без изменений\n");
			Triangle Tr1 = new Triangle(s, cor1, cor2);
			Console.WriteLine("Ваш треугольник имеет следующие параметры:\n "+Tr1+"\n");
			Tr1.Storony();
			Tr1.High();

			Console.Write("Введите %, на который нужно уменьшить ваш угол(-% - уменьшение, +% - увеличение) ");
			pr = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("--------------------------------------------------------------------------------");
			Console.WriteLine("Измененные значения вашего треугольника\n");
			Tr1.MenUv(pr);
			Console.WriteLine("Ваш треугольник имеет следующие параметры:\n " + Tr1 + "\n");
			Tr1.Storony();
			Tr1.High();
			Console.ReadKey();
		}
	}
}
