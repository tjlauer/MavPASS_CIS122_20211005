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
	public sealed class Player : Entity, IAction
	{
		// Constructors
		public Player() : base(-1, "n/a", -1, "Player", 0, 0) { }
		public Player(int aId, string aName, int aHealth, int anArmor, int aDamage)
			: base(aId, aName, aHealth, "Player", anArmor, aDamage) { }

		// Methods
		public Entity Attack(Entity e)
		{
			int damageDealt = -e.Armor;
			if (damageDealt < 0) { damageDealt = 0; }
			e.Health -= this.Damage;
			return e;
		}

		public override string ToString()
		{
			string msg = "PLAYER\n";
			msg += base.ToString();
			return msg;
		}
	}
}
