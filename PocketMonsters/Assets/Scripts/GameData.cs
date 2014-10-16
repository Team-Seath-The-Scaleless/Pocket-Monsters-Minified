using System;
using System.Collections.Generic;
using UnityEngine;
using Common;
using Creatures;
using Pokemons;
using Interfaces;
namespace Scripts
{
    public static class GameData 
    {

		public static IList<IPokemon> mapEnemies = new List<IPokemon>(){
			 new Grandfatty(),
		};
        public static EnemyNpc enemy = new EnemyNpc(mapEnemies);
		public static List<IPokemon> playerPokemons = new List<IPokemon>(){
			new Grandfatty(),
		};
		public static Hero player;
        // so far only this
    }
}
