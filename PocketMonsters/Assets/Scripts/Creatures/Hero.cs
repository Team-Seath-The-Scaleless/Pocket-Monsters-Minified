namespace Creatures
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;

    using UnityEngine;
    using Common;
    using Interfaces;

    public class Hero : GameElement, IMovable, IPokemonTrainer
    {
        private GameObject playerObject;
        private bool isMoving;
        private Vector3 startPosition;
        private Vector3 endPosition;
        private float moveSpeed = 10f;
        private float increment;


        public Hero(float startX, float startY, float startZ, GameObject playerOnField)
        {
            this.PositionX = startX;
            this.PositionY = startY;
            this.PositionZ = startZ;
            this.Player = playerOnField;
            this.Pokemons = new List<IPokemon>();

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
                Debug.Log("Moving");
            }
            else
            {
                this.isMoving = false;
                Debug.Log("Stopped");
            }

            if (this.isMoving)
            {
                this.Player.transform.position = Vector3.Lerp(this.startPosition, this.endPosition, this.increment);
            }

            if (Input.GetKey(KeyCode.UpArrow) && isMoving == false)
            {
                this.increment = 0;
                this.isMoving = true;
                this.startPosition = this.Player.transform.position;
                this.PositionZ += 1f;
                this.endPosition = new Vector3(this.PositionX, this.PositionY, this.PositionZ);
            }
            else if (Input.GetKey(KeyCode.DownArrow) && isMoving == false)
            {
                this.increment = 0;
                this.isMoving = true;
                this.startPosition = this.Player.transform.position;
                this.PositionZ -= 1f;
                this.endPosition = new Vector3(this.PositionX, this.PositionY, this.PositionZ);
            }
            else if (Input.GetKey(KeyCode.LeftArrow) && isMoving == false)
            {
                this.increment = 0;
                this.isMoving = true;
                this.startPosition = this.Player.transform.position;
                this.PositionX -= 1f;
                this.endPosition = new Vector3(this.PositionX, this.PositionY, this.PositionZ);
            }
            else if (Input.GetKey(KeyCode.RightArrow) && isMoving == false)
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
