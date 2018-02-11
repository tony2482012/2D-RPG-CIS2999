/* Joshua Bunnell
 * Updated Jan 28 2018
 * C# script for controlling the flow of battle
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battleflow : MonoBehaviour {

	//controls character turn
	public static int whichTurn = 1;
	public static float currentDamage = 0;

	public static string damageDisplay = "n";

	public static string wizardStatus = "OK";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (wizardStatus);
		if ((whichTurn == 1) && (Battleflow.wizardStatus == "dead")) 
		{
			Battleflow.whichTurn = 2;
		}
	}
}
