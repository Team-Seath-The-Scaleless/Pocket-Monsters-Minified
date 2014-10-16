namespace Pokemons
{
    public class Grandfatty : Pokemon
    {
        private const int NormalAttack = 6;

        private const int Health = 45;

        private const int SpecialAttack = 8;

        public Grandfatty() :
            base(Grandfatty.Health, Grandfatty.NormalAttack, Grandfatty.SpecialAttack, PokemonType.Earth)
        {
        }
    }
}
