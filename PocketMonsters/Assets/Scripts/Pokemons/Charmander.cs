namespace Pokemons
{
    public class Charmander : Pokemon
    {
        private const int NormalAttack = 5;

        private const int Health = 40;

        private const int SpecAttack = 6;

        public Charmander() :
            base(Charmander.Health, Charmander.NormalAttack, Charmander.SpecAttack, PokemonType.Fire)
        {
        }
    }
}
