namespace Pokemons
{
    public class Rattata : Pokemon
    {
        private const int BasicHp = 30;

        private const int BasicAttack = 55;

        private const int BasicDefense = 35;

        private const int BasicSpecAttack = 25;

        private const int BasicSpecDefense = 35;

        private const int BasicSpeed = 70;

        public Rattata() :
            base(Rattata.BasicHp, Rattata.BasicAttack, Rattata.BasicDefense, Rattata.BasicSpecAttack,
            Rattata.BasicSpecDefense, Rattata.BasicSpeed, PokemonType.Normal)
        {
        }
    }
}
