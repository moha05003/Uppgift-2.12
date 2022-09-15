using System;

namespace uppgift_2._12

{
    class Program

    {

        public static void Main()

        {
            int Startavgift = 300;

            Console.WriteLine("Hur många dagar ska du köra?");

            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur många kilometer ska du köra bilen?");

            int y = int.Parse(Console.ReadLine());




            Console.WriteLine(Startavgift + 500 *( x - 1) + 1*y); 









        }




    }

}

