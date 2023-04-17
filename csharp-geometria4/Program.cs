using System;

namespace geometria
{
    class Rettangolo
    {
        private int baseRettangolo;
        private int altezzaRettangolo;

        public Rettangolo(int baseRettangolo, int altezzaRettangolo)
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
        }

        public int CalcolaArea()
        {
            return baseRettangolo * altezzaRettangolo;
        }

        public int CalcolaPerimetro()
        {
            return 2 * (baseRettangolo + altezzaRettangolo);
        }

        public void StampaRettangolo()
        {
            Console.WriteLine("---- Rettangolo ----");
            Console.WriteLine("Base: " + baseRettangolo + " cm");
            Console.WriteLine("Altezza: " + altezzaRettangolo + " cm");
            Console.WriteLine("Perimetro: " + CalcolaPerimetro() + " cm");
            Console.WriteLine("Area: " + CalcolaArea() + " cm2");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci la base del rettangolo:");
            int baseRettangolo = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci l'altezza del rettangolo:");
            int altezzaRettangolo = int.Parse(Console.ReadLine());

            Rettangolo r1 = new Rettangolo(baseRettangolo, altezzaRettangolo);
            r1.StampaRettangolo();

            Rettangolo r2 = new Rettangolo(10, 5);
            r2.StampaRettangolo();

            Rettangolo r3 = new Rettangolo(15, 8);
            r3.StampaRettangolo();
        }
    }
}