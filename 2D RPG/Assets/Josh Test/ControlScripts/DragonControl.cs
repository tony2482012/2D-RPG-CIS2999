using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonControl : MonoBehaviour {
	public float dragonHP = 80;
	public float dragonAttPow = 100;
	// Use this for initialization
	void Start () {

	}
	 
	// Update is called once per frame
	void Update () {
		if (Battleflow.whichTurn == 4) {
			GetComponent<Animator> ().SetTrigger ("DragonSmash1");
			GetComponent<Transform> ().position = new Vector2 (4.0f, -1.79f);
		//	System.Random rnd = new System.Random ();
		//	int attack = rnd.Next (1, 100);
		//	if (attack >= 50) {
		//		ArcherControl.archerHP -= 10;
		//	}
		}
			if(Battleflow.damageDisplay == "y")
				{
					dragonHP -= Battleflow.currentDamage;
					Debug.Log (dragonHP);
					Battleflow.damageDisplay = "n";
					
				}
		if (dragonHP <= 0) {
			Destroy (gameObject);
		}
		
	}

	IEnumerator returnDragon()
	{
		yield return new WaitForSeconds (0.1f);
		WizardControl.wizardHP -= dragonAttPow;	
		//Debug.Log ("WizardHP " + WizardControl.wizardHP);
		GetComponent<Transform> ().position = new Vector2 (-4.18f, 1.45f );
		Battleflow.whichTurn = 1;

	}
}
