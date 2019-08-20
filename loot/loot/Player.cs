using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loot
{
    class Player
    {
        public Player()
        {
            MaxHealth = 15;
            Health = 15;
            Gold = 0;
            Level = 1;
            Experience = 0;
            Equipped = "sword";
            Hometown = "";
            FirstName = "";
            LastName = "";
            Gender = "";
        }

        public int Health { get; set; }

        public int Gold { get; set; }

        public int MaxHealth { get; set; }

        public int Level { get; set; }

        public int Experience { get; set; }

        public string Equipped { get; set; }

        public string Gender { get; set; }

        public string Hometown { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public static void Die()
        {
            Console.WriteLine("Your days of adventuring are cut short as you collapse to the floor.");
            if(Program.currentDepth <= 10)
                Console.WriteLine("And at the very beginning of the exploration, too.\n\n");
            Console.WriteLine("Press enter to continue.");
            Console.Read();
            Program.MainMenu();
        }
    }
}
