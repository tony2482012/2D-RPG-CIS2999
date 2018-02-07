using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonControl : MonoBehaviour {
	public float dragonHP = 80;

	// Use this for initialization
	void Start () {

	}
	 
	// Update is called once per frame
	void Update () {
		if (Battleflow.whichTurn == 4) {
			GetComponent<Animator> ().SetTrigger ("DragonSmash1");
			GetComponent<Transform> ().position = new Vector2 (4.0f, -1.79f);
			System.Random rnd = new System.Random ();
			int attack = rnd.Next (1, 100);
			if (attack >= 50) {
				ArcherControl.archerHP -= 10;
			}
			Battleflow.whichTurn = 1;
		}
			if(Battleflow.damageDisplay == "y")
				{
					dragonHP -= Battleflow.currentDamage;
					Debug.Log (dragonHP);
					Battleflow.damageDisplay = "n";
				}
		
	}

	void returnDragon()
	{
		GetComponent<Transform> ().position = new Vector2 (-4.18f, 1.45f );
	}
}
