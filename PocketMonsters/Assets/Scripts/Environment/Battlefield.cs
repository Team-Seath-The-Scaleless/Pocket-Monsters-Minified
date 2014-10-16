using UnityEngine;
using System.Collections;
using Pokemons;
using Creatures;
using Interfaces;
namespace Environment
{
    public class Battlefield : MonoBehaviour
    {
		// Heroes temporary comes with constructor
        private Hero myHero;

        private EnemyNpc enemyHero;

        public Battlefield()
        {
            this.MyHero = myHero;
            this.EnemyHero = enemyHero;
        }

        public Hero MyHero { get; set; }
        public EnemyNpc EnemyHero { get; set; }
        private IPokemon playerActivePokemon;
      	private IPokemon enemyActivePokemon;
       
	   // Use this for initialization
        void Start()
        {
            int randomFromMyPokemons = Random.Range(0, this.myHero.Pokemons.Count);
            int randomFromEnemyPokemons = Random.Range(0, this.enemyHero.Pokemons.Count);
            this.playerActivePokemon = (Pokemon)this.MyHero.Pokemons[randomFromMyPokemons];
            this.enemyActivePokemon = (Pokemon)this.EnemyHero.Pokemons[randomFromEnemyPokemons];
            this.playerActivePokemon.CurrentlyActive = true;
            this.enemyActivePokemon.CurrentlyActive = true;
        }

        public void UseNormalAttack()
        {
			int attack = this.playerActivePokemon.Attack;
			// this.enemyActivePokemon.Health -= attack;
        }

        public void UseSpecialAttack()
        {
			int attack = this.enemyActivePokemon.Attack;
			// this.playerActivePokemon.Health -= attack;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}