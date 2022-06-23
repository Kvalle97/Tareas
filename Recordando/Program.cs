using System;

namespace Recordando
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado = 0;
            resultado = suma(1, 2, 3);
            Console.WriteLine(resultado);


            coche micoche = new coche();
            micoche.Puertas();
            Console.WriteLine(micoche.puertas);

        }

        public static int suma(int a, int b, int c)
        {
            return a + b + c;
        }


        class coche
        {
            public int puertas = 4;

            public void Puertas()
            {
                this.puertas++;
            }
        }


    }
}

