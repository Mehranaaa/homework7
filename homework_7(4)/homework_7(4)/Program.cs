using System;

namespace homework_7_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pervoe chislo: ");
                string s1 = Console.ReadLine();
                int chislo1 = int.Parse(s1);
                Console.WriteLine("Vtoroe chislo: ");
                string s2 = Console.ReadLine();
                int chislo2 = int.Parse(s2);
                int test;
                if (chislo1 == chislo2 + 1 || chislo2 == chislo1 + 1)
                {
                    test = 0;
                }
                else if (chislo1 > chislo2)
                {
                    test = Summa(chislo1 - 1, chislo2 + 1);
                }
                else if (chislo1 < chislo2)
                {
                    test = Summa(chislo1 + 1, chislo2 - 1);
                }
                else
                {
                    test = 0;
                }
                Console.WriteLine("Summa chisel v diapazone: " + test);
            }
            catch
            {
                Console.WriteLine("Oshibka Nujno chislo!");
            }
        }

        static int Summa(int chislo1, int chislo2)
        {
            if (chislo1 == chislo2)
            {
                return chislo1;
            }
            else if (chislo1 > chislo2)
            {
                return chislo2 + Summa(chislo1, chislo2 + 1);
            }
            else
            {
                return chislo1 + Summa(chislo1 + 1, chislo2);
            }
        }
    }
}
