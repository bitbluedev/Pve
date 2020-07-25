using Pve.GameEntity;
using Pve.GameEntity.Equipment;
using System;
using System.ComponentModel;

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
                    if (World.Player.Inventory.Count == 0)
                    {
                        Console.WriteLine("No items to equip.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                    }
                    else
                    {
                        EquipItem();
                    }
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

        private void EquipItem()
        {
            bool done;
            do
            {
                done = true;

                Console.Clear();
                Console.WriteLine("Equipment: ");
                if (World.Player.Weapon == null)
                {
                    Console.WriteLine("Weapon: NONE");
                }
                else
                {
                    Console.WriteLine("Weapon: " + World.Player.Weapon);
                }

                if (World.Player.Armor == null)
                {
                    Console.WriteLine("Armor: NONE");
                }
                else
                {
                    Console.WriteLine("Armor: " + World.Player.Armor);
                }
                Console.WriteLine();

                Console.WriteLine("What would you like to do?");
                for (int i = 0; i < World.Player.Inventory.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". Equip" + World.Player.Inventory[i]);
                }
                Console.WriteLine((World.Player.Inventory.Count + 1) + ". Back to " + Description);
                Console.Write(": ");

                string result = Console.ReadLine();
                if (int.TryParse(result, out int choice))
                {
                    if (choice > 0 && choice <= World.Player.Inventory.Count)
                    {
                        int index = choice - 1;
                        Item item = World.Player.Inventory[index];
                        World.Player.Inventory.RemoveAt(index);
                        if (item is Weapon)
                        {
                            if (World.Player.Weapon != null)
                            {
                                World.Player.Inventory.Add(World.Player.Weapon);
                            }
                            World.Player.Weapon = item as Weapon;
                        }
                        else
                        {
                            if (World.Player.Armor != null)
                            {
                                World.Player.Inventory.Add(World.Player.Armor);
                            }
                            World.Player.Armor = item as Armor;
                        }
                    }
                    else if (choice != World.Player.Inventory.Count + 1)
                    {
                        done = false;
                    }
                }
                else
                {
                    done = false;
                }
            } while (!done);
        }
    }
}