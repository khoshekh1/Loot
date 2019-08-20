using System;

namespace loot
{
    class Enemy
    {
        private int health;
        private string name;

        public Enemy()
        {
            Health = 0;
            for(int i = 0; i <= Program.player.Level; i++)
            {
                Health += (Program.RollDice(8)*Program.player.Level);
            }

            if (Health >= 50) Name = "Dragon";
            else if (Health <= 49 && Health >= 40) Name = "Orc";
            else if (Health <= 39 && Health >= 25) Name = "Skeleton";
            else if (Health <= 24 && Health >= 15) Name = "Goblin";
            else Name = "Spider";
        }

        public static void Die()
        {
            Console.WriteLine("The enemy is defeated!\n");
            Program.ObtainGold();
            Program.enemiesSlain++;
            Program.ObtainEXP();
            Prompt.PromptUser();
        }

        public int Health { get; set; }
        public string Name { get; set; }
    }
}
