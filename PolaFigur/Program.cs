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
            decimal o = 0;

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

            string check = Console.ReadLine();
            //sprawdza czy wybór figury jest ok

            while ((check != "o") && (check != "k") && (check != "p") && (check != "t"))    
                {
                Console.WriteLine($"Wprowadź prawidłową wartość.");
                check = Console.ReadLine();
                }
         
            // obliczenia na podstawie wyboru
                switch (check)
                {
                case "o":   //okrąg
                    const double pi = Math.PI;
                    Console.WriteLine("Podaj promień:");
                    r = Convert.ToDecimal(Console.ReadLine());
                    o = (Convert.ToDecimal(r * r) * Convert.ToDecimal(pi));
                    Console.WriteLine($"Pole okręgu wynosi {o.ToString("#.##")}.");
                    break;
                
                case "k":   //kwadrat
                    Console.WriteLine("Podaj bok kwadratu:");
                    k = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine($"Pole kwadratu wynosi {(Convert.ToDecimal(k * k)).ToString("#.##")}.");
                    break;
                
                case "p":   //prostokąt
                    Console.WriteLine("Podaj krótszy bok:");
                    a = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Podaj dłuższy bok:");
                    b = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine($"Pole prostokąta wynosi {(Convert.ToDecimal(a * b)).ToString("#.##")}.");
                    break;
                
                case "t":   //trójkąt
                    Console.WriteLine("Podaj podstawę:");
                    c = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Podaj wysokość:");
                    h = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine($"Pole trójkąta wynosi {(Convert.ToDecimal(c * h / 2)).ToString("#.##")}.");
                    break;
            }
            Console.Write("Wciśnij dowolny przycisk żeby zakończyć...");
            Console.ReadKey();
        }
    }
}
