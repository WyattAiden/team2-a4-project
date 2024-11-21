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
        //Ints
        int GameState;
        
        //Floats
        float FishBar;

        //Bools
        bool IsFishBarFull;

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
            GameState = 0;
            FishBar = 0;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(color: Color.LightGray);
            DrawFisherman();
            DrawScenery();
            //State Machine
            if (Input.IsKeyboardKeyPressed(KeyboardInput.Space))
            {
                if (GameState <= 2)
                {
                    GameState++;
                }

                else if (GameState == 3)
                {
                    GameState = 0;
                }
            }
            else if (GameState == 2 && IsFishBarFull)
            {
                GameState++;
            }
            else if (Input.IsKeyboardKeyPressed(KeyboardInput.Escape))
            {
                GameState = 0;
            }

            //Idle State Code Here
            if (GameState == 0)
            {

            }


            //Prepping State Code Here

            if (GameState == 1)
            {
                Draw.Rectangle(Line2.X, 320, 5, 10);
                if (Line2.X < 650 && Input.IsMouseButtonDown(MouseInput.Left))
                {
                    Line2.X += 1;
                }
                if (Line2.X > 400 && !Input.IsMouseButtonDown(MouseInput.Left))
                {
                    Line2.X -= 1;
                }
            }

            //Casting State Code Here

            if (GameState == 2)
            {
                DrawFishingLine();
                
            }

            //Display State Code Here
            if (GameState == 3)
            {

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
            Draw.LineColor = Color.Clear;
            Draw.Rectangle(300, 250, 50, 90);
        }
        
        public void DrawFishingLine()
        {
            if (GameState == 2)
            {
                Draw.LineColor = Color.White;
                Draw.LineSize = 2;
                Draw.Line(Line1, Line2);
            }
            
            
        }
    }
}
