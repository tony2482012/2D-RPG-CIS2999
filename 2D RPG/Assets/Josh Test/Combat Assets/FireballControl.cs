/* Joshua Bunnell
 * Updated Jan 28 2018
 * C# script for controlling the animation of a fireball in battle
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody> ().velocity = new Vector2 (-4.5f, 0);
		Destroy (gameObject, 2);
		Battleflow.whichTurn = 2;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
