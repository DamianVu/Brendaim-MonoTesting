using System;

namespace Brendaim
{
#if WINDOWS || LINUX

    public static class Program
    {

        [STAThread]
        static void Main()
        {
            using (var game = new Brendaim())
                game.Run();
        }
    }
#endif
}
