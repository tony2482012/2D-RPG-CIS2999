using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamTextControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Renderer> ().sortingOrder = 10;
		GetComponent<TextMesh> ().text = Battleflow.currentDamage.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
