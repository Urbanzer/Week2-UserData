using System;

namespace DrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            //kysi synniaastat
            //arvuta vanus
            //noorem 18 siis oled liiga noor
            //vanem 18 siis oled piisavalt vana
            //kui 18 siis palju onne

            Console.WriteLine("Palun sisestage oma synniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());
            int userAge = 2021 - yearOfBirth;
            if (userAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et Instagrami kontot luua.");
            }
            else if (userAge < 18)
            {
                Console.WriteLine("Oled liiga noor, et Instagrami kontot luua.");
            }
            else if (userAge == 18)
            {
                Console.WriteLine("Palju onne, nyyd saad ka juhiluba taotleda!");
            }
            Console.WriteLine("Kena paeva");
        }
    }
}
