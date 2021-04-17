using System;

namespace PolaFigur
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            decimal r;
            
            //Console.WriteLine("Hello World!");
            Console.WriteLine("       Pola figur         ");
            Console.WriteLine("------------------------\n");
            Console.WriteLine("Pole jakiej figury chcesz obliczyć ?");
            Console.WriteLine("Wybierz z listy poniżej:");
            Console.WriteLine("\n");
            Console.WriteLine($"Okrąg -     wybierz 'o'");
            Console.WriteLine($"Kwadrat -   wybierz 'k'");
            Console.WriteLine($"Prostokąt - wybierz 'p'");
            Console.WriteLine($"Trapez    - wybierz 't'");
            //Console.ReadKey();
            Console.WriteLine($"Twój wybór + Enter ?");
            //Console.ReadLine();
            /*
            if (Console.ReadLine() ==)
                {
                Console.WriteLine("Wybierz prawidłową wartość !");            
                }
                else  */
             switch (Console.ReadLine())
                {
                case "o":
                    const double pi = 3.14159274;
                    Console.WriteLine("Podaj promień:");
                    r = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine($"Pole okręgu wynosi {Convert.ToDecimal(r*r)*Convert.ToDecimal(pi)} ");
                break;    

                }

                
            Console.ReadKey();
        }
    }
}
