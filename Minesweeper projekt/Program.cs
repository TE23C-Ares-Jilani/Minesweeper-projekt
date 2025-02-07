using System;
using Raylib_cs;

class Minesweeper
{
    static int rows = 16; // Number of rows
    static int cols = 16; // Number of columns
    static int cellSize = 40; // Size of each tile in pixels
    static bool[,] revealed = new bool[rows, cols]; // Track revealed tiles
    static void Main()
    {
        // Initialize a 640x480 window with the title "Minesweeper"
        Raylib.InitWindow(640, 640, "Minesweeper");
        Raylib.SetTargetFPS(60);

        while (!Raylib.WindowShouldClose()) // Main Game loop
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.RayWhite);
            DrawBoard(); // Draw the game Board
            Raylib.EndDrawing();
        }
        Raylib.CloseWindow(); // Close the window when the game loop ends
    }

    // Function to draw the game board 
    static void DrawBoard()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int x = j * cellSize; // X position of the tile
                int y = i * cellSize; // Y position of the tile

                // Draw tiles: hidden tiles are dark gray, revealed tiles are light gray
                Raylib.DrawRectangle(x, y, cellSize, cellSize, revealed[i, j] ? Color.LightGray : Color.Gray);

                // Draw grid lines to separate the tiles
                Raylib.DrawRectangleLines(x, y, cellSize, cellSize, Color.Black);
            }
        }
    }
}


