using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoSipSakHW
{
    internal class PhotografMachine : CameraBase, IFlash
    {
        public PhotografMachine(int id, string brand, Battery battery) : base(id, brand, battery)
        {
        }

        public void TakePhotoWithFlash(int shotCount, string place)
        {
            if (ShotCount > shotCount)
            {
                for (int i = 0; i < shotCount; i++)
                {
                    Console.WriteLine($"{place} => {i + 1}. kare flaş ile fotoğraf makinasıyla çekiliyor..");
                    ShotCount--;
                    Battery.BatteryPercentage -= 3;
                }

            }
            else
            {
                Console.WriteLine($"Kalan Kare Sayısı:{ShotCount}. Flaşla fotoğraf çekemiyorum ");
            }

        }

        public override string ToString()
        {
            return $"Fotoğraf Makinasında {ShotCount} kare, %{Battery.BatteryPercentage} şarj kaldı.";
        }
    }
}
