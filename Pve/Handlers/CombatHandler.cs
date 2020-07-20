using Pve.Util;
using System;

namespace Pve.Handlers
{
    internal class CombatHandler : StateHandlerBase
    {
        Random random = new Random();
        public override void Execute()
        {
            Console.Clear();
            int turn = 1;
            while (World.Player.Health >= 0 && World.Enemy.Health >= 0)
            {
                Console.WriteLine("Turn #" + turn++);
                Console.WriteLine(World.Player.ToString());
                Console.WriteLine("Enemy: " + World.Enemy.ToString());
                DoCombatTurn();
            }

            bool victory = World.Player.Health > 0;

            if (victory)
            {
                Console.WriteLine("You have won.");
                DoLoot();
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

        private void DoLoot()
        {
            // TODO : implementation
            return;
        }

        private void DoCombatTurn()
        {
            int playerAttackRoll = Dice.RollMultipleDice(2) + Dice.RollCrit(1, 100);
            int enemyAttackRoll = Dice.RollMultipleDice(2) + Dice.RollCrit(85, 100);
            int playerAttack = World.Player.Attack + playerAttackRoll;
            int enemyAttack = World.Enemy.Attack + enemyAttackRoll;

            Console.WriteLine("Player Attack Power: " + World.Player.Attack + "+" + playerAttackRoll + " -> " + playerAttack);
            Console.WriteLine("Enemy Attack Power:  " + World.Enemy.Attack + "+" + enemyAttackRoll + " -> " + enemyAttack);
            if (playerAttack > enemyAttack)
            {
                int damage = Math.Max(0, World.Player.Attack - World.Enemy.Defense) + Dice.RollCrit(20, 5);
                World.Enemy.Health -= damage;
                Console.WriteLine("Player attacks " + World.Enemy.Name + ". " + World.Enemy.Name + " takes " + damage + " damage.");
            }
            else
            {
                int damage = Math.Max(0, World.Enemy.Attack - World.Player.Defense) + Dice.RollCrit(20, 5);
                World.Player.Health -= damage;
                Console.WriteLine(World.Enemy.Name + " attacks Player. Player takes " + damage + " damage.");
            }
        }
    }
}