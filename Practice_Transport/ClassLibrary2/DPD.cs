using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public static class DPD
    {
        public static DateTime Date(string Otkuda)
        {
            switch (Otkuda)
            {
                case "Москва":
                    return DateTime.Today.AddDays(4);
                    break;
                case "Казань":
                    return DateTime.Today.AddDays(1);
                    break;
                case "Самара":
                    return DateTime.Today.AddDays(1);
                    break;
                case "Санкт-Петербург":
                    return DateTime.Today.AddDays(5);
                    break;
                default: return DateTime.Today;
            }
        }
        public static float Price(string Otkuda, bool FromDoor, bool ToDoor, float Length, float Width, float Height, float Weight)
        {
            float price = 0;
            switch (Otkuda)
            {
                case "Москва":
                    price += 450;
                    break;
                case "Казань":
                    price += 150;
                    break;
                case "Самара":
                    price += 150;
                    break;
                case "Санкт-Петербург":
                    price += 500;
                    break;
            }
            if (ToDoor == true) price += 80;
            if (FromDoor == true) price += 80;
            price += Length * Width * Height * 0.05f + Weight * 25;
            return price;
        }
    }
}
