using Pokedex.Src;
using System;

namespace Pokedex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vinda(o) a sua Pokedex! \n");            

            Pokemon squirtle = new Pokemon(007, "Squirtle", "Água", 02, "Elétrico/Grama");
            Pokemon jigglypuff = new Pokemon(039, "Jigglypuff", "Normal/Fada", 02, "Aço/Veneno");
            Pokemon psyduck = new Pokemon(054, "Psyduck", "Água", 01, "Elétrico/Grama");
            Pokemon mankey = new Pokemon(056, "Mankey", "Lutador", 01, "Fada/Psíquico/Voador");
            Pokemon slowpoke = new Pokemon(079, "Slowpoke", "Água/Psíquico", 02, "Elétrico/Fantasma/Grama/Inseto/Sombrio");

            Console.WriteLine(squirtle.ToString());
            Console.WriteLine(jigglypuff.ToString());
            Console.WriteLine(psyduck.ToString());
            Console.WriteLine(mankey.ToString());
            Console.WriteLine(slowpoke.ToString());
        }
    }
}
