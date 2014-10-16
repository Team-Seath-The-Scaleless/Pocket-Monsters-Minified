using System;
using System.Collections.Generic;
using UnityEngine;

using Creatures;
using Pokemons;

namespace Scripts
{
    public class WorldInitializer : MonoBehaviour
    {
        private GameObject playerObject;

        private void Start()
        {
            this.playerObject = GameObject.Find("Player");
            if (GameData.player == null)
            {
                GameData.player = new Hero(-2f, 1f, 0f, this.playerObject);
            }
        }

        private void Update()
        {
            GameData.player.Move();
        }
    }
}
