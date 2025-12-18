namespace Ülesanded
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kirjuta programm, mis küsib kasutajalt tsüklis, millised sõnad talle meeldivad
            // küsimiste tulemus hoia järjendis
            List<string> mängud = new List<string>();
            Console.WriteLine("Tere kasutaja, millised mängud sulle meeldivad");
            string mäng = "";
            while (mäng =="")
            {
                Console.WriteLine($"Palun sisesta järgmine mäng, kui ei ole, kirjuta \"ei ole\"");
                mäng = Console.ReadLine();
                if (mäng != "ei ole")
                {
                    mängud.Add(mäng);
                }
               if (mängud.Contains("mario kart"))
                {
                    Console.WriteLine("Kui vana oled??????? Mingi kuus vä?????");
                }
               if (mängud.Contains("gta 6"))
                {
                    Console.WriteLine("Kust ajamasina said? Kuidas rockstar arendusaega juurde sai?");
                }
               if (mängud.Contains("pong"))
                {
                    Console.WriteLine("80ndad tahavad vanureid tagasi, toimub boomerite recall");
                }
            }
            //kui järjend sisaldab (.Contains()) "mario kart", siis küsi kui vana ta on, sarkastiliselt.
            //kui järjend sisaldab "gta 6", siis küsi kust ta ajamasina sai, et  rockstar lõpuks asjaga valmis sai
            // kui järjend sisaldab "pong", siis ütle "80ndad tahavad vanureid tagasi, toimub boomerite recall"
            // kui järjend on tühi, siis programm läheb edasi ->

            if (!mängud.Any())
            {
                Console.WriteLine("Kas sulle ei meeldi mängud, vasta kas jah või ei");
                string jahvõiei = Console.ReadLine().ToLower();
                if (jahvõiei.Contains("Jah"))
                {
                    Console.WriteLine("Aga miks siis ei sisestanud");
                }
                else if (jahvõiei.Contains("ei"))
                {
                    Console.WriteLine("Kahju :c");
                }
                else
                {
                    Console.WriteLine("Ei saa aru :/");
                }
            }
        }
    }
}
