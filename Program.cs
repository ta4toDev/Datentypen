namespace Datentypen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklarieren und initialisieren der Variable wert1
            int wert1 = 25;
            //Deklarieren
            int wert2;
            //Initialisieren
            wert2 = 15;
            int summe = wert1 + wert2;
            //Deklarieren mehrere Variablen in einer Zeile
            int wert3, wert4, wert5;
            //Verwendung von Gleitkommazahlen mit Double
            double d1 = 333.5;
            double d2 = 1.337;
            double ergebnis = d1 / d2;

            //Verwendung von Gleitkommazahlen mit Float
            float f1 = 1.337f;


            Console.WriteLine("Ergebnis " + ergebnis);
            Console.ReadKey();
        }
    }
}
