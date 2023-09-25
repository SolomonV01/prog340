using System;
using static System.Console;

namespace Vidal_DungeonCrawler
{
	public class Player
	{
		public string name { get; set; }
		public int shiftLvl { get; set; }
		public int shifter = 3;

        public Player(string _name, int shiftLvl)
		{
			name = _name;
			_name = ReadLine();
			shiftLvl = 0;
		}

        public Player(string? name)
        {
            this.name = name;
        }
    }
}

