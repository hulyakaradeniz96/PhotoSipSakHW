using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoSipSakHW
{
    internal class Battery
    {
   

        public int Id { get; set; }
        public string BatteryBrand { get; set; } //
        public int BatteryPercentage { get; set; } = 100; //Batarya Yüzdesi=100 ilk başta
        public Battery(int id, string batteryBrand)
        {
            Id = id;
            BatteryBrand = batteryBrand;
        }
    }
}
