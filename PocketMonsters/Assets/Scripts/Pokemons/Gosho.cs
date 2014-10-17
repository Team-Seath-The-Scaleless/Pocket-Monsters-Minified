namespace Pokemons
{
    public class Gosho : Pokemon
    {
        private const int NormalAttack = 5;

        private const int Health = 38;

        private const int SpecAttack = 7;

        public Gosho() :
            base(Gosho.Health, Gosho.NormalAttack, Gosho.SpecAttack, PokemonType.Grass)
        {
        }
    }
}
