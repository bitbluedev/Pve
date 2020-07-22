using Pve.GameEntity;
using System.Collections.Generic;

namespace Pve.Util
{
    class LootGenerator
    {
        public static List<Item> GenerateLootItems(int enemyLevel)
        {
            int numberOfItems = Dice.Roll() > 3 ? 1 : 0;
            for (int i = 2; i <= enemyLevel; i++)
            {
                numberOfItems += Dice.Roll() > 3 ? 1 : 0;
            }
            List<Item> loot = new List<Item>(numberOfItems);

            for (int i = 0; i < numberOfItems; i++)
            {
                Item item = GenerateItem();
                loot.Add(item);
            }
            return loot;
        }

        private static Item GenerateItem()
        {
            if (Dice.Roll() > 3)
            {
                return new Weapon();
            }
            else
            {
                return new Armor();
            }
        }
    }
}
