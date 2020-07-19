using System;

namespace Pve.Handlers
{
    internal class MainHandler : StateHandlerBase
    {
        public override void Execute()
        {
            bool done = true;
            do
            {
                Console.Clear();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. " + World.ExitHandlerInstance.Description);
                Console.Write(": ");
                string result = Console.ReadLine();
            } while (!done);
        }
    }
}