using System;
using System.Collections.Generic;

namespace NeneQuest
{
    internal class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new NeneQuest())
                game.Run();
        }
    }
}