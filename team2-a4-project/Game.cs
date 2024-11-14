// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        //Custom Colors
        Color VeryLightBlue = new Color(225, 225, 255);
        Color Brown = new Color(100, 100, 50);
        Color DarkGreen = new Color(100, 200, 100);
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Fishing");
            Window.SetSize(800, 600);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(color: Color.LightGray);
            DrawFisherman();
            DrawScenery();
        }
        public void DrawScenery()
        {
            Draw.FillColor = Color.Blue;
            Draw.LineColor = Color.Clear;
            Draw.Rectangle(0, 350, 800, 250);
            Draw.FillColor = VeryLightBlue;
            Draw.Rectangle(0, 350, 800, 3);
            Draw.FillColor = DarkGreen;
            Draw.Rectangle(0, 340, 150, 360);
            Draw.FillColor = Brown;
            Draw.Rectangle(150, 340, 200, 5);
        }
        public void DrawFisherman()
        {
            Draw.FillColor = Color.Red;
            Draw.Square(40, 300, 40);
        }
    }
}
