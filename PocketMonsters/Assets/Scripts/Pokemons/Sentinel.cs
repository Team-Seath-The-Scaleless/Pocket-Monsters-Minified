namespace Pokemons
{
    public class Sentinel : Pokemon
    {
        private const int NormalAttack = 3;

        private const int Health = 45;

        private const int SpecialAttack = 4;

        public Sentinel() :
            base(Sentinel.Attack, Sentinel.Health, Sentinel.NormalAttack, PokemonType.Frost)
        {
        }
    }
}
