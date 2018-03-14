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

	void onMouseDown(){
		Debug.Log ("button clicked");
		Battleflow.attButSelected = "y";

	}
}
