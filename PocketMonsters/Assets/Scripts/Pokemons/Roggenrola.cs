namespace Pokemons
{
    public class Roggenrola : Pokemon
    {
        private const int NormalAttack = 4;

        private const int Health = 40;

        private const int SpecialAttack = 5;

        public Roggenrola() :
            base(Roggenrola.SpecialAttack, Roggenrola.Health, Roggenrola.NormalAttack, PokemonType.Fire)
        {
        }
    }
}
