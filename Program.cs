using System;
using System.Threading;

namespace Litecoin
{class Program
    {

            static void Main()
            {
            Menu:
                //Header
                Console.ForegroundColor = ConsoleColor.DarkMagenta;

                Console.Title = " Sikdware - Paid ";
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                        [ <1> ] Spoof");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                        [ <2> ] Clean");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                        [ <3> ] Check Serials");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write(" </> ");
                string option = Console.ReadLine();

                if (option == "1")
                {
                    Spoofer.Spoof();
                    Console.Clear();
                    goto Menu;
                }
                else if (option == "2")
                {
                    Spoofer.Clean();
                    Thread.Sleep(1000);
                    Console.Clear();
                    goto Menu;
                }
                else if (option == "3")
                {
                    Spoofer.Serials();
                    Thread.Sleep(1000);
                    Console.Clear();
                goto Menu;               
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please Choose a Valid Option!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    goto Menu;
                }
            }
        }
    }