using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8
{
	interface IWarShip : IShip
	{
		void AirUp();
		void AirDown();
		void Battle();
	}
}
