using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja käest siestada tema lemmikvärv;
            //kui kasutaja sisestab "punane", konsool kuvab "oled romantiline"

            Console.WriteLine("Mis on sinu lemmikvärv?");
            string Usercolor = Console.ReadLine();

            if (Usercolor == "punane")
            {
                Console.WriteLine("oled romantiline");
            }

            else if (Usercolor =="sinine")
            {
                Console.WriteLine("oled töökas");
            }
            else if (Usercolor =="roheline")
            {
                Console.WriteLine("Oled Loodusesõbralik");
            }       

            

                                   





        }
    }
}
