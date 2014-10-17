namespace Pokemons
{
    public class Ginka : Pokemon
    {
        private const int NormalAttack = 3;

        private const int Health = 43;

        private const int SpecAttack = 4;

        public Ginka() :
            base(Ginka.Health, Ginka.NormalAttack, Ginka.SpecAttack, PokemonType.Water)
        {
        }
    }
}
