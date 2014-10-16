namespace Pokemons
{
    public class Sheldon : Pokemon
    {
        private const int NormalAttack = 3;

        private const int Health = 44;

        private const int SpecialAttack = 4;

        public Sheldon() :
            base(Sheldon.SpecialAttack, Sheldon.Health, Sheldon.NormalAttack, PokemonType.Frost)
        {
        }
    }
}
