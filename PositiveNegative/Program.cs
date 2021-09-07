using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub sisestada numbrit
            //programm kontrollib numbrit
            //kui number on positiivne, siis konsool kuvab "number on positiivne"
            //kui number on negatiivne, siis konsool kuvab "number on negatiivne"
            //kui sisestatud number on 0, siis konsool kuvab "null"

            ///NB! Int32.Parse asemel kasutame Convert.ToInt32(Consol.Readline());

            Console.WriteLine("Please enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)

                Console.WriteLine("Number on positiivne.");

            else if (number < 0) 

                Console.WriteLine("Number on negatiivne");

            else

                Console.WriteLine("null");











        }
    }
}
