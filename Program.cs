using System;
using System.Collections.Generic;

namespace day4_loops
{
    class Program
    {

        class Trijsturis  
            {
                    

            }

        static void Main(string[] args)
        {

            byte mainiigais1 = 0b_0000_0001;// 0000_0001
            byte mainiigais2 = 0b_0000_0111;

            int rez = mainiigais1 & mainiigais2;
            Console.WriteLine(Convert.ToString(rez, toBase: 2));

            rez = mainiigais1 | mainiigais2;
            Console.WriteLine(Convert.ToString(rez, toBase:2));


            rez = mainiigais1 ^ mainiigais2;
            Console.WriteLine(Convert.ToString(rez, toBase: 2));

            rez = ~mainiigais2;
            Console.WriteLine(Convert.ToString((byte)rez, toBase: 2));

            //================================================================

            // left bitshift 
            mainiigais1 = 0b_1110_0001;// => 0000_1000
            
            Console.WriteLine(Convert.ToString((byte)mainiigais1, toBase: 2));
            rez = mainiigais1 << 3;
            Console.WriteLine(Convert.ToString((byte)rez, toBase: 2));


            //right bitshift
            mainiigais1 = 0b_1110_0001;// => 0001_1100

            Console.WriteLine(Convert.ToString((byte)mainiigais1, toBase: 2));
            rez = mainiigais1 >> 3;
            Console.WriteLine(Convert.ToString((byte)rez, toBase: 2));

            //================================================================================

            //int i = 0;
            /*
            while (i < 10)
            {

                i = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Hello World! no Cikla " + i);
                //i++;
            }
            */



            //while 
            /*
            while (1 == 1)
            {
                i = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Hello World! no Cikla " + i);

                if (i > 9)
                    break;
            }
            */


            //i = 0;
            /*
            do
            {
                Console.WriteLine("Hello World! no Cikla " + i);
                i++;
            } while (i < 10);
            */


            /*
            string rez_str = "feils";

            while (rez_str == "feils")
            {
                //i = Int32.Parse(Console.ReadLine());

                rez_str = Console.ReadLine();
                Console.WriteLine("Hello World! no Cikla [" + rez_str + "]");

            }
            */

            /*
            while (Console.ReadLine() == "feils")
            {
                //i = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Hello World! no Cikla ");

            }
            */
            //======================================================================

            /*
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    continue;

                if (i == 6)
                    break;

                Console.WriteLine("Cikls " + i);
            }
            */

            //masīvs ?
            //kā saraksts

            //int[] masivs_liels = new int[234];

            int[] masivs = {100,200,300,400,500,600,700,701,800};
            string[] masivs_str = { "aaa", "bbb", "ccc", "ddd", "eee", "fff"};
            

            for (int i = 0; i < masivs.Length ; i++)
            {
                Console.WriteLine("Masīva elementa vērtība " + masivs[i]);
            }


            for (int i = 0; i < masivs_str.Length; i++)
            {
                Console.WriteLine("Masīva elementa vērtība " + masivs_str[i]);
            }


            string rinda = "abcdef";
            //for (int i = 0; i < rinda.Length; i++)
            //for (int i = 0; i < rinda.Length; i+=2)//i = i + 2
            //for (int i = 0; i < rinda.Length; i -= 2)//i = i - 2

            for (double i = 0; i < 10; i += 0.0005)
            {
                break;
                //Console.WriteLine("Masīva elementa vērtība " + rinda[i]);
                Console.WriteLine("Masīva elementa vērtība " + i);
            }

            //int[] masivs = {100,200,300,400,500,600,700,701,800};



            // ..... kautkāds datu blāķis, kura izmērs nav paredzams
            foreach (int elements in masivs)
            {
                //darbības ar mainīgo
                Console.WriteLine("Masīva elementa vērtība " + elements);
            }

            List<ConsoleColor> liste = new List<ConsoleColor>();

            //List<Trijsturis> liste_t = new List<Trijsturis>();
            //Trijsturis[] t_masiivs = new Trijsturis[434];




            liste.Add(ConsoleColor.Red);
            liste.Add(ConsoleColor.DarkBlue);
            liste.Add(ConsoleColor.Yellow);
            liste.Add(ConsoleColor.Green);
            liste.Add(ConsoleColor.Cyan);
            liste.Add(ConsoleColor.Blue);
            liste.Add(ConsoleColor.DarkBlue);
            


            foreach (ConsoleColor kraasa in liste)
            {
                //darbības ar mainīgo
                //Console.WriteLine("Masīva elementa vērtība " + elements);

                Console.ForegroundColor = kraasa;
                Console.WriteLine(kraasa.ToString());

            }


            //0 - 4,3MM
            uint mainiigais = 4000000000;
            Console.WriteLine(Convert.ToString(mainiigais, 2));

            //-2,2MM -- +2,2MM
            int mainiigais_int = (int)mainiigais;
            Console.WriteLine(Convert.ToString(mainiigais_int, 2));

            //0 - 255
            byte mainiigais_byte = (byte)mainiigais;
            Console.WriteLine(mainiigais_byte);


            //0 - 2 ^64
            long mainiigais_long = (long)mainiigais;
            Console.WriteLine(mainiigais_long);

            //string str = "abcd";
            //Console.WriteLine((char)str[0]);






            Console.WriteLine("Hello World!");
        }
    }
}
