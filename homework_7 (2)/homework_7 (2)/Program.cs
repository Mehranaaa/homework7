using System;

namespace homework_7__2
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
                    Console.WriteLine("NOD raven: " + NOD(chislo1, chislo2));
                }
                catch
                {
                    Console.WriteLine("Oshibka Nujno chislo!");
                }
            }

            static int NOD(int chislo1, int chislo2)
            {
                if (chislo1 % chislo2 == 0)
                {
                    return chislo2;
                }
                else if (chislo2 % chislo1 == 0)
                {
                    return chislo1;
                }
                else if (chislo1 > chislo2)
                {
                    return NOD(chislo1 %= chislo2, chislo2);
                }
                else
                {
                    return NOD(chislo1, chislo2 %= chislo1);
                }
            }
        }
    }
