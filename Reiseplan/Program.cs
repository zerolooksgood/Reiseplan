using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reiseplan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Oppg 1
            string[] reisemål = new string[5];
            Console.WriteLine("Vennligst oppgi fem reisemål:");
            for (int i = 0; i < reisemål.Length; i++)
            {
                reisemål[i] = Console.ReadLine();
            }

            //Oppg 2
            string[] klesplagg = new string[5];
            Console.WriteLine("Vennligst oppgi fem klesplagg");
            for (int i = 0; i < klesplagg.Length; i++)
            {
                klesplagg[i] = Console.ReadLine();
            }

            string[] avreisedatoer = new string[5];
            Console.WriteLine("Vennligst oppgi fem avreisedatoer");
            for (int i = 0; i < avreisedatoer.Length; i++)
            {
                avreisedatoer[i] = Console.ReadLine();
            }

            //Oppg 3
            string[,] reiseplan = new string[3,5];
            for (int i = 0; i < reisemål.Length; i++)
            {
                reiseplan[0,i] = reisemål[i];
            }
            for (int i = 0; i < klesplagg.Length; i++)
            {
                reiseplan[1, i] = klesplagg[i];
            }
            for (int i = 0; i < avreisedatoer.Length; i++)
            {
                reiseplan[2, i] = avreisedatoer[i];
            }

            //Oppg 4
            foreach (string i in reiseplan)
            {
                Console.WriteLine(i);
            }

            //Oppg 5.1 & 5.3
            int i1;
            while (true)
            {
                try
                {
                    Console.WriteLine("Hvilken liste vil du vite om? (1-3)");
                    i1 = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (i1 < 0 || i1 > 2)
                    {
                        Console.WriteLine("Vennligst oppgi et tall mellom 1 og 3");
                    } else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Vennligst oppgi et gyldig heltall");
                }
            }

            //Oppg 5.2 & 5.3
            int i2;
            while (true)
            {
                try
                {
                    Console.WriteLine("Hvilket element i denne listen vil du vite om? (1-5)");
                    i2 = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (i2 < 0 || i2 > 4)
                    {
                        Console.WriteLine("Vennligst oppgi et tall mellom 1 og 5");
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Vennligst oppgi et gyldig heltall");
                }
            }
            Console.WriteLine($"Element {i1},{i2} er: {reiseplan[i1,i2]}");

            

            Console.ReadLine();
        }
    }
}
