
//1. tuvasta sisu võrdluses tühja stringiga, string andmetüüp
using System.ComponentModel.Design;

Console.WriteLine("Tere Kasutaja, kuidas on su  nimi?");
string nimi = Console.ReadLine();

if (nimi == "")
{
    Console.WriteLine("Sa ei sisestanud oma nime, sadface 😢");
}
else if (nimi != "")
{
    Console.WriteLine("Tere "+nimi+""! );
}
else
{
    Console.WriteLine("Tundmatu sisestus.");
}
//2. vahemikud
Console.WriteLine(nimi + ", mis on sinu vanus?");
int kasutajavanus = int.Parse(Console.ReadLine());



//2.1 mitu tingimust pesastatud ifide abil
//if (kasutajavanus > 0)
//{
//    if (kasutajavanus < 18)
//    {
//        Console.WriteLine("Kahjuks enerksi sa ei saa, oled alakas, monsterist ilma");
//    }
//    else
//    {
//        Console.WriteLine("Yippie! saad monsut osta");
//    }


//}
//2.2 mitu tingimust kasutades loogilist tehet "and"
//if (kasutajavanus > 0)
//{
//    if (kasutajavanus < 16)
//    {
//        Console.WriteLine("Kahjuks enerksi sa ei saa, oled alakas, monsterist ilma");
//    }
//    else
//    {
//        Console.WriteLine("Yippie! saad monsut osta");
//    }


//}
////2.3 mitu vahemikku if/else-if abil. andmetüüp double/float/decimal
//Console.WriteLine($"Siseta oma pikkus ka {nimi}");
//double kasutajaPikkus = double.Parse(Console.ReadLine());


//if (kasutajaPikkus < 1.00d)
//{
   
//    Console.WriteLine("Oled Juntsu");
//}

// else if (kasutajaPikkus < 1.50d && kasutajaPikkus >= 1.25d)
//{
//    Console.WriteLine("Oled peaaegu allameetrimees");
//} 


//else if (kasutajaPikkus < 1.25d && kasutajaPikkus >= 1.00d)
//{
//    Console.WriteLine("OIOIOI, päkapik enam polegi, "+nimi);
//}
//else if (kasutajaPikkus < 1.75d && kasutajaPikkus >= 1.5d)
//{
//    Console.WriteLine("Oled enamasti standardpikkuses, kui mitte natuke lühike,, "+nimi);
//}

//else if (kasutajaPikkus < 2.00d && kasutajaPikkus >= 1.75d)
//{
//    Console.WriteLine("Oled pikk kolge, vaata et oma suurt pead ära ei löö"+nimi);
//}
//else
//{
//    Console.WriteLine("Täielik tulnukas! Kuidas pilved välja näevad lähedalt?");
//}
////3. kalkulaator ifi ja else-ifiga, int ja string andmetüüp
//int liidetav1 = 0;
//int liidetav2 = 0;
//Console.WriteLine("Tere, palun sisesta esimene liidetav");
//liidetav1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Tere, palun sisesta esimene liidetav");
//liidetav2 = int.Parse(Console.ReadLine());
//int liitmine = liidetav1 + liidetav2;
//int arv1 = 0;
//int arv2 = 0;
//Console.WriteLine("Tere, palun sisesta esimene arv: ");
//arv1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Tere, palun sisesta teine arv: ");
//arv2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Missugust tehet soovid teha? Kirjuta kas: + - / * ^");
//string tehtetüüp = Console.ReadLine();
//int tehe = 0;
//if (tehtetüüp == "+" )
//{
//    tehe = arv1 + arv2;
//}
//if (tehtetüüp == "-" )
//{
//    tehe = arv1 - arv2;
//}
//if (tehtetüüp == "*" )
//    tehe = arv1 * arv2;
//{ 
//if (tehtetüüp == "/" )
//{
//    tehe = arv1 / arv2;
//}
//if (tehtetüüp == "^")
//    tehe = (int)Math.Pow(arv1, arv2);
//}

//Console.WriteLine($"{tehtetüüp} Tehte tulemus: {tehe}");
////4. parool, if ja string andmetüüp
//Console.WriteLine($"Palun vabandust{ nimi}, aga programmi edasiseks tööks on parooli vaja");
//string password = Console.ReadLine();
//if (password =="simsalabim")
//{
//    Console.WriteLine("YIS, parool on õige, oled sisse lubatud");
//}
//else if (password =="saatana" || password =="1234")
//{
//    Console.WriteLine("Parool on sobimatu, see sinu parool kindlasti ei ole");
//}
//else
//{
//    Console.WriteLine("Parool on vale");
//}
////5 värvituvastus
//Console.WriteLine("Mis on sinu lemmikvärv?");
//string favColour = Console.ReadLine();
//if (favColour == "punane")
//{
//    Console.BackgroundColor = ConsoleColor.Red;
//}
//else if (favColour == "roheline")
//{
//    Console.BackgroundColor = ConsoleColor.Green;
//}
//else if (favColour == "sinine")
//{
//    Console.BackgroundColor = ConsoleColor.Blue;
//}
//else if (favColour == "kollane")
//{
//    Console.BackgroundColor = ConsoleColor.Yellow;
//}
//else if (favColour == "valge")
//{
//    Console.BackgroundColor = ConsoleColor.White;
//}
//else if (favColour == "oranz")
//{
//    Console.WriteLine("Kahjuks ei ole oranz saadaval");
//}
//else if (favColour == "must")
//{
//    Console.BackgroundColor = ConsoleColor.Black;
//}
//else if (favColour == "lilla")
//{
//    Console.BackgroundColor = ConsoleColor.DarkMagenta;
//}
//else if (favColour == "roosa")
//{
//    Console.BackgroundColor = ConsoleColor.Magenta;
//}

//else
//{
//    Console.WriteLine("Ei tea seda värvi!!!");
//}
//Console.WriteLine("The colour has maybe changed!!!!!");

Console.WriteLine("Tere, kas sa tahad ära mõõta pappkasti või õlitünni?");
string mõõdetav = Console.ReadLine();
if (mõõdetav == "pappkasti")
{
    Console.WriteLine("Mis on sinu pappkasti mõõtmed?");
}
Console.ReadLine();