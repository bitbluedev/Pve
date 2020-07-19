using System;

namespace Pve.Handlers
{
    internal class InventoryHandler : StateHandlerBase
    {
        public InventoryHandler()
        {
            Description = "Manage Inventory.";
        }
        public override void Execute()
        {
            bool done;
            do
            {
                done = true;

                Console.Clear();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Equip Item.");
                Console.WriteLine("2. Unequip Item.");
                Console.WriteLine("3. Continue Adventure.");
                Console.WriteLine("4. " + World.ExitHandlerInstance.Description);
                Console.Write(": ");
                string result = Console.ReadLine();
                if (result == "1")
                {
                    Console.WriteLine("No items to equip.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (result == "2")
                {
                    Console.WriteLine("No items to unequip.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (result == "3")
                {
                    World.CurrentState = World.MainHandlerInstance;
                }
                else if (result == "4")
                {
                    World.CurrentState = World.ExitHandlerInstance;
                }
                else
                {
                    done = false;
                }
            } while (!done);
        }
    }
}