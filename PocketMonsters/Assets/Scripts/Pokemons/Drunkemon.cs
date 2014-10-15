namespace Pokemons
{
    public class Drunkemon : Pokemon
    {
        private const int NormalAttack = 5;

        private const int Health = 39;

        private const int SpecialAttack = 6;

        public Drunkemon() :
            base(Drunkemon.Attack, Drunkemon.Health, Drunkemon.NormalAttack, PokemonType.Lightning)
        {
        }
    }
}
