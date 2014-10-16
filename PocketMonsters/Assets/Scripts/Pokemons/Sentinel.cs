namespace Pokemons
{
    public class Sentinel : Pokemon
    {
        private const int NormalAttack = 3;

        private const int Health = 45;

        private const int SpecAttack = 4;

        public Sentinel() :
            base(Sentinel.Health, Sentinel.NormalAttack, Sentinel.SpecAttack, PokemonType.Lightning)
        {
        }
    }
}
