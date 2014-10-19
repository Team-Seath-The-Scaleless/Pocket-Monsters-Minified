namespace Scripts
{
    using System;
    using System.Collections.Generic;

    using UnityEngine;
    using Common;
    using Creatures;
    using Pokemons;
    using Interfaces;

    public static class GameData
    {
        public static IList<IPokemon> mapEnemies = new List<IPokemon>(){
			 new Grandfatty(),
		};
        public static EnemyNpc currentEnemy;
        public static List<IPokemon> playerPokemons = new List<IPokemon>(){
			new Grandfatty(),
		};
        public static Hero player;
        public static IList<Npc> npcs = new List<Npc>();
        // so far only this
    }
}
