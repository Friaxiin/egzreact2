namespace egzreact2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liczba zarejestrowanych osób to " + Osoba.instancjeKlasy);

            Osoba osoba1 = new Osoba();

            Osoba osoba2 = new Osoba(1, "Andrzej");

            Osoba osoba3 = new Osoba(osoba2);

            osoba1.WypiszImie("Jan");
            osoba2.WypiszImie("Jan");
            osoba3.WypiszImie("Jan");

            Console.WriteLine("Liczba zarejestrowanych osób to " + Osoba.instancjeKlasy);
        }
    }

    public class Osoba
    {
        private int id;
        private string imie;

        public static int instancjeKlasy = 0;

        public Osoba()
        {
            instancjeKlasy++;
        }

        public Osoba(int id, string imie)
        {
            this.id = id;
            this.imie = imie;
            instancjeKlasy++;
        }

        public Osoba(Osoba osoba)
        {
            this.id = osoba.id;
            this.imie = osoba.imie;
            instancjeKlasy++;
        }

        public void WypiszImie(string podaneImie)
        {
            if (!string.IsNullOrEmpty(imie))
            {
                Console.WriteLine("Cześć " + podaneImie + " mam na imię " + imie);

            }
            else
            {
                Console.WriteLine("Brak danych");
            }
        }
    }
}
