namespace Pokemons
{
    public class PeachoSaurus : Pokemon
    {
        private const int NormalAttack = 5;

        private const int Health = 40;

        private const int SpecAttack = 6;

        public PeachoSaurus() :
            base(PeachoSaurus.Health, PeachoSaurus.NormalAttack, PeachoSaurus.SpecAttack, PokemonType.Fire)
        {
        }
    }
}
