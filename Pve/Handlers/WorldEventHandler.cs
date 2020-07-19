using System;

namespace Pve.Handlers
{
    internal class WorldEventHandler : StateHandlerBase
    {
        public override void Execute()
        {
            Console.Clear();
            Console.WriteLine("You wandered in green meadows of foreign lands.");
            Console.WriteLine("Press any key to begin continue...");
            Console.ReadKey();
            World.CurrentState = World.MainHandlerInstance;
        }
    }
}