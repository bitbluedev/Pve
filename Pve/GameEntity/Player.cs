using System.Collections.Generic;

namespace Pve.GameEntity
{
    internal class Player
    {
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int Level { get; set; }
        public int Weapon { get; set; }
        public int Armor { get; set; }
        public List<Item> Inventory { get; set; }

        public Player()
        {
            Attack = 10;
            Defense = 10;
            Health = 25;
            MaxHealth = 30;
            Level = 1;
            Inventory = new List<Item>();
        }

        public override string ToString()
        {
            return "Player [ATTACK: " + Attack + " DEFENSE: " + Defense + " HEALTH: " + Health + "/" + MaxHealth + "]";
        }
    }
}