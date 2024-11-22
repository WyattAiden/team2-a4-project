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
        // Place your variables here:
        Texturfishing tf = new Texturfishing();
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Fishing");
            Window.SetSize(800, 600);
            tf.Setup();
            
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(color: Color.White);
            DrawScenery();
            tf.CastF();
        }
        public void DrawScenery()
        {

        }
        public void DrawFisherman()
        {
            
        }
    }
}
