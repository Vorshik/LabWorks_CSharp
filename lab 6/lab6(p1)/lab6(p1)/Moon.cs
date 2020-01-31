using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_p1_
{
	class Moon
	{
		private string nameMoon;
		private double mass;
		private string shape;

		public string NameMoon
		{
			get { return nameMoon; }
			set { nameMoon = value; }
		}
		public double Mass
		{
			get { return mass; }
			set { mass = value; }
		}
		public string Shape
		{
			get { return shape; }
			set { shape = value; }
		}

		public Moon(string nameMoon, double mass, string shape)
		{
			this.nameMoon = nameMoon;
			this.mass = mass;
			this.shape = shape;
		}

		public override string ToString()
		{
			return "Имя cпутника " + nameMoon + "\nМасса луны " + mass + "\nФорма луны " + shape;
		}
	}
}
