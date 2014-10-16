namespace Pokemons
{
    public class Bulbasaur : Pokemon
    {
        private const int NormalAttack = 5;

        private const int Health = 38;

        private const int SpecialAttack = 7;

        public Bulbasaur() :
            base(Bulbasaur.SpecialAttack, Bulbasaur.Health, Bulbasaur.NormalAttack, PokemonType.Lightning)
        {
        }
    }
}
