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
            CreatePlayer();
            CreateNpcs();
        }

        private void Update()
        {
            GameData.player.Move();
        }

        private void CreatePlayer()
        {
            this.playerObject = GameObject.Find("Player");
            if (GameData.player == null)
            {
                GameData.player = new Hero(-2f, 1f, 0f, this.playerObject, GameData.playerPokemons);
            }
        }

        private void CreateNpcs()
        {
            GameObject villageGirlObject = (GameObject)Instantiate(Resources.Load(VillageGirl.prefabPath, typeof(GameObject)));
            Npc villageGirl = new VillageGirl(-1f, 1f, 8f, villageGirlObject);
            villageGirl.NpcObject.transform.position = new Vector3(villageGirl.PositionX, villageGirl.PositionY, villageGirl.PositionZ);

            GameObject nakovObject = (GameObject)Instantiate(Resources.Load(Nakov.prefabPath, typeof(GameObject)));
            Npc nakov = new Nakov(0f, 1f, 22f, nakovObject);
            nakov.NpcObject.transform.position = new Vector3(nakov.PositionX, nakov.PositionY, nakov.PositionZ);

            GameObject banditObject = (GameObject)Instantiate(Resources.Load(Bandit.prefabPath, typeof(GameObject)));
            Npc bandit = new Bandit(0f, 1f, 15f, banditObject);
            bandit.NpcObject.transform.position = new Vector3(bandit.PositionX, bandit.PositionY, bandit.PositionZ);

            GameData.npcs.Add(villageGirl);
            GameData.npcs.Add(nakov);
            GameData.npcs.Add(bandit);
        }
    }
}
