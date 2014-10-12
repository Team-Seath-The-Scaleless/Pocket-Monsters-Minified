namespace Pokemons
{
    public class Sheldon : Pokemon
    {
        private const int BasicHp = 50;

        private const int BasicAttack = 48;

        private const int BasicDefense = 45;

        private const int BasicSpecAttack = 68;

        private const int BasicSpecDefense = 60;

        private const int BasicSpeed = 50;

        public Sheldon() :
            base(Sheldon.BasicHp, Sheldon.BasicAttack, Sheldon.BasicDefense, Sheldon.BasicSpecAttack,
            Sheldon.BasicSpecDefense, Sheldon.BasicSpeed, PokemonType.Fire)
        {
        }
    }
}
