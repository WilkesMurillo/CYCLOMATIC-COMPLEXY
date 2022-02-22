using System;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1=3;
            int N2=34;
            int N3=67;
            int Mayor;
            
            Console.WriteLine("Ingrese el primer numero: ");
            if (N1 > N2 && N2 > N3)
            {
                Mayor = N1;
            }
            else
            {
                if (N2 > N3)
                {
                    Mayor = N2;
                }
                else
                {
                    Mayor = N3;
                }
                Console.WriteLine("El numero mayor entre los tres numeros es : " + Mayor);
            }
        }

    }
    }

