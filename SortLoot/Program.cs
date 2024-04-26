using System;
using System.Collections.Generic;

namespace SortLoot
{
    public class Program
    {
        private static void Main()
        {
            // We'll use this list later to keep the loot
            List<Loot> lootList = new List<Loot>();

            // Add various loot to the set
            lootList.Add(new Loot(LootType.Ammo, "Average 30mm rounds", 12.5f));
            lootList.Add(new Loot(LootType.Collectible, "Unique ruby", 500f));
            lootList.Add(new Loot(LootType.Health, "Powerup +50HP", 7.5f));
            lootList.Add(new Loot(LootType.Shield, "Powerup +75AP", 42.5f));
            lootList.Add(new Loot(LootType.Weapon, "Colt Revolver", 83.75f));
            lootList.Add(new Loot(LootType.Ammo, "Powerful 45mm rounds", 12.5f));
            lootList.Add(new Loot(LootType.Ammo, "Weaker 25mm rounds", 12.5f));
            lootList.Add(new Loot(LootType.Shield, "Powerup +75AP", 42.5f));
            lootList.Add(new Loot(LootType.Weapon, "Colt Revolver", 83.75f));
            lootList.Add(new Loot(LootType.Shield, "Powerup +25AP", 21.25f));
            lootList.Add(new Loot(LootType.Weapon, "Colt Revolver", 67.25f));
            lootList.Add(null);

            // Sort the list
            // This will fail if the Loot class doesn't implement IComparable<Loot>)
            lootList.Sort();

            // Print the contents of the sorted loot list
            foreach (Loot loot in lootList)
            {
                // This will implicitly call loot.ToString()
                Console.WriteLine(loot);
            }

            // Expected output:
            //
            // [    Collectible]	500.00	Unique ruby
            // [         Weapon]	83.75	Colt Revolver
            // [         Weapon]	83.75	Colt Revolver
            // [         Weapon]	67.25	Colt Revolver
            // [         Shield]	42.50	Powerup +75AP
            // [         Shield]	42.50	Powerup +75AP
            // [         Shield]	21.25	Powerup +25AP
            // [           Ammo]	12.50	Average 30mm rounds
            // [           Ammo]	12.50	Powerful 45mm rounds
            // [           Ammo]	12.50	Weaker 25mm rounds
            // [         Health]	7.50	Powerup +50HP

        }
    }
}
