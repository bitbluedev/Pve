using Pve.GameEntity;
using Pve.Util;
using System;

namespace Pve.Handlers
{
    internal class AdventureHandler : StateHandlerBase
    {
        public AdventureHandler()
        {
            Description = "Go on Adventure.";
        }

        public override void Execute()
        {
            bool combat = true;
            World.Enemy = CreateRandomEnemy();
            if (combat)
            {
                Console.Clear();
                Console.WriteLine("You have encountered a hostile " + World.Enemy.Name);
                Console.WriteLine("Press any key to begin combat...");
                Console.ReadKey();
                World.CurrentState = World.CombatHandlerInstance;
            }
            else
            {
                World.CurrentState = World.WorldEventHandlerInstance;
            }
        }

        private Enemy CreateRandomEnemy()
        {
            /* 36-35 Giant  2/31
             * 34-27 Bear   8/31
             * 26-6  Dog   21/31
             * */
            int roll = Dice.RollMultipleDice(6);
            if (roll >= 35)
            {
                return new EnemyGiant();
            }
            else if (roll >= 27)
            {
                return new EnemyBear();
            }
            else
            {
                return new EnemyDog();
            }
        }
    }
}