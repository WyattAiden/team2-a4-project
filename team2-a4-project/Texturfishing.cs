using System;
using System.Numerics;

namespace Game10003
{
    public class Texturfishing
    {
        Texture2D FisherB;
        Texture2D FisherF;
        public Vector2 Fisherpos = new Vector2(250, 300);

       
        public void Setup()
        {
            FisherF = Graphics.LoadTexture("Assets/FisherMan-front.png");
            FisherB = Graphics.LoadTexture("Assets/FisherMan-back.png");

        }
       
        public void CastF()
        {
            Graphics.Draw(FisherF, Fisherpos);
        }
        public void CastB()
        {
            
            Graphics.Draw(FisherB, Fisherpos);
        }
    }
}
