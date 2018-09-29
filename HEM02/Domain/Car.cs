using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02.Domain
{
    class Car
    {
        public string Brand { get; }
        public string Model { get; }
        public Engine Engine { get; }
        public Person Owner { get; }
        public SoundSystem SoundSystem { get; }

        public Car(string brand, string model, Engine engine, Person owner, SoundSystem soundSystem)
        {
            Brand = brand;
            Model = model;
            Engine = engine;
            Owner = owner;
            SoundSystem = soundSystem;
        }

        public void StartButton()
        {
            Engine.StartEngine();
            SoundSystem.TurnOnSoundSystem();
        }

        public void PlayMusic()
        {
            SoundSystem.MusicIsPlaying();
        }

        public void TurnOffMusic()
        {
            SoundSystem.MusicOff();
        }

        public void Accelerate()
        {
            Engine.IncreaseOutput();
        }

        public void Brake()
        {
            Engine.DecreaseOutput();
        }

        public void ButtonLSpeed()
        {
            Engine.LudicrousSpeed();
        }

        public void OffButton()
        {
            SoundSystem.TurnOffSoundSystem();
            Engine.StopEngine();
        }

        public void StatusCheck()
        {
            Engine.PrintEngineInfo();
            Owner.CarOwner();
            SoundSystem.SoundSystemStatus();
        }
    }
}
