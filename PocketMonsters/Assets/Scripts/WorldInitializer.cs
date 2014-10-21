namespace Scripts
{
    using System;
    using System.Collections.Generic;
    using UnityEngine;

    using Creatures;
    using Interfaces;
    using Pokemons;

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
                IList<IPokemon> playerPokemons =
                    new List<IPokemon>()
                    {
                        new Pikachu(),
                        new MewTwo(),
                        new Snorlax()
                    };

                GameData.player = new Hero(-2f, 1f, 0f, this.playerObject, playerPokemons);
            }
            else
            {
                GameData.player.Player = this.playerObject;
                GameData.player.Player.transform.position =
                    new Vector3(GameData.player.PositionX, GameData.player.PositionY, GameData.player.PositionZ);
            }
        }

        private void CreateNpcs()
        {
            if (GameData.npcs == null)
            {
                GameData.npcs = new List<Npc>();

                GameObject villageGirlObject = (GameObject)Instantiate(Resources.Load(VillageGirl.NpcPrefabPath, typeof(GameObject)));
                Npc villageGirl = new VillageGirl(-1f, 1f, 8f, villageGirlObject);
                villageGirl.NpcObject.transform.position = new Vector3(villageGirl.PositionX, villageGirl.PositionY, villageGirl.PositionZ);

                GameObject nakovObject = (GameObject)Instantiate(Resources.Load(Nakov.NpcPrefabPath, typeof(GameObject)));
                Npc nakov = new Nakov(0f, 1f, 22f, nakovObject);
                nakov.NpcObject.transform.position = new Vector3(nakov.PositionX, nakov.PositionY, nakov.PositionZ);

                GameObject banditObject = (GameObject)Instantiate(Resources.Load(Bandit.NpcPrefabPath, typeof(GameObject)));
                Npc bandit = new Bandit(0f, 1f, 15f, banditObject);
                bandit.NpcObject.transform.position = new Vector3(bandit.PositionX, bandit.PositionY, bandit.PositionZ);

                GameData.npcs.Add(villageGirl);
                GameData.npcs.Add(nakov);
                GameData.npcs.Add(bandit);
            }
            else
            {
                foreach (var npc in GameData.npcs)
                {
                    GameObject newNpcObject = (GameObject)Instantiate(Resources.Load(npc.PrefabPath, typeof(GameObject)));
                    npc.NpcObject = newNpcObject;
                    npc.NpcObject.transform.position =
                        new Vector3(npc.PositionX, npc.PositionY, npc.PositionZ);
                }
            }
        }
    }
}
