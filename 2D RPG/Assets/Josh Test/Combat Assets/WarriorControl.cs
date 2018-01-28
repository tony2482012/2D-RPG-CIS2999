using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("1")) {
			GetComponent<Animator> ().SetTrigger ("warriorStab");
			GetComponent<Transform>().position = new Vector2 (-5.2f, -1.2f);
		}
	}

	void returnWarrior(){
		GetComponent<Transform> ().position = new Vector2 (8.18f, -2.01f );
	}
}
