// Olio-ohjelmointi - Aleksi Bovellan - INTIM21A6
// Harjoitus 1


// Alustuksia

int kierrosLaskuri = 0;
int kysymysLaskuri = kierrosLaskuri + 1;
double annaLuku;
double numerotYhteensa = 0.0;


// Kysytaan numeroiden kpl

Console.WriteLine("Terve!\n");

Console.WriteLine("Monenko luvun keskiarvon haluaisit saada?");

int numeroidenMaara;
int.TryParse(Console.ReadLine(), out numeroidenMaara);


// Loopataan tarvittavat numerot talteen

while (kierrosLaskuri != numeroidenMaara)
{
    Console.WriteLine("\nAnna {0}. lukusi:", kysymysLaskuri);

    double.TryParse(Console.ReadLine(), out annaLuku);

    numerotYhteensa += annaLuku;
    kierrosLaskuri++;
    kysymysLaskuri++;
}


// Lasketaan ja tulostetaan saatujen numeroiden keskiarvo

double numeroidenKeskiarvo = numerotYhteensa / numeroidenMaara;

Console.WriteLine("\nLukujesi keskiarvo oli: {0}", numeroidenKeskiarvo);
Console.WriteLine("\n");
