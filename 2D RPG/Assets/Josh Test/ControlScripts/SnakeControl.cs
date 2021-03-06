﻿/* Joshua Bunnell
 * Updated Jan 28 2018
 * C# script for controlling an enemy in battle
 * Name may be changed to be a genaric enemy control
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeControl : MonoBehaviour {
	public float snakeHP = 50;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Battleflow.whichTurn == 5) {
			GetComponent<Animator> ().SetTrigger ("SnakeBite1");
			GetComponent<Transform>().position = new Vector2 (4.0f, -1.79f);
			Battleflow.whichTurn = 1;
		}
	}

	void returnSnake(){
		GetComponent<Transform> ().position = new Vector2 (-4.45f, -1.22f );
	}

	void OnMouseDown(){
		Battleflow.selectedEnemy = gameObject.name;

	}
}
