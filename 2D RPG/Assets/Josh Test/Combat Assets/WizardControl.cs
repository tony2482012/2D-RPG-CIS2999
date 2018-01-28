using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardControl : MonoBehaviour {

	public Transform fireballObj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("2")) {
			GetComponent<Animator> ().SetTrigger ("WizardMagic1");
			Instantiate (fireballObj, new Vector2 (7.0f, -.21f), fireballObj.rotation);
		}
	}
}
