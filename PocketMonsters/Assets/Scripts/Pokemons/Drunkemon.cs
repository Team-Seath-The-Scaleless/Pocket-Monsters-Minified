namespace Pokemons
{
    public class Drunkemon : Pokemon
    {
        private const int BasicHp = 43;

        private const int BasicAttack = 48;

        private const int BasicDefense = 48;

        private const int BasicSpecAttack = 62;

        private const int BasicSpecDefense = 47;

        private const int BasicSpeed = 70;

        public Drunkemon() :
            base(Drunkemon.BasicHp, Drunkemon.BasicAttack, Drunkemon.BasicDefense, Drunkemon.BasicSpecAttack,
            Drunkemon.BasicSpecDefense, Drunkemon.BasicSpeed, PokemonType.Water)
        {
        }
    }
}
