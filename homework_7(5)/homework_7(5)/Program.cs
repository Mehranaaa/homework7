using System;

namespace homework_7_5_
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Nomer dna nedeli: ");
                string den = Console.ReadLine();
                int nomerDna = int.Parse(den);
                string denNedeli = DenNedeli(nomerDna);
                Console.WriteLine(denNedeli);
            }
            catch
            {
                Console.WriteLine("Oshibka! Nujno chislo!");
            }
        }

        enum Days
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }

        static string DenNedeli(int nomerDna)
        {
            switch (nomerDna)
            {
                case 1:
                    return Convert.ToString(Days.Monday);
                case 2:
                    return Convert.ToString(Days.Tuesday);
                case 3:
                    return Convert.ToString(Days.Wednesday);
                case 4:
                    return Convert.ToString(Days.Thursday);
                case 5:
                    return Convert.ToString(Days.Friday);
                case 6:
                    return Convert.ToString(Days.Saturday);
                case 7:
                    return Convert.ToString(Days.Sunday);
                default:
                    return "Oshibka! Nujno chislo ot 1 do 7!";
            }
        }
    }
}
