namespace Creatures
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;

    using Common;
    using Interfaces;

    public class Hero : GameElement, IMovable, IPokemonTrainer
    {
        public Hero()
        {
            this.Pokemons = new List<IPokemon>();
        }

        public IList<IPokemon> Pokemons { get; private set; }

        public void Move(string direction)
        {
            switch (direction)
            {
                case "west":
                    this.PositionX -= 1F;
                    break;
                case "east":
                    this.PositionX += 1F;
                    break;
                case "north":
                    this.PositionZ += 1F;
                    break;
                case "south":
                    this.PositionZ -= 1F;
                    break;
                default:
                    throw new InvalidOperationException("wrong direction");
            }
        }
    }
}
