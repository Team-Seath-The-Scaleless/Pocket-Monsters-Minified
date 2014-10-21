namespace Creatures
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;

    using UnityEngine;
    using Scripts;
    using Abilities;
    using Common;
    using Interfaces;

    public class Hero : GameElement, IMovable, IPokemonTrainer
    {
        private const int SpriteMoveImages = 3;
        private GameObject playerObject;
        private GameObject interactionPanel;
        private AnimatedSprites drawer;
        private Npc foundNpc;
        private bool npcFound;
        private bool challengedToFight;
        private bool isMoving;
        private bool canMove;

        private Vector3 startPosition;
        private Vector3 endPosition;

        private float moveSpeed = 10f;
        private float increment;

        public Hero(float startX, float startY, float startZ, GameObject playerOnField, IList<IPokemon> pokemons)
        {
            this.PositionX = startX;
            this.PositionY = startY;
            this.PositionZ = startZ;
            this.Player = playerOnField;
            this.drawer = this.Player.GetComponent<AnimatedSprites>();
            this.Pokemons = pokemons;

            this.interactionPanel = this.Player.transform.Find("PanelBackground").gameObject;
            this.startPosition = this.Player.transform.position;
            this.endPosition = this.Player.transform.position;
        }

        public GameObject Player
        {
            get { return this.playerObject; }
            set { this.playerObject = value; }
        }

        public IList<IPokemon> Pokemons { get; private set; }

        public void Move()
        {
            if (this.increment <= 1 && this.isMoving == true)
            {
                this.increment += this.moveSpeed / 200;
            }
            else
            {
                this.isMoving = false;
                this.drawer.rowImages = 1;
            }

            if (this.isMoving)
            {
                this.Player.transform.position = Vector3.Lerp(this.startPosition, this.endPosition, this.increment);
            }
            
            if (Input.GetKey(KeyCode.UpArrow) && isMoving == false)
            {
                this.canMove = true;
                RaycastHit hit;
                if (Physics.Raycast(this.Player.transform.position, Vector3.forward, out hit, 1.0f))
                {
                    if (hit.collider.gameObject.tag.Equals("Environment") ||
                        hit.collider.gameObject.tag.Equals("NPC"))
                    {
                        this.canMove = false;
                    }
                }

                this.drawer.offsetY = 0.25f;
                this.drawer.rowImages = SpriteMoveImages;
                if (this.canMove)
                {
                    this.increment = 0;
                    this.isMoving = true;
                    this.startPosition = this.Player.transform.position;
                    this.PositionZ += 1f;
                    this.endPosition = new Vector3(this.PositionX, this.PositionY, this.PositionZ);
                }

                CheckForNearbyNpcs();
            }
            else if (Input.GetKey(KeyCode.DownArrow) && isMoving == false)
            {
                this.canMove = true;
                RaycastHit hit;
                if (Physics.Raycast(this.Player.transform.position, Vector3.back, out hit, 1.0f))
                {
                    if (hit.collider.gameObject.tag.Equals("Environment") ||
                        hit.collider.gameObject.tag.Equals("NPC"))
                    {
                        this.canMove = false;
                    }
                }

                this.drawer.offsetY = 0.75f;
                this.drawer.rowImages = SpriteMoveImages;
                if (this.canMove)
                {
                    this.increment = 0;
                    this.isMoving = true;
                    this.startPosition = this.Player.transform.position;
                    this.PositionZ -= 1f;
                    this.endPosition = new Vector3(this.PositionX, this.PositionY, this.PositionZ);
                }

                CheckForNearbyNpcs();
            }
            else if (Input.GetKey(KeyCode.LeftArrow) && isMoving == false)
            {
                this.canMove = true;
                RaycastHit hit;
                if (Physics.Raycast(this.Player.transform.position, Vector3.left, out hit, 1.0f))
                {
                    if (hit.collider.gameObject.tag.Equals("Environment") ||
                        hit.collider.gameObject.tag.Equals("NPC"))
                    {
                        this.canMove = false;
                    }
                }

                this.drawer.offsetY = 0.5f;
                this.drawer.rowImages = SpriteMoveImages;
                if (this.canMove)
                {
                    this.increment = 0;
                    this.isMoving = true;
                    this.startPosition = this.Player.transform.position;
                    this.PositionX -= 1f;
                    this.endPosition = new Vector3(this.PositionX, this.PositionY, this.PositionZ);
                }

                CheckForNearbyNpcs();
            }
            else if (Input.GetKey(KeyCode.RightArrow) && isMoving == false)
            {
                this.canMove = true;
                RaycastHit hit;
                if (Physics.Raycast(this.Player.transform.position, Vector3.right, out hit, 1.0f))
                {
                    if (hit.collider.gameObject.tag.Equals("Environment") ||
                        hit.collider.gameObject.tag.Equals("NPC"))
                    {
                        this.canMove = false;
                    }
                }

                this.drawer.offsetY = 0f;
                this.drawer.rowImages = SpriteMoveImages;
                if (this.canMove)
                {
                    this.increment = 0;
                    this.isMoving = true;
                    this.startPosition = this.Player.transform.position;
                    this.PositionX += 1f;
                    this.endPosition = new Vector3(this.PositionX, this.PositionY, this.PositionZ);
                }

                CheckForNearbyNpcs();
            }

            if (this.interactionPanel == null)
            {
                this.interactionPanel = this.Player.transform.Find("PanelBackground").gameObject;
            }

            if (this.drawer == null)
            {
                this.drawer = this.Player.GetComponent<AnimatedSprites>();
            }

            if (this.interactionPanel.activeInHierarchy)
            {
                if (this.challengedToFight)
                {
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        StartBattle();
                    }
                }

                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (this.foundNpc.GetType().BaseType == typeof(FriendlyNpc))
                    {
                        ((FriendlyNpc)this.foundNpc).Talk();
                    }
                    else if (this.foundNpc.GetType().BaseType == typeof(EnemyNpc))
                    {
                        ((EnemyNpc)this.foundNpc).Talk();
                        this.interactionPanel.GetComponentInChildren<TextMesh>().text = "Press Spacebar to Duel";
                        this.challengedToFight = true;
                    }
                }
            }
        }

        private void ShowInteractionLabel()
        {
            this.interactionPanel.SetActive(true);
            this.interactionPanel.GetComponentInChildren<TextMesh>().text = "Press Spacebar to Talk";
        }

        private void HideInteractionLabel()
        {
            this.interactionPanel.SetActive(false);
        }

        private void CheckForNearbyNpcs()
        {
            if (this.foundNpc != null)
            {
                this.foundNpc = null;                
            }

            foreach (var npc in GameData.npcs)
            {
                if (this.Player.GetComponent<BoxCollider>().bounds.Contains(npc.NpcObject.transform.position))
                {
                    this.foundNpc = (Npc)npc;
                    this.npcFound = true;
                    break;
                }
            }

            if (this.npcFound)
            {
                ShowInteractionLabel();

                this.npcFound = false;
            }
            else
            {
                if (this.foundNpc != null)
                {
                    if (this.foundNpc.GetType().BaseType == typeof(FriendlyNpc))
                    {
                        ((FriendlyNpc)this.foundNpc).StopTalking();                        
                    }
                    else if (this.foundNpc.GetType().BaseType == typeof(EnemyNpc))
                    {
                        Debug.Log(this.foundNpc);
                        ((EnemyNpc)this.foundNpc).StopTalking();
                    }

                    this.foundNpc = null;
                }

                HideInteractionLabel();
                this.challengedToFight = false;
            }
        }

        private void StartBattle()
        {
            GameData.currentEnemy = (EnemyNpc)this.foundNpc;
            RechargePokemons(this.Pokemons);
            RechargePokemons(GameData.currentEnemy.Pokemons);
            Application.LoadLevel("BattleScene");
        }

        private void RechargePokemons(IList<IPokemon> pokemons)
        {
            foreach (var pokemon in pokemons)
            {
                pokemon.CurrentHealth = pokemon.MaxHealth;
                pokemon.IsAlive = true;
                pokemon.CurrentlyActive = false;

                foreach (var ability in pokemon.Abilities)
                {
                    ((SpecialAbility)ability).CurrentCooldown = 0;
                }
            }
        }
    }
}
