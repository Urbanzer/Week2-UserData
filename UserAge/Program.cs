using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //prgoramm kysib kasutaja vanust;
            //prorgramm arvutab kasutaja synniaasta;
            //programm kuvab synniaasta konsoolis;
            //"oled syndinud aastal {yearOfBirth}"

            Console.WriteLine("Palun sisestage oma vanus:");
            int userAge = Convert.ToInt32(Console.ReadLine());
            int yearOfBirth = 2021 - userAge;
            //Console.WriteLine("Oled " + userAge + " aastat vana.");
            //string interpolation
            Console.WriteLine($"Oled syndinud {yearOfBirth} aastal.");
        }


    }
    
}

