using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pve.GameEntity
{
    abstract class Enemy
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
