using System;
using Raylib_cs;

class Program
{
    static int rows = 16; // Number of rows in the Minesweeper grid
    static int cols = 16; // Number of columns in the Minesweeper grid
    static int cellSize = 40; // Size of each tile
    static bool[,] revealed = new bool[rows, cols]; // Track revealed tiles

    static void Main()
    {
        // Initialize a window with the grid size
        Raylib.InitWindow(cols * cellSize, rows * cellSize + 50, "Minesweeper");
        Raylib.SetTargetFPS(60); // Set frame rate to 60 FPS

        while (!Raylib.WindowShouldClose()) // Main game loop
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.RayWhite);

            // Draw game board
            DrawBoard();

            // Draw game title text below the grid
            Raylib.DrawText("Minesweeper Game", 10, rows * cellSize + 10, 20, Color.Black);

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow(); // Close the window when the loop ends
    }

    // Function to draw the Minesweeper grid
    static void DrawBoard()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int x = j * cellSize; // X position of the tile
                int y = i * cellSize; // Y position of the tile
                
                // Draw a rectangle for each tile
                Raylib.DrawRectangle(x, y, cellSize, cellSize, revealed[i, j] ? Color.LightGray : Color.Gray);

                // Draw grid lines to separate the tiles (make them white for visibility)
                Raylib.DrawRectangleLines(x, y, cellSize, cellSize, Color.White);
            }
        }
    }
}
