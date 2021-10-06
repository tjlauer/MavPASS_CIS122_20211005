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
	public class Program
	{
		public static void Main(string[] args)
		{
			// Create a list of type "IAction" called "aListOfActions"
			List<IAction> aListOfActions = new List<IAction>();

			// Add 1 Player to the list
			aListOfActions.Add(new Player(1, "Joe", 100, 2, 15)); // Id = 1, Name = "Joe", Health = 100, Armor = 2, Damage = 15
			
			// Add 3 Monsters to the list
			aListOfActions.Add(new Monster(2, "Monster1", 30, 1, 3)); // Id = 2, Name = "Monster1", Health = 30, Armor = 1, Damage = 2
			aListOfActions.Add(new Monster(3, "Monster2", 30, 1, 3)); // Id = 3, Name = "Monster2", Health = 30, Armor = 1, Damage = 2
			aListOfActions.Add(new Monster(4, "Monster3", 30, 1, 3)); // Id = 4, Name = "Monster3", Health = 30, Armor = 1, Damage = 2
			
			// Add 5 Animals to the list
			aListOfActions.Add(new Animal(5, "Animal1", 5, 0, 1)); // Id = 5, Name = "Animal1", Health = 5, Armor = 0, Damage = 1
			aListOfActions.Add(new Animal(6, "Animal2", 5, 0, 1)); // Id = 6, Name = "Animal2", Health = 5, Armor = 0, Damage = 1
			aListOfActions.Add(new Animal(7, "Animal3", 5, 0, 1)); // Id = 7, Name = "Animal3", Health = 5, Armor = 0, Damage = 1
			aListOfActions.Add(new Animal(8, "Animal4", 5, 0, 1)); // Id = 8, Name = "Animal4", Health = 5, Armor = 0, Damage = 1
			aListOfActions.Add(new Animal(9, "Animal5", 5, 0, 1)); // Id = 9, Name = "Animal5", Health = 5, Armor = 0, Damage = 1

			// Loop through the list and write each object to the console
			foreach(IAction a in aListOfActions) { Console.WriteLine(a.ToString()); }

			// Prevent the console from closing
			Console.ReadLine();
		}
	}
}
