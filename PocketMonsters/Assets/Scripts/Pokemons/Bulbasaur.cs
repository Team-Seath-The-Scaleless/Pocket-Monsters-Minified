namespace Pokemons
{
    public class Bulbasaur : Pokemon
    {
        private const int NormalAttack = 5;

        private const int Health = 38;

        private const int SpecAttack = 7;

        public Bulbasaur() :
            base(Bulbasaur.Health, Bulbasaur.NormalAttack, Bulbasaur.SpecAttack, PokemonType.Grass)
        {
        }
    }
}
