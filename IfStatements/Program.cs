using System;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //programm küsib kastutaja vanust
            //kui kasutaja on vanem kui 18,siis konsoolis kuvatakse "oled piisavalt vana"
            //kui kasutaja on noorem kui 18,siis konsoolis kuvatakse "oled liiga noor"
            //kui kasutaja on 18, siis kuvatakse "oledki 18"
            Console.WriteLine("Kui vana sa oled?");

            int Age = Int32.Parse(Console.ReadLine());

            if (Age > 18)


            else if (Age > 18) Console.WriteLine("Oled piisavalt vana");



            if (Age < 18) Console.WriteLine("Oled liiga noor");

            

            







        }
    }
}
