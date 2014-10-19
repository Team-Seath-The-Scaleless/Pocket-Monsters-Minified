﻿namespace Environment
{
    using UnityEngine;
    using System.Collections;

    using Scripts;
    using Abilities;
    using Creatures;
    using Interfaces;
    using Pokemons;

    public class Battlefield : MonoBehaviour
    {
        public UILabel playerPokemonNameLabel;
        public UILabel enemyPokemonNameLabel;
        public UILabel playerPokemonLevelLabel;
        public UILabel enemyPokemonLevelLabel;
        public UILabel playerPokemonHealthLabel;
        public UILabel actionResultLabel;
        public GameObject firstSpecialButton;
        public GameObject secondSpecialButton;
        public GameObject thirdSpecialButton;
        public GameObject fourthSpecialButton;

        private bool playerTurn;
        private bool enemyTurn;

        // Heroes temporary comes with constructor
        private Hero myHero;

        private GameObject playerObject;

        private EnemyNpc enemyHero;


        private IPokemon playerActivePokemon;
        private IPokemon enemyActivePokemon;
        private int AbilityCount;

        void Start()
        {
            Debug.Log("Battle Scene started");
            Debug.Log(GameData.player);
            Debug.Log(GameData.currentEnemy);
            Debug.Log(GameData.npcs.Count);



            //int randomFromMyPokemons = 1;
            //int randomFromEnemyPokemons = 1; //Random.Range(0, this.enemyHero.Pokemons.Count);
            ////this.playerActivePokemon = (Pokemon)this.MyHero.Pokemons[randomFromMyPokemons];
            ////this.enemyActivePokemon = (Pokemon)this.EnemyHero.Pokemons[randomFromEnemyPokemons];
            //Battlefield.playerActivePokemon = new Meowth();
            //Battlefield.enemyActivePokemon = new Pesho();
            //Battlefield.playerActivePokemon.Abilities.Add(new Armageddon());
            //Battlefield.playerActivePokemon.CurrentlyActive = true;
            //Battlefield.enemyActivePokemon.CurrentlyActive = true;
            //this.AbilityCount = 1;
        }

        public void UseNormalAttack()
        {
            this.enemyActivePokemon.CurrentHealth -= this.playerActivePokemon.AttackDamage;
        }

        public void UseSpecialAttack(GameObject buttonPressed)
        {
            int abilityIndex = int.Parse(buttonPressed.name.Substring(0, buttonPressed.name.IndexOf('_')));
            Debug.Log(abilityIndex);
            //if (AbilityCount > Battlefield.playerActivePokemon.Abilities.Count)
            //{
            //    AbilityCount = 1;
            //}
            //Debug.Log(Battlefield.enemyActivePokemon.CurrentHealth);
            //IDamageAbility damageAbility = Battlefield.playerActivePokemon.Abilities[AbilityCount] as IDamageAbility;
            //if ((object)damageAbility != null)
            //{
            //    Battlefield.enemyActivePokemon.TakeDamage(damageAbility.Damage);
            //    Debug.Log(Battlefield.enemyActivePokemon.CurrentHealth);
            //}
            //else
            //{
            //    Debug.Log("Fail");
            //}

            //IHealingAbility healAbility = Battlefield.playerActivePokemon.Abilities[AbilityCount] as IHealingAbility;
            //if ((object)healAbility != null)
            //{
            //    Battlefield.playerActivePokemon.Heal(healAbility.Heal);
            //}
            //else
            //{
            //    Debug.Log("Fail");
            //}
        }

        //public static string GetHeroName()
        //{
        //    return Battlefield.playerActivePokemon.GetType().Name;
        //}

        //public static string GetEnemyPokemonName()
        //{
        //    return Battlefield.enemyActivePokemon.GetType().Name;
        //}

        //public static string HeroHealth()
        //{
        //    return Battlefield.playerActivePokemon.CurrentHealth + "/" +
        //        Battlefield.playerActivePokemon.MaxHealth;
        //}

        // Update is called once per frame
        void Update()
        {

        }
    }
}