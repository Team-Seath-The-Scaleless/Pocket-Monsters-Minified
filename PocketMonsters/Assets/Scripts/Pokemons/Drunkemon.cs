namespace Pokemons
{
    public class Drunkemon : Pokemon
    {
        private const int NormalAttack = 5;

        private const int Health = 39;

        private const int SpecAttack = 6;

        public Drunkemon() :
            base(Drunkemon.Health, Drunkemon.NormalAttack, Drunkemon.SpecAttack, PokemonType.Fire)
        {
        }
    }
}
