using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HelloWorld
{
    class Sound
    {
        private string partialURL = "https://www.google.com/logos/fnbx/animal_sounds/";
        private string completeURL;
        public void MakeNoise(Animal animal)
        {
            completeURL = partialURL + animal.Name().ToLower() + ".mp3";
            var sound = new WMPLib.WindowsMediaPlayer();
            sound.URL = completeURL;
            Console.WriteLine(string.Format("{0} makes {1}", animal.Name(), animal.Noise()));
            Thread.Sleep(2500);
        }
    }
}
