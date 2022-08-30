using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Src
{
    internal class Pokemon
    {
        int Id_Pokedex { get; set; }
        string Nome { get; set; }
        string Tipo { get; set; }
        int Evoluções { get; set; }
        string Fraquezas { get; set; }

        public Pokemon(int id_Pokedex, string nome, string tipo, int evoluções, string fraquezas)
        {
            Id_Pokedex = id_Pokedex;
            Nome = nome;
            Tipo = tipo;
            Evoluções = evoluções;
            Fraquezas = fraquezas;
        }

        public override string ToString()
        {
            return $"Lista de Pokemons capturados: Id na Pokedex {Id_Pokedex} \n" +
                   $"Nome: {Nome} \n" +
                   $"Tipo: {Tipo} \n" +
                   $"Evoluções: {Evoluções} \n" +
                   $"Fraquezas: {Fraquezas} \n";
        }
    }
}
