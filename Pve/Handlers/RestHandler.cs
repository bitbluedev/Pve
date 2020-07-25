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
            string playerDescription = World.Player.ToString();
            bool shouldHeal = World.Player.Health < World.Player.BaseMaxHealth;
            if (shouldHeal)
            {
                World.Player.Health = World.Player.BaseMaxHealth;
                playerDescription += " -> " + World.Player.ToString();
            }
            Console.Clear();
            Console.WriteLine(playerDescription);
            Console.WriteLine("You have rested.");
            if (shouldHeal)
            {
                Console.WriteLine("You are at full strength again.");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            World.CurrentState = World.MainHandlerInstance;
        }
    }
}