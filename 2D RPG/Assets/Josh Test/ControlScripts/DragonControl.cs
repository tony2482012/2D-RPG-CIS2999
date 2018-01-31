using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonControl : MonoBehaviour {
	public float snakeHP = 50;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Battleflow.whichTurn == 4) {
			GetComponent<Animator> ().SetTrigger ("DragonSmash1");
			GetComponent<Transform>().position = new Vector2 (4.0f, -1.79f);
			Battleflow.whichTurn = 1;
		}
	}

	void returnDragon(){
		GetComponent<Transform> ().position = new Vector2 (-4.18f, 1.45f );
	}
}
