using System;
using System.Diagnostics.SymbolStore;

namespace uppgift_4_2
{
    class program
    {
        static void Main(string[] args)
        {
            int tal2 = 0;
            while(true)
            {
                Console.WriteLine("Vill du skriva in ett heltal eller avsluta programmet?");
                string svar = Console.ReadLine().ToLower();
                if (svar == "avsluta")
                {
                    break;
                }
                Console.WriteLine("Skriv in ett heltal");
                int tal = int.Parse(Console.ReadLine());
                if ( tal > tal2)
                {
                    tal2 = tal;
                }
            }
            Console.WriteLine("Det största talet du skrev var " + tal2);
            Console.ReadKey();
        }
    }
}
