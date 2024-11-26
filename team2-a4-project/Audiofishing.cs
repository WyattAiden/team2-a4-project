using System;
using System.Numerics;

namespace Game10003
{
    public class Audiofishing
    {
        //in your public class put Audiofishing af = new Audiofishing();
        Sound Splash;
        Sound Cast;
        Music mucast;
        public void Setup()
        {
            //Loading the Audio
            Splash = Audio.LoadSound("Assets/water-splash-80537.mp3");
            Cast = Audio.LoadSound("Assets/Fishing_rod_cast.ogg");
            mucast =Audio.LoadMusic("Assets/StockTune-Angler's Anthem_1732650117.mp3");
            Audio.SetPan(Cast, 1);
            Audio.SetPan(Splash, 0);
        }

        public void watersplash()//can be used to play Audio 
        {
            Audio.Play(Splash);
            
        }
        public void cast()
        {
            Audio.Play(Cast);
        }
        public void music()
        {
            Audio.Play(mucast);
        }

    }
}
