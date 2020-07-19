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
            if (combat)
            {
                Console.Clear();
                Console.WriteLine("You have encountered an enemy.");
                Console.WriteLine("Press any key to begin combat...");
                Console.ReadKey();
                World.CurrentState = World.CombatHandlerInstance;
            }
            else
            {
                World.CurrentState = World.WorldEventHandlerInstance;
            }
        }
    }
}