namespace Pokemons
{
    public class Rattata : Pokemon
    {
        private const int NormalAttack = 4;

        private const int Health = 41;

        private const int SpecAttack = 5;

        public Rattata() :
            base(Rattata.Health, Rattata.NormalAttack, Rattata.SpecAttack, PokemonType.Earth)
        {
        }
    }
}
