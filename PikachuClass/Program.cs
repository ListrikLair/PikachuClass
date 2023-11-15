using System.Net.Security;
using PikachuClass;

List<Pokemon> pokemonList = new List<Pokemon>();
//     pokemonList.Add(new Pokemon {Name = "Pikachu", Hp = 50, Level = 24 });
//     pokemonList.Add(new Pokemon {Name = "Swablu", Hp = 38, Level = 13 });
//     pokemonList.Add(new Pokemon {Name = "Giratina", Hp = 180, Level = 63 });
//
// foreach (var pokemon in pokemonList)
// {
//     Console.WriteLine($"{pokemon.Name} is level {pokemon.Level} and has {pokemon.Hp}");
// }
Init();
void Init()
{
    Console.WriteLine("Make your own Pokemon!");
    GenerateNewPokemon();
}
void GenerateNewPokemon()
{
    Console.WriteLine("What is your pokemon's name?");
    string inputName = Console.ReadLine();
    Console.WriteLine("How much hp does it have?");
    var inputHp = Console.ReadLine();
    Console.WriteLine("What level is it?");
    var inputLevel = Console.ReadLine();
    pokemonList.Add(new Pokemon(inputName, Convert.ToInt32(inputHp), Convert.ToInt32(inputLevel)));
    GenerateList();
}

void GenerateList()
{
    foreach (var pokemon in pokemonList)
    {
        Console.WriteLine($"{pokemon.Name} is level {pokemon.Level} and has {pokemon.Hp}hp");
    }
    Console.WriteLine();
    GenerateNewPokemon();
}