using System;

namespace homework_7_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Chislo: ");
                string s1 = Console.ReadLine();
                int chislo = int.Parse(s1);
                Console.WriteLine("Stepen chisla: ");
                string s2 = Console.ReadLine();
                int stepen = int.Parse(s2);
                if (stepen < 0)
                {
                    Console.WriteLine("Oshibka! Nujno neotricatelnoe celoe chislo!");
                }
                else
                {
                    int stepenChisla = Stepen(chislo, stepen);
                    Console.WriteLine(stepenChisla);
                }
            }
            catch
            {
                Console.WriteLine("Oshibka! Nujno celoe chislo!");
            }
        }

        static int Stepen(int chislo, int stepen)
        {
            if (stepen == 0)
            {
                return 1;
            }
            else
            {
                return chislo * Stepen(chislo, stepen - 1);
            }
        }
    }
}
