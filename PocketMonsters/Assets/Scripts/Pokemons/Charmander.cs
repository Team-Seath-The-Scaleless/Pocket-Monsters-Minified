namespace Pokemons
{
    public class Charmander : Pokemon
    {
        private const int NormalAttack = 5;

        private const int Health = 40;

        private const int SpecialAttack = 6;

        public Charmander() :
            base(Charmander.SpecialAttack, Charmander.Health, Charmander.NormalAttack, PokemonType.Lightning)
        {
        }
    }
}
