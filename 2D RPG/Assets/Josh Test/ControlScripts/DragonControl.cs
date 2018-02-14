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
		if ((Input.GetKeyDown ("1")) && (Battleflow.whichTurn == 2)) {
			GetComponent<Animator> ().SetTrigger ("DragonSmash1");
			GetComponent<Transform> ().position = new Vector2 (4.0f, -1.79f);
			Battleflow.whichTurn = 1;
			Debug.Log (Battleflow.whichTurn);
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
		yield return new WaitForSeconds (0.3f);
		WizardControl.wizardHP -= dragonAttPow;	
		GetComponent<Transform> ().position = new Vector2 (-4.18f, 1.45f );
	}
}
