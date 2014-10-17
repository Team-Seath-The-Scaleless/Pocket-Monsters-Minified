namespace Creatures
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;

    using UnityEngine;
    using Scripts;
    using Common;
    using Interfaces;

    public class Hero : GameElement, IMovable, IPokemonTrainer
    {
        private const int SpriteMoveImages = 3;
        private GameObject playerObject;
        private AnimatedSprites drawer;
        private bool isMoving;
        private bool canMove;
        private Vector3 startPosition;
        private Vector3 endPosition;
        private float moveSpeed = 10f;
        private float increment;

        public Hero(float startX, float startY, float startZ, GameObject playerOnField, List<IPokemon> pokemons)
        {
            this.PositionX = startX;
            this.PositionY = startY;
            this.PositionZ = startZ;
            this.Player = playerOnField;
            this.drawer = this.Player.GetComponent<AnimatedSprites>();
            this.Pokemons = pokemons;

            this.startPosition = playerOnField.transform.position;
            this.endPosition = playerOnField.transform.position;
        }

        public GameObject Player
        {
            get { return this.playerObject; }
            private set { this.playerObject = value; }
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
                    if (hit.collider.gameObject.tag.Equals("Environment"))
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
            }
            else if (Input.GetKey(KeyCode.DownArrow) && isMoving == false)
            {
                this.canMove = true;
                RaycastHit hit;
                if (Physics.Raycast(this.Player.transform.position, Vector3.back, out hit, 1.0f))
                {
                    if (hit.collider.gameObject.tag.Equals("Environment"))
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
            }
            else if (Input.GetKey(KeyCode.LeftArrow) && isMoving == false)
            {
                this.canMove = true;
                RaycastHit hit;
                if (Physics.Raycast(this.Player.transform.position, Vector3.left, out hit, 1.0f))
                {
                    if (hit.collider.gameObject.tag.Equals("Environment"))
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
            }
            else if (Input.GetKey(KeyCode.RightArrow) && isMoving == false)
            {
                this.canMove = true;
                RaycastHit hit;
                if (Physics.Raycast(this.Player.transform.position, Vector3.right, out hit, 1.0f))
                {
                    if (hit.collider.gameObject.tag.Equals("Environment"))
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
            }
        }
    }
}
