/* Joshua Bunnell
 * Updated Jan 28 2018
 * C# script for controlling the warrior in battle
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorControl : MonoBehaviour {

	public static float warriorHP = 100;
	public static float warriorMaxHP = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetKeyDown ("1")) && (Battleflow.whichTurn == 2)) {
			GetComponent<Animator> ().SetTrigger ("warriorStab");
			GetComponent<Transform>().position = new Vector2 (-3.5f, -1.22f);
		}
	}

	void returnWarrior(){
		GetComponent<Transform> ().position = new Vector2 (4.41f, -1.79f );
		Battleflow.whichTurn = 3;
	}
}
