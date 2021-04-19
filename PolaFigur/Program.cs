using System;

namespace PolaFigur
{
    class Program
    {

        static void Main(string[] args)
        {
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
                    var radius = Convert.ToDecimal(Console.ReadLine());
                    var result = (Convert.ToDecimal(radius * radius) * Convert.ToDecimal(pi));
                    Console.WriteLine($"Pole okręgu wynosi {result.ToString("#.##")}.");
                    break;

                case "k":   //kwadrat
                    Console.WriteLine("Podaj bok kwadratu:");
                    var length = Convert.ToDecimal(Console.ReadLine());
                    var result1 = Convert.ToDecimal(length * length);
                    Console.WriteLine($"Pole kwadratu wynosi {result1.ToString("#.##")}.");
                    break;

                case "p":   //prostokąt
                    Console.WriteLine("Podaj krótszy bok:");
                    var length1 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Podaj dłuższy bok:");
                    var length2 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine($"Pole prostokąta wynosi {(Convert.ToDecimal(length1 * length2)).ToString("#.##")}.");
                    break;

                case "t":   //trójkąt
                    Console.WriteLine("Podaj podstawę:");
                    var baseLength = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Podaj wysokość:");
                    var height = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine($"Pole trójkąta wynosi {(Convert.ToDecimal(height * baseLength / 2)).ToString("#.##")}.");
                    break;
            }
            Console.Write("Wciśnij dowolny przycisk żeby zakończyć...");
            Console.ReadKey();
        }
    }
}
