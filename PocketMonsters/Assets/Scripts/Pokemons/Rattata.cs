namespace Pokemons
{
    public class Rattata : Pokemon
    {
        private const int NormalAttack = 4;

        private const int Health = 41;

        private const int SpecialAttack = 5;

        public Rattata() :
            base(Rattata.Attack, Rattata.Health, Rattata.NormalAttack, PokemonType.Fire)
        {
        }
    }
}
