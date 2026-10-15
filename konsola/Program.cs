class Program
{
    static void Main(string[] args)
    {
        Notatka notatka = new Notatka("Spotkanie z kolegami", "", true);
        
        Console.WriteLine("Podaj tytuł notatki:");
        string tytul = Console.ReadLine();
        Notatka notatka2 = new Notatka(tytul);
        notatka.Wypisz();
        notatka2.Wypisz();
    }
}

class Notatka
{
    public string tytul = "";
    public string tresc = "";
    public bool wazna = false;
    public DateTime data = new();

    public Notatka(string tytul, string tresc, bool wazna)
    {
        this.tytul = tytul;
        this.tresc = tresc;
        this.wazna = wazna;

        this.data = DateTime.Now;
    }

    public Notatka(string tytul)
    {
        this.tytul = tytul;
        this.tresc = "";
        this.wazna = true;
        this.data = DateTime.Now;
    }

    public void Wypisz()
    {
        Console.WriteLine("__________________");

        if (wazna)
        {
            Console.WriteLine($"Notatka WAŻNA! {tytul}");
        }
        else
        {
            Console.WriteLine($"Notatka {tytul}");
        }

        Console.WriteLine(tresc);
        Console.WriteLine(data);
        Console.WriteLine("__________________");
    }
}



/*
 * nazwa: Wypisz
 * 
 * opis: MEtoda wypisuje dane notatek. W zależności czy wazna = true, wypisuje notatka ważna lub nie.
 * 
 * parametry: brak
 * 
 * zwracany typ: brak
 */