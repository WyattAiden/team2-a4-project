using System;
using System.Numerics;

namespace Game10003
{
    public class Audiofishing
    {
        Sound Splash;
        public void Setup()
        {
            Splash = Audio.LoadSound("Assets/water-splash-80537.mp3");

        }

        public void watersplash()
        {
            Audio.Play(Splash);
        }

    }
}
