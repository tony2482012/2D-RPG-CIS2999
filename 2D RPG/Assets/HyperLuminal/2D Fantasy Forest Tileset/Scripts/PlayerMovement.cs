using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		var y = Input.GetAxis ("Horizontal") * Time.deltaTime * 3.0f;
		var x = Input.GetAxis ("Vertical") * Time.deltaTime * 3.0f;

		//transform.Rotate (0, x, 0);
		transform.Translate (y, 0, 0);
		transform.Translate (0, x, 0);

	}
}
