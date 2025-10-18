

Console.WriteLine("Palun sisesta oma ostusumma");
// Console.WriteLine prindib teksti või väärtuse järele uue rea
int ostusumma = 0;
// Int salvestab täisarve ilma kümnendkohtadeta
 ostusumma = int.Parse(Console.ReadLine());
// int.Parse teisendab stringi 32-bitiliseks täisarvuks

 if (ostusumma > 0 && ostusumma <= 24)
    {
        Console.WriteLine("Sinu allahindlus on 0%");
    }
 // if ja if else on tingimuslaused, mis võimaldavad koodi harude loomist
    else if (ostusumma >= 25 && ostusumma <= 49)
    {
        Console.WriteLine("Sinu allahindlus on 5%");

    }
    else if (ostusumma >= 50 && ostusumma <= 74)
    {
        Console.WriteLine("Sinu allahindlus on 10%");
    }
    else if (ostusumma >= 75 && ostusumma <= 100)
    {
        Console.WriteLine("Sinu allahindlus on 20%");
    }
    else if (ostusumma >= 101)
    {
        Console.WriteLine("Sinu allahindlus on 20%");
    }



