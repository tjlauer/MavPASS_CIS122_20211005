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
	public abstract class Entity
	{
		// Variables
		private int id = -1;
		private string name = "n/a";
		private int health = -1;
		private string type = "n/a";
		private int armor = 0;
		private int damage = 0;

		// Properties (Gets and Sets)
		public int Id { get { return this.id; } set { this.id = value; } }
		public string Name { get { return this.name; } set { this.name = value; } }
		public int Health { get { return this.health; } set { this.health = value; } }
		public string Type { get { return this.type; } set { this.type = value; } }
		public int Armor { get { return this.armor; } set { this.armor = value; } }
		public int Damage { get { return this.damage; } set { this.damage = value; } }

		// Constructors
		public Entity() : this(-1, "n/a", -1, "n/a", 0, 0) { }

		public Entity(int aId, string aName, int aHealth, string aType, int anArmor, int aDamage)
		{
			this.Id = aId;
			this.Name = aName;
			this.Health = aHealth;
			this.Type = aType;
			this.Armor = anArmor;
			this.Damage = aDamage;
		}

		// Methods
		public override string ToString()
		{
			string msg = "";
			msg += "Id: " + this.Id + "\n";
			msg += "Name: " + this.Name + "\n";
			msg += "Health: " + this.Health + "\n";
			msg += "Type: " + this.Type + "\n";
			msg += "Armor: " + this.Armor + "\n";
			msg += "Damage: " + this.Damage + "\n";
			return msg;
		}
	}
}
