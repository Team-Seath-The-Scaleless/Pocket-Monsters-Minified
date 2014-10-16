namespace Pokemons
{
    public class Separatist : Pokemon
    {
        private const int NormalAttack = 4;

        private const int Health = 42;

        private const int SpecAttack = 5;

        public Separatist() :
            base(Separatist.Health, Separatist.NormalAttack, Separatist.SpecAttack, PokemonType.Earth)
        {
        }
    }
}
