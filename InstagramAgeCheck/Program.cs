using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun sisestage oma vanus:");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge > 13) 
            {
                Console.WriteLine("Oled piisavalt vana, et Instagrami kontot luua.");
            }
            else if (userAge < 13)
            {
                Console.WriteLine("Oled liiga noor, et Instagrami kontot luua.");
            }
            Console.WriteLine("Kena paeva");
        }
    }
}
