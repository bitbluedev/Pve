namespace Pve.GameEntity
{
    internal abstract class Enemy
    {
        public Enemy(int attack, int defense, int health)
        {
            Attack = attack;
            Defense = defense;
            Health = health;
        }

        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Health { get; set; }
    }
}