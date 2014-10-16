namespace Pokemons
{
    public class Meowth : Pokemon
    {
        private const int NormalAttack = 6;

        private const int Health = 46;

        private const int SpecAttack = 7;

        public Meowth() :
            base(Meowth.Health, Meowth.NormalAttack, Meowth.SpecAttack, PokemonType.Lightning)
        {
        }
    }
}
