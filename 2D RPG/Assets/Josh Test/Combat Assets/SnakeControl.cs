using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("3")) {
			GetComponent<Animator> ().SetTrigger ("SnakeBite1");
			GetComponent<Transform>().position = new Vector2 (8.0f, -1.2f);
		}
	}

	void returnSnake(){
		GetComponent<Transform> ().position = new Vector2 (-8.00f, -1.2f );
	}
}
