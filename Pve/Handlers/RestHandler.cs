using System;

namespace Pve.Handlers
{
    internal class RestHandler : StateHandlerBase
    {
        public RestHandler()
        {
            Description = "Rest.";
        }

        public override void Execute()
        {
            Console.Clear();
            Console.WriteLine("You have rested.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            World.CurrentState = World.MainHandlerInstance;
        }
    }
}