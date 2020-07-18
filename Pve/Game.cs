using Pve.Handlers;

namespace Pve
{
    internal static class Game
    {
        public static void Run()
        {
            World.CurrentState = new NewGameHandler();
            do
            {
                World.CurrentState.Execute();
            } while (!World.Exit);
        }
    }
}