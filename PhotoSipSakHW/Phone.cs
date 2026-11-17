using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoSipSakHW
{
    internal class Phone : CameraBase, IFlash
    {
        public Phone(int id, string brand, Battery battery) : base(id, brand, battery)
        {
        }

        public void TakePhotoWithFlash(int shotCount, string place)
        {
            if (ShotCount > shotCount)
            {
                for (int i = 0; i < shotCount; i++)
                {
                    Console.WriteLine($"{place} => {i + 1}. kare flaş ile telefondan fotoğraf çekiliyor..");
                    ShotCount--;
                    Battery.BatteryPercentage -= 1;
                }

            }
            else
            {
                Console.WriteLine($"Kalan Kare Sayısı:{ShotCount}. Flaşla telefondan fotoğraf çekemiyorum ");
            }
        }

        public override string ToString()
        {
            return $"Telefonda {ShotCount} kare, %{Battery.BatteryPercentage} şarj kaldı.";
        }
    }
}
