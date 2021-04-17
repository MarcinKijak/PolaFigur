using System;

namespace PolaFigur
{
    class Program
    {
        
        static void Main(string[] args)
        {
            decimal r = 0;
            decimal k = 0;
            decimal a = 0;
            decimal b = 0;
            decimal c = 0;
            decimal h = 0;

            Console.WriteLine("       Pola figur         ");
            Console.WriteLine("------------------------\n");
            Console.WriteLine("Pole jakiej figury chcesz obliczyć ?");
            Console.WriteLine("Wybierz z listy poniżej:");
            Console.WriteLine("\n");
            Console.WriteLine($"Okrąg -     wybierz 'o'");
            Console.WriteLine($"Kwadrat -   wybierz 'k'");
            Console.WriteLine($"Prostokąt - wybierz 'p'");
            Console.WriteLine($"Trójąt    - wybierz 't'");
            Console.WriteLine("\n");
            Console.WriteLine($"Twój wybór + Enter ?");



            // if ((Console.ReadLine() != "o") || (Console.ReadLine() != "k") 
            //     || (Console.ReadLine() != "p") || (Console.ReadLine() != "t"))
            //     {
            //     Console.WriteLine("Wybierz prawidłową wartość !");
            //     }
            //     else 
            while ((Console.ReadLine() != "o") || (Console.ReadLine() != "k")
                || (Console.ReadLine() != "p") || (Console.ReadLine() != "t"))
            {
                Console.WriteLine($"Wprowadź prawidłową wartość.");
            }



                switch (Console.ReadLine())
                {
                case "o":
                    const double pi = 3.14159274;
                    Console.WriteLine("Podaj promień:");
                    r = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine($"Pole okręgu wynosi {Convert.ToDecimal(r*r)*Convert.ToDecimal(pi)}.");
                    break;
                case "k":
                    Console.WriteLine("Podaj bok kwadratu:");
                    k = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine($"Pole kwadratu wynosi {Convert.ToDecimal(k * k)}.");
                    break;
                case "p":
                    Console.WriteLine("Podaj krótszy bok:");
                    a = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Podaj dłuższy bok:");
                    b = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine($"Pole prostokąta wynosi {Convert.ToDecimal(a * b)}.");
                    break;
                case "t":
                    Console.WriteLine("Podaj podstawę:");
                    c = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Podaj wysokość:");
                    h = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine($"Pole trójkąta wynosi {Convert.ToDecimal(c * h / 2)}.");
                    break;
            }
            Console.WriteLine("\n");
            Console.Write("Wciśnij dowolny przycisk żeby zakończyć...");
            Console.ReadKey();
        }
    }
}
