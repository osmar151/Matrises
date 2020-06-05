using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class Program
    {
        static int val = 3;

        static string[,] palabras = new string[val, val];

        static void Main(string[] args)

        {
            
            

            for (int x = 0; x < val; x++)

            {

                for (int y = 0; y < val; y++)

                {

                
                    Console.Write("Ingrese una palabra: ");
                    palabras[y, x] = Console.ReadLine();

                }

            }

            Console.WriteLine("\n----------------------------------\n");

            for (int x = 0; x < val; x++)

            {

                for (int y = 0; y < val; y++)

                {

                    Console.WriteLine("palabra: " + palabras[y, x]);



                }

            }



            Console.ReadKey();

        }
    }
}