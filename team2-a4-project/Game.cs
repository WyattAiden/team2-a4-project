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
        //Bools
        bool IsCasting;
        
        //Custom Colors
        Color VeryLightBlue = new Color(225, 225, 255);
        Color Brown = new Color(100, 100, 50);
        Color DarkGreen = new Color(100, 200, 100);

        //Fishing Line Vectors
        Vector2 Line1 = new Vector2(350, 280);
        Vector2 Line2 = new Vector2(400, 350);
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
            DrawFishingLine();
            DrawScenery();

            
            if (Input.IsKeyboardKeyDown(KeyboardInput.Space))
            {
                IsCasting = true;
            }

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
            Draw.Rectangle(300, 250, 50, 90);
        }
        
        public void DrawFishingLine()
        {
            if (IsCasting)
            {
                Draw.LineColor = Color.White;
                Draw.LineSize = 2;
                Draw.Line(Line1, Line2);
            }
            if (IsCasting && Line2.X > 400 && !Input.IsMouseButtonDown(MouseInput.Left))
            {
                Line2.X -= 1;
            }
            if (IsCasting && Line2.X < 650 && Input.IsMouseButtonDown(MouseInput.Left))
            {
                Line2.X += 1;
            }

            
        }
    }
}
