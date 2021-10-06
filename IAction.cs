// Thomas J. Lauer
// CIS 122 MavPASS Exam Session
// October 05, 2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavPASS_CIS122_20211005
{
	public interface IAction
	{
		// Properties (Gets and Sets)
		int Armor { get; set; }
		int Damage { get; set; }
		int Health { get; set; }

		// Methods
		Entity Attack(Entity e);
	}
}
