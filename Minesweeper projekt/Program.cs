using System;
using Raylib_cs;

class Minesweeper
{
    static void Main()
    {
        // start window for game with dimentions and title
        Raylib.InitWindow(640, 480, "Minesweeper");
        Raylib.SetTargetFPS(60);

        while (!Raylib.WindowShouldClose()) // Main Game loop
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.RayWhite);
            Raylib.DrawText("Minesweeper Game", 10, 10, 20, Color.Black);
            Raylib.EndDrawing();
        }
        Raylib.CloseWindow(); // Close the window when the game loop exits
    }
}