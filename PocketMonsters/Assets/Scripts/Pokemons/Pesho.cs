namespace Pokemons
{
    public class Pesho : Pokemon
    {
        private const int NormalAttack = 6;

        private const int Health = 48;

        private const int SpecAttack = 8;

        public Pesho() :
            base(Pesho.Health, Pesho.NormalAttack, Pesho.SpecAttack, PokemonType.Frost)
        {
        }
    }
}
