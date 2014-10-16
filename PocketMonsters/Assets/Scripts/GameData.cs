using System;
using System.Collections.Generic;
using UnityEngine;

using Creatures;
using Pokemons;

namespace Scripts
{
    public static class GameData
    {
        public static IList<EnemyNpc> mapEnemies = new List<EnemyNpc>();
        public static Hero player;
        // so far only this
    }
}
