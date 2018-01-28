/* Joshua Bunnell
 * Updated Jan 28 2018
 * C# script for controlling an enemy in battle
 * This File is to test a generic enemy control file
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour {
	public float EnemyHP = 50;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Battleflow.whichTurn == 3) {
			GetComponent<Animator> ().SetTrigger ("SnakeBite1");
			GetComponent<Transform>().position = new Vector2 (5.0f, -1.2f);
			Battleflow.whichTurn = 1;
		}
	}

	void returnEnemy(){
		GetComponent<Transform> ().position = new Vector2 (-5.27f, -1.05f );
	}
}
