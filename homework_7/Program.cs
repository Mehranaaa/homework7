using System;

namespace homework_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int testChislo = Stepen(2, 10);
            Console.WriteLine(testChislo);
            int testChislo2 = SummaStepeney(2, 10);
            Console.WriteLine(testChislo2);
        }

        // Metod dla vichisleniya stepeni
        static int Stepen(int chislo, int stepen)
        {
            if (stepen == 2 && chislo == 2)
            {
                return 4;
            }
            else
            {
                return chislo * Stepen(chislo, stepen - 1);
            }
        }

        // Metod dla vichisleniya summi stepeney chisla
        static int SummaStepeney(int chislo, int stepen)
        {
            if (stepen == 2 && chislo == 2)
            {
                return 4;
            }
            else
            {
                return Stepen(chislo, stepen) + SummaStepeney(chislo, stepen - 1);
            }
        }
    }
}




