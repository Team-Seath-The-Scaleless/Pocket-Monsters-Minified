using UnityEngine;
using System.Collections;
using Pokemons;
using Creatures;
using Interfaces;
using Scripts;
namespace Environment
{
    public class Battlefield : MonoBehaviour
    {
		// Heroes temporary comes with constructor
        private Hero myHero;

        private EnemyNpc enemyHero;

        public Battlefield()
        {
			this.MyHero = GameData.player;
            this.EnemyHero = GameData.enemy;
        }

        public Hero MyHero 
		{
			get{
				return this.myHero;
						}
			set{
				this.myHero = value;
						}
		}
        public EnemyNpc EnemyHero {
			get{
				return this.enemyHero;
			}
			set{
				this.enemyHero = value;
			}
		}
        private IPokemon playerActivePokemon;
      	private IPokemon enemyActivePokemon;
       
	   // Use this for initialization
        void Start()
        {
			Debug.Log (MyHero.Pokemons.Count);
            int randomFromMyPokemons = 1;
			int randomFromEnemyPokemons = 1; //Random.Range(0, this.enemyHero.Pokemons.Count);
            this.playerActivePokemon = (Pokemon)this.MyHero.Pokemons[randomFromMyPokemons];
            this.enemyActivePokemon = (Pokemon)this.EnemyHero.Pokemons[randomFromEnemyPokemons];
            this.playerActivePokemon.CurrentlyActive = true;
            this.enemyActivePokemon.CurrentlyActive = true;
        }

        public void UseNormalAttack()
        {
            int attack = this.playerActivePokemon.Attack;
            this.enemyActivePokemon.TakeDamage(attack);
        }

        public void UseSpecialAttack()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}