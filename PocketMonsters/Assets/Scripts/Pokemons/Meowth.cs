namespace Pokemons
{
    public class Meowth : Pokemon
    {
        private const int BasicHp = 40;

        private const int BasicAttack = 45;

        private const int BasicDefense = 35;

        private const int BasicSpecAttack = 40;

        private const int BasicSpecDefense = 40;

        private const int BasicSpeed = 90;

        public Meowth() :
            base(Meowth.BasicHp, Meowth.BasicAttack, Meowth.BasicDefense, Meowth.BasicSpecAttack,
            Meowth.BasicSpecDefense, Meowth.BasicSpeed, PokemonType.Normal)
        {
        }
    }
}
