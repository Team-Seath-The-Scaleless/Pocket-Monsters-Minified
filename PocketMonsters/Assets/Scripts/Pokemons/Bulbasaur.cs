namespace Pokemons
{
    public class Bulbasaur : Pokemon
    {
        private const int BasicHp = 45;

        private const int BasicAttack = 50;

        private const int BasicDefense = 50;

        private const int BasicSpecAttack = 65;

        private const int BasicSpecDefense = 65;

        private const int BasicSpeed = 45;

        public Bulbasaur() :
            base(Bulbasaur.BasicHp, Bulbasaur.BasicAttack, Bulbasaur.BasicDefense, Bulbasaur.BasicSpecAttack,
            Bulbasaur.BasicSpecDefense, Bulbasaur.BasicSpeed, PokemonType.Grass)
        {
        }
    }
}
