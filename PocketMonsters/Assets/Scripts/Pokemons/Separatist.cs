namespace Pokemons
{
    public class Separatist : Pokemon
    {
        private const int BasicHp = 38;

        private const int BasicAttack = 52;

        private const int BasicDefense = 30;

        private const int BasicSpecAttack = 28;

        private const int BasicSpecDefense = 30;

        private const int BasicSpeed = 65;

        public Separatist() :
            base(Separatist.BasicHp, Separatist.BasicAttack, Separatist.BasicDefense, Separatist.BasicSpecAttack,
            Separatist.BasicSpecDefense, Separatist.BasicSpeed, PokemonType.Normal)
        {
        }
    }
}
