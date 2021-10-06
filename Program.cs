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
			List<IAction> aListOfActions = new List<IAction>();

			aListOfActions.Add(new Player(1, "Joe", 100, 2, 15));
			aListOfActions.Add(new Monster(2, "Monster1", 30, 1, 3));
			aListOfActions.Add(new Monster(3, "Monster2", 30, 1, 3));
			aListOfActions.Add(new Monster(4, "Monster3", 30, 1, 3));
			aListOfActions.Add(new Animal(5, "Animal1", 5, 0, 1));
			aListOfActions.Add(new Animal(6, "Animal2", 5, 0, 1));
			aListOfActions.Add(new Animal(7, "Animal3", 5, 0, 1));
			aListOfActions.Add(new Animal(8, "Animal4", 5, 0, 1));
			aListOfActions.Add(new Animal(9, "Animal5", 5, 0, 1));

			foreach(IAction a in aListOfActions)
			{
				Console.WriteLine(a.ToString());
			}

			Console.ReadLine();
		}
	}
}
