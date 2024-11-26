using System;
using System.Numerics;

namespace Game10003
{
    public class Texturfishing
    {
        //Texturfishing tf = new Texturfishing();
        Texture2D FisherB;
        Texture2D FisherF;
        Texture2D Fish1;
        Texture2D Fish2;
        Texture2D Fish3;
        Texture2D Fish4;
        Texture2D Fish5;
        Texture2D Fish6;
        Texture2D Fish7;   
        Texture2D Fish8;
        Texture2D Fish9;
        Texture2D Fish10;
        public Vector2 Fisherpos = new Vector2(250, 300);

        public Vector2 Fisherpos = new Vector2(225, 215);

       
        public void Setup()
        {
            //Loads the images 
            FisherF = Graphics.LoadTexture("Assets/FisherMan-forward.png");
            FisherB = Graphics.LoadTexture("Assets/FisherMan-back.png");
            Fish1 = Graphics.LoadTexture("Assets/Clam.png");
            Fish2 = Graphics.LoadTexture("Assets/Crab.png");
            Fish3 = Graphics.LoadTexture("Assets/Marlin.png");
            Fish4 = Graphics.LoadTexture("Assets/Salmon.png");
            Fish5 = Graphics.LoadTexture("Assets/Seahorse.png");
            Fish6 = Graphics.LoadTexture("Assets/Shark.png");
            Fish7 = Graphics.LoadTexture("Assets/Shrimp.png");
            Fish8 = Graphics.LoadTexture("Assets/Siamese_Fighting_Fish.png");
            Fish9 = Graphics.LoadTexture("Assets/Sonfish.png");
            Fish10 = Graphics.LoadTexture("Assets/Wahoo.png");

            //tf.Setup();
            //tf.CastF(); where you need it
        }
       
        public void CastF()//Lets people use them
        {
            Graphics.Draw(FisherF, Fisherpos);
        }
        public void CastB()
        {
            
            Graphics.Draw(FisherB, 225,215);
        }
        public void Clam()
        {
            Graphics.Draw(Fish1,500,100);
        }
        public void Crab()
        {
            Graphics.Draw(Fish2, 500, 100);
        }
        public void Marlin()
        {
            Graphics.Draw(Fish3, 500, 100);
        }
        public void Salmon()
        {
            Graphics.Draw(Fish4, 500, 100);
        }
        public void Seahorse()
        {
            Graphics.Draw(Fish5, 500, 100);
        }
        public void Shark()
        {
            Graphics.Draw(Fish6, 500, 100);
        }
        public void Shrimp()
        {
            Graphics.Draw(Fish7, 500, 100);
        }
        public void Fightingfish()
        {
            Graphics.Draw(Fish8, 500, 100);
        }
        public void Sunfish()
        {
            Graphics.Draw(Fish9, 500, 100);
        }
        public void Wahoo()
        {
            Graphics.Draw(Fish10, 500, 100);
        }
    }
}
