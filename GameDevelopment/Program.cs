﻿using System;

namespace GameDevelopment
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new Platformer())
                game.Run();
        }
    }
}
