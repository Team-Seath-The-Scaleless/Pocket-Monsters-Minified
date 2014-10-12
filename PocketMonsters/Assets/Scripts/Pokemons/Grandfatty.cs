namespace Pokemons
{
    public class Grandfatty : Pokemon
    {
        private const int BasicHp = 44;

        private const int BasicAttack = 46;

        private const int BasicDefense = 55;

        private const int BasicSpecAttack = 50;

        private const int BasicSpecDefense = 70;

        private const int BasicSpeed = 30;

        public Grandfatty() :
            base(Grandfatty.BasicHp, Grandfatty.BasicAttack, Grandfatty.BasicDefense, Grandfatty.BasicSpecAttack,
            Grandfatty.BasicSpecDefense, Grandfatty.BasicSpeed, PokemonType.Grass)
        {
        }
    }
}
