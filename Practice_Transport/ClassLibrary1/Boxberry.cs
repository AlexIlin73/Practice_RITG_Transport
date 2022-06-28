using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class Boxberry
    {
        public static DateTime Date(string Otkuda) {
            switch (Otkuda)
            {
                case "Москва":
                    return DateTime.Today.AddDays(5);
                    break;
                case "Казань":
                    return DateTime.Today.AddDays(1);
                    break;
                case "Самара":
                    return DateTime.Today.AddDays(2);
                    break;
                case "Санкт-Петербург":
                    return DateTime.Today.AddDays(5);
                    break;
                default: return DateTime.Today;
            }
        }
        public static float Price(string Otkuda,bool FromDoor, bool ToDoor, float Length, float Width, float Height, float Weight)
        {
            float price = 0;
            switch(Otkuda)
            {
                case "Москва":
                    price += 500;
                    break;
                case "Казань":
                    price += 100;
                    break;
                case "Самара":
                    price += 100;
                    break;
                case "Санкт-Петербург":
                    price += 500;
                    break;
            }
            if (ToDoor == true) price += 100;
            if (FromDoor == true) price += 100;
            price += Length * Width * Height * 0.06f + Weight*30;
            return price;
        }
    }
}
