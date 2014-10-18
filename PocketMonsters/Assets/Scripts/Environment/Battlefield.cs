using UnityEngine;
using System.Collections;
using Pokemons;
using Creatures;
using Interfaces;
using Scripts;
using Abilities;
namespace Environment
{
    public class Battlefield : MonoBehaviour
    {
		// Heroes temporary comes with constructor
        private Hero myHero;

		private GameObject playerObject;

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
        private int AbilityCount;
	   // Use this for initialization
        void Start()
        {
            int randomFromMyPokemons = 1;
			int randomFromEnemyPokemons = 1; //Random.Range(0, this.enemyHero.Pokemons.Count);
            //this.playerActivePokemon = (Pokemon)this.MyHero.Pokemons[randomFromMyPokemons];
            //this.enemyActivePokemon = (Pokemon)this.EnemyHero.Pokemons[randomFromEnemyPokemons];
			this.playerActivePokemon = new Meowth ();
			this.enemyActivePokemon = new Pesho();
			this.playerActivePokemon.Abilities.Add(new Balefrost());
            this.playerActivePokemon.CurrentlyActive = true;
            this.enemyActivePokemon.CurrentlyActive = true;
            this.AbilityCount = 1;
        }

        public void UseNormalAttack()
        {
            int attack = this.playerActivePokemon.Attack;
            this.enemyActivePokemon.TakeDamage(attack);
			Debug.Log (this.enemyActivePokemon.CurrentHealth);
        }

        public void UseSpecialAttack()
        {
            if (AbilityCount > this.playerActivePokemon.Abilities.Count) {
								AbilityCount = 1;
			}

			IDamageAbility damageAbility = this.playerActivePokemon.Abilities [AbilityCount] as IDamageAbility;
			if ((object)damageAbility != null) {
				this.enemyActivePokemon.TakeDamage(damageAbility.Damage);
			}

			IHealingAbility healAbility = this.playerActivePokemon.Abilities [AbilityCount] as IHealingAbility;
			if ((object)healAbility != null) {
				this.playerActivePokemon.Heal(healAbility.Heal);
			}
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}