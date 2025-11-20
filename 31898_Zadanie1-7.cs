//Zadanie 1

string haslo = "";

while (haslo != "admin123")
{
    Console.Write("Podaj haslo: ");
    haslo = Console.ReadLine();
}

Console.WriteLine("Zalogowano pomyslnie!");



//Zadanie 2

int liczba;

do
{
    Console.Write("Podaj liczbe wieksza od 0: ");
    liczba = int.Parse(Console.ReadLine());

} while (liczba <= 0);

Console.WriteLine("Podales: " + liczba);



//Zadanie 3 

string[] miasta = { "Warszawa", "Krakow", "Gdansk", "Poznan", "Wroclaw" };

foreach (string x in miasta)
{
    Console.WriteLine(x);
}



//Zadanie 4

class Osoba
{
    public string Imie;
    public int Wiek;

    public void PrzedstawSie()
    {
        Console.WriteLine("Czesc, jestem " + Imie + " i mam " + Wiek + " lat.");
    }
}

Osoba o1 = new Osoba();
o1.Imie = "Jan";
o1.Wiek = 20;

Osoba o2 = new Osoba();
o2.Imie = "Ala";
o2.Wiek = 25;

o1.PrzedstawSie();
o2.PrzedstawSie();



//Zadanie 5

class KontoBankowe
{
    private double saldo;

    public void Wplata(double kw)
    {
        saldo = saldo + kw;
    }

    public void Wyplata(double kw)
    {
        if (saldo >= kw)
        {
            saldo = saldo - kw;
            Console.WriteLine("Wyplacono: " + kw);
        }
        else
        {
            Console.WriteLine("Za malo srodkow");
        }
    }

    public double PobierzSaldo()
    {
        return saldo;
    }
}



//Zadanie 6

class Zwierze
{
    public void Jedz()
    {
        Console.WriteLine("Zwierze je");
    }
}

class Pies : Zwierze
{
    public void Szczekaj()
    {
        Console.WriteLine("Hau hau!");
    }
}

class Kot : Zwierze
{
    public void Mialcz()
    {
        Console.WriteLine("Mial!");
    }
}



//Zadanie 7

class Zwierze2
{
    public virtual void DajGlos()
    {
        Console.WriteLine("Zwierze robi dzwiek");
    }
}

class Pies2 : Zwierze2
{
    public override void DajGlos()
    {
        Console.WriteLine("Hau hau!");
    }
}

class Kot2 : Zwierze2
{
    public override void DajGlos()
    {
        Console.WriteLine("Miau!");
    }
}

Zwierze2[] tab =
{
    new Pies2(),
    new Kot2(),
    new Pies2()
};

foreach (var z in tab)
{
    z.DajGlos();
}
