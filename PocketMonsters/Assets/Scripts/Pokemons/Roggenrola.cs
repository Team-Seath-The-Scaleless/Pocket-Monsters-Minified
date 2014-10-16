namespace Pokemons
{
    public class Sentinel : Pokemon
    {
        private const int NormalAttack = 4;

        private const int Health = 40;

        private const int SpecialAttack = 5;

        public Sentinel() :
            base(Sentinel.Attack, Sentinel.Health, Sentinel.NormalAttack, PokemonType.Fire)
        {
        }
    }
}
