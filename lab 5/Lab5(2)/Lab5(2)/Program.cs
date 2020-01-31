/*гр.761401. Варламов Дмитрий Класс Треугольник 
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

namespace Lab5_2_
{
	class Program
	{
		static void Main(string[] args)
		{
			Triangle Tr1 = new Triangle(7, 54, 64);
			Console.WriteLine(Tr1);
			Console.ReadKey();
		}
		
	}
}
