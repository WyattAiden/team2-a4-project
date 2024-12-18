﻿// Include code libraries you need below (use the namespace).
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
        int FishTimer;
        
        //Floats
        float FishBar;

        //Bools
        bool IsFishBarFull;

        //Custom Colors
        Color VeryLightBlue = new Color(225, 225, 255);
        Color Brown = new Color(100, 100, 50);
        Color DarkGreen = new Color(100, 200, 100);
        Color BackgroundGray = new Color(175, 175, 175);

        //Vectors
        Vector2 Line1 = new Vector2(339, 242);
        Vector2 Line2 = new Vector2(400, 350);

        Vector2 Bar1 = new Vector2(165, 250);
        Vector2 Bar2 = new Vector2(165, 250);

        //Texture Portal
        Texturfishing tf = new Texturfishing();

        //Audio Portal
        Audiofishing af = new Audiofishing();


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Fishing");
            Window.SetSize(800, 600);
            GameState = 0;
            FishBar = 250;
            FishTimer = Random.Integer(0, 300);
            tf.Setup();
            af.Setup();
            af.music();
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(color: Color.LightGray);
            
            DrawScenery();
            //State Machine
            if (Input.IsKeyboardKeyPressed(KeyboardInput.Space))
            {
                if (GameState <= 1)
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
                Bar2.Y = 250;
                FishTimer = Random.Integer(0, 300);
            }
            else if (Input.IsKeyboardKeyPressed(KeyboardInput.R))
            {
                GameState = 0;
                FishTimer = Random.Integer(0, 300);
            }

            //Idle State Code Here
            if (GameState == 0)
            {
                tf.CastB();
            }


            //Prepping State Code Here

            if (GameState == 1)
            {
                //Sounds here
                af.watersplash();
                af.cast();

                //Fisherman Texture Here
                tf.CastB();

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
                //Sounds Here
                af.watersplash();

                //Fisherman Texture Here
                tf.CastF();

                //Fishing Line Here
                DrawFishingLine();
                FishTimer++;
                if (FishTimer >= 350)
                {
                    FishBar = Bar2.Y;
                    
                    if (Bar2.Y <= 250 && !Input.IsMouseButtonPressed(MouseInput.Left))
                    {
                        Bar2.Y += 1;
                    }
                    else if (Bar2.Y >= 99 && Input.IsMouseButtonPressed(MouseInput.Left))
                    {
                        {
                            Bar2.Y -= 20;
                        }
                    }
                    if (FishBar <= 100)
                    {
                        IsFishBarFull = true;
                    }
                    Draw.LineColor = Color.Gray;
                    Draw.FillColor = BackgroundGray;
                    Draw.Rectangle(150, 80, 30, 180);
                    Draw.LineColor = Color.Red;
                    Draw.LineSize = 10;
                    Draw.Line(Bar1, Bar2);
                }
                
            }

            //Display State Code Here
            if (GameState == 3)
            {
                tf.CastB();
                Draw.LineSize = 3;
                Draw.LineColor = Color.Gray;
                Draw.FillColor = BackgroundGray;
                Draw.Rectangle(500, 80, 220, 220);
            }

            //Reset Bool
            if (GameState != 2)
            {
                IsFishBarFull = false;
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
