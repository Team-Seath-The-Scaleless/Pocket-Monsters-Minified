namespace Pokemons
{
    public class Roggenrola : Pokemon
    {
        private const int NormalAttack = 4;

        private const int Health = 40;

        private const int SpecAttack = 5;

        public Roggenrola() :
            base(Roggenrola.Health, Roggenrola.NormalAttack, Roggenrola.SpecAttack, PokemonType.Frost)
        {
        }
    }
}
