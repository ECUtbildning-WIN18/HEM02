using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace HEM02.Domain
{
    class SoundSystem
    {
        public string Model { get; }
        public string SerialNumber { get; }
        bool IsOn { get; set; }
        bool IsPlaying { get; set; }

        public SoundSystem(string model, string serialNumber)
        {
            Model = model;
            SerialNumber = serialNumber;
        }

        public void TurnOnSoundSystem()
        {
            IsOn = true;
            Console.WriteLine("Soundsystem is starting...");
            Thread.Sleep(3000);
            Console.WriteLine("Soundsystem is now ready!");
        }

        public void MusicIsPlaying()
        {
            if(IsOn)
            IsPlaying = true;
            Console.WriteLine("The speakers are now blasting:\n Darude - Sandstorm");
        }

        public void MusicOff()
        {
            if(IsOn)
            IsPlaying = false;
            Console.WriteLine("Silence!");
        }

        public void TurnOffSoundSystem()
        {
            IsOn = false;
            Console.WriteLine("Soundsystem turned off!");
        }

        public void SoundSystemStatus()
        {
            if (IsOn)
                Console.WriteLine("Model:" + Model + "\n" + "Serialnumber:" + SerialNumber);
            else if(IsOn && IsPlaying)
                Console.WriteLine("Soundsystem is doing fine!\nMusic: There is a Sandstorm brewing!");
            else if(IsOn =! IsPlaying)
                Console.WriteLine("Soundsystem is doing fine!\nMusic: Dead silent!");
        }
    }
}
