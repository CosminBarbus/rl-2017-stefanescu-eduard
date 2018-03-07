using HelloWorld.BussinessLogic;
using System;
using System.Threading;

namespace HelloWorld.ConsoleUI
{
    internal static class AnimalSound
    {
        private static string _partialURL = "https://www.google.com/logos/fnbx/animal_sounds/";
        private static string _completeURL;
        public static void MakeNoise(IAnimal animal)
        {
            _completeURL = _partialURL + animal.Name().ToLower() + ".mp3";
            var sound = new WMPLib.WindowsMediaPlayer { URL = _completeURL };
            Console.WriteLine($"{animal.Name()} makes {animal.Noise()}");
            Thread.Sleep(2500);
        }
    }
}
