namespace Pokemons
{
    public class Squirtle : Pokemon
    {
        private const int BasicHp = 45;

        private const int BasicAttack = 50;

        private const int BasicDefense = 65;

        private const int BasicSpecAttack = 50;

        private const int BasicSpecDefense = 65;

        private const int BasicSpeed = 40;

        public Squirtle() :
            base(Squirtle.BasicHp, Squirtle.BasicAttack, Squirtle.BasicDefense, Squirtle.BasicSpecAttack,
            Squirtle.BasicSpecDefense, Squirtle.BasicSpeed, PokemonType.Water)
        {
        }
    }
}
