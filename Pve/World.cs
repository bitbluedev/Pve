using Pve.Handlers;

namespace Pve
{
    internal static class World
    {
        static World()
        {
            World.NewGameHandlerInstance = new NewGameHandler();
            World.ExitHandlerInstance = new ExitHandler();
            World.MainHandlerInstance = new MainHandler();
        }

        public static StateHandlerBase CurrentState { get; set; }
        public static bool Exit { get; set; }

        #region handlers

        public static ExitHandler ExitHandlerInstance { get; set; }
        public static NewGameHandler NewGameHandlerInstance { get; set; }

        public static MainHandler MainHandlerInstance { get; set; }

        #endregion handlers
    }
}