using System;
using System.Numerics;

namespace Game10003
{
    public class Texturfishing
    {
        //Texturfishing tf = new Texturfishing();
        Texture2D FisherB;
        Texture2D FisherF;
        public Vector2 Fisherpos = new Vector2(225, 215);

       
        public void Setup()
        {
            //Loads the images 
            FisherF = Graphics.LoadTexture("Assets/FisherMan-front.png");
            FisherB = Graphics.LoadTexture("Assets/FisherMan-back.png");

            //tf.Setup();
            //tf.CastF(); where you need it
        }
       
        public void CastF()//Lets people use them
        {
            Graphics.Draw(FisherF, Fisherpos);
        }
        public void CastB()
        {
            
            Graphics.Draw(FisherB, Fisherpos);
        }
    }
}
