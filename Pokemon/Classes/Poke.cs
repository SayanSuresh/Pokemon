using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon.Classes
{
	class Poke
	{
		// Base-stats
		private int hp_Base;

		public int HP_Base
		{
			get { return hp_Base; }
			set { hp_Base = value; }
		}
		private int attack_Base;

		public int Attack_Base
		{
			get { return attack_Base; }
			set { attack_Base = value; }
		}
		private int defence_Base;

		public int Defence_Base
		{
			get { return defence_Base; }
			set { defence_Base = value; }
		}
		private int specialAttack_Base;

		public int SpecialAttack_Base
		{
			get { return specialAttack_Base; }
			set { specialAttack_Base = value; }
		}
		private int specialDefence_Base;

		public int SpecialDefence_Base
		{
			get { return specialDefence_Base; }
			set { specialDefence_Base = value; }
		}
		private int speed_Base;

		public int Speed_Base
		{
			get { return speed_Base; }
			set { speed_Base = value; }
		}

		// Extra stats

		public string Naam { get; set; }
		public string Type { get; set; }
		public int NummerPoke { get; set; }

		// Level

		private int level;

		public int Level
		{
			get { return level; }
			private set { level = value; }
		}

		public void VerhoogLevel()
		{
			Level++;
		}

		// Statistieken

		public int Total
		{
			get
			{
				return
				HP_Base + Attack_Base + Defence_Base + SpecialAttack_Base + SpecialDefence_Base + Speed_Base;
			}
		}
		public double Average
		{
			get
			{
				return Total / 6.0;
			}
		}

		// Level-gebaseerde stats

		public double HP_FULL
		{
			get
			{
				return (((HP_Base + 50) * level) / 50) + 10;
			}
		}
		public int Attack_Full
		{
			get
			{
				return
			 ((Attack_Base * Level) / 50) + 5;
			}
		}
		public int Defence_Full
		{
			get
			{
				return
			 ((Defence_Base * Level) / 50) + 5;
			}
		}
		public int SpAttack_Full
		{
			get
			{
				return
			 ((SpecialAttack_Base * Level) / 50) + 5;
			}
		}
		public int SpDefence_Full
		{
			get
			{
				return
			 ((SpecialDefence_Base * Level) / 50) + 5;
			}
		}
		public int Speed_Full
		{
			get
			{
				return
			 ((Speed_Base * Level) / 50) + 5;
			}
		}

		public void ToonInfo()
		{
			Console.WriteLine($"#{NummerPoke} {Naam}");
			Console.WriteLine($"Type(s): {Type}");
			Console.WriteLine($"Lvl. {Level}");
			Console.WriteLine(HP_FULL + " Hp");
			Console.WriteLine(Attack_Full + " attack");
			Console.WriteLine(Defence_Full + " Defence");
			Console.WriteLine(SpAttack_Full + " SpAttack");
			Console.WriteLine(SpDefence_Full + " SpDefence");
			Console.WriteLine(Speed_Full + " Speed");
		}
	}
}
