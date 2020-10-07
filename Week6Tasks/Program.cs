using System;

namespace Week6Tasks
{
    class Program
    {
        static void Main(string[] args)
        { //{random superhero} will fight {random Supervillain} with a {random weapon}*

            string[] superHeroes = new string[5] { "Batman", "Rick Grimes", "Pepe", "Thor", "Spider man" };
            string[] superVillains = new string[5] { "Rogue Superman", "Riddler", "Joker", "Darth Vader", "T-1000" };
            string[] weapon = new string[5] { "Colt python", "knife", "battarang", "thin air", "bag of sand" };
            int i = 0;
            while (i < superHeroes.Length) 
            while (i < superVillains.Length) 
            while (i < weapon.Length) 
            
           i++;
           Random rnd = new Random();
            Console.WriteLine($"{superHeroes[rnd.Next(0,superHeroes.Length)]} will fight {superVillains[rnd.Next(0,superVillains.Length)]} with {weapon[rnd.Next(0,weapon.Length)]}");
            

            
            
           

        }
    }
}
