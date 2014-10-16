namespace Pokemons
{
    public class Meowth : Pokemon
    {
        private const int NormalAttack = 6;

        private const int Health = 46;

        private const int SpecialAttack = 7;

        public Meowth() :
            base(Meowth.Attack, Meowth.Health, Meowth.NormalAttack, PokemonType.Earth)
        {
        }
    }
}
