using Pve.GameEntity;
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
            return new EnemyDog();
        }
    }
}