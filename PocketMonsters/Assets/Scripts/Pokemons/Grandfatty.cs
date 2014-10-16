namespace Pokemons
{
    public class Grandfatty : Pokemon
    {
        private const int NormalAttack = 6;

        private const int Health = 45;

        private const int SpecialAttack = 8;

        public Grandfatty() :
            base(Grandfatty.Attack, Grandfatty.Health, Grandfatty.NormalAttack, PokemonType.Earth)
        {
        }
    }
}
