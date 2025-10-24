
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

    //int muutuja = 3;
    //// int -> muutuja nime ees olev andmetüübi kirjeldus. See näitab ära mis tüüpi andmed selle muutuja sees on
    //// = -> võrdusmärk omistab sellele muutujale mingisuguse väärtuse
    //// 3 -> väärtus mis sellele muutujale omistatakse

    ////võimalikud andmetüübid:
    //int a = 1; // täisarv
    //decimal b = 2.0M; // kümnendsüsteemis olev komakohaga arv
    //float c = 3.0f; // kümnendsüsteemis olev ujukomaga arv
    //double d = 4.0d; // kümnendsüsteemis olev komakohaga arv, sarnane decimaliga
    //char c1 = 'a'; // üksainus täht või tähemärk
    //string s = "tekst"; // inimloetaval kujul tekst
    //var x = "abc"; // ebamäärase tüübiga kohalik muutuja. 
    //var y = 123;
    //const int z = 3; // konstant-tüüpi muutujaid ei saa muuta, need on read-only

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
    //// https://github.com/Estlib/Konspekt_Jyri_Vaitmaa_IKTpe25/blob/main/Konspekt/Program.cs
}








