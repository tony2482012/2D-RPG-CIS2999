/* Joshua Bunnell
 * Updated Jan 28 2018
 * C# script for controlling an enemy in battle
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Battleflow.whichTurn == 3) {
			GetComponent<Animator> ().SetTrigger ("SnakeBite1");
			GetComponent<Transform>().position = new Vector2 (8.0f, -1.2f);
		}
	}

	void returnSnake(){
		GetComponent<Transform> ().position = new Vector2 (-8.00f, -1.2f );
		Battleflow.whichTurn = 1;
	}
}
