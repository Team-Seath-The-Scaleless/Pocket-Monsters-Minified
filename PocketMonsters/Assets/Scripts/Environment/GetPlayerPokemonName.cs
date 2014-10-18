namespace Environment
{
	using System.Collections;
	using UnityEngine;
	using UnityEditor;

	public class GetPlayerPokemonName :  MonoBehaviour
	{
		void Update () {
			UILabel lbl = GetComponent<UILabel>();
			lbl.text = Battlefield.GetHeroName ();
		}
	}
}

