using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoSipSakHW
{
    internal abstract class CameraBase
    {
        protected CameraBase(int id, string brand, Battery battery)
        {
            Id = id;
            Brand = brand;
            Battery = battery;
        }

        public int Id { get; set; }
        public string Brand { get; set; }//Marka
        public Battery Battery { get; set; }
        public int ShotCount { get; protected set; } = 30;//fotoğraf Karesi Sayısı.

        public virtual void TakePhoto(int shotCount,string place)
        {
            if (ShotCount > shotCount) {
                for (int i = 0; i < shotCount; i++)
                {
                    Console.WriteLine($"{place} => {i+1} kare çekildi");
                    ShotCount--;
                    Battery.BatteryPercentage--;
                }
            }
            else
            {
                Console.WriteLine($"Kalan Kare Sayısı:{ShotCount}. Fotoğraf çekemiyorum ");
            }
        }


    }
}
