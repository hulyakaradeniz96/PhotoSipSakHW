using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoSipSakHW
{
    internal class Drone:CameraBase
    {
        public Drone(int id, string brand, Battery battery) : base(id, brand, battery)
        {
        }

        public override void TakePhoto(int shotCount, string place)
        {

            if (ShotCount > shotCount)
            {
                for (int i = 0; i < shotCount; i++)
                {
                    Console.WriteLine($"{place} => {i + 1}. kare dronedan çekiliyor..");
                    ShotCount--;
                    Battery.BatteryPercentage-=5; //Fotoğraf çekince drone'un şarjı çabuk bitsin
                }

            }
            else
            {
                Console.WriteLine($"Kalan Kare Sayısı:{ShotCount}. Fotoğraf çekemiyorum ");
            }
        }

        public override string ToString()
        {
            return $"Droneda {ShotCount} kare, %{Battery.BatteryPercentage} şarj kaldı.";
        }
    }
}
