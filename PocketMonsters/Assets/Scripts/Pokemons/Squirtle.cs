namespace Pokemons
{
    public class Squirtle : Pokemon
    {
        private const int NormalAttack = 3;

        private const int Health = 43;

        private const int SpecialAttack = 4;

        public Squirtle() :
            base(Squirtle.Attack, Squirtle.Health, Squirtle.NormalAttack, PokemonType.Frost)
        {
        }
    }
}
