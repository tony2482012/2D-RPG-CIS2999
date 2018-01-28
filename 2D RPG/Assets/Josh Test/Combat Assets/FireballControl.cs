using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody> ().velocity = new Vector2 (-8, 0);
		Destroy (gameObject, 2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
