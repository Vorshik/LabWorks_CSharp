using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_p2_
{
	class necklet
	{
		private string name;
		private double cost;
		private int vibor;
		private double vcarat=0;
		private double fcost=0;
		private int countSS;
		private int count;
		
		public Expensive[] ExpStones;
		public SemiExpens[] SemiExpStones;
		

		//Определение
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public double Cost
		{
			get { return cost; }
			set { cost = value; }
		}
		public int Vibor
		{
			get { return vibor; }
			set { vibor = value; }
		}
		public double Vcarat
		{
			get { return vcarat; }
			set { vcarat = value; }
		}

		public double Fcost
		{
			get { return fcost; }
			set { fcost = value; }
		}
		public int Count
		{
			get { return count; }
			set { count = value; }
		}
		public int CountSS
		{
			get { return countSS; }
			set { countSS = value; }
		}
		

		public necklet(string name, Expensive[] ExpStones, SemiExpens[] SemiExpStones)
		{
			this.name = name;
			
			this.ExpStones = ExpStones;
			this.SemiExpStones = SemiExpStones;
		}

		//Конструктор
		public necklet(string name, double cost)
		{
			string nameS;
			double mass;
			double prozrach;
			double costs;


			Console.WriteLine("Какое ожерелье вы хотите создать? \n(1 - из драгоценных камней; 2 - из полудрагоценных камней; 3 - Смешанное;)");
			vibor = Convert.ToInt32(Console.ReadLine());
			this.name = name;
			this.cost = cost;
			

			if(vibor == 1)
			{
				Console.WriteLine("Введите количество камней");
				count = Convert.ToInt32(Console.ReadLine());
				ExpStones = new Expensive[count];
				for (int i= 0; i<count; i++)
				{
					Console.WriteLine("Введите название "+i+" камня");
					nameS = Convert.ToString(Console.ReadLine());
					Console.WriteLine("Введите стоимость");
					costs = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Введите массу в каратах");
					mass = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Введите параметр прозрачности");
					prozrach=Convert.ToDouble(Console.ReadLine());


					ExpStones[i] = new Expensive(nameS, costs, mass, prozrach);
					
				}
			}
			else if (vibor == 2)
			{
				Console.WriteLine("Введите количество камней");
				countSS = Convert.ToInt32(Console.ReadLine());
				SemiExpStones = new SemiExpens[countSS];
				for (int i = 0; i < countSS; i++)
				{
					Console.WriteLine("Введите название " + i + " камня");
					nameS = Convert.ToString(Console.ReadLine());
					Console.WriteLine("Введите стоимость");
					costs = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Введите массу в каратах");
					mass = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Введите параметр прозрачности");
					prozrach = Convert.ToDouble(Console.ReadLine());


					SemiExpStones[i] = new SemiExpens(nameS, costs, mass, prozrach);
					
				}
			}
			else if (vibor == 3)
			{
				Console.WriteLine("Введите количество драгоценных камней");
				count = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Введите количество полудрагоценных камней");
				countSS = Convert.ToInt32(Console.ReadLine());
				ExpStones = new Expensive[count+countSS];
				for (int i = 0; i < count; i++)
				{
					Console.WriteLine("Введите название " + i + " драгоценного камня");
					nameS = Convert.ToString(Console.ReadLine());
					Console.WriteLine("Введите стоимость");
					costs = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Введите массу в каратах");
					mass = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Введите параметр прозрачности");
					prozrach = Convert.ToDouble(Console.ReadLine());


					ExpStones[i] = new Expensive(nameS, costs, mass, prozrach);
					
				}
				for (int i = count; i < countSS+count; i++)
				{
					Console.WriteLine("Введите название " + i + " полудрагоценного камня");
					nameS = Convert.ToString(Console.ReadLine());
					Console.WriteLine("Введите стоимость");
					costs = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Введите массу в каратах");
					mass = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Введите параметр прозрачности");
					prozrach = Convert.ToDouble(Console.ReadLine());


					ExpStones[i] = new Expensive(nameS, costs, mass, prozrach);
					
				}
				

			}
			else
			{
				Console.WriteLine("Неверный ввод!");
				Console.ReadKey();
			
			}

		}
		
		//Методы
		public void Vivod()
		{
			if (vibor == 1)
			{
				for (int i = 0; i < ExpStones.Length; i++)
				{
					ExpStones[i].Print();
					Console.WriteLine(ExpStones[i]);
					
					fcost += ExpStones[i].Count();
					vcarat += ExpStones[i].MassCount();
				}
			}
			else if (vibor == 2)
			{
				for (int i = 0; i < SemiExpStones.Length; i++)
				{
					SemiExpStones[i].Print();
					Console.WriteLine(SemiExpStones[i]);
					
					fcost += SemiExpStones[i].Count();
					vcarat += SemiExpStones[i].MassCount();
				}
			}
			else if (vibor == 3)
			{
				
				for (int i = 0; i < ExpStones.Length; i++)
				{
					ExpStones[i].Print();
					Console.WriteLine(ExpStones[i]);
					
					fcost += ExpStones[i].Count();
					vcarat += ExpStones[i].MassCount();
				}
			}

		}
		public void Sort()
		{
			if (vibor == 1)
			{
				Array.Sort(ExpStones, new Comparison<Expensive>((a, b) => a.CostExp.CompareTo(b.CostExp)));
			}
			else if (vibor == 2)
			{
				Array.Sort(SemiExpStones, new Comparison<SemiExpens>((a, b) => a.CostSemi.CompareTo(b.CostSemi)));
			}
			else if (vibor == 3)
			{
				Array.Sort(ExpStones, new Comparison<Expensive>((a, b) => a.CostExp.CompareTo(b.CostExp)));
			}
		}

		public void Find(double prozrach)
		{
			if(vibor == 1)
			{
				for(int i=0; i<ExpStones.Length; i++)
				{
					if (ExpStones[i].Prozrach == prozrach)
					{
						ExpStones[i].Print();
						Console.WriteLine(ExpStones[i]);
						Console.WriteLine();
					}
				}
			}
			else if (vibor == 2)
			{
				for (int i = 0; i < SemiExpStones.Length; i++)
				{
					if (SemiExpStones[i].Prozrach == prozrach)
					{
						SemiExpStones[i].Print();
						Console.WriteLine(SemiExpStones[i]);
						Console.WriteLine();
					}
				}
			}
			else if (vibor == 3)
			{
				for (int i = 0; i < ExpStones.Length; i++)
				{
					if (ExpStones[i].Prozrach == prozrach)
					{
						ExpStones[i].Print();
						Console.WriteLine(ExpStones[i]);
						Console.WriteLine();
					}
				}
			}
		}

		public override string ToString()
		{
			return "Название ожирелья " + name + "\nСтоимость ожерелья " + cost + "\nВес ожерелья в каратах " + vcarat + "\nФактическая стоимость " + fcost;
		}
	}
}
