using System;

namespace Pve.Handlers
{
    internal class CombatHandler : StateHandlerBase
    {
        public override void Execute()
        {
            bool victory = true;
            Console.Clear();
            if (victory)
            {
                Console.WriteLine("You have won.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                World.CurrentState = World.MainHandlerInstance;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You have lost. Your adventure ends here.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                World.CurrentState = World.NewGameHandlerInstance;
            }
        }
    }
}