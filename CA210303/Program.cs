using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CA210303
{
    enum Irány
    {
        Fel, Le, Bal, Jobb
    }

    class Program
    {
        static Random rnd = new Random();

        static void Main()
        {
            //Feladatok_switch();
            //Feladatok0201_plusz();
            //Feladatok0202();
            //Feladatok0203();
            //Feladatok0204_a();
            //Feladatok0204_b();
            //Feladatok0210();
            //Feladatok0211();
            //Feladatok0214();
            //Feladatok0215();
            Console.ReadKey();
        }

        private static void Feladatok0215()
        {
            for (int i = 12; i <= 99; i+=3)
            {
                Console.WriteLine(i);
            }

            //"kevésbé" 6ékony +oldás
            for (int i = 10; i < 100; i++)
            {
                if (i % 3 == 0) Console.WriteLine(i);
            }
        }

        private static void Feladatok0214()
        {
            for (int i = -30; i <= 30; i++)
            {
                Console.WriteLine("{0,3}°C == {1, 5:0.0}°F", i, i*1.8 + 32);
            }
        }

        private static void Feladatok0211()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(10 + i * 7);
            }

            //vagy

            for (int i = 10; i < 360; i += 7)
            {
                Console.WriteLine(i);
            }
        }
        private static void Feladatok0210()
        {
            for (int i = 99; i > 0; i -= 2)
            {
                Console.Write(i + " ");
            }
        }
        private static void Feladatok0204_b()
        {
            Console.Write("ird be a neved: ");
            string nev = Console.ReadLine();
            Console.CursorVisible = false;
            Console.Clear();

            //int width = Console.WindowWidth;
            //int height = Console.WindowHeight;

            for (int i = 0; i < 100; i++)
            {
                //int left = rnd.Next(width - nev.Length);
                //int top = rnd.Next(height);

                Console.SetCursorPosition(
                    rnd.Next(Console.WindowWidth - nev.Length),
                    rnd.Next(Console.WindowHeight));

                //Console.ForegroundColor = (ConsoleColor)rnd.Next(16);

                Console.BackgroundColor = (ConsoleColor)rnd.Next(16);

                for (int j = 0; j < nev.Length; j++)
                {
                    Console.ForegroundColor = (ConsoleColor)rnd.Next(16); 
                    Console.Write(nev[j]);
                }
                Console.ResetColor();

                Thread.Sleep(200);
                //Console.Clear();
            }
            Console.CursorVisible = true;
        }
        private static void Feladatok0204_a()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    //Console.WriteLine();
                    Console.Write(" ");
                }
                Console.WriteLine("nevünk");
                Thread.Sleep(500);
                Console.Clear();
            }
        }
        private static void Feladatok0203()
        {
            for(int i = 10; i > 0; i--)
            {
                Console.Write(i);
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(".");
                    Thread.Sleep(200);
                }
                Console.Clear();
            }
            Console.WriteLine("cső!");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("press any key to Exit!");
        }
        private static void Feladatok0202()
        {
            Console.Write("szam: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("szoveg: ");
            string szoveg = Console.ReadLine();

            for(int i = 0; i < n; i++)
                Console.Write($"{szoveg} ");
            Console.WriteLine("\nN értéke: " + n);

            Console.Write("\n-----------\n");

            for(; n > 0; n--)
                Console.Write("{0} ", szoveg);
            Console.WriteLine("\nN értéke: " + n);
        }
        private static void Feladatok0201_plusz()
        {
            Console.Write("neved: ");
            string nev = Console.ReadLine();

            for (int i = 1; i <= 10; i += 1)
            {
                Console.WriteLine("{0,2} {1}", i, nev);
            }
            //----------------------------------
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1} {nev}");
            }

            //----------------------------------

            Console.Write("hany eves vagy? ");
            int kor = int.Parse(Console.ReadLine());

            for (; kor > 0; kor--)
            {
                Console.WriteLine(nev);
            }

            int[] t = new int[4];

            int valosLefutas = 0;
            for (int i = 0; i < 4;)
            {
                int szam = rnd.Next(4) + 1;
                if(!t.Contains(szam))
                {
                    t[i] = szam;
                    i++;
                }
                valosLefutas++;
            }

            for (int i = 0; i < t.Length; i++)
            {
                Console.Write(t[i]+ " ");
            }
            Console.WriteLine($"\nvalós lefutások száma: {valosLefutas}");

        }
        private static void Feladatok_switch()
        {
            Console.Write("hányadik hónap van? ");

            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    {
                        Console.WriteLine("január van");
                        Console.WriteLine("meg még ide írhatok sok minen mást is....");
                        break;
                    }
                case 2: Console.WriteLine("február van");
                    break;
                case 4: Console.WriteLine("április van");
                    break;
                case 3: Console.WriteLine("március van");
                    break;
                case 5:
                case 6:
                    Console.WriteLine("május vagy június van");
                    break;
                case 7: Console.WriteLine("július van");
                    break;
                default:
                    Console.WriteLine("ilyen hónap nincs is!");
                    break;
            }

            //Irány x = Irány.Bal;

            //switch (x)
            //{
            //    case Irány.Fel:
            //        break;
            //    case Irány.Le:
            //        break;
            //    case Irány.Bal:
            //        break;
            //    case Irány.Jobb:
            //        break;
            //    default:
            //        break;
            //}

            //string x = Fuggveny(12);
        }
        private static string Fuggveny(int v)
        {
            switch (v)
            {
                case 12: return "tizenkettő";
                case 13: return "tizenhárom";
                default: return null;
            }
        }
    }
}
