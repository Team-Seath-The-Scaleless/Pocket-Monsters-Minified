using System.Collections;
using Environment;
using UnityEngine;
using UnityEditor;
namespace Environment{
public class GetPlayerHealth : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		UILabel lbl = GetComponent<UILabel>();
		lbl.text = Battlefield.HeroHealth ();
	}
}
}