using System.ComponentModel.Design;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kirjuta programm, kus on kaks kasutajat (kasutajanime ja parooliga)


            List<List<string>> kasutajad = new List<List<string>>();
            kasutajad.Add(new List<string> { "kasutajanimi1", "parool1" });
            kasutajad.Add(new List<string> { "kasutajanimi2", "parool2" });
            //foreach (var item in kasutajad)
            //{
            //    Console.WriteLine(item.ToString() + item[0]+ item[1]);
            //}
            string kasutajanimi = "";
            Console.WriteLine("Palun sisesta oma kasutajanimi");
            kasutajanimi = Console.ReadLine();
            bool doesuserexist = false;
            string õigeparool = "";
            foreach (var user in kasutajad)
            {
                if (user[0] == kasutajanimi)
                {
                    doesuserexist = true;
                    õigeparool = user[1];
                }
                if (doesuserexist == true)
                {
                    string sisestus = "";
                    Console.WriteLine("Tere", kasutajanimi, "sisesta oma parool");
                    while (sisestus != õigeparool)
                    {
                        Console.WriteLine("Palun sisesta oma parool");
                        sisestus = Console.ReadLine();
                    }
                    Console.WriteLine($"Tere tulemast, {kasutajanimi} ");
                    
                }
                else
                {
                    Console.WriteLine("kasutaja ei eksisteeri");
                }
            }
        }
    }
}
