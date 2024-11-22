using System;
using System.Numerics;

namespace Game10003
{
    public class Audiofishing
    {
        //in your public class put Audiofishing af = new Audiofishing();
        Sound Splash;
        Sound Cast;
        public void Setup()
        {
            //Loading the Audio
            Splash = Audio.LoadSound("Assets/water-splash-80537.mp3");
            Cast = Audio.LoadSound("Assets/Fishing_rod_cast.ogg");
        }

        public void watersplash()//can be used to play Audio 
        {
            Audio.Play(Splash);
        }
        public void cast()
        {
            Audio.Play(Cast);
        }

    }
}
