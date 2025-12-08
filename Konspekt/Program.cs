
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

Console.WriteLine("Tere, kas sa tahad ära mõõta kasti või õlitünni?");
string valik = Console.ReadLine();
if (valik == "tünn")
{
    Console.WriteLine("Kas sa tead tünni raadiust (r) või põhja läbimõõtu (d)");
    string rvõid = Console.ReadLine();
    Console.WriteLine("Sisesta see mõõt:");
    double mõõt = double.Parse(Console.ReadLine());
    if (rvõid == "d")
    {
        mõõt = mõõt / 2;
    }
    else if (rvõid != "r")
    {
        Console.WriteLine("Sisend ei ole tuntav");
    }
    Console.WriteLine("Kui kõrge on su tünn?");
    int kõrgus = int.Parse(Console.ReadLine());
    Console.WriteLine("Kui paks on tünni kaas?");
    int kaanepaksus = int.Parse(Console.ReadLine());
    double tünnipõhiS = Math.PI * (mõõt * mõõt);
    double mahtV = tünnipõhiS * (kõrgus - kaanepaksus);
    double küljepindala = tünnipõhiS * kõrgus;
    double kogupindala = (tünnipõhiS * 2) + küljepindala;
    Console.WriteLine($"Sinu tünn mahutab {mahtV} Tünni küljepindala on {küljepindala} Kogupindala aga on {kogupindala}");
}
else if (valik == "kast")
{
    Console.WriteLine("Kas su kast on kuubik (k) või risttahukas (r)? ");
    string kastitüüp = Console.ReadLine();
    if (kastitüüp == "k")
    {
        Console.WriteLine("Sisesta kasti küljepikkus:");
        double külgA = double.Parse(Console.ReadLine());
        double kuubik = Math.Pow(külgA, 3);
        double küljepindala = (külgA * külgA) * 6;
        double diagonaal = külgA * Math.Sqrt(3);
        Console.WriteLine($"Sinu kuubik mahutab {kuubik} Kuubiku küljepindala on {küljepindala} diagonaal aga on {diagonaal}");

    }
    else if (kastitüüp == "r")
    {
        Console.WriteLine("Mis on sinu kasti kõige pikem külg");
        double pikkkülg = double.Parse(Console.ReadLine());
        Console.WriteLine("Mis on sinu kasti kõige lühim külg");
        double lühikekülg = double.Parse(Console.ReadLine());
        Console.WriteLine("Mis on  sinu kasti kõrgus");
        double kõrgus = double.Parse(Console.ReadLine());
        double V = pikkkülg * lühikekülg * kõrgus;
        double kogupindala = 2 * ((pikkkülg * lühikekülg) + (lühikekülg * kõrgus) * (pikkkülg * kõrgus));
        double diagonaal = Math.Sqrt((pikkkülg * pikkkülg) + (lühikekülg * lühikekülg) + (kõrgus * kõrgus));
        Console.WriteLine($" Sinu kast mahutab {V} kasti külgpindala on {kogupindala}Diagonaal aga on {diagonaal}");
        //string string = "abc"; //ei sobi

        // muutuja nimeks ei sobi järgmised sõnad:
        //abstract, as, base, bool, break, byte, case, catch, char, checked, class, const, continue, decimal, default, delegate, do, double, else, volatile, while, ulong, unchecked, unsafe
        //ushort, using, virtual, void, switch, this, throw, true, try, typeof, uint, sealed, short, sizeof, stackalloc, static, string, struct, private, protected, public, readonly, ref, return, sbyte,
        // null, object, operator, out, override, params, interface, internal, is, lock, long, namespace, new
    }
    //Console.WriteLine("Palun sisesta oma kasutajanimi");
    //string kasutajanimi = "";
    //do
    //{
    //    kasutajanimi = Console.ReadLine();
    //}
    //while (kasutajanimi != "user1");
    //if (kasutajanimi == "user1")
    //{
    //    int ruuduSuurus = 0;
    //    do
    //    {

    //        Console.WriteLine("Kui suurt ruutu tahad?");
    //        ruuduSuurus = int.Parse(Console.ReadLine());
    //    } while (ruuduSuurus < 0 && ruuduSuurus > 20);

    //    char reaKujund = '1';
    //    string üksRida = "";
    //    int tsükliMuutuja = ruuduSuurus;
    //    do
    //    {
    //        üksRida += reaKujund;
    //    } while (tsükliMuutuja != 0);
    //    tsükliMuutuja = ruuduSuurus;
    //    do
    //    {
    //        Console.WriteLine(üksRida);
    //        tsükliMuutuja -= 1;
    //    } while (tsükliMuutuja != 0);
    //    Console.WriteLine($"Palun, siin on sinu ruut, suurusega {ruuduSuurus} x {ruuduSuurus}");
    //}
    if (true) { } //kaitstud sõna if kutsub esile tingimuslause, mille tingimus on sulgude vahel ning millele järgneb
    //koodiplokk tingimuse täitumisel teostatava koodiga
    else if (true) { } //kaitstud sõnad else ja if kutsuvad esile sekundaarse tingimuslause, mille tingimus
    //on samamoodi sulgude vahel, ning millele peab eelnema alati if või else if. Tingimuse täitumisel
    //ja eelneva tingimuse mittetäitumisel teostatakse koodiploki sees olev kood
    else { } //kaitstud sõna else kutsub esile järeltingimuse, millele peab eelnema kas if või else if, ning mille koodi-
             //ploki sisu täidektakse kõikide if ja else if sees olevate tingimuste läbikukkumisel

    /* Loogilised tehted */
    // && -> loogiline tehe, mida kasutatakse tingimuste kirjutamisel, ja mis annab positiivse vastuse (true) juhul kui
    // mõlemal pool && märki olevad tingimused täidetud. Kui üks neist pole, siis annab negatiivse vastuse (false)
    // || -> loogiline tehe, mida kasutatakse tingimuste kirjutamisel, ning mis annab positiivse vastuse (true) siis kui
    // vähemalt üks tingimus on täidetud, negatiivne vastus (false) tagatakse siis, kui kõik tingimused on täitmata.

    /* Võrdlusoperaatorid*/ 
    // == -> on võrdne. Võrdusmärkide ühel pool olev objekt peab vastama täpselt oma olemuselt võrdusmärkide teisel pool oleva objektiga, ei ole sama nagu üks võrdusmärk.
    // üks võrdusmark omistab, teine võrdleb.
    //!= -> ei ole võrdne. Võrdusmärgi ühel pool olev objekt *EI TOHI* olla samal kujul nagu teisel pool olev objekt
    /* Omistusoperaatorid ja kiirtehted */
    int arv = 1; // = -> üksik võrdusmärk omistab muutujale väärtuse
    arv += 1; // += -> võrdusmärk, mille ees on plus, automaatselt liidab muutujale otsa võrdusmärgi teisel pool oleva arvu
    // asendab tehet "arv = arv + 1"
    arv -= 1; // -= -> võrdusmärk mille ees on miinus, automaatselt lahutab muutujast maha võrdusmärgi teisel pool oleva väärtuse
    // asendab tehet "arv = arv - 1"
    arv *= 2; // võrdusmärk mille ees on korrutusmärk *. automaatselt korrutab muutuja sisu võrdusmärgi teisel pool oleva arvu kordi
    // asendab tehet "arv = arv * 2"
    arv /= 2; // võrdusmärk, mille ees on jagamismärk /. automaatselt jagab muutuja sisu võrdusmärgi teisel pool oleva arvu osadeks. asendab tehet "arv = arv / 2"
    /* Tsüklid */
    do // "do on kaitstud sõna, mis alustab do-while tsüklit pärast mida on koodiplokk, nint ütleb et tee seda koodi
    {

    } while (true); //niikaua kuni while järel olevate sulgude vahel olev tingimus on täidetud
// HEAD
                    //2. While
                    // on kaitstud sõna, mis alustab while tsükli varianti, ilma "do"-ta, ning ta vajab välist tsüklit
    string alfa = "a\nb"; // \n tekitab ühe sõna sisse reamurde, sõna kus on üks "\n" omab kahte rida
    string beta = $"{alfa}";  // $ -> lubab kasutada muutujaid loogiliste sulgude vahel otse teksti sees
                              //Console.WriteLine("e");
                              //// Console -> adresseritav moodul või objekt (Roheline)
                              //// . -> midagi selle objekti seest, sarnane windowsi kausta pathis oleva slashiga
                              ////    - komakohtadega andmetüüpidel komakoha tähistamine.
                              //// WriteLine -> adresseritav funktsioon objektist Console
                              //// () -> sulupaar mis omab endas funktsioonile vajalikku infot
                              ////     - saab kasutada ka if tingimuslauses oleva tingimuse piiramiseks, ehk teisiõnu "ifi parameeter"
                              ////     - kasutatakse ka matemaatilistes tehetes
                              //// [] -> tähistab massiive
                              //// {} -> koodiplokk, tavaliselt pärast tingimust või funktsiooni kirjeldust.
                              ////     - saab ka kasutada teksti sees muutujate kuvamiseks
                              //    // -> taane aitab arendajal aru saada millise koodiploki sees, miski on. Vajalik ka kompilaatorile.
                              //// "banana" -> parameeter mis antakse funktsioonile WriteLine töötlemiseks kaasa.
                              //// ; -> iga koodilause lõppeb komakooloniga
                              //// // -> kommentaaritingmärk üherealise kommentaari jaoks (kaks / märki)


    // 3. for
    int kogus = 6; // muutuja mida tsükkel kasutab töötamiseks mingisugusel kujul
    for (int k = 0; k < kogus; k++) // kaitstud sõna "for" alustab for tsüklit, pärast mida on sulud, mille vahel on kõik tsükli töö
                                    // jaoks vajalik info. esimene parameeter tekitab tsükli töö jaoks muutuja
                                    // teine parameeter on tingimuslause, mis kontrollib tingimuse täitumist
                                    // kolmas inkrementeerib tekitatud muutujat "k++;". pane tähele, et isa gulgude vahel
                                    // oleva osa järel on lauselõpumärk. Tsükli tööd kontrolliv tingimuslause
                                    // koosneb kolmest reast, mitte ühest nagu while või do-while puhul.
                                    // koodiplokk, kus tehakse mingi tegevus
                                    
    {
        Console.WriteLine(k); //antud juhul on tegevuseks muutuja "k" arvu väljakuvamine
    }


    // 4. foreach
    int[] arvuLoend = { 3, 89, 123412, 7, 67 }; // massiiv mida foreach tsükkel kasutab, või töötleb mingil kujul.
    foreach (var arvInLoend in arvuLoend) // kaitstud sõna foreach alustab foreach tsükli. Pärast mida on sulud, mille vahel tekitatakse
        // ajutine muutuja andmetüübiga "var" töödeldava andmekogumi üksikelemendi jaoks. Süntaksis olev kaitstud sõna
        // "in" väljendab, et tsükkel käib selle loendi elementide kohta, ning var "arvInLoend"
        // muutuja hoiab endas just peale sõna "in" oleva andmekogumi elementi. Tsüklil ei ole nähtavat tsüklimuutujat
        // ega tingimust, tsükkel toimib niikaua kuni elemente jätkub ehk tsükli töö käib iga üksiku elemendi kohta andmekogumis.
        // // Tsüklil ei ole vaja tsüklimuutujat, kuna talle on sisse ehitatud vaikimisi elemendi järjestuse jälgimine. Niipalju kui andmeid on, ongi see,
        // mitu korda tsükkel käivitatakse
    {  // {} koodiplokk, kus tehakse mingi tegevus
        Console.WriteLine(arvInLoend);     // antud juhul kuvatakse välja ajutine muutuja, mille sees on loendi element.
    }

    //int muutuja = 3;
    //// int -> muutuja nime ees olev andmetüübi kirjeldus. See näitab ära mis tüüpi andmed selle muutuja sees on
    //// = -> võrdusmärk omistab sellele muutujale mingisuguse väärtuse
    //// 3 -> väärtus mis sellele muutujale omistatakse

    ////võimalikud lihtandmetüübid:
    //int a = 1; // täisarv
    //decimal b = 2.0M; // kümnendsüsteemis olev komakohaga arv
    //float c = 3.0f; // kümnendsüsteemis olev ujukomaga arv
    //double d = 4.0d; // kümnendsüsteemis olev komakohaga arv, sarnane decimaliga
    //char c1 = 'a'; // üksainus täht või tähemärk
    //string s = "tekst"; // inimloetaval kujul tekst
    //var x = "abc"; // ebamäärase tüübiga kohalik muutuja. 
    //var y = 123;
    //const int z = 3; // konstant-tüüpi muutujaid ei saa muuta, need on read-only

    // võimalikud komposiitandmetüübid
    // [] -> masiiv on komposiitandmetüüp, mille sees saab olla mitu samat tüüpi lihtadnmetüüpi. Masiivi tähistatakse kantsulgudega
    // massiive saab olla ükskõik millist lihtandmetüüpi massiive
    // Esimene tekitusviis
 int[] arvuMassiiv = new int[3]; // andmetüüp väljendab, et tegu on täisarvutüüpi andmega ja kantsulud väljendavad
    // et tegu on ühtlasi ka masiiviga, nimeks on arvumassiiv
    // masiivi tekitamisel tuleb ära öelda, kui pikk või suur see masiiv on
    // Teine tekitusviis:
    int[] arvumMassiiv2 = [1, 2, 3];
    //teine massiivi tekitusviis, kus järjendi pikkuse sätestamise asemel, pannakse elemendid kohe sisse
    // järjendi pikkus tuletatakse arvust

    //2. loend:
    // List<T> -> Loend on komposiitandmetüüp, mille sees saab olla mitmeid samat tüüpi liht ja komposiitandmeid. Loend-tüüpi andmeid tähistatakse
    // Täiendava andmetüübikirjeldusega "List" mille järel noolsulgudesse asetatakse mis tüüpi andmed loendis on.
    // Loendi tekitamisel, erinevalt massiivist, ei pea ütlema, kui pikk loend on. Loendisse saab dünaamiliselt elemente juurde 
    // lisada, ehk tema pikkus ei ole fikseeritud. 
    // Sarnaselt massiiviga, saab loend omada endas teisi loendeid.
    // Esimene tekitusviis:
    List<int> arvuNimekiri = new List<int>(); // Andmetüübi kirjeldus "List<>" näitab, et tegu on loendiga, List noolsulgude vahel on loendis
                                              // olevate andmete andmetüüp, muutuja nimeks on "arvuNimekiri". Omistame sellesse muutujasse //kaitstud sõna "new" abil uue tühja täisarvuloendi loendi sätestusega "List<int>()".

    // teine tekitusviis:
    List<int> arvuNimekiri2 = new List<int>() { 1, 2, 3 }; // teine loendi tekitusviis, muutuja instantsieerimine võrdusmärgi ees on sama nagu esimesel, juurde
                                                           // tuleb ainult võrdusmärgi taga olevate sätestusele loogelised sulud koos juba sinna asetatud elementidega. Enam ei ole tegu tühja nimekirjaga
                                                           // vaid loendiga, kus on kolm elementi.

    // Kolmas tekitusviis:
    List<int> arvuNimekiri3 = new List<int>(3); // Kolmas loendi tekitusviis kus muutuja instantsieerimine jääb samaks, aga tavaliste sulgude
    // vahel, sarnaselt massiiviga, saame anda loendile esialgse suuruse. Loend ise ei oma veel andmeid, aga loendis on neli tühja elementi. Nimelt on sätestusel, peale andmetüüpi
    // kirjeldavaid noolsulge, paar tavalisi sulge, mille sisse saab parameetrina panna loendi
    // pikkuse. ()
    
    
    
    // -- Loendi sisemised meetodid:
    arvuNimekiri3.Add(67); // Loendi meetod "Add()" lisab enne punkti olevale järjendile uue elemendi, element mida lisada, on Add meetodi
    // sulgude vahel. Elementi saab lisada otse (antud juhul "67") või muutujana - näiteks ...Add(arv);
    arvuNimekiri3.Count(); // Loendi meetod "Count()" loeb kokku, mitu elementi järjendis on, meetod tagastab täisarvu, mis vastab elementide kogusele
    bool kasSeeArvOn = arvuNimekiri3.Contains(3); // Loendi meetod "Contains()" otsib kogu järjendi seest elementi, mis vastutab sulgude vahel olevatele parameetrile, tagastab kas true või false
    // on leitud või ei ole. Tegemist on põhimõtteliselt foreach tsükliga, mis otsib kindlat parameetrit, töödeldes läbi kogu loendi.

    arvuNimekiri3.Remove(4); // Loendi meetod "Remove()" eemaldab enne punkti olevast loendist, kindlal asukohal oleva elemendi. Sulgude vahel
                             // on parameetriks eemaldatava elemendi asukohajärjekorranumber. 


    ////põhilised matemaatilised tehted
    //int liitmine = 1 + 1; // liitmine, kaks arvu kokku
    //int lahutamine = 1 - 1; // lahutamine, esimene arv maha teisest
    //int korrutamine = 1 * 1; //korrutamine, esimene arv korrutatakse teisega
    //int jagamine = 1 / 1; //jagamine, esimene arv jagatakse teisega
    //double astendamine = Math.Pow(2, 2); //astendamine, esimene arv astendatakse teisega
    //double juurimine = Math.Sqrt(2); //ruutjuur, parameetriks arv mida juuritakse


    //int arv = 0; // sobib
    //string sõne = "abc"; //sobib
    //string string = "abc"; //ei sobi

    // muutuja nimeks ei sobi järgnevad sõnad:
    //abstract, as, base, bool, break, byte, case,
    //catch, char, checked, class, const, continue, decimal,
    //default, delegate, do, double, else, enum, event,
    //explicit, extern, false, finally, fixed, float, for
    //foreach, goto, if, implicit, in, int,
    //interface, internal, is, lock, long, namespace, new,
    //null, object, operator, out, override, params,
    //private, protected, public, readonly, ref, return, sbyte,
    //sealed, short, sizeof, stackalloc, static, string, struct,
    //switch, this, throw, true, try, typeof, uint,
    //ulong, unchecked, unsafe, ushort, using, virtual, void,
    //volatile, while.

    ////Ülesanne, kasutades süntaksiseletust, kirjelda kommentaariga iga koodirida
    //Console.WriteLine("tere, sisesta esimene liidetav arv");
    ////Adresseerime moodulit "Console", punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum
    //// mis asub funktsiooni taga olevate sulgude vahel, antud rida lõppeb lauselõpumärgiga.
    //int arv1 = int.Parse(Console.ReadLine());
    //// instantsieerime muutuja "arv1", ning ütleme et sinna saab panna täisarve andmetüübisõnaga int, selle muutuja sisse omistame tulemuse
    //// mille saame kasutajalt Console.Readline() abil (kasutame moodulist "Console" realugemisfunktsiooni), ning teisendame int andmetüübis
    //// asuva funktsiooni "Parse" abil kasutajasisendi täisarvuks. Lause lõppeb lauselõpumärgiga ; .
    //Console.WriteLine("tere, sisesta teine liidetav arv");
    ////Adresseerime moodulit "Console", punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum
    //// mis asub funktsiooni taga olevate sulgude vahel, antud rida lõppeb lauselõpumärgiga.
    //int arv2 = int.Parse(Console.ReadLine());
    //// instantsieerime muutuja "arv2", ning ütleme et sinna saab panna täisarve andmetüübisõnaga int, selle muutuja sisse omistame tulemuse
    //// mille saame kasutajalt Console.Readline() abil (kasutame moodulist "Console" realugemisfunktsiooni), ning teisendame int andmetüübis
    //// asuva funktsiooni "Parse" abil kasutajasisendi täisarvuks. Lause lõppeb lauselõpumärgiga ; .
    //Console.WriteLine("sisesta tehemärk: / * + - ^");
    ////Adresseerime moodulit "Console", punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum
    //// mis asub funktsiooni taga olevate sulgude vahel, antud rida lõppeb lauselõpumärgiga.
    //string tehtetyyp = Console.ReadLine();
    //// tekitame muutuja "tehtetyyp", mille ette paneme andmetüübiks string ehk ütleme et seal on tekst, ning võrdusmärgi abil omistame talle
    //// konsooli rea pealt loetu info, mis saame kasutades "Console" mooduli, ReadLine() funktsiooni. lause lõppeb lauselõpumärgiga ; ..

    //int tulemus = 0;
    //// instantsieerime muutuja tulemus, mille andmetüübiks on int, ja omistame talle esialgu väärtuse 0. Lause lõpp lõpeb lauselõpumärgiga
    //if (tehtetyyp == "+")
    //// teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "+"
    //{
    //    tulemus = arv1 + arv2;
    //}
    //// peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisaldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus liites kokku
    //// muutuja arv1 ja muutuja arv2. Lause lõppeb lauselõpumärgiga sulgude sees.
    //if (tehtetyyp == "-")
    //// teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "-"
    //{
    //    tulemus = arv1 - arv2;
    //}
    //// peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisaldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus lahutades
    //// muutujast arv1 muutuja arv2. Lause lõppeb lauselõpumärgiga sulgude sees.  
    //if (tehtetyyp == "*")
    //// teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "*"
    //{
    //    tulemus = arv1 * arv2;
    //}
    //// peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisaldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus korrutades
    //// muutuja arv1 ja muutuja arv2 sisu omavahel kokku. Lause lõppeb lauselõpumärgiga sulgude sees.
    //if (tehtetyyp == "/")
    //// teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "/"
    //{
    //    tulemus = arv1 / arv2;
    //}
    //// peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisaldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus jagades
    //// muutuja arv1 muutujaga arv2. Lause lõppeb lauselõpumärgiga sulgude sees.
    //if (tehtetyyp == "^")
    //// teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "^"
    //{
    //    tulemus = (int)Math.Pow(arv1, arv2);
    //}
    //// peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisaldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus kasutades
    //// moodulist "Math" punkti abil funktsiooni "Pow()", selle sees on arv1 astendatavana esimene parameeter, ning arv2 astendajana teine parameeter.
    //// Funktsiooni ees on kiirteisendus kus funktsiooni väljund teisendatakse täisarvuks (int) abil. Lause lõppeb lauselõpumärgiga sulgude sees.

    //Console.WriteLine(tulemus);
    //// Adresseerime moodulit "Console", ning kasutame sealt funktsiooni "WriteLine" koos sulgude vahel parameetriga tulemus, et kuvada kasutajale tehte vastus.
    //// lause lõppeb lauselõpumärgiga.




    /* meetodid */
    // Meetodid on väljakutsutavad koodijupid. Meetodid teostavad tavaliselt mingeid funktsioone või tegevusi.
    // Meetodid lasevad programmeerijal taaskasutada oma eelnevalt kirjutatud koodi - write once use many times.
    // Meetodeid on kahte liiki - ühed, mis tagastavad andmeid töö tulemina, ja teised, mis ei tagasta
    // midagi, kuid omavad siiski mingit tegevust


    // meetofdi signatuur
    // Meetodi signatuur koosneb mitmest kindlalt äramääratud omadusest, nendeks on:
    // - Juurdepääsu modifikaator ütleb ära, kust ja kuidas sellele meetodile juurde pääseda saab
    //  public - meetofd on avalik ja kättesaadav ka teistes klassides peale selle, kus meetod ise asub
    // private - meetod saadaval ainult selles klassis, kus meetod ise asub
    // protected - meetod saadaval ainult selles klassis, kus meetod ise asub ja kõikides klassides mille pärilus sellele klassile
    // internal - meetod saadaval ainult selles klassis ja ainult selles failis.
    // Tagastustüüp on modifikaator mis ütleb ära, mis tüüpi meetod tagasi annab kutsumise asukohta.
    // Andmetüüp mida tagastada võib olla ükskõik milline liht või kombinatsioonandmetüüp, aga kui meetod ei tagasta üldse andmeid, pannakse selle asemel andmetüübiks "void".
    // void on andmeedastustüüp, mida muutujatele anda ei saa, void on andmetüüp mida kasutatakse meetodite jms signatuurides, et näidata tagastatava andmetüübi puudumist.
    // Tegemist on sõna otseses mõttes mitte millegagi
    // Kaitstud sõna return ütleb, et just see, on vaja väljakutseasukohta tagastada, ning peale returni on muutuja nimi tagastatava infoga. Peale return lauset ei teostata mitte ühtegi muud meetodi sisu.
    // Return toimib ka kui breakina
    static void UusMeetod()
        {
        Console.WriteLine("Tere");
           
        }
    // 2. tüüpi meetod - tagastab väärtuse
    int[] arvutatavadArvud = new int[] { 3, 67, 420 };

    public static int ArvutaKokku(int[]arvud )  //meetod, mille signatuuris on juurdepääsumodifikaator public, static ütleb et meetod kuulub siia klassi, tagastustüüp "int" ütleb, et
                                               // programmis väljakutseasukohta tagastatakse täisarv, peale seda on meetodi nimi "ArvutaKokku" ning sulgude vahel ootab meetod täisarvumassiivi, millele pannakse meetodi sees ajutine nimi arvud.
                                               // Peale signatuuri on koodiplokk {} tehtava koodiga.

{


    int summa = 0; // Tekitatakse täisarvuandmetüüpi muutuja nimega "summa", kuhu esialgu omistatakse arv 0.
    foreach (int i in arvud) // foreach tsükliga käiakse kõik täisarvumassiivi "arvud" arvud läbi

    {
        summa + - = i; // ja muutujale summa lisatakse juurde, hetkel käidav element
    }
    return summa; // pärast tsükli töö lõppu tagastatakse return käsu abil muutuja summa sisu
}
//private static void Main(string[] args)
//{
//    NewMessage();
//    List<string> ostunimekiri = new List<string>();
//    Console.WriteLine("Sisesta oma tänane poeskäigunimekiri");
//    string kasutajasisestus = "";
//    // meetodi väljakutse
//    GetUserInput(kasutajasisestus, ostunimekiri);
//    Console.WriteLine("See on sinu nimekiri: \n");
//    foreach (var söök in ostunimekiri)
//    {
//        Console.WriteLine($"-*- {söök}");
//    }
//    GetUserInput(kasutajasisestus, ostunimekiri);
//}

//static List<string> GetUserInput(string kasutajasisestus, List<string> ostunimekiri)
//{
//    while (kasutajasisestus == "")
//    {
//        Console.WriteLine("Palun järgmine ost ostunimekirja, kirjuta \"rohkem pole\" et lõpetada:");
//        kasutajasisestus = Console.ReadLine();
//        if (kasutajasisestus == "rohkem pole")
//        {
//            break;
//        }
//        ostunimekiri.Add(kasutajasisestus);
//        kasutajasisestus = "";
//    }
//    return ostunimekiri;

//}
//// static - staatiline selles klassis
//// private- meetod on saadaval ainult selles klassis
//// public - meetod on saadaval ükskõik millises klassis
//// protected - meetod on saadaval ainult seal klassis, või testes klassides mis pärib selle klassi andmed
//// internal - on saadaval ainult iseenda sees
//static void NewMessage()
//{
//    Console.WriteLine("NewMessage");
//}

    
    private stativ void Main(string[] args)

Console.WriteLine("Kas sa soovid münti visata, või täringut veeretada?");
string müntVõiTäring = Console.ReadLine();

if (müntVõiTäring == "münt")

{ Console.WriteLine(müntVõiTäring(juhuarv));
    else if (müntVõiTäring == "täring")
} Console.WriteLine(müntVõiTäring(juhuarv));
else
{
    Console.WriteLine("valikut ei ole");


    public static string Münt(Random juhuarv)
{
    int mündivise = juhuarv.Next(1, 2);
    if (mündivise == 1)
    { return "kull"; }
    else
    { return "kiri"; }



 public static int Täring(random juhuarv)
{

    int täringuvise = juhuarv.Next(1, 6);
    return täringuvise;
}

/* Castimine */
// Castimine on viis, kuidas ühest andmetüübist teist saada. Castimist on kahte eri liiki, automaatne ja manuaalne.
// Automaatne castimine toimb siis, kui teisendatakse väiksemast andmetüübist suuremasse.
// Manuaalne castimine toimub siis, kui tahetakse saada suuremast andmetüübist väiksemat
// Castitakse nii, et teisendatava muutuja ette pannakse sulud koos soovitud andmetüübiga.


double newdata1 = 2.22d; // tekitame või on olemas suure mahuga andmed muutujas newdata1. Tegu double andmetega
float data1Float = (float)newdata1; // (float) teisendab double tüüpi andmed float tüüpi andmeteks.
long data1long = (long)newdata1; // (long) teisendab double tüüpi andmed long tüüpi andmeteks.
int data1int = (int)newdata1; // (int) teisendab double tüüpi andmed int tüüpi andmeteks.
char data1char = (char)newdata1; // (char) teisendab double tüüpi andmed char tüüpi andmeteks.

Math.Round(d); // moodulist math kutsutakse punkti abil esile meetod "round". Sulgude vahel on ümardatav arv.
// round ümardab sulgude vahel olevas muutujas asetseva arvu, vastavalt komakohtade parameetrile.
// Vaikeväärtusena, lähima täisarvuni. 0-4 on allapoole, 5-9 on ülespoole.
double newpi = Math.Pi // moodulist Math.Pi kutsutakse punkti abil esile kaitstud väärtus



}







    
    
    
    
    
    
    
    
    
    
    
    
    
    
    //// https://github.com/Estlib/Konspekt_Jyri_Vaitmaa_IKTpe25/blob/main/Konspekt/Program.cs
}

            







