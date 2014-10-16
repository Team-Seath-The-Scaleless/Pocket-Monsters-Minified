namespace Pokemons
{
    public class Sheldon : Pokemon
    {
        private const int NormalAttack = 3;

        private const int Health = 44;

        private const int SpecAttack = 4;

        public Sheldon() :
            base(Sheldon.Health, Sheldon.NormalAttack, Sheldon.SpecAttack, PokemonType.Lightning)
        {
        }
    }
}
