﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetKeyDown ("1")) && (Battleflow.whichTurn == 3)) {
			GetComponent<Animator> ().SetTrigger ("archerShot1");
			//Instantiate (fireballObj, new Vector2 (7.0f, -.21f), fireballObj.rotation);
		}
	}
}
