namespace Pve.GameEntity
{
    internal class Player
    {
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }

        public Player()
        {
            Attack = 10;
            Defense = 10;
            Health = 30;
            MaxHealth = 30;
        }

        public override string ToString()
        {
            return "Player [ATTACK: " + Attack + " DEFENSE: " + Defense + " HEALTH: " + Health + "/" + MaxHealth + "]";
        }
    }
}