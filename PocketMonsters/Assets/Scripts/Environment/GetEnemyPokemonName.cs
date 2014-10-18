using System.Collections;
using Environment;
using UnityEngine;
using UnityEditor;
namespace Environment
{
	public class GetEnemyPokemonName : MonoBehaviour
		{
			void Update () {
				UILabel lbl = GetComponent<UILabel>();
				lbl.text = Battlefield.GetEnemyPokemonName ();
			}
		}
}

