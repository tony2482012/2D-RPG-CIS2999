using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCon : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}

	void OnMouseDown()
	{
		//Debug.Log ("button clicked");
		if (gameObject.name == "Fireball Button") {
			Battleflow.attButSelected = "y";
		} else if (gameObject.name == "Defense Button") {
			
		}

	}
}
