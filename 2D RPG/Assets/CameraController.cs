using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {


	public Camera myCamera;
	public float fieldOfView;

	void Awake(){
		
		myCamera.fieldOfView = 90.0f;	
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
