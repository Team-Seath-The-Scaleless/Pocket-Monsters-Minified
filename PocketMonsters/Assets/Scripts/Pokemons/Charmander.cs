namespace Pokemons
{
    public class Charmander : Pokemon
    {
        private const int BasicHp = 40;

        private const int BasicAttack = 50;

        private const int BasicDefense = 40;

        private const int BasicSpecAttack = 60;

        private const int BasicSpecDefense = 50;

        private const int BasicSpeed = 65;

        public Charmander() :
            base(Charmander.BasicHp, Charmander.BasicAttack, Charmander.BasicDefense, Charmander.BasicSpecAttack,
            Charmander.BasicSpecDefense, Charmander.BasicSpeed, PokemonType.Fire)
        {
        }
    }
}
