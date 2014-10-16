namespace Pokemons
{
    public class Pesho : Pokemon
    {
        private const int NormalAttack = 6;

        private const int Health = 48;

        private const int SpecialAttack = 8;

        public Pesho() :
            base(Pesho.SpecialAttack, Pesho.Health, Pesho.NormalAttack, PokemonType.Earth)
        {
        }
    }
}
