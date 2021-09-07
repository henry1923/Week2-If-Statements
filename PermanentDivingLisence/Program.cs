using System;

namespace PermanentDivingLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //programm küsib kasutaja sünniaastat
            //programm kontrollib kasutaja vanust
            //programm teatab kasutajat, kas ta on piisavalt vana
            //et juhiluba saada

            Console.WriteLine("Kui vana sa oled?");

            int YearOfBirth = Int32.Parse(Console.ReadLine());
            int Age = 2021 - YearOfBirth;
          /*if (Age > 18)
                Console.WriteLine("Oled piisavalt vana,et juhiluba saada");
            else if (Age < 18)
                Console.WriteLine("Liiga noor, et juhiluba saada");
            else
                Console.WriteLine("Oled 18, nüüd oled piisavalt vana, et juhiluba saada");



            */



        }
    }
}
