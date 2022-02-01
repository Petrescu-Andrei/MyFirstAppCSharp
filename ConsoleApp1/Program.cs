using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!!!!!!!!!");

            Console.WriteLine("Here is my branch");

            Console.WriteLine("Am primit argumentul de linia de comanda: " + args[0]);
            Console.WriteLine("Am primit argumentul de linia de comanda: " + args[1]);

            int[] numere = new int[] { 1, 8, 13, 21, 37, 41, 74, 12, 4, 3, 10, 101, 3424};
            double[] preturi = new double[] { 13, 5, 1.5, 39, 100 };

            // numere[6] = 7; -> mesaj de eroare, nu poti sa adaugi valori pe o pozitie inexistenta

            Console.WriteLine(numere.Length);
            Console.WriteLine(numere.Rank);

            /*
             * Se poate citi "manual" fiecare adresa, dar este mult prea lent
             * 
            Console.WriteLine(numere[0]);
            Console.WriteLine(numere[1]);
            Console.WriteLine(numere[2]);
            Console.WriteLine(numere[3]);
            Console.WriteLine(numere[4]);
            Console.WriteLine(numere[5]);
            */

            Console.WriteLine("Numerele castigatoare sunt: --------------------------");

            for (int i = 0; i < numere.Length; i++)
            {
                Console.WriteLine(numere[i]);
            }

                Console.WriteLine("Preturile initiale sunt:");

            for (int i = 0; i < preturi.Length; i++)
            {
                Console.WriteLine(preturi[i]);
            }

            Console.WriteLine("Preturile reduse sunt:");

            for (int i = 0; i < preturi.Length; i++)
            {
                
                preturi[i] *= 0.9;
                Console.WriteLine(preturi[i]);
            }

            string[,] tabla = new string[3, 3] { { "X", "0", "X" }, { "X", "0", "X" }, { "0", "X", "0" } };

            if (tabla[0,0] == tabla[1,1] && tabla[1,1] == tabla[2,2])
            {
                Console.WriteLine("Jucatorul este: " + tabla[0, 0]);
            }
            else
            {
                Console.WriteLine("Este egalitate!");
            }

            for(int r = 0; r < tabla.GetLength(0); r++)
            {
                string row = "";
                for (int c = 0; c < tabla.GetLength(1); c++)
                {
                    row += " " + tabla[r, c];
                }
                Console.WriteLine(row);
            }

            //SORTARE, CAUTARE, COMPARARE
            int[] nums = new int[] { 1, 5, 3, 2, 6, 7, 9, 8 };

            Console.WriteLine("Inainte de sortare: ");

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            Array.Sort(nums);

            Console.WriteLine("Dupa sortare: ");

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            Array.Reverse(nums);

            Console.WriteLine("Sortare descrescatoare: ");

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            int[] Numbers = new int[] { 1, 3, 5, 7, 9 };
            int[] Numbers2 = new int[] { 1, 3, 5, 7, 9 };
            int five = Array.Find(Numbers, number => number == 5);
            int greaterThan7 = Array.Find(Numbers, number => number > 7);

            Console.WriteLine("Find 5 -> " + five);
            Console.WriteLine("Greater Than 7 -> " + greaterThan7);

            bool areEqual = Numbers.SequenceEqual(Numbers2);
            if (areEqual == true)
            {
                Console.WriteLine("Numbers = Numbers2");
            }
            else
            {
                Console.WriteLine("Numbers Nu e egal cu Numbers2");
            }

            Console.ReadKey();
        }
    }
}
