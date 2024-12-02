using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Game10003;

namespace Group2_A4_Fishing
{
    public class Fish
    {
        //Place Your Variables Here
        public int number;

        public void Setup()
        {
            //Set Array for Paths to Images
            string[] fishArray = { "Assets/Clam.png", "Assets/Crab.png", "Assets/Marlin.png", "Assets/Salmon.png", "Assets/Seahorse.png", "Assets/Shark.png", "Assets/Shrimp.png", "Assets/Siamese_Fighting_Fish.png", "Assets/SunFish.png", "Assets/Wahoo.png" };

            //Set Array for Amount of Textures in the Texture Array
            Texture2D[] texture = new Texture2D[10];

            for (int i = 0; i < 10; i++)
            {
                texture[i] = Graphics.LoadTexture(fishArray[1]);
            }
        }
        public void Update()
        {
            //Randomize Variable Number
            number = Random.Integer(0, 9);
        }
    }
}