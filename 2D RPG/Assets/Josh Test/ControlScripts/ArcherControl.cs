/* Joshua Bunnell
 * Updated Jan 28 2018
 * C# script for controlling the archer in battle
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherControl : MonoBehaviour {
	public static float archerHP = 100;
	public static float archerMaxHP = 100;

	public Transform damTextObj;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetKeyDown ("1")) && (Battleflow.whichTurn == 3)) {
			GetComponent<Animator> ().SetTrigger ("archerShot1");
			Instantiate (damTextObj, new Vector2 (-3.46f, 6.0f), damTextObj.rotation);
			Battleflow.whichTurn = 4;

		}
	}
}
