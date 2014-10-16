namespace Pokemons
{
    public class Separatist : Pokemon
    {
        private const int NormalAttack = 4;

        private const int Health = 42;

        private const int SpecialAttack = 5;

        public Separatist() :
            base(Separatist.SpecialAttack, Separatist.Health, Separatist.NormalAttack, PokemonType.Fire)
        {
        }
    }
}
