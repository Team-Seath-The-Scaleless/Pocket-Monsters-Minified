namespace Pokemons
{
    public class Pesho : Pokemon
    {
        private const int BasicHp = 50;

        private const int BasicAttack = 70;

        private const int BasicDefense = 50;

        private const int BasicSpecAttack = 50;

        private const int BasicSpecDefense = 50;

        private const int BasicSpeed = 70;

        public Pesho() :
            base(Pesho.BasicHp, Pesho.BasicAttack, Pesho.BasicDefense, Pesho.BasicSpecAttack,
            Pesho.BasicSpecDefense, Pesho.BasicSpeed, PokemonType.Grass)
        {
        }
    }
}
