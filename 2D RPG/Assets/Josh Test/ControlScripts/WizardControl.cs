/* Joshua Bunnell
 * Updated Jan 28 2018
 * C# script for controlling the wizard in battle
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardControl : MonoBehaviour {
	public  static float wizardHP = 100;
	public static float wizardMaxHP = 100;

	public Transform damTextObj;
	public Transform fireballObj;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (wizardHP <= 0) 
		{
			Battleflow.wizardStatus = "dead";
			Debug.Log (Battleflow.wizardStatus);
			Debug.Log (Battleflow.whichTurn);
			Destroy (gameObject);	
		}

		if ((Input.GetKeyDown ("1")) && (Battleflow.whichTurn == 1))  {
			
			Battleflow.currentDamage = 30;
			GetComponent<Animator> ().SetTrigger ("WizardMagic1");
			Instantiate (fireballObj, new Vector2 (7.0f, -.21f), fireballObj.rotation);
			StartCoroutine (returnWizard ());
		}


	}

	IEnumerator returnWizard()
	{
		yield return new WaitForSeconds (2);
		Instantiate (damTextObj, new Vector2 (-3.0f, 1.0f), damTextObj.rotation);
		Battleflow.damageDisplay = "y";
		Battleflow.whichTurn = 2;


	}
}
