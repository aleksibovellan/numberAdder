// Olio-ohjelmointi - Aleksi Bovellan - INTIM21A6
// Harjoitus 2


// Alustuksia

string? yhteenVaiVahennys = null;
double summa;


// Kysytään tehdäänkö yhteen- vai vähennyslasku

Console.WriteLine("Terve!\n");

Console.WriteLine("Yhteen- vai vähennyslasku? (+/-)");
yhteenVaiVahennys = Console.ReadLine();


// Tarkistetaan oliko syöte halutun kaltainen - jos ei, niin eteneminen keskeytyy.

if (yhteenVaiVahennys == "+" || yhteenVaiVahennys == "-") {


    // Kysytaan tarvittavat numerot talteen

    Console.WriteLine("\nAnna ensimmäinen luku:");

    double ekaLuku;
    double.TryParse(Console.ReadLine(), out ekaLuku);


    Console.WriteLine("Anna toinen luku:");

    double tokaLuku;
    double.TryParse(Console.ReadLine(), out tokaLuku);


    // Tehdään haluttu laskutoimitus ja printataan lopputulos

    if (yhteenVaiVahennys == "+")
    {
        summa = ekaLuku + tokaLuku;
        Console.WriteLine("\nAntamiesi lukujen summa on: " + summa);
    }
    else
    {
        summa = ekaLuku - tokaLuku;
        Console.WriteLine("\nAntamiesi lukujen erotus on: " + summa);
    }

}
else {
    // Muuten, näkemiin.
    Console.WriteLine("\nValintasi ei ollut oikeanlainen. Sorry.\n");
}
