namespace Pokemons
{
    public class Squirtle : Pokemon
    {
        private const int NormalAttack = 3;

        private const int Health = 43;

        private const int SpecAttack = 4;

        public Squirtle() :
            base(Squirtle.Health, Squirtle.NormalAttack, Squirtle.SpecAttack, PokemonType.Water)
        {
        }
    }
}
